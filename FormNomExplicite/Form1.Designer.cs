namespace FormNomExplicite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitre = new Label();
            buttonAjout = new Button();
            buttonSupprimer = new Button();
            buttonModifier = new Button();
            labelMessageSysteme = new Label();
            SuspendLayout();
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitre.Location = new Point(278, 68);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(245, 41);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "MES CONTACTS";
            labelTitre.Click += label1_Click;
            // 
            // buttonAjout
            // 
            buttonAjout.Location = new Point(267, 154);
            buttonAjout.Name = "buttonAjout";
            buttonAjout.Size = new Size(267, 41);
            buttonAjout.TabIndex = 1;
            buttonAjout.Text = "Ajouter";
            buttonAjout.UseVisualStyleBackColor = true;
            buttonAjout.Click += buttonAjout_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Location = new Point(267, 227);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(267, 41);
            buttonSupprimer.TabIndex = 2;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.Location = new Point(267, 304);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(267, 41);
            buttonModifier.TabIndex = 3;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // labelMessageSysteme
            // 
            labelMessageSysteme.AutoSize = true;
            labelMessageSysteme.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMessageSysteme.ForeColor = Color.FromArgb(0, 192, 0);
            labelMessageSysteme.Location = new Point(314, 383);
            labelMessageSysteme.Name = "labelMessageSysteme";
            labelMessageSysteme.Size = new Size(173, 28);
            labelMessageSysteme.TabIndex = 4;
            labelMessageSysteme.Text = "Message système";
            labelMessageSysteme.Click += labelMessageSysteme_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMessageSysteme);
            Controls.Add(buttonModifier);
            Controls.Add(buttonSupprimer);
            Controls.Add(buttonAjout);
            Controls.Add(labelTitre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitre;
        private Button buttonAjout;
        private Button buttonSupprimer;
        private Button buttonModifier;
        private Label labelMessageSysteme;
    }
}
