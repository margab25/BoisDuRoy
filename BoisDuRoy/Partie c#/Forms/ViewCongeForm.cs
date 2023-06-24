using BoisDuRoy_Margaux_Louison.class_folder;
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

namespace BoisDuRoy_Margaux_Louison.Forms
{
    public partial class ViewCongeForm : Form
    {
        dataBDD dt_conge;
        DataView dv;
        int demandeRTT;
        int demandeCP;
        int employeRTT;
        int employeCP;
        string matricule;

        public ViewCongeForm()
        {
            InitializeComponent();

            dt_conge = new dataBDD();
            dv = new DataView(dt_conge.getConges());
            dgvConges.DataSource = dv;

            dgvConges.Columns[0].Visible = false;

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
         * Vérifie si l'employé possède assez de jour de congé ou non
         */
        public bool validConge()
        {
            DataTable dtValidConge = dt_conge.getJourConge(dgvConges.SelectedCells[0].Value.ToString());
            matricule = dtValidConge.Rows[0][2].ToString();
            DataTable dtEmployeConge = dt_conge.getEmployeJourConge(matricule);

            demandeRTT = Convert.ToInt32(dtValidConge.Rows[0][0]);
            demandeCP = Convert.ToInt32(dtValidConge.Rows[0][1]);

            employeRTT = Convert.ToInt32(dtEmployeConge.Rows[0][0]);
            employeCP = Convert.ToInt32(dtEmployeConge.Rows[0][1]);

            if (demandeRTT > employeRTT || demandeCP > employeCP)
            {
                return false;
            }
            return true;
        }

        /*
         * gestion du message de refus dans un messagebox
         */
        public string showDialog()
        {
            Form userInputForm = new Form();
            TextBox textBox = new TextBox();
            Button okButton = new Button();
            Button cancelButton = new Button();

            // Définir les propriétés de la zone de texte
            textBox.Location = new Point(10, 10);
            textBox.Size = new Size(200, 20);

            // Définir les propriétés du bouton OK
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(10, 40);

            // Définir les propriétés du bouton Annuler
            cancelButton.Text = "Annuler";
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(120, 40);

            // Ajouter les contrôles à la boîte de dialogue personnalisée
            userInputForm.ClientSize = new Size(220, 80);
            userInputForm.Controls.Add(textBox);
            userInputForm.Controls.Add(okButton);
            userInputForm.Controls.Add(cancelButton);
            userInputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            userInputForm.StartPosition = FormStartPosition.CenterScreen;
            userInputForm.Text = "Saisir un message de refus";

            // Afficher la boîte de dialogue personnalisée et récupérer le texte entré par l'utilisateur
            string userInput = "";
            if (userInputForm.ShowDialog() == DialogResult.OK)
            {
                userInput = textBox.Text;
            }

            return userInput;
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
                    for (int i = 0; i < dgvConges.Columns.Count; i++)
                    {
                        writer.Write(dgvConges.Columns[i].HeaderText);
                        if (i != dgvConges.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();

                    // Écrire les données de chaque ligne dans le fichier
                    for (int i = 0; i < dgvConges.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvConges.Columns.Count; j++)
                        {
                            writer.Write(dgvConges.Rows[i].Cells[j].Value.ToString());
                            if (j != dgvConges.Columns.Count - 1)
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
         * Filtrer les demandes de congé
         */
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "" && searchBox.Text != "Rechercher un employé . . . ")
            {
                dv = new DataView(dt_conge.FilterConges(searchBox.Text));
                dgvConges.DataSource = dv;
            }
            else
            {
                dv = new DataView(dt_conge.getConges());
                dgvConges.DataSource = dv;
            }
        }

        /*
         * Accepter une demande
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if(dgvConges.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Accepter cette demande de congé ?", "Accepter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Vérifier si les jours de congés demandés ne sont pas supérieur à ce possèdé par l'employé
                    if (validConge())
                    {
                        MessageBox.Show("Demande accepté !");
                        dt_conge.acceptConge(dgvConges.SelectedCells[0].Value.ToString());
                        dv = new DataView(dt_conge.getConges());
                        dgvConges.DataSource = dv;

                        dgvConges.Columns[0].Visible = false;

                        //soustraire le nombre de congé utilisé au nombre de comgé actuel
                        dt_conge.updateCongeEmployee(demandeRTT.ToString(), demandeCP.ToString(), matricule);
                    }
                    else
                    {
                        MessageBox.Show("Erreur !\n\rL'employé ne possède pas assez de jour de congé");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une colonne");
            }
        }

        /*
         * Refuser une demande
         */
        private void button3_Click(object sender, EventArgs e)
        {
            if(dgvConges.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Refuser cette demande de congé ?", "Accepter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string motifRefus = showDialog();

                    if(motifRefus != "")
                    {
                        dt_conge.demandeRefuser(dgvConges.SelectedCells[0].Value.ToString(), motifRefus);
                        MessageBox.Show("Demande Refusé !");

                        //actualisation des demandes
                        dv = new DataView(dt_conge.getConges());
                        dgvConges.DataSource = dv;
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une colonne");
            }
        }

        /*
         * Imprimer les données
         */
        private void button2_Click(object sender, EventArgs e)
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
                DataGridViewPrinter dataGridViewPrinter = new DataGridViewPrinter(dgvConges, printDocument1);

                // Configurer les paramètres d'impression du document
                printDocument1.PrinterSettings.PrinterName = printerName;
                printDocument1.DefaultPageSettings.Landscape = true;

                // Imprimer le document
                dataGridViewPrinter.Print();
            }
        }
    }
}
