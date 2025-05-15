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

        public static void AjoutContactEnfants(string nom, string prenom, List<string> enfants)
        {
            string reqSQL = $"INSERT INTO contact (nom, prenom) VALUES ('{nom}', '{prenom}')";
            MySqlCommand cmd = new MySqlCommand(reqSQL, connexion);
            cmd.ExecuteNonQuery();
            int nEnfant = 0;
            foreach (string enfant in enfants)
            {
                ++nEnfant;
                int idParent;
                idParent = (int)cmd.LastInsertedId;
                string reqSQL2 = $"INSERT INTO enfant (idContact, noEnfant, prenomE) VALUES ('{idParent}', '{nEnfant}', '{enfant}')";
                MySqlCommand cmd2 = new MySqlCommand(reqSQL2, connexion);
                cmd2.ExecuteNonQuery();
            }
        }

        public static List<Contact> LectureContact()
        {
            string reqSQL = @"
            SELECT c.idContact, c.nom, c.prenom, e.prenomE
            FROM contact c
            LEFT JOIN enfant e ON c.idContact = e.idContact
            ORDER BY c.idContact, e.noEnfant";

            List<Contact> contacts = new List<Contact>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(reqSQL, connexion);
                MySqlDataReader rdr = cmd.ExecuteReader();

                int lastId = -1;
                Contact? contact = null;

                while (rdr.Read())
                {
                    int idContact = rdr.GetInt32("idContact");
                    string nom = rdr.GetString("nom");
                    string prenom = rdr.GetString("prenom");
                    string? prenomE = rdr.IsDBNull(rdr.GetOrdinal("prenomE")) ? null : rdr.GetString("prenomE");

                    if (idContact != lastId)
                    {
                        int nbEnfants = 0;
                        contact = new Contact(idContact, nom, prenom, 0);
                        contacts.Add(contact);
                        lastId = idContact;
                    }

                    if (prenomE != null && contact != null)
                    {
                        contact.AddEnfant(prenomE);
                    }
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la lecture des contacts : " + ex.Message);
            }

            foreach (Contact contact in contacts) {
                foreach (Contact contact1 in contacts) {
                    if (contact.Id == contact1.Id && contact1.PrenomsEnfants != null) {
                        contact.AddEnfant(contact1.PrenomsEnfants[0]);
                        contacts.Remove(contact1);
                    }
                }
            }

            return contacts;
        }


        public static void SupprimerContact(string nom, string prenom)
        {

        }
    }
}
