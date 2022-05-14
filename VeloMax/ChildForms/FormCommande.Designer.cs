namespace VeloMax.ChildForms
{
    partial class FormCommande
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
            this.btnAddFournisseur = new FontAwesome.Sharp.IconButton();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxSiret = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelDateL = new System.Windows.Forms.Label();
            this.labelAdresseL = new System.Windows.Forms.Label();
            this.labelDateC = new System.Windows.Forms.Label();
            this.labelIdCommande = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddFournisseur
            // 
            this.btnAddFournisseur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnAddFournisseur.FlatAppearance.BorderSize = 0;
            this.btnAddFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFournisseur.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFournisseur.ForeColor = System.Drawing.Color.White;
            this.btnAddFournisseur.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddFournisseur.IconColor = System.Drawing.Color.White;
            this.btnAddFournisseur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFournisseur.Location = new System.Drawing.Point(895, 411);
            this.btnAddFournisseur.Name = "btnAddFournisseur";
            this.btnAddFournisseur.Size = new System.Drawing.Size(173, 65);
            this.btnAddFournisseur.TabIndex = 22;
            this.btnAddFournisseur.Text = "Ajouter";
            this.btnAddFournisseur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFournisseur.UseVisualStyleBackColor = false;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Items.AddRange(new object[] {
            "Très bon",
            "Bon",
            "Moyen",
            "Mauvais"});
            this.comboBoxClient.Location = new System.Drawing.Point(876, 238);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(231, 28);
            this.comboBoxClient.TabIndex = 21;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdresse.Location = new System.Drawing.Point(876, 154);
            this.textBoxAdresse.MaxLength = 100;
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(231, 26);
            this.textBoxAdresse.TabIndex = 20;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContact.Location = new System.Drawing.Point(313, 318);
            this.textBoxContact.MaxLength = 20;
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(231, 26);
            this.textBoxContact.TabIndex = 19;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNom.Location = new System.Drawing.Point(313, 238);
            this.textBoxNom.MaxLength = 20;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(231, 26);
            this.textBoxNom.TabIndex = 18;
            // 
            // textBoxSiret
            // 
            this.textBoxSiret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSiret.Location = new System.Drawing.Point(313, 156);
            this.textBoxSiret.MaxLength = 14;
            this.textBoxSiret.Name = "textBoxSiret";
            this.textBoxSiret.Size = new System.Drawing.Size(231, 26);
            this.textBoxSiret.TabIndex = 17;
            // 
            // labelClient
            // 
            this.labelClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.White;
            this.labelClient.Location = new System.Drawing.Point(767, 234);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(70, 28);
            this.labelClient.TabIndex = 16;
            this.labelClient.Text = "Client";
            // 
            // labelDateL
            // 
            this.labelDateL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateL.AutoSize = true;
            this.labelDateL.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateL.ForeColor = System.Drawing.Color.White;
            this.labelDateL.Location = new System.Drawing.Point(664, 152);
            this.labelDateL.Name = "labelDateL";
            this.labelDateL.Size = new System.Drawing.Size(180, 28);
            this.labelDateL.TabIndex = 15;
            this.labelDateL.Text = "Date de livraison";
            // 
            // labelAdresseL
            // 
            this.labelAdresseL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdresseL.AutoSize = true;
            this.labelAdresseL.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresseL.ForeColor = System.Drawing.Color.White;
            this.labelAdresseL.Location = new System.Drawing.Point(66, 318);
            this.labelAdresseL.Name = "labelAdresseL";
            this.labelAdresseL.Size = new System.Drawing.Size(211, 28);
            this.labelAdresseL.TabIndex = 14;
            this.labelAdresseL.Text = "Adresse de livraison";
            // 
            // labelDateC
            // 
            this.labelDateC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateC.AutoSize = true;
            this.labelDateC.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateC.ForeColor = System.Drawing.Color.White;
            this.labelDateC.Location = new System.Drawing.Point(62, 238);
            this.labelDateC.Name = "labelDateC";
            this.labelDateC.Size = new System.Drawing.Size(215, 28);
            this.labelDateC.TabIndex = 13;
            this.labelDateC.Text = "Date de commande";
            // 
            // labelIdCommande
            // 
            this.labelIdCommande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIdCommande.AutoSize = true;
            this.labelIdCommande.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCommande.ForeColor = System.Drawing.Color.White;
            this.labelIdCommande.Location = new System.Drawing.Point(158, 152);
            this.labelIdCommande.Name = "labelIdCommande";
            this.labelIdCommande.Size = new System.Drawing.Size(119, 28);
            this.labelIdCommande.TabIndex = 12;
            this.labelIdCommande.Text = "Identifiant";
            // 
            // FormCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1255, 629);
            this.Controls.Add(this.btnAddFournisseur);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxSiret);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelDateL);
            this.Controls.Add(this.labelAdresseL);
            this.Controls.Add(this.labelDateC);
            this.Controls.Add(this.labelIdCommande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCommande";
            this.Text = "FormCommande";
            this.Load += new System.EventHandler(this.FormCommande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddFournisseur;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxSiret;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelDateL;
        private System.Windows.Forms.Label labelAdresseL;
        private System.Windows.Forms.Label labelDateC;
        private System.Windows.Forms.Label labelIdCommande;
    }
}