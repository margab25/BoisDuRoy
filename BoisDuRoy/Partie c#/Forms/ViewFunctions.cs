using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoisDuRoy_Margaux_Louison.class_folder;


namespace BoisDuRoy_Margaux_Louison.Forms
{
    public partial class ViewFunctions : Form
    {
        dataBDD dtFunctions;
        DataView dv;
        string idFunction;
        string nomFunction;

        public ViewFunctions()
        {
            InitializeComponent();
            dtFunctions = new dataBDD();
            dv = new DataView(dtFunctions.getFunctions());
            dgvFunctions.DataSource = dv;
            dgvFunctions.Columns[0].Visible = false;

            //gérer le focus
            searchBox.GotFocus += (s, e) => {
                if (searchBox.Text == "Rechercher une fonction . . . ")
                {
                    searchBox.Text = "";
                    searchBox.ForeColor = SystemColors.WindowText;
                }
            };
            searchBox.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    searchBox.Text = "Rechercher une fonction . . . ";
                    searchBox.ForeColor = SystemColors.GrayText;
                }
            };
        }

        /*
         * Supprimer une fonction
         */
        private void button3_Click(object sender, EventArgs e)
        {
            if(dgvFunctions.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer cette fonction ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!dtFunctions.isPresentFunction(dgvFunctions.SelectedCells[0].Value.ToString()))
                    {

                        dtFunctions.DeleteFunction(dgvFunctions.SelectedCells[0].Value.ToString());

                        dv = new DataView(dtFunctions.getFunctions());
                        dgvFunctions.DataSource = dv;
                        MessageBox.Show("Fonction supprimé");
                    }
                    else
                    {
                        MessageBox.Show("Impossible de supprimer la fonction, veuillez d'abord supprimez les employés affilié à cette fonction");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            
        }

        /*
         * Créer une fonction
         */
        private void button1_Click_1(object sender, EventArgs e)
        {
            ChildForm SF = new ChildForm((Application.OpenForms["ViewHomeForm"] as ViewHomeForm).panelScreen);
            SF.openChildForm(new ViewCreateFunction());
        }

        /*
         * Modifier une fonction
         */
        private void button2_Click(object sender, EventArgs e)
        {
            if(dgvFunctions.SelectedRows.Count > 0)
            {
                idFunction = dgvFunctions.SelectedCells[0].Value.ToString();
                ChildForm SF = new ChildForm((Application.OpenForms["ViewHomeForm"] as ViewHomeForm).panelScreen);
                SF.openChildForm(new ViewUpdateFunctions(idFunction));
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
        }

        /*
         * Exporter les données de la datagridview
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
                    for (int i = 0; i < dgvFunctions.Columns.Count; i++)
                    {
                        writer.Write(dgvFunctions.Columns[i].HeaderText);
                        if (i != dgvFunctions.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();

                    // Écrire les données de chaque ligne dans le fichier
                    for (int i = 0; i < dgvFunctions.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvFunctions.Columns.Count; j++)
                        {
                            writer.Write(dgvFunctions.Rows[i].Cells[j].Value.ToString());
                            if (j != dgvFunctions.Columns.Count - 1)
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
         * Filtrer les fonctions
         */
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "" && searchBox.Text != "Rechercher une fonction . . . ")
            {
                dv = new DataView(dtFunctions.FilterFunctions(searchBox.Text));
                dgvFunctions.DataSource = dv;
            }
            else
            {
                dv = new DataView(dtFunctions.getFunctions());
                dgvFunctions.DataSource = dv;
            }
        }

        /*
         * Visualiser les employés d'une fonction
         */
        private void dgvFunctions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idFunction = dgvFunctions.SelectedCells[0].Value.ToString();
            nomFunction = dgvFunctions.SelectedCells[1].Value.ToString();
            ChildForm SF = new ChildForm((Application.OpenForms["ViewHomeForm"] as ViewHomeForm).panelScreen);
            SF.openChildForm(new ViewFunctionEmployees(idFunction, nomFunction));
        }

        /*
         * Imprimer la datagridview
         */
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
                DataGridViewPrinter dataGridViewPrinter = new DataGridViewPrinter(dgvFunctions, printDocument1);

                // Configurer les paramètres d'impression du document
                printDocument1.PrinterSettings.PrinterName = printerName;
                printDocument1.DefaultPageSettings.Landscape = true;

                // Imprimer le document
                dataGridViewPrinter.Print();
            }
        }
    }
}
