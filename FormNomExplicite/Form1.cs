using BiblioContacts;

namespace FormNomExplicite
{
    public partial class Form1 : Form
    {
        private ListeContacts listeContacts;
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize!;
            listeContacts = new ListeContacts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMessageSysteme.Text = "";
            CentrerLabel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            //FormAjout frmAjout = new FormAjout();
            //frmAjout show();
            ajoutWindow ajout = new ajoutWindow(listeContacts);
            ajout.Show(this);
            this.Hide();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            supprimerWindow supprimer = new supprimerWindow(listeContacts);
            supprimer.Show(this);
            this.Hide();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            modifierWindow modifier = new modifierWindow(listeContacts);
            modifier.Show(this);
            this.Hide();
        }

        private void labelMessageSysteme_Click_1(object sender, EventArgs e)
        {
 
        }

        private void CentrerLabel()
        {
            labelMessageSysteme.Left = (this.ClientSize.Width - labelMessageSysteme.Width) / 2;
            labelTitre.Left = (this.ClientSize.Width - labelTitre.Width) / 2;
            buttonAjout.Left = (this.ClientSize.Width - buttonAjout.Width) / 2;
            buttonSupprimer.Left = (this.ClientSize.Width - buttonSupprimer.Width) / 2;
            buttonModifier.Left = (this.ClientSize.Width - buttonModifier.Width) / 2;
        }


        //Pour centrer labelMessageSystem

        private void Form1_Resize(object sender, EventArgs e)
        {
            CentrerLabel();
        }

        public void AfficherMessage(string message)
        {
            labelMessageSysteme.Text = message;
            CentrerLabel();
        }
    }
}
