using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoisDuRoy_Margaux_Louison
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
            server = "localhost";
            database = "bois";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
    }
}
