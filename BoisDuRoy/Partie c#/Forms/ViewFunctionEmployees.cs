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
    public partial class ViewFunctionEmployees : Form
    {
        dataBDD dtFunctions;
        DataView dv;
        string idFunction;
        public ViewFunctionEmployees(string idFunction, string nomFunction)
        {
            InitializeComponent();
            this.idFunction = idFunction;

            dtFunctions = new dataBDD();
            dv = new DataView(dtFunctions.getFunctionEmployees(idFunction));
            dgvEmployees.DataSource = dv;

            labelTitle.Text = "Liste des employés de "+nomFunction;
        }
    }
}
