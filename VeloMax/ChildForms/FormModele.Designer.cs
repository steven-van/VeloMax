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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewModele = new System.Windows.Forms.DataGridView();
            this.dataIdModele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrandeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrixU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLigneP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnOpenAddModele = new FontAwesome.Sharp.IconButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModele)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewModele
            // 
            this.dataGridViewModele.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.dataGridViewModele.AllowUserToAddRows = false;
            this.dataGridViewModele.AllowUserToDeleteRows = false;
            this.dataGridViewModele.AllowUserToResizeColumns = false;
            this.dataGridViewModele.AllowUserToResizeRows = false;
            this.dataGridViewModele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewModele.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewModele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewModele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataIdModele,
            this.dataNom,
            this.dataGrandeur,
            this.dataPrixU,
            this.dataLigneP,
            this.dataDateI,
            this.dataDateD,
            this.btnUpdate,
            this.btnDelete});
            this.dataGridViewModele.GridColor = System.Drawing.Color.White;
            this.dataGridViewModele.Location = new System.Drawing.Point(105, 140);
            this.dataGridViewModele.MultiSelect = false;
            this.dataGridViewModele.Name = "dataGridViewModele";
            this.dataGridViewModele.ReadOnly = true;
            this.dataGridViewModele.RowHeadersVisible = false;
            this.dataGridViewModele.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewModele.RowTemplate.Height = 28;
            this.dataGridViewModele.ShowEditingIcon = false;
            this.dataGridViewModele.Size = new System.Drawing.Size(1044, 422);
            this.dataGridViewModele.TabIndex = 13;
            this.dataGridViewModele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModele_CellClick);
            // 
            // dataIdModele
            // 
            this.dataIdModele.DataPropertyName = "idModele";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdModele.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataIdModele.HeaderText = "idModele";
            this.dataIdModele.Name = "dataIdModele";
            this.dataIdModele.ReadOnly = true;
            this.dataIdModele.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIdModele.Width = 150;
            // 
            // dataNom
            // 
            this.dataNom.DataPropertyName = "nom";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNom.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataNom.HeaderText = "nom";
            this.dataNom.Name = "dataNom";
            this.dataNom.ReadOnly = true;
            this.dataNom.Width = 150;
            // 
            // dataGrandeur
            // 
            this.dataGrandeur.DataPropertyName = "grandeur";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrandeur.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGrandeur.HeaderText = "grandeur";
            this.dataGrandeur.Name = "dataGrandeur";
            this.dataGrandeur.ReadOnly = true;
            this.dataGrandeur.Width = 150;
            // 
            // dataPrixU
            // 
            this.dataPrixU.DataPropertyName = "prixU";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPrixU.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataPrixU.HeaderText = "prixU";
            this.dataPrixU.Name = "dataPrixU";
            this.dataPrixU.ReadOnly = true;
            this.dataPrixU.Width = 150;
            // 
            // dataLigneP
            // 
            this.dataLigneP.DataPropertyName = "ligneP";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLigneP.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataLigneP.HeaderText = "ligneP";
            this.dataLigneP.Name = "dataLigneP";
            this.dataLigneP.ReadOnly = true;
            this.dataLigneP.Width = 150;
            // 
            // dataDateI
            // 
            this.dataDateI.DataPropertyName = "dateI";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateI.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataDateI.HeaderText = "dateI";
            this.dataDateI.Name = "dataDateI";
            this.dataDateI.ReadOnly = true;
            // 
            // dataDateD
            // 
            this.dataDateD.DataPropertyName = "dateD";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateD.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataDateD.HeaderText = "dateD";
            this.dataDateD.Name = "dataDateD";
            this.dataDateD.ReadOnly = true;
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle17;
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle18;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 150;
            // 
            // btnOpenAddModele
            // 
            this.btnOpenAddModele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenAddModele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnOpenAddModele.FlatAppearance.BorderSize = 0;
            this.btnOpenAddModele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAddModele.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAddModele.ForeColor = System.Drawing.Color.White;
            this.btnOpenAddModele.IconChar = FontAwesome.Sharp.IconChar.Bicycle;
            this.btnOpenAddModele.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOpenAddModele.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenAddModele.Location = new System.Drawing.Point(105, 43);
            this.btnOpenAddModele.Name = "btnOpenAddModele";
            this.btnOpenAddModele.Size = new System.Drawing.Size(173, 65);
            this.btnOpenAddModele.TabIndex = 14;
            this.btnOpenAddModele.Text = "Ajouter un modèle";
            this.btnOpenAddModele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenAddModele.UseVisualStyleBackColor = false;
            this.btnOpenAddModele.Click += new System.EventHandler(this.btnOpenAddModele_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(855, 73);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(294, 35);
            this.textBoxSearch.TabIndex = 18;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // FormModele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1255, 629);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewModele);
            this.Controls.Add(this.btnOpenAddModele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModele";
            this.Text = "FormModele";
            this.Shown += new System.EventHandler(this.FormModele_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewModele;
        private FontAwesome.Sharp.IconButton btnOpenAddModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIdModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrandeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrixU;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLigneP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateD;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}