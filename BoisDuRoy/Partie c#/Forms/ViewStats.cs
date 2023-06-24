using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BoisDuRoy_Margaux_Louison.class_folder;
using Mysqlx.Resultset;

namespace BoisDuRoy_Margaux_Louison.Forms
{
    public partial class ViewStats : Form
    {
        DataTable dv;
        dataBDD data = new dataBDD();

        string[] month = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };

        public ViewStats()
        {
            InitializeComponent();
            chartStat.Visible = false;

            //titre du graphe
            chartStat.Titles.Add("stats").Text = "";
        }

        /*
         * Modifier les statistiques à afficher en fonction du choix de l'utilisateur
         */
        private void cbb_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbb_stats.SelectedIndex)
            {
                case 0:
                    clearStats();
                    chartStat.Visible = false;
                    break;
                case 1:
                    clearStats();
                    chartStat.Visible = true;
                    afficherCongeAccpeter();
                    break;
                case 2:
                    clearStats();
                    chartStat.Visible = true;
                    afficherCongeAttente();
                    break;
                case 3:
                    clearStats();
                    chartStat.Visible = true;
                    afficherConge();
                    break;
                case 4:
                    clearStats();
                    chartStat.Visible = true;
                    afficherCongePourcentStatut();
                    break;
            }
        }

        /*
         * Clear les données
         */
        private void clearStats()
        {
            foreach (var series in chartStat.Series)
            {
                series.Points.Clear();
            }
        }

        /*
         * Afficher les données concernant les congés accepté par mois
         */
        public void afficherCongeAccpeter()
        {
            dv = data.statCongeAccepterMois();
            
            foreach(DataRow row in dv.Rows)
            {
                string thisMonth = month[int.Parse(row[0].ToString()) - 1];
                int value = int.Parse(row[1].ToString());

                chartStat.Series[0].Points.AddXY(thisMonth, value);
                chartStat.Series[0].IsValueShownAsLabel= true;
                chartStat.Series[0].Label = "";
            }
        }

        /*
         * Afficher les données concernant les congés en attente par mois
         */
        public void afficherCongeAttente()
        {
            dv = data.statCongeAttenteMois();

            foreach (DataRow row in dv.Rows)
            {
                string thisMonth = month[int.Parse(row[0].ToString()) - 1];
                int value = int.Parse(row[1].ToString());

                chartStat.Series[0].Points.AddXY(thisMonth, value);
                chartStat.Series[0].IsValueShownAsLabel = true;
                chartStat.Series[0].Label = "";
            }
        }

        /*
         * Afficher les données concernant les congés peu importe leur statut
         */
        public void afficherConge()
        {
            dv = data.statCongeMois();

            foreach (DataRow row in dv.Rows)
            {
                string thisMonth = month[int.Parse(row[0].ToString()) - 1];
                int value = int.Parse(row[1].ToString());

                chartStat.Series[0].Points.AddXY(thisMonth, value);
                chartStat.Series[0].IsValueShownAsLabel = true;
                chartStat.Series[0].Label = "";
            }
        }

        /*
         * Afficher % de congé selon leur statut
         */
        public void afficherCongePourcentStatut()
        {
            dv = data.statCongeMoisStatut();

            foreach (DataRow row in dv.Rows)
            {
                string statut = row[0].ToString();
                int value = int.Parse(row[1].ToString());

                chartStat.Series[0].Points.AddXY(statut, value);
                chartStat.Series[0].IsValueShownAsLabel = true;
                chartStat.Series[0].Label = "#PERCENT";
            }
        }
    }
}
