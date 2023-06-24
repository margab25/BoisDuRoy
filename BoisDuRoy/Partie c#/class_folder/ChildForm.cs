using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoisDuRoy_Margaux_Louison.class_folder
{
    internal class ChildForm
    {

        public Panel PanelSousFormlaire;
        public Form activeForm = null;

        public ChildForm(Panel panelenvoit)
        {
            PanelSousFormlaire = panelenvoit;
        }

        public string openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            PanelSousFormlaire.Controls.Add(formEnfant);
            PanelSousFormlaire.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();

            return formEnfant.Text;
        }
    }
}
