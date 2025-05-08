namespace FormNomExplicite
{
    partial class supprimerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnModifierWindow = new Button();
            btnSupprimerWindow = new Button();
            btnAjouterWindow = new Button();
            btnSupprimer = new Button();
            btnVisualiser = new Button();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            labelPrenoms = new Label();
            flpEnfants = new FlowLayoutPanel();
            updElement = new NumericUpDown();
            labelContacts = new Label();
            lstContacts = new ListBox();
            ((System.ComponentModel.ISupportInitialize)updElement).BeginInit();
            SuspendLayout();
            // 
            // btnModifierWindow
            // 
            btnModifierWindow.Location = new Point(223, 12);
            btnModifierWindow.Name = "btnModifierWindow";
            btnModifierWindow.Size = new Size(102, 38);
            btnModifierWindow.TabIndex = 5;
            btnModifierWindow.Text = "Modifier";
            btnModifierWindow.UseVisualStyleBackColor = true;
            btnModifierWindow.Click += btnModifierWindow_Click;
            // 
            // btnSupprimerWindow
            // 
            btnSupprimerWindow.Enabled = false;
            btnSupprimerWindow.Location = new Point(115, 12);
            btnSupprimerWindow.Name = "btnSupprimerWindow";
            btnSupprimerWindow.Size = new Size(102, 38);
            btnSupprimerWindow.TabIndex = 4;
            btnSupprimerWindow.Text = "Supprimer";
            btnSupprimerWindow.UseVisualStyleBackColor = true;
            btnSupprimerWindow.Click += btnSupprimerWindow_Click;
            // 
            // btnAjouterWindow
            // 
            btnAjouterWindow.Location = new Point(7, 12);
            btnAjouterWindow.Name = "btnAjouterWindow";
            btnAjouterWindow.Size = new Size(102, 38);
            btnAjouterWindow.TabIndex = 3;
            btnAjouterWindow.Text = "Ajouter";
            btnAjouterWindow.UseVisualStyleBackColor = true;
            btnAjouterWindow.Click += btnAjouterWindow_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Enabled = false;
            btnSupprimer.Location = new Point(654, 385);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(102, 38);
            btnSupprimer.TabIndex = 6;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnVisualiser
            // 
            btnVisualiser.Enabled = false;
            btnVisualiser.Location = new Point(12, 310);
            btnVisualiser.Name = "btnVisualiser";
            btnVisualiser.Size = new Size(205, 29);
            btnVisualiser.TabIndex = 16;
            btnVisualiser.Text = "Visualiser";
            btnVisualiser.UseVisualStyleBackColor = true;
            btnVisualiser.Click += btnVisualiser_Click;
            // 
            // txtNom
            // 
            txtNom.Enabled = false;
            txtNom.Location = new Point(252, 204);
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = "Saisir nom";
            txtNom.Size = new Size(233, 27);
            txtNom.TabIndex = 20;
            // 
            // txtPrenom
            // 
            txtPrenom.Enabled = false;
            txtPrenom.Location = new Point(252, 159);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.PlaceholderText = "Saisir prénom";
            txtPrenom.Size = new Size(233, 27);
            txtPrenom.TabIndex = 19;
            // 
            // labelPrenoms
            // 
            labelPrenoms.AutoSize = true;
            labelPrenoms.Location = new Point(524, 141);
            labelPrenoms.Name = "labelPrenoms";
            labelPrenoms.Size = new Size(152, 20);
            labelPrenoms.TabIndex = 23;
            labelPrenoms.Text = "Prénoms des enfants :";
            // 
            // flpEnfants
            // 
            flpEnfants.AutoScroll = true;
            flpEnfants.Enabled = false;
            flpEnfants.Location = new Point(524, 164);
            flpEnfants.Name = "flpEnfants";
            flpEnfants.Size = new Size(250, 132);
            flpEnfants.TabIndex = 22;
            // 
            // updElement
            // 
            updElement.Enabled = false;
            updElement.Location = new Point(440, 269);
            updElement.Name = "updElement";
            updElement.Size = new Size(45, 27);
            updElement.TabIndex = 21;
            // 
            // labelContacts
            // 
            labelContacts.AutoSize = true;
            labelContacts.Location = new Point(12, 141);
            labelContacts.Name = "labelContacts";
            labelContacts.Size = new Size(141, 20);
            labelContacts.TabIndex = 25;
            labelContacts.Text = "Noms des contacts :";
            labelContacts.Click += label1_Click;
            // 
            // lstContacts
            // 
            lstContacts.FormattingEnabled = true;
            lstContacts.Location = new Point(12, 164);
            lstContacts.Name = "lstContacts";
            lstContacts.Size = new Size(205, 124);
            lstContacts.TabIndex = 26;
            lstContacts.SelectedIndexChanged += lstContacts_SelectedIndexChanged;
            // 
            // supprimerWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstContacts);
            Controls.Add(labelContacts);
            Controls.Add(labelPrenoms);
            Controls.Add(flpEnfants);
            Controls.Add(updElement);
            Controls.Add(txtNom);
            Controls.Add(txtPrenom);
            Controls.Add(btnVisualiser);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifierWindow);
            Controls.Add(btnSupprimerWindow);
            Controls.Add(btnAjouterWindow);
            Name = "supprimerWindow";
            Text = "Supprimer Contact";
            Load += supprimerWindow_Load;
            ((System.ComponentModel.ISupportInitialize)updElement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModifierWindow;
        private Button btnSupprimerWindow;
        private Button btnAjouterWindow;
        private Button btnSupprimer;
        private Button btnVisualiser;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private Label labelPrenoms;
        private FlowLayoutPanel flpEnfants;
        private NumericUpDown updElement;
        private Label labelContacts;
        private ListBox lstContacts;
    }
}