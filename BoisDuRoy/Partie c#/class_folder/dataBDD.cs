using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace BoisDuRoy_Margaux_Louison.class_folder
{
    internal class dataBDD
    {
        private DataTable dtList;
        private connexionBDD conn = new connexionBDD();


        //===========================================================================================================
        //
        //  ______         _    _                   _                                  _ 
        // / ____|        | |  (_)                 | |                                | |                 
        //| |  __ ___  ___| |_ _  ___ _ __ __   ___| | ___  ___    ___ _ __ ___  _ __ | | ___  _   _  ___  ___
        //| | |_ |/ _ \/ __| __| |/ _ \| '_ \   / _` |/ _ \/ __|  / _ \ '_ ` _ \| '_ \| |/ _ \| | | |/ _ \/ __|
        //| |__| |  __/\__ \ |_| | (_) | | | | | (_| |  __/\__ \ |  __/ | | | | | |_) | | (_) | |_| |  __/\__ \
        // \_____|\___||___/\__|_|\___/|_| |_|  \__,_|\___||___/  \___|_| |_| |_| .__/|_|\___/ \__, |\___||___/
        //                                                                      | |             __/ |     
        //                                                                      |_|            |___/     
        //
        //===========================================================================================================


        /*
         * Retourne une DataTable qui renvoi la liste des employés
         */
        public DataTable GetEmployees()
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT employe.matricule_emp as Matricule, employe.nom_emp as Nom, employe.prenom_emp as Prénom, employe.mail_emp as Mail, employe.tel_emp as Téléphone, employe.num_secu_emp as NSS, employe.date_emb_emp as 'Date embauche', employe.date_naiss_emp as 'Date naissance' FROM employe;", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
        * Création d'un employé
        */
        public void createEmployees(string mat, string mail, string tel, string num_secu, string date_emb, string date_naiss, string mdp, string nom, string prenom, string idService, string idFonction)
        {

            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO employe(employe.matricule_emp, employe.mail_emp, employe.tel_emp, employe.num_secu_emp, employe.date_emb_emp, employe.date_naiss_emp, employe.mdp_emp, employe.nom_emp, employe.prenom_emp, employe.id_fonction, employe.id_service) VALUES\r\n('" + mat + "','" + mail + "','" + tel + "','" + num_secu + "','" + date_emb + "','" + date_naiss + "',PASSWORD('" + mdp + "'),'" + nom + "','" + prenom + "'," + idFonction + "," + idService + ");", conn.Connection))
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
            conn.Connection.Close();
        }

        /*
         * Update d'un employé
         */
        public void updateEmployees(string mail, string tel, string num_secu, string date_emb, string date_naiss, string nom, string prenom, string idService, string idFonction, string matriculeEnreg)
        {

            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE employe SET employe.mail_emp = '" + mail + "', employe.tel_emp = '" + tel + "', employe.num_secu_emp = '" + num_secu + "', employe.date_emb_emp = '" + date_emb + "', employe.date_naiss_emp = '" + date_naiss + "', employe.nom_emp = '" + nom + "', employe.prenom_emp = '" + prenom + "', employe.id_fonction = " + idService + ", employe.id_service = " + idFonction + " WHERE employe.matricule_emp = '" + matriculeEnreg + "';", conn.Connection))
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
            conn.Connection.Close();
        }

        /*
         * Retourne les données d'un employé
         */
        public DataTable getEmployee(string matricule)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT employe.matricule_emp, employe.mail_emp, employe.tel_emp, employe.num_secu_emp, employe.date_emb_emp, employe.date_naiss_emp, employe.mdp_emp, employe.nom_emp, employe.prenom_emp, employe.id_fonction, employe.id_service FROM employe WHERE employe.matricule_emp = '" + matricule + "';", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        public DataTable GetEmployeesByName()
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT employe.matricule_emp as matricule, CONCAT(employe.nom_emp,\" \", employe.prenom_emp) as nom FROM employe", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Suppression d'un employé
         */
        public void DeleteEmployee(string mat)
        {
            dtList = new DataTable();

            /*
             * Supression de l'état en lien avec l'employé devant se faire supprimer
             */
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM etat WHERE etat.matricule_emp = '"+mat+"';", conn.Connection))
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
            conn.Connection.Close();

            /*
             * Supression des demandes de l'employé
             */

            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM demande WHERE demande.matricule_emp = '"+mat+"';", conn.Connection))
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
            conn.Connection.Close();

            /*
             * Supression de l'employé
             */

            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM employe WHERE employe.matricule_emp = '" + mat + "';", conn.Connection))
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
            conn.Connection.Close();
        }

        /*
         * Filtrer les employés par nom
         */
        public DataTable FilterEmployees(string nom)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT employe.matricule_emp as Matricule, employe.nom_emp as Nom, employe.prenom_emp as Prénom, employe.mail_emp as Mail, employe.tel_emp as Téléphone, employe.num_secu_emp as NSS, employe.date_emb_emp as 'Date embauche', employe.date_naiss_emp as 'Date naissance' FROM employe WHERE employe.nom_emp LIKE '"+nom+"%';", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Afficher les employés d'une fonction
         */
        public DataTable getFunctionEmployees(string idFunction)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT employe.matricule_emp as Matricule, employe.nom_emp as Nom, employe.prenom_emp as Prénom, employe.mail_emp as Mail FROM employe WHERE employe.id_fonction = "+idFunction+";", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Affiche les employés d'un service
         */
        public DataTable getServiceEmployees(string idService)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT employe.matricule_emp as Matricule, employe.nom_emp as Nom, employe.prenom_emp as Prénom, employe.mail_emp as Mail FROM employe WHERE employe.id_service = " + idService + ";", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Retourne une datatable permettant de vérifier la connexion à l'application
         * On vérifie le matricule ainsi que son mdp /!\ hashage, on vérifie aussi sa fonction étant donnée que seul les personnes étant drh peuvent se connecter
         */
        public DataTable getConnexion(string matricule, string mdp)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM employe INNER JOIN fonction ON fonction.id_fonction = employe.id_fonction WHERE employe.matricule_emp = '"+matricule+"' AND employe.mdp_emp = PASSWORD('"+mdp+"') AND fonction.nom_fonction = 'Directrice des ressources humaines';", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        //===========================================================================================================
        //
        //   _____           _   _                   _              __                 _   _                 
        //  / ____|         | | (_)                 | |            / _|               | | (_)                
        // | |  __  ___  ___| |_ _  ___  _ __     __| | ___  ___  | |_ ___  _ __   ___| |_ _  ___  _ __  ___ 
        // | | |_ |/ _ \/ __| __| |/ _ \| '_ \   / _` |/ _ \/ __| |  _/ _ \| '_ \ / __| __| |/ _ \| '_ \/ __|
        // | |__| |  __/\__ \ |_| | (_) | | | | | (_| |  __/\__ \ | || (_) | | | | (__| |_| | (_) | | | \__ \
        //  \_____|\___||___/\__|_|\___/|_| |_|  \__,_|\___||___/ |_| \___/|_| |_|\___|\__|_|\___/|_| |_|___/
        //
        //===========================================================================================================


        /*
         * Retourne une DataTable qui renvoi la liste des fonctions
         */
        public DataTable getFunctions()
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT id_fonction as 'ID fonction', nom_fonction as 'Nom fonction' FROM fonction;", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Création d'une fonction
         */
        public void createFunctions(string nom)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO fonction(fonction.nom_fonction) VALUES ('" + nom + "');", conn.Connection))
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
            conn.Connection.Close();
        }

        /*
         * Modification d'une fonction
         */
        public void UpdateFunction(string idFunction, string nom)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE fonction set fonction.nom_fonction = '" + nom + "' WHERE fonction.id_fonction = " + idFunction + ";", conn.Connection))
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
            conn.Connection.Close();
        }

        /*
         * Retourne les données d'une fonction
        */
        public DataTable getFunction(string idFunction)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT fonction.id_fonction, fonction.nom_fonction FROM fonction WHERE fonction.id_fonction = " + idFunction + " ;", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Suppression d'un employé
         */
        public void DeleteFunction(string idFunction)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM fonction WHERE `fonction`.`id_fonction` = '"+idFunction+"'", conn.Connection))
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
            conn.Connection.Close();
        }

        /*
         * Vérifier la présence d'employé étant affilié à la fonction
         */
        public bool isPresentFunction(string idFunction)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT employe.matricule_emp FROM employe INNER JOIN fonction ON fonction.id_fonction = employe.id_fonction WHERE fonction.id_fonction = "+idFunction+";", conn.Connection))
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
            conn.Connection.Close();

            if(dtList.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                //Si le tableau retourne une valeur alors retourner faux
                return false;
            }
        }
        
        /*
         * Filtrer les fonctions
         */
        public DataTable FilterFunctions(string nom)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT id_fonction as 'ID fonction', nom_fonction as 'Nom fonction' FROM fonction WHERE nom_fonction LIKE '"+nom+"%';", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        //===========================================================================================================
        //
        //   _____          _    _                   _                                 _               
        //  / ____|        | |  (_)                 | |                               (_)              
        // | |  __ ___  ___| |_  _  ___  _ __     __| | ___  ___   ___  ___ _ ____   ___  ___ ___  ___ 
        // | | |_ |/ _ \/ __| __| |/ _ \| '_ \   / _` |/ _ \/ __| / __|/ _ \ '__\ \ / / |/ __/ _ \/ __|
        // | |__| |  __/\__ \ |_| | (_) | | | | | (_| |  __/\__ \ \__ \  __/ |   \ V /| | (_|  __/\__ \
        //  \_____|\___||___/\__|_|\___/|_| |_|  \__,_|\___||___/ |___/\___|_|    \_/ |_|\___\___||___/
        //
        //===========================================================================================================                                                                                            

        /*
         * Retourne une DataTable qui renvoi la liste des services
         */
        public DataTable getServices()
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT service.id_service as 'ID service', service.nom_service as 'Nom service', employe.nom_emp as 'nom responsable', employe.prenom_emp as 'prénom responsable' FROM service INNER JOIN employe ON employe.matricule_emp = service.responsable_service;", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Création d'un service
         */
        public void createServices(string nomService, string nomResp)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO service(service.nom_service, service.responsable_service) VALUES ('"+nomService+"','"+nomResp+"');", conn.Connection))
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
            conn.Connection.Close();
        }

        /*
         * Retourne les données d'un service
        */
        public DataTable getService(string idService)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT service.id_service, service.nom_service, service.responsable_service FROM service WHERE service.id_service = " + idService + " ;", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Modification d'une fonction
         */
        public void UpdateService(string idService, string nom, string respService)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE service SET service.nom_service = '"+ nom +"', service.responsable_service = '"+ respService + "' WHERE service.id_service = "+ idService +";", conn.Connection))
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
            conn.Connection.Close();
        }

        /*
         * Filtrer les services par nom
         */
        public DataTable FilterServices(string nom)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT service.id_service as 'ID service', service.nom_service as 'Nom service', employe.nom_emp as 'nom responsable', employe.prenom_emp as 'prénom responsable' FROM service INNER JOIN employe ON employe.matricule_emp = service.responsable_service WHERE service.nom_service LIKE '"+nom+"%';", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Supprimer un service
         */
        public void DeleteService(string idService)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM service WHERE `service`.`id_service` = '" + idService + "'", conn.Connection))
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
            conn.Connection.Close();
        }

        /*
         * Vérifier la présence d'employé étant affilié à un service
         */
        public bool isPresentService(string idService)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT employe.matricule_emp FROM employe INNER JOIN service ON service.id_service = employe.id_service WHERE service.id_service = " + idService + ";", conn.Connection))
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
            conn.Connection.Close();

            if (dtList.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                //Si le tableau retourne une valeur alors retourner faux
                return false;
            }
        }

        //===========================================================================================================
        //
        //   _____           _   _                   _                                     __      
        //  / ____|         | | (_)                 | |                                   /_/      
        // | |  __  ___  ___| |_ _  ___  _ __     __| | ___  ___    ___ ___  _ __   __ _  ___  ___ 
        // | | |_ |/ _ \/ __| __| |/ _ \| '_ \   / _` |/ _ \/ __|  / __/ _ \| '_ \ / _` |/ _ \/ __|
        // | |__| |  __/\__ \ |_| | (_) | | | | | (_| |  __/\__ \ | (_| (_) | | | | (_| |  __/\__ \
        //  \_____|\___||___/\__|_|\___/|_| |_|  \__,_|\___||___/  \___\___/|_| |_|\__, |\___||___/
        //                                                                          __/ |          
        //                                                                         |___/          
        //
        //===========================================================================================================

        /*
         * Retourne une DataTable qui renvoi la liste des congés
         */
        public DataTable getConges()
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT demande.id_demande as idDemande, CONCAT(employe.nom_emp,' ', employe.prenom_emp) as 'Nom employé', demande.date_debut as 'Début congé', demande.date_fin as 'Fin congé', demande.date_envoi as Envoi, demande.nb_rtt as 'RTT', demande.nb_cp as 'Congé payé' FROM demande INNER JOIN employe ON employe.matricule_emp = demande.matricule_emp INNER JOIN statut ON statut.id_statut = demande.id_statut WHERE statut.nom_statut = 'En cours' ORDER BY `Envoi` ASC;", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Filtrer les congés
         */
        public DataTable FilterConges(string nom)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT demande.id_demande as idDemande, CONCAT(employe.nom_emp,' ', employe.prenom_emp) as 'Nom employé', demande.date_debut as 'Début congé', demande.date_fin as 'Fin congé', demande.date_envoi as Envoi, demande.nb_rtt as 'RTT', demande.nb_cp as 'Congé payé' FROM demande INNER JOIN employe ON employe.matricule_emp = demande.matricule_emp INNER JOIN statut ON statut.id_statut = demande.id_statut WHERE CONCAT(employe.nom_emp,' ', employe.prenom_emp) LIKE '" + nom+ "%' and statut.nom_statut = 'En cours' ORDER BY `Envoi` ASC", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Validation de la demande de congé
         */
        public void acceptConge(string idDemande)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE demande set demande.id_statut = 2 WHERE demande.id_demande = " + idDemande + ";", conn.Connection))
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
            conn.Connection.Close();
        }

        /*
         * Retourne les jours de RTT et congé d'une demande
         */
        public DataTable getJourConge(string idDemande)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT demande.nb_rtt, demande.nb_cp, demande.matricule_emp FROM demande WHERE demande.id_demande = " + idDemande + ";", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Retourne le nombre de jour de congé que peut dépenser un employé
         */
        public DataTable getEmployeJourConge(string matricule)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT etat.rtt_restant, etat.cp_restant FROM etat WHERE etat.matricule_emp = '"+matricule+"';", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        public void updateCongeEmployee(string demandeRTT, string demandeCP, string matricule)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE etat SET etat.cp_restant = etat.cp_restant - " + demandeCP + ", etat.rtt_restant = etat.rtt_restant - " + demandeRTT + " WHERE etat.matricule_emp = '" + matricule + "';", conn.Connection))
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
            conn.Connection.Close();
        }

        /*
         * Refuser une demande
         */
        public void demandeRefuser(string idDemande, string motif)
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE demande SET demande.motif_refus = '" + motif + "', demande.id_statut = 1 WHERE demande.id_demande = " + idDemande + ";", conn.Connection))
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
            conn.Connection.Close();
        }

        //============================================================================================

        /*
         * Retourne les données concernant les congés pris par mois accepter
         */
        public DataTable statCongeAccepterMois()
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT MONTH(date_debut) AS mois, COUNT(*) AS nombre_demandes FROM demande WHERE id_statut = ( SELECT id_statut FROM statut WHERE nom_statut = 'Validé' ) GROUP BY mois ORDER BY mois;", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Retourne les données concernant les congés pris par mois en attente
         */
        public DataTable statCongeAttenteMois()
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT MONTH(date_debut) AS mois, COUNT(*) AS nombre_demandes FROM demande WHERE id_statut = ( SELECT id_statut FROM statut WHERE nom_statut = 'En cours' ) GROUP BY mois ORDER BY mois;", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Retourne les données concernant les congés peu importe leur statut
         */
        public DataTable statCongeMois()
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT MONTH(date_debut) AS mois, COUNT(*) AS nombre_demandes FROM demande GROUP BY mois ORDER BY mois;", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

        /*
         * Retourne les données concernant les congés selon leur statut
         */
        public DataTable statCongeMoisStatut()
        {
            dtList = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT s.nom_statut AS statut, COUNT(*) AS nombre_conges FROM demande d JOIN statut s ON d.id_statut = s.id_statut WHERE s.nom_statut IN ('Validé', 'En cours', 'Refusé') GROUP BY s.nom_statut ORDER BY s.nom_statut;", conn.Connection))
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
            conn.Connection.Close();
            return dtList;
        }

    }
}
