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

        public static bool OuvertureConnexion()
        {
            string serveur = "localhost";
            string login = "root";
            string mdp = "root";
            string bd = "gestion_contacts";

            string chaineConnexion = $"server={serveur};uid={login};pwd={mdp};database={bd}";

            try
            {
                connexion = new MySqlConnection(chaineConnexion);
                connexion.Open();
                Console.WriteLine("Connexion réussie");
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
                    Console.WriteLine("Déconnexion réussie");
                    connexion.Dispose();
                    return true;
                } return false;
            }
            catch (MySqlException ex) {
                Console.WriteLine("Erreur lors de la fermeture de la connexion : " + ex.Message);
                return false;
            }
        }

        public static void AjoutContact(string nom, string prenom)
        {
            string reqSQL = $"INSERT INTO contact (nom, prenom) VALUES ('{nom}', '{prenom}')";
            MySqlCommand cmd = new MySqlCommand(reqSQL, connexion);
            cmd.ExecuteNonQuery();
        }
    }
}
