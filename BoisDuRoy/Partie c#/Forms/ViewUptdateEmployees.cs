using BoisDuRoy_Margaux_Louison.class_folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoisDuRoy_Margaux_Louison.Forms
{
    public partial class ViewUptdateEmployees : Form
    {
        dataBDD data = new dataBDD();
        DataView dv;
        DataRow[] rows;
        int cpt = 0;
        List<string> listDataEmployee = new List<string>();
        private string dateEmb;
        private string dateNaiss;
        string matriculeEnreg;

        public ViewUptdateEmployees(string matricule)
        {
            InitializeComponent();
            cbb_service.DataSource = data.getServices();
            cbb_service.DisplayMember = "Nom service";
            cbb_service.ValueMember = "ID service";

            cbb_fonction.DataSource = data.getFunctions();
            cbb_fonction.DisplayMember = "Nom fonction";
            cbb_fonction.ValueMember = "ID fonction";

            displayEmploye(matricule);
        }

        /*
         * Valider la modification
         */
        private void button2_Click(object sender, EventArgs e)
        {
            bool check = true;
            dateEmb = ConvertirDate(dtp_dateEmb.Value.ToString());
            dateNaiss = ConvertirDate(dtp_dateNaiss.Value.ToString());

            if (!IsValidEmail(tbx_mail.Text))
            {
                err_mail.Visible = true;
                check = false;
            }
            if (!IsValidTel(tbx_tel.Text))
            {
                err_tel.Visible = true;
                check = false;
            }
            if (!IsValidSSN(tbx_nss.Text))
            {
                err_nss.Visible = true;
                check = false;
            }
            if (tbx_prenom.Text == "")
            {
                err_prenom.Visible = true;
                check = false;
            }
            if (tbx_nom.Text == "")
            {
                err_nom.Visible = true;
                check = false;
            }
            else if (check)
            {
                data.updateEmployees(tbx_mail.Text, tbx_tel.Text, tbx_nss.Text, dateEmb, dateNaiss, tbx_nom.Text, tbx_prenom.Text, cbb_service.SelectedValue.ToString(), cbb_fonction.SelectedValue.ToString(), matriculeEnreg);

                // effacer les textbox et rendre invisible les erreurs
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                    if (c is Label && c.ForeColor == Color.Red)
                    {
                        ((Label)c).Visible = false;
                    }
                }

                // message box utilisateur modifié et renvoi à la page Viewemployees
                MessageBox.Show("Employé modifié");
                ChildForm SF = new ChildForm((Application.OpenForms["ViewHomeForm"] as ViewHomeForm).panelScreen);
                SF.openChildForm(new ViewEmployee());
            }
        }

        /*
         * Affiche les données de l'enployé dans les bons label
         */
        private void displayEmploye(string matricule)
        {
            dv = new DataView(data.getEmployee(matricule));

            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;

                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    listDataEmployee.Add(row[i].ToString());
                }
                matriculeEnreg = listDataEmployee[0];
                tbx_mail.Text = listDataEmployee[1];
                tbx_tel.Text = listDataEmployee[2];
                tbx_nss.Text = listDataEmployee[3];
                dtp_dateEmb.Value = DateTime.Parse(listDataEmployee[4]);
                dtp_dateNaiss.Value = DateTime.Parse(listDataEmployee[5]);
                tbx_nom.Text = listDataEmployee[7];
                tbx_prenom.Text = listDataEmployee[8];
                cbb_service.SelectedValue = listDataEmployee[9];
                cbb_fonction.SelectedValue = listDataEmployee[10];
            }
        }

        /*
         * Fonction utilisant les expressions régulières afin de vérifier si le mail est correcte
         */
        public bool IsValidEmail(string email)
        {
            string emailRegexPattern = @"^[^\s@]+@broy\.com$";
            Regex emailRegex = new Regex(emailRegexPattern);
            return emailRegex.IsMatch(email);
        }

        /*
         * Fonction utilisant les expressions régulières afin de vérifier si le téléphone est de 5 chiffres
         */
        public bool IsValidTel(string tel)
        {
            string pattern = @"^\d{5}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(tel);
        }

        /*
         * Fonction utilisant les expressions régulières afin de vérifier si le mdp possède 7 caractères, majuscule, minuscule et un chiffre
         */
        public bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{7,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }

        /*
         * Fonction utilisant les expressions régulières afin de vérifier si le numéro de sécurité sociale
         */
        public bool IsValidSSN(string ssn)
        {
            string pattern = @"^(\d{13})\s(\d{2})$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(ssn);
        }

        /*
         * Convertir une date de format dd/mm/yyyy en yyyy-mm-dd
         */
        public string ConvertirDate(string dateHeure)
        {
            string[] dateHeureParts = dateHeure.Split(' ');
            string[] dateParts = dateHeureParts[0].Split('/');
            string nouvelleDate = dateParts[2] + "-" + dateParts[1] + "-" + dateParts[0];
            return nouvelleDate;
        }
    }
}
