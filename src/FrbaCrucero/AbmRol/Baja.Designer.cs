﻿namespace FrbaCrucero.AbmRol
{
    partial class Baja
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnRol_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRol_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFunction = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnActive = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnSelection = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Rol:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnRol_Id,
            this.columnRol_Name,
            this.columnFunction,
            this.columnActive,
            this.columnSelection});
            this.dataGridView1.Location = new System.Drawing.Point(26, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 176);
            this.dataGridView1.TabIndex = 4;
            // 
            // columnRol_Id
            // 
            this.columnRol_Id.HeaderText = "Rol ID";
            this.columnRol_Id.Name = "columnRol_Id";
            this.columnRol_Id.ReadOnly = true;
            // 
            // columnRol_Name
            // 
            this.columnRol_Name.HeaderText = "Nombre del Rol";
            this.columnRol_Name.Name = "columnRol_Name";
            this.columnRol_Name.ReadOnly = true;
            // 
            // columnFunction
            // 
            this.columnFunction.HeaderText = "Funcionalidades";
            this.columnFunction.Name = "columnFunction";
            this.columnFunction.ReadOnly = true;
            // 
            // columnActive
            // 
            this.columnActive.HeaderText = "Esta Activo";
            this.columnActive.Name = "columnActive";
            this.columnActive.ReadOnly = true;
            // 
            // columnSelection
            // 
            this.columnSelection.HeaderText = "Seleccionar";
            this.columnSelection.Name = "columnSelection";
            this.columnSelection.ReadOnly = true;
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 331);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Baja";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRol_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRol_Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnFunction;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnActive;
        private System.Windows.Forms.DataGridViewButtonColumn columnSelection;

    }
}