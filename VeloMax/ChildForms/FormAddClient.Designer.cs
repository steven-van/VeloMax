namespace VeloMax.ChildForms
{
    partial class FormAddClient
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxCourriel = new System.Windows.Forms.TextBox();
            this.labelCourriel = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.groupBoxIndividu = new System.Windows.Forms.GroupBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxNomI = new System.Windows.Forms.TextBox();
            this.labelNomI = new System.Windows.Forms.Label();
            this.groupBoxBoutique = new System.Windows.Forms.GroupBox();
            this.textBoxNomB = new System.Windows.Forms.TextBox();
            this.labelNomB = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelVolumeA = new System.Windows.Forms.Label();
            this.numVolumeA = new System.Windows.Forms.NumericUpDown();
            this.numRemise = new System.Windows.Forms.NumericUpDown();
            this.labelRemise = new System.Windows.Forms.Label();
            this.btnAddClient = new FontAwesome.Sharp.IconButton();
            this.groupBoxIndividu.SuspendLayout();
            this.groupBoxBoutique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumeA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemise)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Individu",
            "Boutique"});
            this.comboBoxType.Location = new System.Drawing.Point(294, 202);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(231, 28);
            this.comboBoxType.TabIndex = 12;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(178, 198);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(59, 28);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "Type";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTelephone.Location = new System.Drawing.Point(294, 489);
            this.textBoxTelephone.MaxLength = 20;
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(231, 26);
            this.textBoxTelephone.TabIndex = 21;
            // 
            // labelTel
            // 
            this.labelTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.ForeColor = System.Drawing.Color.White;
            this.labelTel.Location = new System.Drawing.Point(119, 485);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(118, 28);
            this.labelTel.TabIndex = 20;
            this.labelTel.Text = "Téléphone";
            // 
            // textBoxCourriel
            // 
            this.textBoxCourriel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCourriel.Location = new System.Drawing.Point(294, 394);
            this.textBoxCourriel.MaxLength = 20;
            this.textBoxCourriel.Name = "textBoxCourriel";
            this.textBoxCourriel.Size = new System.Drawing.Size(231, 26);
            this.textBoxCourriel.TabIndex = 23;
            // 
            // labelCourriel
            // 
            this.labelCourriel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCourriel.AutoSize = true;
            this.labelCourriel.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourriel.ForeColor = System.Drawing.Color.White;
            this.labelCourriel.Location = new System.Drawing.Point(147, 390);
            this.labelCourriel.Name = "labelCourriel";
            this.labelCourriel.Size = new System.Drawing.Size(90, 28);
            this.labelCourriel.TabIndex = 22;
            this.labelCourriel.Text = "Courriel";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdresse.Location = new System.Drawing.Point(294, 295);
            this.textBoxAdresse.MaxLength = 20;
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(231, 26);
            this.textBoxAdresse.TabIndex = 25;
            // 
            // labelAdresse
            // 
            this.labelAdresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.ForeColor = System.Drawing.Color.White;
            this.labelAdresse.Location = new System.Drawing.Point(145, 291);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(92, 28);
            this.labelAdresse.TabIndex = 24;
            this.labelAdresse.Text = "Adresse";
            // 
            // groupBoxIndividu
            // 
            this.groupBoxIndividu.Controls.Add(this.textBoxPrenom);
            this.groupBoxIndividu.Controls.Add(this.labelPrenom);
            this.groupBoxIndividu.Controls.Add(this.textBoxNomI);
            this.groupBoxIndividu.Controls.Add(this.labelNomI);
            this.groupBoxIndividu.Enabled = false;
            this.groupBoxIndividu.ForeColor = System.Drawing.Color.White;
            this.groupBoxIndividu.Location = new System.Drawing.Point(672, 40);
            this.groupBoxIndividu.Name = "groupBoxIndividu";
            this.groupBoxIndividu.Size = new System.Drawing.Size(730, 254);
            this.groupBoxIndividu.TabIndex = 26;
            this.groupBoxIndividu.TabStop = false;
            this.groupBoxIndividu.Text = "Individu";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrenom.Location = new System.Drawing.Point(332, 144);
            this.textBoxPrenom.MaxLength = 20;
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(231, 26);
            this.textBoxPrenom.TabIndex = 29;
            // 
            // labelPrenom
            // 
            this.labelPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.ForeColor = System.Drawing.Color.White;
            this.labelPrenom.Location = new System.Drawing.Point(183, 140);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(94, 28);
            this.labelPrenom.TabIndex = 28;
            this.labelPrenom.Text = "Prenom";
            // 
            // textBoxNomI
            // 
            this.textBoxNomI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNomI.Location = new System.Drawing.Point(332, 62);
            this.textBoxNomI.MaxLength = 20;
            this.textBoxNomI.Name = "textBoxNomI";
            this.textBoxNomI.Size = new System.Drawing.Size(231, 26);
            this.textBoxNomI.TabIndex = 27;
            // 
            // labelNomI
            // 
            this.labelNomI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomI.AutoSize = true;
            this.labelNomI.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomI.ForeColor = System.Drawing.Color.White;
            this.labelNomI.Location = new System.Drawing.Point(213, 58);
            this.labelNomI.Name = "labelNomI";
            this.labelNomI.Size = new System.Drawing.Size(62, 28);
            this.labelNomI.TabIndex = 26;
            this.labelNomI.Text = "Nom";
            // 
            // groupBoxBoutique
            // 
            this.groupBoxBoutique.Controls.Add(this.numRemise);
            this.groupBoxBoutique.Controls.Add(this.labelRemise);
            this.groupBoxBoutique.Controls.Add(this.numVolumeA);
            this.groupBoxBoutique.Controls.Add(this.labelVolumeA);
            this.groupBoxBoutique.Controls.Add(this.textBoxContact);
            this.groupBoxBoutique.Controls.Add(this.textBoxNomB);
            this.groupBoxBoutique.Controls.Add(this.labelContact);
            this.groupBoxBoutique.Controls.Add(this.labelNomB);
            this.groupBoxBoutique.Enabled = false;
            this.groupBoxBoutique.ForeColor = System.Drawing.Color.White;
            this.groupBoxBoutique.Location = new System.Drawing.Point(672, 350);
            this.groupBoxBoutique.Name = "groupBoxBoutique";
            this.groupBoxBoutique.Size = new System.Drawing.Size(730, 369);
            this.groupBoxBoutique.TabIndex = 27;
            this.groupBoxBoutique.TabStop = false;
            this.groupBoxBoutique.Text = "Boutique";
            // 
            // textBoxNomB
            // 
            this.textBoxNomB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNomB.Location = new System.Drawing.Point(332, 71);
            this.textBoxNomB.MaxLength = 20;
            this.textBoxNomB.Name = "textBoxNomB";
            this.textBoxNomB.Size = new System.Drawing.Size(231, 26);
            this.textBoxNomB.TabIndex = 29;
            // 
            // labelNomB
            // 
            this.labelNomB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomB.AutoSize = true;
            this.labelNomB.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomB.ForeColor = System.Drawing.Color.White;
            this.labelNomB.Location = new System.Drawing.Point(93, 67);
            this.labelNomB.Name = "labelNomB";
            this.labelNomB.Size = new System.Drawing.Size(212, 28);
            this.labelNomB.TabIndex = 28;
            this.labelNomB.Text = "Nom de la boutique";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContact.Location = new System.Drawing.Point(332, 139);
            this.textBoxContact.MaxLength = 20;
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(231, 26);
            this.textBoxContact.TabIndex = 31;
            // 
            // labelContact
            // 
            this.labelContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ForeColor = System.Drawing.Color.White;
            this.labelContact.Location = new System.Drawing.Point(213, 137);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(92, 28);
            this.labelContact.TabIndex = 30;
            this.labelContact.Text = "Contact";
            // 
            // labelVolumeA
            // 
            this.labelVolumeA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVolumeA.AutoSize = true;
            this.labelVolumeA.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumeA.ForeColor = System.Drawing.Color.White;
            this.labelVolumeA.Location = new System.Drawing.Point(136, 211);
            this.labelVolumeA.Name = "labelVolumeA";
            this.labelVolumeA.Size = new System.Drawing.Size(169, 28);
            this.labelVolumeA.TabIndex = 32;
            this.labelVolumeA.Text = "Volume d\'achat";
            // 
            // numVolumeA
            // 
            this.numVolumeA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numVolumeA.Location = new System.Drawing.Point(332, 213);
            this.numVolumeA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numVolumeA.Name = "numVolumeA";
            this.numVolumeA.Size = new System.Drawing.Size(231, 26);
            this.numVolumeA.TabIndex = 34;
            // 
            // numRemise
            // 
            this.numRemise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numRemise.Location = new System.Drawing.Point(332, 278);
            this.numRemise.Name = "numRemise";
            this.numRemise.Size = new System.Drawing.Size(231, 26);
            this.numRemise.TabIndex = 36;
            // 
            // labelRemise
            // 
            this.labelRemise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRemise.AutoSize = true;
            this.labelRemise.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemise.ForeColor = System.Drawing.Color.White;
            this.labelRemise.Location = new System.Drawing.Point(213, 276);
            this.labelRemise.Name = "labelRemise";
            this.labelRemise.Size = new System.Drawing.Size(86, 28);
            this.labelRemise.TabIndex = 35;
            this.labelRemise.Text = "Remise";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddClient.IconColor = System.Drawing.Color.White;
            this.btnAddClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddClient.Location = new System.Drawing.Point(320, 589);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(173, 65);
            this.btnAddClient.TabIndex = 28;
            this.btnAddClient.Text = "Ajouter";
            this.btnAddClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // FormAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1459, 788);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.groupBoxBoutique);
            this.Controls.Add(this.groupBoxIndividu);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.textBoxCourriel);
            this.Controls.Add(this.labelCourriel);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Name = "FormAddClient";
            this.Text = "FormAddClient";
            this.Load += new System.EventHandler(this.FormAddClient_Load);
            this.groupBoxIndividu.ResumeLayout(false);
            this.groupBoxIndividu.PerformLayout();
            this.groupBoxBoutique.ResumeLayout(false);
            this.groupBoxBoutique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumeA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxCourriel;
        private System.Windows.Forms.Label labelCourriel;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.GroupBox groupBoxIndividu;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxNomI;
        private System.Windows.Forms.Label labelNomI;
        private System.Windows.Forms.GroupBox groupBoxBoutique;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxNomB;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelNomB;
        private System.Windows.Forms.Label labelVolumeA;
        private System.Windows.Forms.NumericUpDown numRemise;
        private System.Windows.Forms.Label labelRemise;
        private System.Windows.Forms.NumericUpDown numVolumeA;
        private FontAwesome.Sharp.IconButton btnAddClient;
    }
}