﻿namespace FrbaCrucero.AbmRecorrido
{
    partial class AltaRecorrido
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tramosTable = new System.Windows.Forms.DataGridView();
            this.ciudadOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addTramoButton = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.codigoError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tramosError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tramosTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramosError)).BeginInit();
            this.SuspendLayout();
            // 
            // tramosTable
            // 
            this.tramosTable.AllowUserToAddRows = false;
            this.tramosTable.AllowUserToDeleteRows = false;
            this.tramosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tramosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciudadOrigen,
            this.ciudadDestino,
            this.precio});
            this.tramosTable.Location = new System.Drawing.Point(107, 142);
            this.tramosTable.Margin = new System.Windows.Forms.Padding(4);
            this.tramosTable.Name = "tramosTable";
            this.tramosTable.ReadOnly = true;
            this.tramosTable.Size = new System.Drawing.Size(464, 196);
            this.tramosTable.TabIndex = 0;
            this.tramosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.tramosTable.Validating += new System.ComponentModel.CancelEventHandler(this.tramosTable_Validating);
            // 
            // ciudadOrigen
            // 
            this.ciudadOrigen.DataPropertyName = "ciudadOrigen";
            this.ciudadOrigen.HeaderText = "Ciudad origen";
            this.ciudadOrigen.Name = "ciudadOrigen";
            this.ciudadOrigen.ReadOnly = true;
            this.ciudadOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.DataPropertyName = "ciudadDestino";
            this.ciudadDestino.HeaderText = "Ciudad destino";
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.ReadOnly = true;
            this.ciudadDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(161, 34);
            this.codigo.Margin = new System.Windows.Forms.Padding(4);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(132, 22);
            this.codigo.TabIndex = 1;
            this.codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_KeyPress);
            this.codigo.Validating += new System.ComponentModel.CancelEventHandler(this.codigo_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addTramoButton
            // 
            this.addTramoButton.Location = new System.Drawing.Point(440, 34);
            this.addTramoButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTramoButton.Name = "addTramoButton";
            this.addTramoButton.Size = new System.Drawing.Size(131, 27);
            this.addTramoButton.TabIndex = 3;
            this.addTramoButton.Text = "Agregar Tramo";
            this.addTramoButton.UseVisualStyleBackColor = true;
            this.addTramoButton.Click += new System.EventHandler(this.onAgregarTramo);
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(342, 362);
            this.clean.Margin = new System.Windows.Forms.Padding(4);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(100, 28);
            this.clean.TabIndex = 4;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(471, 362);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // codigoError
            // 
            this.codigoError.ContainerControl = this;
            // 
            // tramosError
            // 
            this.tramosError.ContainerControl = this;
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(107, 359);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(97, 31);
            this.btn_atras.TabIndex = 22;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // AltaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(695, 473);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.addTramoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.tramosTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AltaRecorrido";
            this.Text = "Alta recorrido";
            ((System.ComponentModel.ISupportInitialize)(this.tramosTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramosError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tramosTable;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTramoButton;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.ErrorProvider codigoError;
        private System.Windows.Forms.ErrorProvider tramosError;
        private System.Windows.Forms.Button btn_atras;
    }
}