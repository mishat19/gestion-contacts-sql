namespace FormNomExplicite
{
    partial class ajoutWindow
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
            btnAjouterWindow = new Button();
            btnSupprimerWindow = new Button();
            btnModifierWindow = new Button();
            btnEnregistrer = new Button();
            txtPrenom = new TextBox();
            txtNom = new TextBox();
            updElement = new NumericUpDown();
            flpEnfants = new FlowLayoutPanel();
            labelPrenoms = new Label();
            ((System.ComponentModel.ISupportInitialize)updElement).BeginInit();
            SuspendLayout();
            // 
            // btnAjouterWindow
            // 
            btnAjouterWindow.Enabled = false;
            btnAjouterWindow.Location = new Point(12, 22);
            btnAjouterWindow.Name = "btnAjouterWindow";
            btnAjouterWindow.Size = new Size(102, 38);
            btnAjouterWindow.TabIndex = 0;
            btnAjouterWindow.Text = "Ajouter";
            btnAjouterWindow.UseVisualStyleBackColor = true;
            btnAjouterWindow.Click += btnAjouterWindow_Click;
            // 
            // btnSupprimerWindow
            // 
            btnSupprimerWindow.Location = new Point(120, 22);
            btnSupprimerWindow.Name = "btnSupprimerWindow";
            btnSupprimerWindow.Size = new Size(102, 38);
            btnSupprimerWindow.TabIndex = 1;
            btnSupprimerWindow.Text = "Supprimer";
            btnSupprimerWindow.UseVisualStyleBackColor = true;
            btnSupprimerWindow.Click += btnSupprimerWindow_Click;
            // 
            // btnModifierWindow
            // 
            btnModifierWindow.Location = new Point(228, 22);
            btnModifierWindow.Name = "btnModifierWindow";
            btnModifierWindow.Size = new Size(102, 38);
            btnModifierWindow.TabIndex = 2;
            btnModifierWindow.Text = "Modifier";
            btnModifierWindow.UseVisualStyleBackColor = true;
            btnModifierWindow.Click += btnModifierWindow_Click;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Enabled = false;
            btnEnregistrer.Location = new Point(663, 369);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(102, 38);
            btnEnregistrer.TabIndex = 3;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(120, 171);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.PlaceholderText = "Saisir prénom";
            txtPrenom.Size = new Size(339, 27);
            txtPrenom.TabIndex = 5;
            txtPrenom.TextChanged += textBox1_TextChanged;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(120, 216);
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = "Saisir nom";
            txtNom.Size = new Size(339, 27);
            txtNom.TabIndex = 8;
            txtNom.TextChanged += textBox4_TextChanged;
            // 
            // updElement
            // 
            updElement.Location = new Point(406, 281);
            updElement.Name = "updElement";
            updElement.Size = new Size(45, 27);
            updElement.TabIndex = 11;
            updElement.ValueChanged += nudElement_ValueChanged;
            // 
            // flpEnfants
            // 
            flpEnfants.AutoScroll = true;
            flpEnfants.Location = new Point(515, 176);
            flpEnfants.Name = "flpEnfants";
            flpEnfants.Size = new Size(250, 132);
            flpEnfants.TabIndex = 12;
            // 
            // labelPrenoms
            // 
            labelPrenoms.AutoSize = true;
            labelPrenoms.Location = new Point(515, 153);
            labelPrenoms.Name = "labelPrenoms";
            labelPrenoms.Size = new Size(152, 20);
            labelPrenoms.TabIndex = 13;
            labelPrenoms.Text = "Prénoms des enfants :";
            // 
            // ajoutWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPrenoms);
            Controls.Add(flpEnfants);
            Controls.Add(updElement);
            Controls.Add(txtNom);
            Controls.Add(txtPrenom);
            Controls.Add(btnEnregistrer);
            Controls.Add(btnModifierWindow);
            Controls.Add(btnSupprimerWindow);
            Controls.Add(btnAjouterWindow);
            Name = "ajoutWindow";
            Text = "Ajouter Contact";
            Load += ajoutWindow_Load;
            ((System.ComponentModel.ISupportInitialize)updElement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAjouterWindow;
        private Button btnSupprimerWindow;
        private Button btnModifierWindow;
        private Button btnEnregistrer;
        private TextBox txtPrenom;
        private TextBox txtNom;
        private NumericUpDown updElement;
        private FlowLayoutPanel flpEnfants;
        private Label labelPrenoms;
    }
}