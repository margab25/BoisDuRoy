using BoisDuRoy_Margaux_Louison.class_folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace BoisDuRoy_Margaux_Louison.Forms
{
    public partial class ViewConnexionApp : Form
    {

        dataBDD data = new dataBDD();
        DataTable dtConnexion;

        public ViewConnexionApp()
        {
            InitializeComponent();

            //gérer le focus sur matricule
            txt_matricule.GotFocus += (s, e) =>
            {
                if (txt_matricule.Text == "Matricule")
                {
                    txt_matricule.Text = "";
                    txt_matricule.ForeColor = SystemColors.WindowText;
                }
            };
            txt_matricule.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt_matricule.Text))
                {
                    txt_matricule.Text = "Matricule";
                    txt_matricule.ForeColor = SystemColors.GrayText;
                }
            };

            //gérer le focus sur password
            txt_password.GotFocus += (s, e) => {
                if (txt_password.Text == "Mot de passe")
                {
                    txt_password.Text = "";
                    txt_password.ForeColor = SystemColors.WindowText;
                }
            };
            txt_password.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt_password.Text))
                {
                    txt_password.Text = "Mot de passe";
                    txt_password.ForeColor = SystemColors.GrayText;
                }
            };
        }

        /*
         * Connexion à l'application
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if (verification())
            {
                ViewHomeForm form = new ViewHomeForm();
                form.Show();
                this.Hide();
            }
            else
            {
                err_nomFonction.Visible = true;
                txt_matricule.Text = "Matricule";
                txt_matricule.ForeColor = SystemColors.GrayText;

                txt_password.Text = "Mot de passe";
                txt_password.ForeColor = SystemColors.GrayText;
            }
        }

        /*
         * Vérification des champs permettant de se connecter
         */
        private bool verification()
        {
            dtConnexion = data.getConnexion(txt_matricule.Text, txt_password.Text);

            if(dtConnexion.Rows.Count > 0 )
            {
                return true;
            }
            return false;
        }
    }
}
