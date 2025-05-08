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
    public partial class modifierWindow : Form
    {
        private bool chargementEnCours = false;

        private ListeContacts L;

        public modifierWindow(ListeContacts listeContacts)
        {
            InitializeComponent();
            L = listeContacts;
            RafraichirListeContacts();
        }

        private void modifierWindow_Load(object sender, EventArgs e)
        {
            btnModifierWindow.Focus(); //Focus
        }

        private void btnAjouterWindow_Click(object sender, EventArgs e)
        {
            ajoutWindow ajout = new ajoutWindow(L);
            ajout.Show();
            this.Close();
        }

        private void btnSupprimerWindow_Click(object sender, EventArgs e)
        {
            supprimerWindow supprimer = new supprimerWindow(L);
            supprimer.Show();
            this.Close();
        }

        private void btnModifierWindow_Click(object sender, EventArgs e)
        {

        }

        private void RafraichirListeContacts()
        {
            // Définir la source de données
            lstContacts.DataSource = L.MesContacts;

            // Définir les membres d'affichage et de valeur
            lstContacts.DisplayMember = "Nom"; // Affiche le nom du contact
            lstContacts.ValueMember = "Id";   // Utilise l'ID comme valeur
        }

        private List<string> GetPrenomsEnfants()
        {
            List<string> prenoms = new List<string>();
            foreach (Control ctrl in flpEnfants.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    prenoms.Add(ctrl.Text.Trim());
                }
            }
            return prenoms;
        }

        bool verif = true;
        private void btnModifContact_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            List<string> enfants = GetPrenomsEnfants();

            if (nom.Length < 1 || prenom.Length < 1)
            {
                MessageBox.Show("Veuillez saisir un nom et un prénom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                verif = false;
            }
            else
            {
                foreach (string enfant in enfants)
                {
                    if (string.IsNullOrWhiteSpace(enfant))
                    {
                        MessageBox.Show("Veuillez saisir le prénom de tous les enfants.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        verif = false;
                    }
                }
            }

            if (verif)
            {
                L.AjouterContact(nom, prenom, enfants);

                if (this.Owner is Form1 form)
                {
                    form.AfficherMessage($"{prenom} {nom} a été modifié avec succès");
                    form.Show();
                }
                this.Close();
            }
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            if (!chargementEnCours)
            {
                btnModifContact.Enabled = true;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (!chargementEnCours)
            {
                btnModifContact.Enabled = true;
            }
        }

        private void updElement_ValueChanged(object sender, EventArgs e)
        {
            if (!chargementEnCours)
            {
                btnModifContact.Enabled = true;
                int nbEnfants = (int)updElement.Value;
                UpdateEnfantTextBoxes(nbEnfants);
            }
        }

        private void EnfantTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!chargementEnCours)
            {
                btnModifContact.Enabled = true;
            }
        }

        private void UpdateEnfantTextBoxes(int nbEnfants)
        {
            // Supprimer les TextBox en trop
            while (flpEnfants.Controls.Count > nbEnfants)
            {
                flpEnfants.Controls.RemoveAt(flpEnfants.Controls.Count - 1);
            }

            // Ajouter les TextBox manquantes
            while (flpEnfants.Controls.Count < nbEnfants)
            {
                TextBox newTextBox = new TextBox
                {
                    Name = $"txtEnfant{nbEnfants}",
                    PlaceholderText = $"Prénom enfant{nbEnfants}",
                    Width = 200
                };
                flpEnfants.Controls.Add(newTextBox);
            }
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVisualiser.Enabled = true;
        }

        private void btnVisualiser_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedItem is Contact contact) {
                chargementEnCours = true;

                txtNom.Text = contact.Nom;
                txtPrenom.Text = contact.Prenom;

                updElement.Value = contact.PrenomsEnfants.Count;
                flpEnfants.Controls.Clear();

                if (contact.PrenomsEnfants != null && contact.PrenomsEnfants.Count > 0)
                {
                    foreach (string enfant in contact.PrenomsEnfants)
                    {
                        TextBox newTextBox = new TextBox
                        {
                            Name = $"txtEnfant{enfant}",
                            Text = enfant,
                            Width = 200
                        };

                        newTextBox.TextChanged += EnfantTextBox_TextChanged;
                        flpEnfants.Controls.Add(newTextBox);

                        txtNom.Enabled = true;
                        txtPrenom.Enabled = true;
                        updElement.Enabled = true;
                        btnModifContact.Enabled = false;

                        chargementEnCours = false;
                    }
                }
            }
        }
    }
}
