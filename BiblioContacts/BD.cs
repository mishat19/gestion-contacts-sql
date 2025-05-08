using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace BiblioContacts
{
    public static class BD
    {
        private static MySqlConnection connexion;

        public static bool OuvrirConnexion()
        {
            string serveur = "10.1.139.235";
            string login = "a1";
            string mdp = "mdp";
            string bd = "basea1";

            string chaineConnexion = $"server={serveur};uid={login};pwd={mdp};database={bd}";

            try
            {
                connexion = new MySqlConnection(chaineConnexion);
                connexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur lors de l'ouverture de la connexion : " + ex.Message);
                return false;
            }
        }

        public static bool FermetureConnexion()
        {
            try
            {
                if (connexion.State == System.Data.ConnectionState.Open)
                {
                    connexion.Close();
                    connexion.Dispose();
                    return true;
                } return false;
            }
            catch (MySqlException ex) {
                Console.WriteLine("Erreur lors de la fermeture de la connexion : " + ex.Message);
                return false;
            }
        }
    }
}
