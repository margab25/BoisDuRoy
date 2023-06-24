using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BoisDuRoy_Margaux_Louison.class_folder;
using System.Globalization;

namespace BoisDuRoy_Margaux_Louison.Forms
{
    public partial class ViewCreateEmployees : Form
    {
        dataBDD data = new dataBDD();
        private string dateEmb;
        private string dateNaiss;
        public ViewCreateEmployees()
        {
            InitializeComponent();

            cbb_service.DataSource = data.getServices();
            cbb_service.DisplayMember = "Nom service";
            cbb_service.ValueMember = "ID service";

            cbb_fonction.DataSource = data.getFunctions();
            cbb_fonction.DisplayMember = "Nom fonction";
            cbb_fonction.ValueMember = "ID fonction";
        }

        /*
         * Bouton qui créer l'utilisateur si les conditions sont respectées
         */
        private void button1_Click_1(object sender, EventArgs e)
        {
            bool check = true;
            dateEmb = ConvertirDate(dtp_dateEmb.Value.ToString());
            dateNaiss = ConvertirDate(dtp_dateNaiss.Value.ToString());

            if (!IsValidMat(tbx_mat.Text))
            {
                err_mat.Visible = true;
                check = false;
            }
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
            if (!IsValidPassword(tbx_password.Text))
            {
                err_mdp.Visible = true;
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
                data.createEmployees(tbx_mat.Text, tbx_mail.Text, tbx_tel.Text, tbx_nss.Text, dateEmb, dateNaiss, tbx_password.Text, tbx_nom.Text, tbx_prenom.Text, cbb_service.SelectedValue.ToString(), cbb_fonction.SelectedValue.ToString());

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

                // message box utilisateur créé
                MessageBox.Show("Employé Créé");
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
         * Fonction utilisant les expressions régulières afin de vérifier si le matricule commence bien par E suivi de 4 chiffres
         */
        public bool IsValidMat(string mat)
        {
            string pattern = @"^E\d{4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(mat);
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
