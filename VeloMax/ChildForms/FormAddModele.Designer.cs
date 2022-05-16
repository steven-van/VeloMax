namespace VeloMax.ChildForms
{
    partial class FormModele
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrixU = new System.Windows.Forms.Label();
            this.labelGrandeur = new System.Windows.Forms.Label();
            this.labelLigneP = new System.Windows.Forms.Label();
            this.labelDateI = new System.Windows.Forms.Label();
            this.labelDateD = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.comboBoxGrandeur = new System.Windows.Forms.ComboBox();
            this.comboBoxLigneP = new System.Windows.Forms.ComboBox();
            this.datePickerDateI = new System.Windows.Forms.DateTimePicker();
            this.datePickerDateD = new System.Windows.Forms.DateTimePicker();
            this.numPrixU = new System.Windows.Forms.NumericUpDown();
            this.btnAddModele = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixU)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.White;
            this.labelNom.Location = new System.Drawing.Point(240, 67);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(62, 28);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom";
            this.labelNom.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // labelPrixU
            // 
            this.labelPrixU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrixU.AutoSize = true;
            this.labelPrixU.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixU.ForeColor = System.Drawing.Color.White;
            this.labelPrixU.Location = new System.Drawing.Point(170, 251);
            this.labelPrixU.Name = "labelPrixU";
            this.labelPrixU.Size = new System.Drawing.Size(132, 28);
            this.labelPrixU.TabIndex = 3;
            this.labelPrixU.Text = "Prix unitaire";
            // 
            // labelGrandeur
            // 
            this.labelGrandeur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGrandeur.AutoSize = true;
            this.labelGrandeur.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandeur.ForeColor = System.Drawing.Color.White;
            this.labelGrandeur.Location = new System.Drawing.Point(194, 153);
            this.labelGrandeur.Name = "labelGrandeur";
            this.labelGrandeur.Size = new System.Drawing.Size(108, 28);
            this.labelGrandeur.TabIndex = 4;
            this.labelGrandeur.Text = "Grandeur";
            // 
            // labelLigneP
            // 
            this.labelLigneP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLigneP.AutoSize = true;
            this.labelLigneP.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLigneP.ForeColor = System.Drawing.Color.White;
            this.labelLigneP.Location = new System.Drawing.Point(141, 342);
            this.labelLigneP.Name = "labelLigneP";
            this.labelLigneP.Size = new System.Drawing.Size(149, 28);
            this.labelLigneP.TabIndex = 6;
            this.labelLigneP.Text = "Ligne produit";
            // 
            // labelDateI
            // 
            this.labelDateI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateI.AutoSize = true;
            this.labelDateI.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateI.ForeColor = System.Drawing.Color.White;
            this.labelDateI.Location = new System.Drawing.Point(80, 430);
            this.labelDateI.Name = "labelDateI";
            this.labelDateI.Size = new System.Drawing.Size(210, 28);
            this.labelDateI.TabIndex = 17;
            this.labelDateI.Text = "Date d\'introduction";
            // 
            // labelDateD
            // 
            this.labelDateD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateD.AutoSize = true;
            this.labelDateD.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateD.ForeColor = System.Drawing.Color.White;
            this.labelDateD.Location = new System.Drawing.Point(34, 520);
            this.labelDateD.Name = "labelDateD";
            this.labelDateD.Size = new System.Drawing.Size(256, 28);
            this.labelDateD.TabIndex = 16;
            this.labelDateD.Text = "Date de discontinuation";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNom.Location = new System.Drawing.Point(352, 69);
            this.textBoxNom.MaxLength = 14;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(231, 26);
            this.textBoxNom.TabIndex = 21;
            // 
            // comboBoxGrandeur
            // 
            this.comboBoxGrandeur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGrandeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrandeur.FormattingEnabled = true;
            this.comboBoxGrandeur.Items.AddRange(new object[] {
            "Adultes",
            "Jeunes",
            "Hommes",
            "Dames",
            "Garçons",
            "Filles"});
            this.comboBoxGrandeur.Location = new System.Drawing.Point(352, 157);
            this.comboBoxGrandeur.Name = "comboBoxGrandeur";
            this.comboBoxGrandeur.Size = new System.Drawing.Size(231, 28);
            this.comboBoxGrandeur.TabIndex = 24;
            // 
            // comboBoxLigneP
            // 
            this.comboBoxLigneP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxLigneP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLigneP.FormattingEnabled = true;
            this.comboBoxLigneP.Items.AddRange(new object[] {
            "VTT",
            "Vélo de course",
            "Classique",
            "BMX"});
            this.comboBoxLigneP.Location = new System.Drawing.Point(352, 342);
            this.comboBoxLigneP.Name = "comboBoxLigneP";
            this.comboBoxLigneP.Size = new System.Drawing.Size(231, 28);
            this.comboBoxLigneP.TabIndex = 25;
            this.comboBoxLigneP.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // datePickerDateI
            // 
            this.datePickerDateI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerDateI.Location = new System.Drawing.Point(352, 432);
            this.datePickerDateI.Name = "datePickerDateI";
            this.datePickerDateI.Size = new System.Drawing.Size(231, 26);
            this.datePickerDateI.TabIndex = 27;
            // 
            // datePickerDateD
            // 
            this.datePickerDateD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerDateD.Location = new System.Drawing.Point(352, 522);
            this.datePickerDateD.Name = "datePickerDateD";
            this.datePickerDateD.Size = new System.Drawing.Size(231, 26);
            this.datePickerDateD.TabIndex = 28;
            // 
            // numPrixU
            // 
            this.numPrixU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPrixU.Location = new System.Drawing.Point(352, 256);
            this.numPrixU.Name = "numPrixU";
            this.numPrixU.Size = new System.Drawing.Size(231, 26);
            this.numPrixU.TabIndex = 33;
            // 
            // btnAddModele
            // 
            this.btnAddModele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddModele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnAddModele.FlatAppearance.BorderSize = 0;
            this.btnAddModele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModele.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModele.ForeColor = System.Drawing.Color.White;
            this.btnAddModele.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddModele.IconColor = System.Drawing.Color.White;
            this.btnAddModele.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddModele.Location = new System.Drawing.Point(374, 627);
            this.btnAddModele.Name = "btnAddModele";
            this.btnAddModele.Size = new System.Drawing.Size(173, 65);
            this.btnAddModele.TabIndex = 26;
            this.btnAddModele.Text = "Ajouter";
            this.btnAddModele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddModele.UseVisualStyleBackColor = false;
            // 
            // FormModele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(824, 832);
            this.Controls.Add(this.numPrixU);
            this.Controls.Add(this.datePickerDateD);
            this.Controls.Add(this.datePickerDateI);
            this.Controls.Add(this.btnAddModele);
            this.Controls.Add(this.comboBoxLigneP);
            this.Controls.Add(this.comboBoxGrandeur);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelDateI);
            this.Controls.Add(this.labelDateD);
            this.Controls.Add(this.labelLigneP);
            this.Controls.Add(this.labelGrandeur);
            this.Controls.Add(this.labelPrixU);
            this.Controls.Add(this.labelNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModele";
            this.Text = "FormCommande";
            this.Load += new System.EventHandler(this.FormCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrixU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrixU;
        private System.Windows.Forms.Label labelGrandeur;
        private System.Windows.Forms.Label labelLigneP;
        private System.Windows.Forms.Label labelDateI;
        private System.Windows.Forms.Label labelDateD;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.ComboBox comboBoxGrandeur;
        private System.Windows.Forms.ComboBox comboBoxLigneP;
        private FontAwesome.Sharp.IconButton btnAddModele;
        private System.Windows.Forms.DateTimePicker datePickerDateI;
        private System.Windows.Forms.DateTimePicker datePickerDateD;
        private System.Windows.Forms.NumericUpDown numPrixU;
    }
}