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
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelDateL = new System.Windows.Forms.Label();
            this.labelAdresseL = new System.Windows.Forms.Label();
            this.labelDateC = new System.Windows.Forms.Label();
            this.labelPiece = new System.Windows.Forms.Label();
            this.comboBoxPiece = new System.Windows.Forms.ComboBox();
            this.labelModele = new System.Windows.Forms.Label();
            this.comboBoxModele = new System.Windows.Forms.ComboBox();
            this.datePickerDateC = new System.Windows.Forms.DateTimePicker();
            this.datePickerDateL = new System.Windows.Forms.DateTimePicker();
            this.btnAddFournisseur = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Items.AddRange(new object[] {
            "Très bon",
            "Bon",
            "Moyen",
            "Mauvais"});
            this.comboBoxClient.Location = new System.Drawing.Point(875, 299);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(231, 28);
            this.comboBoxClient.TabIndex = 21;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContact.Location = new System.Drawing.Point(325, 301);
            this.textBoxContact.MaxLength = 20;
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(231, 26);
            this.textBoxContact.TabIndex = 19;
            // 
            // labelClient
            // 
            this.labelClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.White;
            this.labelClient.Location = new System.Drawing.Point(766, 301);
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
            this.labelDateL.Location = new System.Drawing.Point(663, 219);
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
            this.labelAdresseL.Location = new System.Drawing.Point(78, 301);
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
            this.labelDateC.Location = new System.Drawing.Point(74, 221);
            this.labelDateC.Name = "labelDateC";
            this.labelDateC.Size = new System.Drawing.Size(215, 28);
            this.labelDateC.TabIndex = 13;
            this.labelDateC.Text = "Date de commande";
            // 
            // labelPiece
            // 
            this.labelPiece.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPiece.AutoSize = true;
            this.labelPiece.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPiece.ForeColor = System.Drawing.Color.White;
            this.labelPiece.Location = new System.Drawing.Point(223, 136);
            this.labelPiece.Name = "labelPiece";
            this.labelPiece.Size = new System.Drawing.Size(66, 28);
            this.labelPiece.TabIndex = 24;
            this.labelPiece.Text = "Pièce";
            // 
            // comboBoxPiece
            // 
            this.comboBoxPiece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPiece.FormattingEnabled = true;
            this.comboBoxPiece.Location = new System.Drawing.Point(325, 140);
            this.comboBoxPiece.Name = "comboBoxPiece";
            this.comboBoxPiece.Size = new System.Drawing.Size(231, 28);
            this.comboBoxPiece.TabIndex = 25;
            // 
            // labelModele
            // 
            this.labelModele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelModele.AutoSize = true;
            this.labelModele.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModele.ForeColor = System.Drawing.Color.White;
            this.labelModele.Location = new System.Drawing.Point(749, 136);
            this.labelModele.Name = "labelModele";
            this.labelModele.Size = new System.Drawing.Size(87, 28);
            this.labelModele.TabIndex = 26;
            this.labelModele.Text = "Modèle";
            // 
            // comboBoxModele
            // 
            this.comboBoxModele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModele.FormattingEnabled = true;
            this.comboBoxModele.Location = new System.Drawing.Point(875, 140);
            this.comboBoxModele.Name = "comboBoxModele";
            this.comboBoxModele.Size = new System.Drawing.Size(231, 28);
            this.comboBoxModele.TabIndex = 27;
            // 
            // datePickerDateC
            // 
            this.datePickerDateC.Location = new System.Drawing.Point(325, 223);
            this.datePickerDateC.Name = "datePickerDateC";
            this.datePickerDateC.Size = new System.Drawing.Size(231, 26);
            this.datePickerDateC.TabIndex = 28;
            // 
            // datePickerDateL
            // 
            this.datePickerDateL.Location = new System.Drawing.Point(875, 223);
            this.datePickerDateL.Name = "datePickerDateL";
            this.datePickerDateL.Size = new System.Drawing.Size(231, 26);
            this.datePickerDateL.TabIndex = 29;
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
            this.btnAddFournisseur.Location = new System.Drawing.Point(933, 411);
            this.btnAddFournisseur.Name = "btnAddFournisseur";
            this.btnAddFournisseur.Size = new System.Drawing.Size(173, 65);
            this.btnAddFournisseur.TabIndex = 22;
            this.btnAddFournisseur.Text = "Ajouter";
            this.btnAddFournisseur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFournisseur.UseVisualStyleBackColor = false;
            // 
            // FormCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1255, 629);
            this.Controls.Add(this.datePickerDateL);
            this.Controls.Add(this.datePickerDateC);
            this.Controls.Add(this.comboBoxModele);
            this.Controls.Add(this.labelModele);
            this.Controls.Add(this.comboBoxPiece);
            this.Controls.Add(this.labelPiece);
            this.Controls.Add(this.btnAddFournisseur);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelDateL);
            this.Controls.Add(this.labelAdresseL);
            this.Controls.Add(this.labelDateC);
            this.Name = "FormCommande";
            this.Text = "FormCommande";
            this.Load += new System.EventHandler(this.FormCommande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddFournisseur;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelDateL;
        private System.Windows.Forms.Label labelAdresseL;
        private System.Windows.Forms.Label labelDateC;
        private System.Windows.Forms.Label labelPiece;
        private System.Windows.Forms.ComboBox comboBoxPiece;
        private System.Windows.Forms.Label labelModele;
        private System.Windows.Forms.ComboBox comboBoxModele;
        private System.Windows.Forms.DateTimePicker datePickerDateC;
        private System.Windows.Forms.DateTimePicker datePickerDateL;

    }
}