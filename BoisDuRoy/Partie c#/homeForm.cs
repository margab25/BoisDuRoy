using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoisDuRoy_Margaux_Louison.Forms;

namespace BoisDuRoy_Margaux_Louison
{
    public partial class homeForm : Form
    {

        private Form activateForm;

        public bool True { get; private set; }

        public homeForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        /*
         * Afficher la page de gestion des employés
         */
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            highlightColorBtn((Button)sender);
            openChildForm(new ViewEmployee());
        }
        /*
         * Afficher la page de gestion des fonctions
         */
        private void btnFunction_Click(object sender, EventArgs e)
        {
            highlightColorBtn((Button)sender);
            openChildForm(new ViewFunctions());
        }

        /*
         * Afficher la page de gestion des Services
         */
        private void btnService_Click(object sender, EventArgs e)
        {
            highlightColorBtn((Button)sender);
            openChildForm(new ViewServices());
        }

        /*
         * Afficher la page de gestion des congés
         */
        private void btnHollidays_Click(object sender, EventArgs e)
        {
            highlightColorBtn((Button)sender); 
        }

        /*
         * Indique à l'utilisateur dans quelle section il se situe
         * On surligne la section avec la méthode Backcolor
         */
        private void highlightColorBtn(Button button)
        {
            foreach (Control buttons in panelMenu.Controls)
            {
                if (buttons.GetType() == typeof(Button))
                {
                    buttons.BackColor = Color.White;
                    buttons.ForeColor = Color.Black;
                }
            }
            button.BackColor = Color.FromArgb(35, 196, 179);
            button.ForeColor = Color.White;
            btnCloseChildForm.Visible = true;
        }

        /*
         * Gestion de l'affichage des formulaires
         */
        private void openChildForm(Form childForm)
        {
            activateForm?.Close();

            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelScreen.Controls.Add(childForm);
            this.panelScreen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        /*
         * On revient à la page home
         * on ferme tous les formes actifs
         */
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            activateForm?.Close();
            Reset();
        }

        /*
         * Remise à 0 de la page Home
         */
        private void Reset()
        {
            labelTitle.Text = "HOME";
            btnCloseChildForm.Visible = false;
            foreach (Control buttons in panelMenu.Controls)
            {
                if (buttons.GetType() == typeof(Button))
                {
                    buttons.BackColor = Color.White;
                    buttons.ForeColor = Color.Black;
                }
            }
        }

        /*
         * Permet de gérer le handle étant donnée que l'on à supprimé la haute barre
         */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
         * Fermer l'application
         */
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        /*
         * Permet d'agrandir le plus possible la fenêtre
         */
        private void btnMaxSize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        /*
         * Permet de réduire la fenêtre
         */
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
