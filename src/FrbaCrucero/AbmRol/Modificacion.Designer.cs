namespace FrbaCrucero.AbmRol
{
    partial class Modificacion
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
            this.modificacionTable = new System.Windows.Forms.DataGridView();
            this.columnRol_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRol_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSelection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Rol_activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Rol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Activo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFuncionalidades = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.modificacionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // modificacionTable
            // 
            this.modificacionTable.AllowUserToAddRows = false;
            this.modificacionTable.AllowUserToDeleteRows = false;
            this.modificacionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modificacionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnRol_Id,
            this.columnRol_Name,
            this.columnSelection,
            this.Rol_activo});
            this.modificacionTable.Location = new System.Drawing.Point(37, 120);
            this.modificacionTable.Name = "modificacionTable";
            this.modificacionTable.Size = new System.Drawing.Size(555, 176);
            this.modificacionTable.TabIndex = 9;
            this.modificacionTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // columnRol_Id
            // 
            this.columnRol_Id.DataPropertyName = "rol_id";
            this.columnRol_Id.HeaderText = "Rol ID";
            this.columnRol_Id.Name = "columnRol_Id";
            this.columnRol_Id.ReadOnly = true;
            // 
            // columnRol_Name
            // 
            this.columnRol_Name.DataPropertyName = "rol_nombre";
            this.columnRol_Name.HeaderText = "Nombre del Rol";
            this.columnRol_Name.Name = "columnRol_Name";
            this.columnRol_Name.ReadOnly = true;
            // 
            // columnSelection
            // 
            this.columnSelection.HeaderText = "Seleccionar";
            this.columnSelection.Name = "columnSelection";
            this.columnSelection.ReadOnly = true;
            // 
            // Rol_activo
            // 
            this.Rol_activo.DataPropertyName = "rol_activo";
            this.Rol_activo.HeaderText = "Rol_activo";
            this.Rol_activo.Name = "Rol_activo";
            this.Rol_activo.ReadOnly = true;
            this.Rol_activo.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rol
            // 
            this.Rol.Location = new System.Drawing.Point(202, 39);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(100, 20);
            this.Rol.TabIndex = 6;
            this.Rol.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Rol:";
            // 
            // Activo
            // 
            this.Activo.AutoSize = true;
            this.Activo.Location = new System.Drawing.Point(350, 42);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(56, 17);
            this.Activo.TabIndex = 10;
            this.Activo.Text = "Activo";
            this.Activo.UseVisualStyleBackColor = true;
            this.Activo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del Funcionalidad:";
            // 
            // comboBoxFuncionalidades
            // 
            this.comboBoxFuncionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncionalidades.FormattingEnabled = true;
            this.comboBoxFuncionalidades.Location = new System.Drawing.Point(668, 42);
            this.comboBoxFuncionalidades.Name = "comboBoxFuncionalidades";
            this.comboBoxFuncionalidades.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFuncionalidades.TabIndex = 13;
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 338);
            this.Controls.Add(this.comboBoxFuncionalidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Activo);
            this.Controls.Add(this.modificacionTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.label1);
            this.Name = "Modificacion";
            this.Text = "Modificacion";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modificacionTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView modificacionTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Rol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRol_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRol_Name;
        private System.Windows.Forms.DataGridViewButtonColumn columnSelection;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rol_activo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFuncionalidades;
    }
}