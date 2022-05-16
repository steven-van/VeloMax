﻿namespace VeloMax.ChildForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCommande = new System.Windows.Forms.DataGridView();
            this.btnOpenAddCommande = new FontAwesome.Sharp.IconButton();
            this.dataIdCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAdresseL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDateL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCommande
            // 
            this.dataGridViewCommande.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.dataGridViewCommande.AllowUserToAddRows = false;
            this.dataGridViewCommande.AllowUserToDeleteRows = false;
            this.dataGridViewCommande.AllowUserToResizeColumns = false;
            this.dataGridViewCommande.AllowUserToResizeRows = false;
            this.dataGridViewCommande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCommande.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataIdCommande,
            this.dataDateC,
            this.dataAdresseL,
            this.dateDateL,
            this.dataIdClient,
            this.btnUpdate,
            this.btnDelete});
            this.dataGridViewCommande.GridColor = System.Drawing.Color.White;
            this.dataGridViewCommande.Location = new System.Drawing.Point(105, 52);
            this.dataGridViewCommande.MultiSelect = false;
            this.dataGridViewCommande.Name = "dataGridViewCommande";
            this.dataGridViewCommande.ReadOnly = true;
            this.dataGridViewCommande.RowHeadersVisible = false;
            this.dataGridViewCommande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCommande.RowTemplate.Height = 28;
            this.dataGridViewCommande.ShowEditingIcon = false;
            this.dataGridViewCommande.Size = new System.Drawing.Size(1044, 422);
            this.dataGridViewCommande.TabIndex = 13;
            // 
            // btnOpenAddCommande
            // 
            this.btnOpenAddCommande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenAddCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(174)))), ((int)(((byte)(124)))));
            this.btnOpenAddCommande.FlatAppearance.BorderSize = 0;
            this.btnOpenAddCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAddCommande.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAddCommande.ForeColor = System.Drawing.Color.White;
            this.btnOpenAddCommande.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnOpenAddCommande.IconColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOpenAddCommande.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenAddCommande.Location = new System.Drawing.Point(976, 512);
            this.btnOpenAddCommande.Name = "btnOpenAddCommande";
            this.btnOpenAddCommande.Size = new System.Drawing.Size(173, 65);
            this.btnOpenAddCommande.TabIndex = 14;
            this.btnOpenAddCommande.Text = "Ajouter une commande";
            this.btnOpenAddCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenAddCommande.UseVisualStyleBackColor = false;
            this.btnOpenAddCommande.Click += new System.EventHandler(this.btnOpenAddCommande_Click);
            // 
            // dataIdCommande
            // 
            this.dataIdCommande.DataPropertyName = "idCommande";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdCommande.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataIdCommande.HeaderText = "idCommande";
            this.dataIdCommande.Name = "dataIdCommande";
            this.dataIdCommande.ReadOnly = true;
            this.dataIdCommande.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIdCommande.Width = 150;
            // 
            // dataDateC
            // 
            this.dataDateC.DataPropertyName = "dateC";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateC.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataDateC.HeaderText = "dateC";
            this.dataDateC.Name = "dataDateC";
            this.dataDateC.ReadOnly = true;
            this.dataDateC.Width = 150;
            // 
            // dataAdresseL
            // 
            this.dataAdresseL.DataPropertyName = "adresseL";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAdresseL.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataAdresseL.HeaderText = "adresseL";
            this.dataAdresseL.Name = "dataAdresseL";
            this.dataAdresseL.ReadOnly = true;
            this.dataAdresseL.Width = 150;
            // 
            // dateDateL
            // 
            this.dateDateL.DataPropertyName = "dateL";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateL.DefaultCellStyle = dataGridViewCellStyle18;
            this.dateDateL.HeaderText = "dateL";
            this.dateDateL.Name = "dateDateL";
            this.dateDateL.ReadOnly = true;
            this.dateDateL.Width = 150;
            // 
            // dataIdClient
            // 
            this.dataIdClient.DataPropertyName = "idClient";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIdClient.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataIdClient.HeaderText = "idClient";
            this.dataIdClient.Name = "dataIdClient";
            this.dataIdClient.ReadOnly = true;
            this.dataIdClient.Width = 150;
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
            // FormCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1255, 629);
            this.Controls.Add(this.dataGridViewCommande);
            this.Controls.Add(this.btnOpenAddCommande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCommande";
            this.Text = "FormCommande";
            this.Load += new System.EventHandler(this.FormCommande_Load);
            this.Shown += new System.EventHandler(this.FormCommande_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCommande;
        private FontAwesome.Sharp.IconButton btnOpenAddCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIdCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAdresseL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDateL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIdClient;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}