using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoisDuRoy_Margaux_Louison
{
    internal class dataBDD
    {
        private DataTable dtList = new DataTable();
        private connexionBDD conn = new connexionBDD();

        /*
         * Retourne une DataTable qui renvoi la liste des employés
         */
        public DataTable GetEmployees()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT employe.matricule_emp, employe.nom_emp, employe.prenom_emp, employe.mail_emp, employe.tel_emp, employe.num_secu_emp, employe.date_emb_emp, employe.date_naiss_emp FROM employe;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtList.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtList;
        }

        /*
         * Retourne une DataTable qui renvoi la liste des fonctions
         */
        public DataTable getFunctions()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT fonction.id_fonction, fonction.nom_fonction FROM fonction;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtList.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtList;
        }

        /*
         * Retourne une DataTable qui renvoi la liste des services
         */
        public DataTable getServices()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT service.id_service, service.nom_service, employe.nom_emp as 'nom responsable', employe.prenom_emp as 'prénom responsable' FROM service INNER JOIN employe ON employe.matricule_emp = service.responsable_service;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtList.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtList;
        }
    }
}
