using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoisDuRoy_Margaux_Louison.class_folder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BoisDuRoy_Margaux_Louison.Forms
{
    public partial class ViewEmployee : Form
    {
        dataBDD dt_employees;
        DataView dv;
        string matricule;
        public ViewEmployee()
        {
            InitializeComponent();
            dt_employees = new dataBDD();
            dv = new DataView(dt_employees.GetEmployees());
            dgvEmployees.DataSource = dv;

            //gérer le focus
            searchBox.GotFocus += (s, e) => {
                if (searchBox.Text == "Rechercher un employé . . . ")
                {
                    searchBox.Text = "";
                    searchBox.ForeColor = SystemColors.WindowText;
                }
            };
            searchBox.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    searchBox.Text = "Rechercher un employé . . . ";
                    searchBox.ForeColor = SystemColors.GrayText;
                }
            };
        }

        /*
         * Redirige vers le formulaire de création d'utilisateur
         */
        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm SF = new ChildForm((Application.OpenForms["ViewHomeForm"] as ViewHomeForm).panelScreen);
            SF.openChildForm(new ViewCreateEmployees());
        }

        /*
         * supprime l'élément selectionner
         */
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Supprimer cet employé ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dt_employees.DeleteEmployee(dgvEmployees.SelectedCells[0].Value.ToString());

                    dv = new DataView(dt_employees.GetEmployees());
                    dgvEmployees.DataSource = dv;
                    MessageBox.Show("Employé supprimé");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne");
            }
        }

        /*
         * Modifier les paramètres d'un employé
         */
        private void button2_Click(object sender, EventArgs e)
        {
            if(dgvEmployees.SelectedRows.Count > 0)
            {
                matricule = dgvEmployees.SelectedCells[0].Value.ToString();
                ChildForm SF = new ChildForm((Application.OpenForms["ViewHomeForm"] as ViewHomeForm).panelScreen);
                SF.openChildForm(new ViewUptdateEmployees(matricule));
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne");
            }
        }

        /*
         * Exporter les données des employés
         */
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous télécharger les données de la DataGridView ?", "Téléchargement de données", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Créer un objet SaveFileDialog pour permettre à l'utilisateur de choisir l'emplacement et le nom du fichier de téléchargement
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichiers CSV (*.csv)|*.csv"; // Limiter le choix aux fichiers CSV
                saveFileDialog.Title = "Enregistrer les données de la DataGridView";
                saveFileDialog.ShowDialog();

                // Si l'utilisateur a choisi un emplacement et un nom de fichier valide
                if (saveFileDialog.FileName != "")
                {
                    // Ouvrir un flux d'écriture vers le fichier sélectionné
                    StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());

                    // Écrire les en-têtes de colonnes dans le fichier
                    for (int i = 0; i < dgvEmployees.Columns.Count; i++)
                    {
                        writer.Write(dgvEmployees.Columns[i].HeaderText);
                        if (i != dgvEmployees.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();

                    // Écrire les données de chaque ligne dans le fichier
                    for (int i = 0; i < dgvEmployees.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvEmployees.Columns.Count; j++)
                        {
                            writer.Write(dgvEmployees.Rows[i].Cells[j].Value.ToString());
                            if (j != dgvEmployees.Columns.Count - 1)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();
                    }

                    // Fermer le flux d'écriture et afficher un message de confirmation
                    writer.Close();
                    MessageBox.Show("Les données ont été téléchargées avec succès !", "Téléchargement de données");
                }
            }
        }

        /*
         * Filtrer les employés
         */
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if(searchBox.Text != "" && searchBox.Text != "Rechercher un employé . . . ")
            {
                dv = new DataView(dt_employees.FilterEmployees(searchBox.Text));
                dgvEmployees.DataSource = dv;
            }
            else
            {
                dv = new DataView(dt_employees.GetEmployees());
                dgvEmployees.DataSource = dv;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Créer un objet PrintDialog pour permettre à l'utilisateur de sélectionner l'imprimante
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Récupérer l'imprimante sélectionnée
                PrinterSettings printerSettings = printDialog.PrinterSettings;

                // Récupérer le nom de l'imprimante sélectionnée
                string printerName = printerSettings.PrinterName;

                // Créer un objet DataGridViewPrinter pour gérer l'impression de la DataGridView
                DataGridViewPrinter dataGridViewPrinter = new DataGridViewPrinter(dgvEmployees, printDocument1);

                // Configurer les paramètres d'impression du document
                printDocument1.PrinterSettings.PrinterName = printerName;
                printDocument1.DefaultPageSettings.Landscape = true;

                // Imprimer le document
                dataGridViewPrinter.Print();
            }
        }
    }
}
