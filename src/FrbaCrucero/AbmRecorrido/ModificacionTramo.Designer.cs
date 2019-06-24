namespace FrbaCrucero.AbmRecorrido
{
    partial class ModificacionTramo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.destinoCombo = new System.Windows.Forms.ComboBox();
            this.origenCombo = new System.Windows.Forms.ComboBox();
            this.precioText = new System.Windows.Forms.TextBox();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // destinoCombo
            // 
            this.destinoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinoCombo.FormattingEnabled = true;
            this.destinoCombo.Location = new System.Drawing.Point(201, 118);
            this.destinoCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.destinoCombo.Name = "destinoCombo";
            this.destinoCombo.Size = new System.Drawing.Size(160, 24);
            this.destinoCombo.TabIndex = 3;
            this.destinoCombo.Validating += new System.ComponentModel.CancelEventHandler(this.destinoCombo_Validating);
            // 
            // origenCombo
            // 
            this.origenCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origenCombo.FormattingEnabled = true;
            this.origenCombo.Location = new System.Drawing.Point(201, 58);
            this.origenCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.origenCombo.Name = "origenCombo";
            this.origenCombo.Size = new System.Drawing.Size(160, 24);
            this.origenCombo.TabIndex = 4;
            this.origenCombo.Validating += new System.ComponentModel.CancelEventHandler(this.origenCombo_Validating);
            // 
            // precioText
            // 
            this.precioText.Location = new System.Drawing.Point(201, 188);
            this.precioText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.precioText.Name = "precioText";
            this.precioText.Size = new System.Drawing.Size(132, 22);
            this.precioText.TabIndex = 5;
            this.precioText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioText_KeyPress);
            this.precioText.Validating += new System.ComponentModel.CancelEventHandler(this.precioText_Validating);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(56, 257);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(100, 28);
            this.cancelarButton.TabIndex = 6;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(261, 257);
            this.guardarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(100, 28);
            this.guardarButton.TabIndex = 7;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ModificacionTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.precioText);
            this.Controls.Add(this.origenCombo);
            this.Controls.Add(this.destinoCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificacionTramo";
            this.Text = "ModificarTramo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox destinoCombo;
        private System.Windows.Forms.ComboBox origenCombo;
        private System.Windows.Forms.TextBox precioText;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}