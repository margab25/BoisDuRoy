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
    public partial class ViewUpdateFunctions : Form
    {
        dataBDD data = new dataBDD();
        DataView dv;
        DataRow[] rows;
        int cpt = 0;
        List<string> listDataFunction = new List<string>();
        string idFunctionEnreg;

        public ViewUpdateFunctions(string idFunction)
        {
            InitializeComponent();
            displayFunction(idFunction);
        }

        /*
         * Affichage de la fonction sur le forme de modification
         */
        private void displayFunction(string idFunction)
        {
            dv = new DataView(data.getFunction(idFunction));

            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;

                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    listDataFunction.Add(row[i].ToString());
                }
                idFunctionEnreg = listDataFunction[0];
                tbx_nomFonction.Text = listDataFunction[1];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbx_nomFonction.Text == "")
            {
                err_nomFonction.Visible = true;
            }
            else
            {
                data.UpdateFunction(idFunctionEnreg ,tbx_nomFonction.Text);

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

                // message box fonction modifié et renvoi à la page Viewfunctions
                MessageBox.Show("Fonction modifié");
                ChildForm SF = new ChildForm((Application.OpenForms["ViewHomeForm"] as ViewHomeForm).panelScreen);
                SF.openChildForm(new ViewFunctions());
            }
        }
    }
}
