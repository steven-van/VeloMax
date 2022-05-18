namespace VeloMax.ChildForms
{
    partial class FormAddAdherent
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
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBoxFidelite = new System.Windows.Forms.ComboBox();
            this.labelProgramme = new System.Windows.Forms.Label();
            this.datePickerDateAdhesion = new System.Windows.Forms.DateTimePicker();
            this.labelDateAdhesion = new System.Windows.Forms.Label();
            this.btnAddAdherent = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(373, 80);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(231, 28);
            this.comboBoxClient.TabIndex = 12;
            // 
            // labelClient
            // 
            this.labelClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.White;
            this.labelClient.Location = new System.Drawing.Point(266, 80);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(70, 28);
            this.labelClient.TabIndex = 11;
            this.labelClient.Text = "Client";
            // 
            // comboBoxFidelite
            // 
            this.comboBoxFidelite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxFidelite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFidelite.FormattingEnabled = true;
            this.comboBoxFidelite.Items.AddRange(new object[] {
            "1 - Fidelio -  15€ - 1 an - 5% de rabais",
            "2 - Fidelio Or - 25€ - 2 ans - 8 % de rabais",
            "3 - Fidelio Platine - 60€ - 2 ans - 10% de rabais",
            "4 - Fidelio Max - 100€ - 3 ans - 12% de rabais"});
            this.comboBoxFidelite.Location = new System.Drawing.Point(373, 157);
            this.comboBoxFidelite.Name = "comboBoxFidelite";
            this.comboBoxFidelite.Size = new System.Drawing.Size(231, 28);
            this.comboBoxFidelite.TabIndex = 14;
            // 
            // labelProgramme
            // 
            this.labelProgramme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProgramme.AutoSize = true;
            this.labelProgramme.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramme.ForeColor = System.Drawing.Color.White;
            this.labelProgramme.Location = new System.Drawing.Point(95, 153);
            this.labelProgramme.Name = "labelProgramme";
            this.labelProgramme.Size = new System.Drawing.Size(241, 28);
            this.labelProgramme.TabIndex = 13;
            this.labelProgramme.Text = "Programme de fidélité";
            // 
            // datePickerDateAdhesion
            // 
            this.datePickerDateAdhesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerDateAdhesion.Location = new System.Drawing.Point(373, 251);
            this.datePickerDateAdhesion.Name = "datePickerDateAdhesion";
            this.datePickerDateAdhesion.Size = new System.Drawing.Size(231, 26);
            this.datePickerDateAdhesion.TabIndex = 15;
            // 
            // labelDateAdhesion
            // 
            this.labelDateAdhesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateAdhesion.AutoSize = true;
            this.labelDateAdhesion.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateAdhesion.ForeColor = System.Drawing.Color.White;
            this.labelDateAdhesion.Location = new System.Drawing.Point(158, 249);
            this.labelDateAdhesion.Name = "labelDateAdhesion";
            this.labelDateAdhesion.Size = new System.Drawing.Size(178, 28);
            this.labelDateAdhesion.TabIndex = 16;
            this.labelDateAdhesion.Text = "Date d\'adhésion";
            // 
            // btnAddAdherent
            // 
            this.btnAddAdherent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAdherent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnAddAdherent.FlatAppearance.BorderSize = 0;
            this.btnAddAdherent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdherent.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdherent.ForeColor = System.Drawing.Color.White;
            this.btnAddAdherent.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnAddAdherent.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddAdherent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAdherent.Location = new System.Drawing.Point(394, 359);
            this.btnAddAdherent.Name = "btnAddAdherent";
            this.btnAddAdherent.Size = new System.Drawing.Size(173, 65);
            this.btnAddAdherent.TabIndex = 17;
            this.btnAddAdherent.Text = "Ajouter un adhérent";
            this.btnAddAdherent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAdherent.UseVisualStyleBackColor = false;
            this.btnAddAdherent.Click += new System.EventHandler(this.btnAddAdherent_Click);
            // 
            // FormAddAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.btnAddAdherent);
            this.Controls.Add(this.labelDateAdhesion);
            this.Controls.Add(this.datePickerDateAdhesion);
            this.Controls.Add(this.comboBoxFidelite);
            this.Controls.Add(this.labelProgramme);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelClient);
            this.Name = "FormAddAdherent";
            this.Text = "FormAddAdherent";

            this.Shown += new System.EventHandler(this.FormAddAdherent_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBoxFidelite;
        private System.Windows.Forms.Label labelProgramme;
        private System.Windows.Forms.DateTimePicker datePickerDateAdhesion;
        private System.Windows.Forms.Label labelDateAdhesion;
        private FontAwesome.Sharp.IconButton btnAddAdherent;
    }
}