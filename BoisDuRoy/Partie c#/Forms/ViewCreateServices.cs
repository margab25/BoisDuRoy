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
    public partial class ViewCreateServices : Form
    {
        dataBDD data = new dataBDD();
        public ViewCreateServices()
        {
            InitializeComponent();

            cbb_resp_service.DataSource = data.GetEmployeesByName();
            cbb_resp_service.DisplayMember = "nom";
            cbb_resp_service.ValueMember = "matricule";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbx_nom_service.Text != "")
            {
                data.createServices(tbx_nom_service.Text, cbb_resp_service.SelectedValue.ToString());
                MessageBox.Show("Service crée !");
            }
        }
    }
}
