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
    public partial class ViewServices : Form
    {
        dataBDD dtServices;
        DataView dv;
        string idService;
        string nomService;

        public ViewServices()
        {
            InitializeComponent();
            dtServices = new dataBDD();
            dv = new DataView(dtServices.getServices());
            dgvServices.DataSource = dv;
            dgvServices.Columns[0].Visible = false;


            //gérer le focus
            searchBox.GotFocus += (s, e) => {
                if (searchBox.Text == "Rechercher un service . . . ")
                {
                    searchBox.Text = "";
                    searchBox.ForeColor = SystemColors.WindowText;
                }
            };
            searchBox.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    searchBox.Text = "Rechercher un service . . . ";
                    searchBox.ForeColor = SystemColors.GrayText;
                }
            };


        }

        /*
         * Redirige vers le formulaire de création de service
         */
        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm SF = new ChildForm((Application.OpenForms["ViewHomeForm"] as ViewHomeForm).panelScreen);
            SF.openChildForm(new ViewCreateServices());
        }

        /*
         * Modifier les paramètres d'un service
         */
        private void button2_Click(object sender, EventArgs e)
        {
            idService = dgvServices.SelectedCells[0].Value.ToString();
            ChildForm SF = new ChildForm((Application.OpenForms["ViewHomeForm"] as ViewHomeForm).panelScreen);
            SF.openChildForm(new ViewUpdateServices(idService));
        }

        /*
         * Supprimer un service
         */
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer ce service ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!dtServices.isPresentService(dgvServices.SelectedCells[0].Value.ToString()))
                    {

                        dtServices.DeleteService(dgvServices.SelectedCells[0].Value.ToString());

                        dv = new DataView(dtServices.getServices());
                        dgvServices.DataSource = dv;
                        MessageBox.Show("Service supprimé");
                    }
                    else
                    {
                        MessageBox.Show("Impossible de supprimer le service, veuillez d'abord supprimez les employés affilié à cette fonction");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
        }

        /*
         * Télécharger les données
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
                    for (int i = 0; i < dgvServices.Columns.Count; i++)
                    {
                        writer.Write(dgvServices.Columns[i].HeaderText);
                        if (i != dgvServices.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();

                    // Écrire les données de chaque ligne dans le fichier
                    for (int i = 0; i < dgvServices.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvServices.Columns.Count; j++)
                        {
                            writer.Write(dgvServices.Rows[i].Cells[j].Value.ToString());
                            if (j != dgvServices.Columns.Count - 1)
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
         * Filtrer les services
         */
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "" && searchBox.Text != "Rechercher un service . . . ")
            {
                dv = new DataView(dtServices.FilterServices(searchBox.Text));
                dgvServices.DataSource = dv;
            }
            else
            {
                dv = new DataView(dtServices.getServices());
                dgvServices.DataSource = dv;
            }
        }

        /*
         * Visualiser les employés d'un service
         */
        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idService = dgvServices.SelectedCells[0].Value.ToString();
            nomService = dgvServices.SelectedCells[1].Value.ToString();
            ChildForm SF = new ChildForm((Application.OpenForms["ViewHomeForm"] as ViewHomeForm).panelScreen);
             SF.openChildForm(new ViewServiceEmployees(idService, nomService));
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
                DataGridViewPrinter dataGridViewPrinter = new DataGridViewPrinter(dgvServices, printDocument1);

                // Configurer les paramètres d'impression du document
                printDocument1.PrinterSettings.PrinterName = printerName;
                printDocument1.DefaultPageSettings.Landscape = true;

                // Imprimer le document
                dataGridViewPrinter.Print();
            }
        }
    }
}
