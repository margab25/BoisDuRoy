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
    public partial class ViewUpdateServices : Form
    {
        dataBDD data = new dataBDD();
        DataView dv;
        DataRow[] rows;
        int cpt = 0;
        List<string> listDataService = new List<string>();
        string idServiceEnreg;
        string respService;

        public ViewUpdateServices(string idService)
        {
            InitializeComponent();

            cbb_resp_service.DataSource = data.GetEmployeesByName();
            cbb_resp_service.DisplayMember = "nom";
            cbb_resp_service.ValueMember = "matricule";

            displayService(idService);
        }

        /*
         * Affichage des données du service sélectionné
         */
        private void displayService(string idService)
        {
            dv = new DataView(data.getService(idService));

            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;

                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    listDataService.Add(row[i].ToString());
                }
                idServiceEnreg = listDataService[0];
                tbx_nom_service.Text = listDataService[1];
                cbb_resp_service.SelectedValue = listDataService[2];

            }
        }

        /*
         * Validation des modifications
         */
        private void button2_Click(object sender, EventArgs e)
        {
            if (tbx_nom_service.Text == "")
            {
                err_nom_service.Visible = true;
            }
            if(cbb_resp_service.SelectedValue.ToString() == "")
            {
                MessageBox.Show("saisir un service");
            }
            else
            {
                respService = cbb_resp_service.SelectedValue.ToString();
                data.UpdateService(idServiceEnreg, tbx_nom_service.Text, respService);

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

                // message box service modifié et renvoi à la page Viewfunctions
                MessageBox.Show("Service modifié");
                ChildForm SF = new ChildForm((Application.OpenForms["ViewHomeForm"] as ViewHomeForm).panelScreen);
                SF.openChildForm(new ViewServices());
            }
        }
    }
}
