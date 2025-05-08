using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioContacts;

namespace FormNomExplicite
{
    public partial class supprimerWindow : Form
    {
        private ListeContacts liste;
        public supprimerWindow(ListeContacts listContacts)
        {
            InitializeComponent();
            liste = listContacts;
            RafraichirListeContacts();
        }

        private void supprimerWindow_Load(object sender, EventArgs e)
        {
            btnSupprimerWindow.Focus(); //Focus
        }

        private void btnAjouterWindow_Click(object sender, EventArgs e)
        {
            ajoutWindow ajout = new ajoutWindow(liste);
            ajout.Show();
            this.Close();
        }

        private void btnSupprimerWindow_Click(object sender, EventArgs e)
        {

        }

        private void btnModifierWindow_Click(object sender, EventArgs e)
        {
            modifierWindow modifier = new modifierWindow(liste);
            modifier.Show();
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedItem is Contact contact)
            {
                DialogResult result = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer {contact.Prenom} {contact.Nom} ?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    liste.SupprimerContact(contact);
                    MessageBox.Show("Contact supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RafraichirListeContacts();
                    if (this.Owner is Form1 form)
                    {
                        form.AfficherMessage($"{contact.Prenom} {contact.Nom} a été supprimé avec succès");
                        form.Show();
                    }
                    this.Close();
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RafraichirListeContacts()
        {
            // Définir la source de données
            lstContacts.DataSource = liste.MesContacts;

            // Définir les membres d'affichage et de valeur
            lstContacts.DisplayMember = "Nom"; // Affiche le nom du contact
            lstContacts.ValueMember = "Id";   // Utilise l'ID comme valeur
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            btnVisualiser.Enabled = true;
        }

        private void btnVisualiser_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedItem is Contact contact)
            {
                txtNom.Text = contact.Nom;
                txtPrenom.Text = contact.Prenom;

                flpEnfants.Controls.Clear();

                if (contact.PrenomsEnfants != null && contact.PrenomsEnfants.Count > 0) {
                    updElement.Value = contact.PrenomsEnfants.Count;
                    foreach (string enfant in contact.PrenomsEnfants)
                    {
                        TextBox newTextBox = new TextBox
                        {
                            Name = $"txtEnfant{enfant}",
                            Text = enfant,
                            Width = 200
                        };
                        flpEnfants.Controls.Add(newTextBox);
                    }
                }
                btnSupprimer.Enabled = true;
             }
        }
    }
}
