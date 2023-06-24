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

    public partial class ViewServiceEmployees : Form
    {

        dataBDD dtServices;
        DataView dv;
        string idService;

        public ViewServiceEmployees(string idService, string nomService)
        {
            InitializeComponent();
            this.idService = idService;

            dtServices = new dataBDD();
            dv = new DataView(dtServices.getServiceEmployees(idService));
            dgvEmployees.DataSource = dv;

            labelTitle.Text = "Liste des employés de " + nomService;
        }
    }
}
