namespace VeloMax.ChildForms
{
    partial class FormClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.btnOpenAddClient = new FontAwesome.Sharp.IconButton();
            this.dataIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCourriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.AllowUserToResizeColumns = false;
            this.dataGridViewClient.AllowUserToResizeRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataIdClient,
            this.dataType,
            this.dataAdresse,
            this.dataCourriel,
            this.dataTel,
            this.btnUpdate,
            this.btnDelete});
            this.dataGridViewClient.GridColor = System.Drawing.Color.White;
            this.dataGridViewClient.Location = new System.Drawing.Point(105, 52);
            this.dataGridViewClient.MultiSelect = false;
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowHeadersVisible = false;
            this.dataGridViewClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewClient.RowTemplate.Height = 28;
            this.dataGridViewClient.ShowEditingIcon = false;
            this.dataGridViewClient.Size = new System.Drawing.Size(1044, 422);
            this.dataGridViewClient.TabIndex = 13;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            // 
            // btnOpenAddClient
            // 
            this.btnOpenAddClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnOpenAddClient.FlatAppearance.BorderSize = 0;
            this.btnOpenAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAddClient.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAddClient.ForeColor = System.Drawing.Color.White;
            this.btnOpenAddClient.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnOpenAddClient.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOpenAddClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenAddClient.Location = new System.Drawing.Point(976, 512);
            this.btnOpenAddClient.Name = "btnOpenAddClient";
            this.btnOpenAddClient.Size = new System.Drawing.Size(173, 65);
            this.btnOpenAddClient.TabIndex = 14;
            this.btnOpenAddClient.Text = "Ajouter un client";
            this.btnOpenAddClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenAddClient.UseVisualStyleBackColor = false;
            this.btnOpenAddClient.Click += new System.EventHandler(this.btnOpenAddClient_Click);
            // 
            // dataIdClient
            // 
            this.dataIdClient.DataPropertyName = "idClient";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdClient.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataIdClient.HeaderText = "idClient";
            this.dataIdClient.Name = "dataIdClient";
            this.dataIdClient.ReadOnly = true;
            this.dataIdClient.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIdClient.Width = 150;
            // 
            // dataType
            // 
            this.dataType.DataPropertyName = "type";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataType.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataType.HeaderText = "type";
            this.dataType.Name = "dataType";
            this.dataType.ReadOnly = true;
            this.dataType.Width = 150;
            // 
            // dataAdresse
            // 
            this.dataAdresse.DataPropertyName = "adresse";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAdresse.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataAdresse.HeaderText = "adresse";
            this.dataAdresse.Name = "dataAdresse";
            this.dataAdresse.ReadOnly = true;
            this.dataAdresse.Width = 150;
            // 
            // dataCourriel
            // 
            this.dataCourriel.DataPropertyName = "courriel";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCourriel.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataCourriel.HeaderText = "courriel";
            this.dataCourriel.Name = "dataCourriel";
            this.dataCourriel.ReadOnly = true;
            this.dataCourriel.Width = 150;
            // 
            // dataTel
            // 
            this.dataTel.DataPropertyName = "telephone";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTel.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataTel.HeaderText = "telephone";
            this.dataTel.Name = "dataTel";
            this.dataTel.ReadOnly = true;
            this.dataTel.Width = 150;
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle20;
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle21;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 150;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1255, 629);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.btnOpenAddClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Shown += new System.EventHandler(this.FormClient_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClient;
        private FontAwesome.Sharp.IconButton btnOpenAddClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCourriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTel;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}