namespace VeloMax.ChildForms
{
    partial class FormAddCommande
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
            this.textBoxAdresseL = new System.Windows.Forms.TextBox();
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
            this.btnAddCommande = new FontAwesome.Sharp.IconButton();
            this.numModele = new System.Windows.Forms.NumericUpDown();
            this.numPiece = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numModele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPiece)).BeginInit();
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
            this.comboBoxClient.Location = new System.Drawing.Point(294, 512);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(349, 28);
            this.comboBoxClient.TabIndex = 21;
            // 
            // textBoxAdresseL
            // 
            this.textBoxAdresseL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdresseL.Location = new System.Drawing.Point(294, 420);
            this.textBoxAdresseL.MaxLength = 20;
            this.textBoxAdresseL.Name = "textBoxAdresseL";
            this.textBoxAdresseL.Size = new System.Drawing.Size(349, 26);
            this.textBoxAdresseL.TabIndex = 19;
            // 
            // labelClient
            // 
            this.labelClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.White;
            this.labelClient.Location = new System.Drawing.Point(185, 514);
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
            this.labelDateL.Location = new System.Drawing.Point(82, 340);
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
            this.labelAdresseL.Location = new System.Drawing.Point(47, 420);
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
            this.labelDateC.Location = new System.Drawing.Point(43, 268);
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
            this.labelPiece.Location = new System.Drawing.Point(192, 183);
            this.labelPiece.Name = "labelPiece";
            this.labelPiece.Size = new System.Drawing.Size(66, 28);
            this.labelPiece.TabIndex = 24;
            this.labelPiece.Text = "Pièce";
            // 
            // comboBoxPiece
            // 
            this.comboBoxPiece.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPiece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPiece.FormattingEnabled = true;
            this.comboBoxPiece.Location = new System.Drawing.Point(294, 187);
            this.comboBoxPiece.Name = "comboBoxPiece";
            this.comboBoxPiece.Size = new System.Drawing.Size(349, 28);
            this.comboBoxPiece.TabIndex = 25;
            // 
            // labelModele
            // 
            this.labelModele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelModele.AutoSize = true;
            this.labelModele.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModele.ForeColor = System.Drawing.Color.White;
            this.labelModele.Location = new System.Drawing.Point(168, 104);
            this.labelModele.Name = "labelModele";
            this.labelModele.Size = new System.Drawing.Size(87, 28);
            this.labelModele.TabIndex = 26;
            this.labelModele.Text = "Modèle";
            // 
            // comboBoxModele
            // 
            this.comboBoxModele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxModele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModele.FormattingEnabled = true;
            this.comboBoxModele.Location = new System.Drawing.Point(294, 108);
            this.comboBoxModele.Name = "comboBoxModele";
            this.comboBoxModele.Size = new System.Drawing.Size(349, 28);
            this.comboBoxModele.TabIndex = 27;
            // 
            // datePickerDateC
            // 
            this.datePickerDateC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerDateC.Location = new System.Drawing.Point(294, 270);
            this.datePickerDateC.Name = "datePickerDateC";
            this.datePickerDateC.Size = new System.Drawing.Size(349, 26);
            this.datePickerDateC.TabIndex = 28;
            // 
            // datePickerDateL
            // 
            this.datePickerDateL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerDateL.Location = new System.Drawing.Point(294, 344);
            this.datePickerDateL.Name = "datePickerDateL";
            this.datePickerDateL.Size = new System.Drawing.Size(349, 26);
            this.datePickerDateL.TabIndex = 29;
            // 
            // btnAddCommande
            // 
            this.btnAddCommande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnAddCommande.FlatAppearance.BorderSize = 0;
            this.btnAddCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCommande.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCommande.ForeColor = System.Drawing.Color.White;
            this.btnAddCommande.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnAddCommande.IconColor = System.Drawing.Color.White;
            this.btnAddCommande.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCommande.Location = new System.Drawing.Point(389, 609);
            this.btnAddCommande.Name = "btnAddCommande";
            this.btnAddCommande.Size = new System.Drawing.Size(173, 65);
            this.btnAddCommande.TabIndex = 22;
            this.btnAddCommande.Text = "Ajouter";
            this.btnAddCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCommande.UseVisualStyleBackColor = false;
            this.btnAddCommande.Click += new System.EventHandler(this.btnAddCommande_Click);
            // 
            // numModele
            // 
            this.numModele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numModele.Location = new System.Drawing.Point(680, 108);
            this.numModele.Name = "numModele";
            this.numModele.Size = new System.Drawing.Size(120, 26);
            this.numModele.TabIndex = 30;
            // 
            // numPiece
            // 
            this.numPiece.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPiece.Location = new System.Drawing.Point(680, 188);
            this.numPiece.Name = "numPiece";
            this.numPiece.Size = new System.Drawing.Size(120, 26);
            this.numPiece.TabIndex = 31;
            // 
            // FormAddCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(895, 801);
            this.Controls.Add(this.numPiece);
            this.Controls.Add(this.numModele);
            this.Controls.Add(this.datePickerDateL);
            this.Controls.Add(this.datePickerDateC);
            this.Controls.Add(this.comboBoxModele);
            this.Controls.Add(this.labelModele);
            this.Controls.Add(this.comboBoxPiece);
            this.Controls.Add(this.labelPiece);
            this.Controls.Add(this.btnAddCommande);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.textBoxAdresseL);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelDateL);
            this.Controls.Add(this.labelAdresseL);
            this.Controls.Add(this.labelDateC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddCommande";
            this.Text = "FormAddCommande";
            this.Shown += new System.EventHandler(this.FormAddCommande_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numModele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddCommande;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.TextBox textBoxAdresseL;
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
        private System.Windows.Forms.NumericUpDown numModele;
        private System.Windows.Forms.NumericUpDown numPiece;
    }
}