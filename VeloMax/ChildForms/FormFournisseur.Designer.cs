namespace VeloMax.ChildForms
{
    partial class FormFournisseur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFournisseur = new System.Windows.Forms.DataGridView();
            this.btnOpenAddFournisseur = new FontAwesome.Sharp.IconButton();
            this.dataSiret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFournisseur
            // 
            this.dataGridViewFournisseur.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.dataGridViewFournisseur.AllowUserToAddRows = false;
            this.dataGridViewFournisseur.AllowUserToDeleteRows = false;
            this.dataGridViewFournisseur.AllowUserToResizeColumns = false;
            this.dataGridViewFournisseur.AllowUserToResizeRows = false;
            this.dataGridViewFournisseur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewFournisseur.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFournisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataSiret,
            this.dataNom,
            this.dataContact,
            this.dataAdresse,
            this.dataLibelle,
            this.btnUpdate,
            this.btnDelete});
            this.dataGridViewFournisseur.GridColor = System.Drawing.Color.White;
            this.dataGridViewFournisseur.Location = new System.Drawing.Point(101, 63);
            this.dataGridViewFournisseur.MultiSelect = false;
            this.dataGridViewFournisseur.Name = "dataGridViewFournisseur";
            this.dataGridViewFournisseur.ReadOnly = true;
            this.dataGridViewFournisseur.RowHeadersVisible = false;
            this.dataGridViewFournisseur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewFournisseur.RowTemplate.Height = 28;
            this.dataGridViewFournisseur.ShowEditingIcon = false;
            this.dataGridViewFournisseur.Size = new System.Drawing.Size(1044, 422);
            this.dataGridViewFournisseur.TabIndex = 0;
            this.dataGridViewFournisseur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFournisseur_CellClick);
            // 
            // btnOpenAddFournisseur
            // 
            this.btnOpenAddFournisseur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenAddFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnOpenAddFournisseur.FlatAppearance.BorderSize = 0;
            this.btnOpenAddFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAddFournisseur.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAddFournisseur.ForeColor = System.Drawing.Color.White;
            this.btnOpenAddFournisseur.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnOpenAddFournisseur.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOpenAddFournisseur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenAddFournisseur.Location = new System.Drawing.Point(972, 523);
            this.btnOpenAddFournisseur.Name = "btnOpenAddFournisseur";
            this.btnOpenAddFournisseur.Size = new System.Drawing.Size(173, 65);
            this.btnOpenAddFournisseur.TabIndex = 12;
            this.btnOpenAddFournisseur.Text = "Ajouter un fournisseur";
            this.btnOpenAddFournisseur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenAddFournisseur.UseVisualStyleBackColor = false;
            this.btnOpenAddFournisseur.Click += new System.EventHandler(this.btnOpenAddFournisseur_Click);
            // 
            // dataSiret
            // 
            this.dataSiret.DataPropertyName = "siret";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSiret.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataSiret.HeaderText = "siret";
            this.dataSiret.Name = "dataSiret";
            this.dataSiret.ReadOnly = true;
            this.dataSiret.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSiret.Width = 150;
            // 
            // dataNom
            // 
            this.dataNom.DataPropertyName = "nom";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataNom.HeaderText = "nom";
            this.dataNom.Name = "dataNom";
            this.dataNom.ReadOnly = true;
            this.dataNom.Width = 150;
            // 
            // dataContact
            // 
            this.dataContact.DataPropertyName = "contact";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataContact.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataContact.HeaderText = "contact";
            this.dataContact.Name = "dataContact";
            this.dataContact.ReadOnly = true;
            this.dataContact.Width = 150;
            // 
            // dataAdresse
            // 
            this.dataAdresse.DataPropertyName = "adresse";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAdresse.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataAdresse.HeaderText = "adresse";
            this.dataAdresse.Name = "dataAdresse";
            this.dataAdresse.ReadOnly = true;
            this.dataAdresse.Width = 150;
            // 
            // dataLibelle
            // 
            this.dataLibelle.DataPropertyName = "libelle";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLibelle.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataLibelle.HeaderText = "libelle";
            this.dataLibelle.Name = "dataLibelle";
            this.dataLibelle.ReadOnly = true;
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle6;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.HeaderText = "";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ReadOnly = true;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseColumnTextForButtonValue = true;
            this.btnUpdate.Width = 150;
            // 
            // btnDelete
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle7;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 150;
            // 
            // FormFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1255, 629);
            this.Controls.Add(this.dataGridViewFournisseur);
            this.Controls.Add(this.btnOpenAddFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFournisseur";
            this.Text = "FormFournisseur";
            this.Shown += new System.EventHandler(this.FormFournisseur_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnOpenAddFournisseur;
        private System.Windows.Forms.DataGridView dataGridViewFournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSiret;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLibelle;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}