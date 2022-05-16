namespace VeloMax.ChildForms
{
    partial class FormAddFournisseur
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
            this.labelSiret = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.textBoxSiret = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.comboBoxLibelle = new System.Windows.Forms.ComboBox();
            this.btnAddFournisseur = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelSiret
            // 
            this.labelSiret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSiret.AutoSize = true;
            this.labelSiret.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiret.ForeColor = System.Drawing.Color.White;
            this.labelSiret.Location = new System.Drawing.Point(142, 120);
            this.labelSiret.Name = "labelSiret";
            this.labelSiret.Size = new System.Drawing.Size(57, 28);
            this.labelSiret.TabIndex = 0;
            this.labelSiret.Text = "Siret";
            // 
            // labelNom
            // 
            this.labelNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.White;
            this.labelNom.Location = new System.Drawing.Point(142, 202);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(62, 28);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // labelContact
            // 
            this.labelContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ForeColor = System.Drawing.Color.White;
            this.labelContact.Location = new System.Drawing.Point(112, 282);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(92, 28);
            this.labelContact.TabIndex = 2;
            this.labelContact.Text = "Contact";
            // 
            // labelAdress
            // 
            this.labelAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdress.ForeColor = System.Drawing.Color.White;
            this.labelAdress.Location = new System.Drawing.Point(112, 359);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(92, 28);
            this.labelAdress.TabIndex = 3;
            this.labelAdress.Text = "Adresse";
            // 
            // labelLibelle
            // 
            this.labelLibelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibelle.ForeColor = System.Drawing.Color.White;
            this.labelLibelle.Location = new System.Drawing.Point(122, 445);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(77, 28);
            this.labelLibelle.TabIndex = 4;
            this.labelLibelle.Text = "Libelle";
            // 
            // textBoxSiret
            // 
            this.textBoxSiret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSiret.Location = new System.Drawing.Point(238, 124);
            this.textBoxSiret.MaxLength = 14;
            this.textBoxSiret.Name = "textBoxSiret";
            this.textBoxSiret.Size = new System.Drawing.Size(231, 26);
            this.textBoxSiret.TabIndex = 5;
            this.textBoxSiret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSiret_KeyPress);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNom.Location = new System.Drawing.Point(238, 206);
            this.textBoxNom.MaxLength = 20;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(231, 26);
            this.textBoxNom.TabIndex = 6;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContact.Location = new System.Drawing.Point(238, 286);
            this.textBoxContact.MaxLength = 20;
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(231, 26);
            this.textBoxContact.TabIndex = 7;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdresse.Location = new System.Drawing.Point(238, 363);
            this.textBoxAdresse.MaxLength = 100;
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(231, 26);
            this.textBoxAdresse.TabIndex = 8;
            // 
            // comboBoxLibelle
            // 
            this.comboBoxLibelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxLibelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLibelle.FormattingEnabled = true;
            this.comboBoxLibelle.Items.AddRange(new object[] {
            "Très bon",
            "Bon",
            "Moyen",
            "Mauvais"});
            this.comboBoxLibelle.Location = new System.Drawing.Point(238, 449);
            this.comboBoxLibelle.Name = "comboBoxLibelle";
            this.comboBoxLibelle.Size = new System.Drawing.Size(231, 28);
            this.comboBoxLibelle.TabIndex = 10;
            // 
            // btnAddFournisseur
            // 
            this.btnAddFournisseur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnAddFournisseur.FlatAppearance.BorderSize = 0;
            this.btnAddFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFournisseur.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFournisseur.ForeColor = System.Drawing.Color.White;
            this.btnAddFournisseur.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnAddFournisseur.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddFournisseur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFournisseur.Location = new System.Drawing.Point(263, 540);
            this.btnAddFournisseur.Name = "btnAddFournisseur";
            this.btnAddFournisseur.Size = new System.Drawing.Size(173, 65);
            this.btnAddFournisseur.TabIndex = 11;
            this.btnAddFournisseur.Text = "Ajouter";
            this.btnAddFournisseur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFournisseur.UseVisualStyleBackColor = false;
            this.btnAddFournisseur.Click += new System.EventHandler(this.btnAddFournisseur_Click);
            // 
            // FormAddFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(682, 788);
            this.Controls.Add(this.btnAddFournisseur);
            this.Controls.Add(this.comboBoxLibelle);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxSiret);
            this.Controls.Add(this.labelLibelle);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelSiret);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddFournisseur";
            this.Text = "FormAddFournisseur";
            this.Load += new System.EventHandler(this.FormAddFournisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSiret;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.TextBox textBoxSiret;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.ComboBox comboBoxLibelle;
        private FontAwesome.Sharp.IconButton btnAddFournisseur;
    }
}