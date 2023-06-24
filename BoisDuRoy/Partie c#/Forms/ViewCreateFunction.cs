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

namespace BoisDuRoy_Margaux_Louison.Forms
{
    public partial class ViewCreateFunction : Form
    {

        dataBDD data = new dataBDD();

        public ViewCreateFunction()
        {
            InitializeComponent();
        }

        /*
         * Création et vérification du champ
         */
        private void button2_Click(object sender, EventArgs e)
        {
            if (tbx_nomFonction.Text == "")
            {
                err_nomFonction.Visible = true;
            }
            else
            {
                data.createFunctions(tbx_nomFonction.Text);

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
                MessageBox.Show("Fonction Créé");
            }
        }
    }
}
