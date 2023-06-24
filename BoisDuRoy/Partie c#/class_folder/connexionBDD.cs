using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoisDuRoy_Margaux_Louison.class_folder
{
    internal class connexionBDD
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public connexionBDD()
        {
            Initialise();
        }

        public MySqlConnection Connection
        {
            get => connection;
            set => connection = value;
        }

        /*
         *  Initialiser la connection
         */
        private void Initialise()
        {
            server = "192.168.67.2";
            database = "bois";
            uid = "BoisDuRoy";
            password = "UnMotDeP@sse";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
    }
}
