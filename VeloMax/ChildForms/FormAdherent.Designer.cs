namespace VeloMax.ChildForms
{
    partial class FormAdherent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAdhesion = new System.Windows.Forms.DataGridView();
            this.dataIdFidelite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateAdhesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDuree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRabais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnOpenAddCommande = new FontAwesome.Sharp.IconButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdhesion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdhesion
            // 
            this.dataGridViewAdhesion.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.dataGridViewAdhesion.AllowUserToAddRows = false;
            this.dataGridViewAdhesion.AllowUserToDeleteRows = false;
            this.dataGridViewAdhesion.AllowUserToResizeColumns = false;
            this.dataGridViewAdhesion.AllowUserToResizeRows = false;
            this.dataGridViewAdhesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAdhesion.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAdhesion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAdhesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdhesion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataIdFidelite,
            this.dataDescription,
            this.dataIdClient,
            this.dataNom,
            this.dataPrenom,
            this.dataDateAdhesion,
            this.dataDuree,
            this.dataRabais,
            this.btnDelete});
            this.dataGridViewAdhesion.GridColor = System.Drawing.Color.White;
            this.dataGridViewAdhesion.Location = new System.Drawing.Point(95, 118);
            this.dataGridViewAdhesion.MultiSelect = false;
            this.dataGridViewAdhesion.Name = "dataGridViewAdhesion";
            this.dataGridViewAdhesion.ReadOnly = true;
            this.dataGridViewAdhesion.RowHeadersVisible = false;
            this.dataGridViewAdhesion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAdhesion.RowTemplate.Height = 28;
            this.dataGridViewAdhesion.ShowEditingIcon = false;
            this.dataGridViewAdhesion.Size = new System.Drawing.Size(1044, 422);
            this.dataGridViewAdhesion.TabIndex = 15;
            this.dataGridViewAdhesion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdhesion_CellClick);
            // 
            // dataIdFidelite
            // 
            this.dataIdFidelite.DataPropertyName = "idFidelite";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdFidelite.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataIdFidelite.HeaderText = "idFidelite";
            this.dataIdFidelite.Name = "dataIdFidelite";
            this.dataIdFidelite.ReadOnly = true;
            this.dataIdFidelite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIdFidelite.Width = 150;
            // 
            // dataDescription
            // 
            this.dataDescription.DataPropertyName = "description";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDescription.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataDescription.HeaderText = "description";
            this.dataDescription.Name = "dataDescription";
            this.dataDescription.ReadOnly = true;
            this.dataDescription.Width = 150;
            // 
            // dataIdClient
            // 
            this.dataIdClient.DataPropertyName = "idClient";
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdClient.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataIdClient.HeaderText = "idClient";
            this.dataIdClient.Name = "dataIdClient";
            this.dataIdClient.ReadOnly = true;
            this.dataIdClient.Width = 150;
            // 
            // dataNom
            // 
            this.dataNom.DataPropertyName = "nom";
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNom.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataNom.HeaderText = "nom";
            this.dataNom.Name = "dataNom";
            this.dataNom.ReadOnly = true;
            this.dataNom.Width = 150;
            // 
            // dataPrenom
            // 
            this.dataPrenom.DataPropertyName = "prenom";
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPrenom.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataPrenom.HeaderText = "prenom";
            this.dataPrenom.Name = "dataPrenom";
            this.dataPrenom.ReadOnly = true;
            this.dataPrenom.Width = 150;
            // 
            // dataDateAdhesion
            // 
            this.dataDateAdhesion.DataPropertyName = "dateAdhesion";
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateAdhesion.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataDateAdhesion.HeaderText = "dateAdhesion";
            this.dataDateAdhesion.Name = "dataDateAdhesion";
            this.dataDateAdhesion.ReadOnly = true;
            this.dataDateAdhesion.Width = 150;
            // 
            // dataDuree
            // 
            this.dataDuree.DataPropertyName = "duree";
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDuree.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataDuree.HeaderText = "duree";
            this.dataDuree.Name = "dataDuree";
            this.dataDuree.ReadOnly = true;
            // 
            // dataRabais
            // 
            this.dataRabais.DataPropertyName = "rabais";
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataRabais.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataRabais.HeaderText = "rabais";
            this.dataRabais.Name = "dataRabais";
            this.dataRabais.ReadOnly = true;
            this.dataRabais.Width = 150;
            // 
            // btnDelete
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle27;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 150;
            // 
            // btnOpenAddCommande
            // 
            this.btnOpenAddCommande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenAddCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnOpenAddCommande.FlatAppearance.BorderSize = 0;
            this.btnOpenAddCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAddCommande.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAddCommande.ForeColor = System.Drawing.Color.White;
            this.btnOpenAddCommande.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnOpenAddCommande.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOpenAddCommande.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenAddCommande.Location = new System.Drawing.Point(95, 29);
            this.btnOpenAddCommande.Name = "btnOpenAddCommande";
            this.btnOpenAddCommande.Size = new System.Drawing.Size(173, 65);
            this.btnOpenAddCommande.TabIndex = 16;
            this.btnOpenAddCommande.Text = "Ajouter un adhérent";
            this.btnOpenAddCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenAddCommande.UseVisualStyleBackColor = false;
            this.btnOpenAddCommande.Click += new System.EventHandler(this.btnOpenAddCommande_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(845, 45);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(294, 35);
            this.textBoxSearch.TabIndex = 17;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // FormAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 573);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewAdhesion);
            this.Controls.Add(this.btnOpenAddCommande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdherent";
            this.Text = "FormAdherent";
            this.Shown += new System.EventHandler(this.FormAdherent_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdhesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdhesion;
        private FontAwesome.Sharp.IconButton btnOpenAddCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIdFidelite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateAdhesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDuree;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRabais;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}