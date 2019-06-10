namespace FrbaCrucero.AbmCrucero
{
    partial class FormPantallaInicio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_modificacion = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_modificacion);
            this.groupBox1.Controls.Add(this.btn_baja);
            this.groupBox1.Controls.Add(this.btn_alta);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(229, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cruceros";
            // 
            // btn_modificacion
            // 
            this.btn_modificacion.Location = new System.Drawing.Point(58, 144);
            this.btn_modificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_modificacion.Name = "btn_modificacion";
            this.btn_modificacion.Size = new System.Drawing.Size(113, 37);
            this.btn_modificacion.TabIndex = 2;
            this.btn_modificacion.Text = "MODIFICACION";
            this.btn_modificacion.UseVisualStyleBackColor = true;
            this.btn_modificacion.Click += new System.EventHandler(this.btn_modificacion_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(58, 79);
            this.btn_baja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(113, 37);
            this.btn_baja.TabIndex = 1;
            this.btn_baja.Text = "BAJA";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(58, 17);
            this.btn_alta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(113, 37);
            this.btn_alta.TabIndex = 0;
            this.btn_alta.Text = "ALTA";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // FormPantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 206);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPantallaInicio";
            this.Text = "Pantalla Inicio";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_modificacion;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_alta;
    }
}