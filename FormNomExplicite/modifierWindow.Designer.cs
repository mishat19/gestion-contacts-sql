namespace FormNomExplicite
{
    partial class modifierWindow
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
            btnModifContact = new Button();
            labelContacts = new Label();
            labelPrenoms = new Label();
            flpEnfants = new FlowLayoutPanel();
            updElement = new NumericUpDown();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            lstContacts = new ListBox();
            btnVisualiser = new Button();
            ((System.ComponentModel.ISupportInitialize)updElement).BeginInit();
            SuspendLayout();
            // 
            // btnModifierWindow
            // 
            btnModifierWindow.Enabled = false;
            btnModifierWindow.Location = new Point(230, 12);
            btnModifierWindow.Name = "btnModifierWindow";
            btnModifierWindow.Size = new Size(102, 38);
            btnModifierWindow.TabIndex = 5;
            btnModifierWindow.Text = "Modifier";
            btnModifierWindow.UseVisualStyleBackColor = true;
            btnModifierWindow.Click += btnModifierWindow_Click;
            // 
            // btnSupprimerWindow
            // 
            btnSupprimerWindow.Location = new Point(122, 12);
            btnSupprimerWindow.Name = "btnSupprimerWindow";
            btnSupprimerWindow.Size = new Size(102, 38);
            btnSupprimerWindow.TabIndex = 4;
            btnSupprimerWindow.Text = "Supprimer";
            btnSupprimerWindow.UseVisualStyleBackColor = true;
            btnSupprimerWindow.Click += btnSupprimerWindow_Click;
            // 
            // btnAjouterWindow
            // 
            btnAjouterWindow.Location = new Point(14, 12);
            btnAjouterWindow.Name = "btnAjouterWindow";
            btnAjouterWindow.Size = new Size(102, 38);
            btnAjouterWindow.TabIndex = 3;
            btnAjouterWindow.Text = "Ajouter";
            btnAjouterWindow.UseVisualStyleBackColor = true;
            btnAjouterWindow.Click += btnAjouterWindow_Click;
            // 
            // btnModifContact
            // 
            btnModifContact.Enabled = false;
            btnModifContact.Location = new Point(600, 392);
            btnModifContact.Name = "btnModifContact";
            btnModifContact.Size = new Size(138, 29);
            btnModifContact.TabIndex = 9;
            btnModifContact.Text = "Modifier contact";
            btnModifContact.UseVisualStyleBackColor = true;
            btnModifContact.Click += btnModifContact_Click;
            // 
            // labelContacts
            // 
            labelContacts.AutoSize = true;
            labelContacts.Location = new Point(19, 148);
            labelContacts.Name = "labelContacts";
            labelContacts.Size = new Size(141, 20);
            labelContacts.TabIndex = 32;
            labelContacts.Text = "Noms des contacts :";
            // 
            // labelPrenoms
            // 
            labelPrenoms.AutoSize = true;
            labelPrenoms.Location = new Point(531, 148);
            labelPrenoms.Name = "labelPrenoms";
            labelPrenoms.Size = new Size(152, 20);
            labelPrenoms.TabIndex = 30;
            labelPrenoms.Text = "Prénoms des enfants :";
            // 
            // flpEnfants
            // 
            flpEnfants.AutoScroll = true;
            flpEnfants.Location = new Point(531, 171);
            flpEnfants.Name = "flpEnfants";
            flpEnfants.Size = new Size(250, 132);
            flpEnfants.TabIndex = 29;
            // 
            // updElement
            // 
            updElement.Enabled = false;
            updElement.Location = new Point(447, 276);
            updElement.Name = "updElement";
            updElement.Size = new Size(45, 27);
            updElement.TabIndex = 28;
            updElement.ValueChanged += updElement_ValueChanged;
            // 
            // txtNom
            // 
            txtNom.Enabled = false;
            txtNom.Location = new Point(259, 211);
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = "Saisir nom";
            txtNom.Size = new Size(233, 27);
            txtNom.TabIndex = 27;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // txtPrenom
            // 
            txtPrenom.Enabled = false;
            txtPrenom.Location = new Point(259, 166);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.PlaceholderText = "Saisir prénom";
            txtPrenom.Size = new Size(233, 27);
            txtPrenom.TabIndex = 26;
            txtPrenom.TextChanged += txtPrenom_TextChanged;
            // 
            // lstContacts
            // 
            lstContacts.FormattingEnabled = true;
            lstContacts.Location = new Point(19, 179);
            lstContacts.Name = "lstContacts";
            lstContacts.Size = new Size(205, 124);
            lstContacts.TabIndex = 33;
            lstContacts.SelectedIndexChanged += lstContacts_SelectedIndexChanged;
            // 
            // btnVisualiser
            // 
            btnVisualiser.Enabled = false;
            btnVisualiser.Location = new Point(19, 324);
            btnVisualiser.Name = "btnVisualiser";
            btnVisualiser.Size = new Size(205, 29);
            btnVisualiser.TabIndex = 34;
            btnVisualiser.Text = "Visualiser";
            btnVisualiser.UseVisualStyleBackColor = true;
            btnVisualiser.Click += btnVisualiser_Click;
            // 
            // modifierWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVisualiser);
            Controls.Add(lstContacts);
            Controls.Add(labelContacts);
            Controls.Add(labelPrenoms);
            Controls.Add(flpEnfants);
            Controls.Add(updElement);
            Controls.Add(txtNom);
            Controls.Add(txtPrenom);
            Controls.Add(btnModifContact);
            Controls.Add(btnModifierWindow);
            Controls.Add(btnSupprimerWindow);
            Controls.Add(btnAjouterWindow);
            Name = "modifierWindow";
            Text = "Modifier Contact";
            Load += modifierWindow_Load;
            ((System.ComponentModel.ISupportInitialize)updElement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModifierWindow;
        private Button btnSupprimerWindow;
        private Button btnAjouterWindow;
        private Button btnModifContact;
        private Label labelContacts;
        private Label labelPrenoms;
        private FlowLayoutPanel flpEnfants;
        private NumericUpDown updElement;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private ListBox lstContacts;
        private Button btnVisualiser;
    }
}