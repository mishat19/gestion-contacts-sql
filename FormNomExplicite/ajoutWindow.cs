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
    public partial class ajoutWindow : Form
    {
        private ListeContacts L;

        public ajoutWindow(ListeContacts listeContacts)
        {
            InitializeComponent();
            L = listeContacts;
        }

        private void ajoutWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouterWindow_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerWindow_Click(object sender, EventArgs e)
        {
            supprimerWindow supprimer = new supprimerWindow(L);
            supprimer.Show();
            this.Close();
        }

        private void btnModifierWindow_Click(object sender, EventArgs e)
        {
            modifierWindow modifier = new modifierWindow(L);
            modifier.Show();
            this.Close();
        }

        //Récupérer le prénom de tous les enfants
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

        private void btnEnregistrer_Click(object sender, EventArgs e)
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
                    form.AfficherMessage($"{prenom} {nom} a été ajouté avec succès");
                    form.Show();
                }
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1_TextChanged != null)
            {
                btnEnregistrer.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudElement_ValueChanged(object sender, EventArgs e)
        {
            int nbEnfants = (int)updElement.Value;
            UpdateEnfantTextBoxes(nbEnfants);
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
    }
}
