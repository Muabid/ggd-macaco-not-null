namespace FrbaCrucero.AbmRecorrido
{
    partial class AltaTramo
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
            this.origenComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destinoComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.precioField = new System.Windows.Forms.TextBox();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // origenComboBox
            // 
            this.origenComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.origenComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.origenComboBox.FormattingEnabled = true;
            this.origenComboBox.Location = new System.Drawing.Point(128, 32);
            this.origenComboBox.Name = "origenComboBox";
            this.origenComboBox.Size = new System.Drawing.Size(121, 21);
            this.origenComboBox.TabIndex = 0;
            this.origenComboBox.SelectedIndexChanged += new System.EventHandler(this.fromComboBox_SelectedIndexChanged);
            this.origenComboBox.TextUpdate += new System.EventHandler(this.origen_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudad origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudad destino";
            // 
            // destinoComboBox
            // 
            this.destinoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.destinoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.destinoComboBox.FormattingEnabled = true;
            this.destinoComboBox.Location = new System.Drawing.Point(128, 72);
            this.destinoComboBox.Name = "destinoComboBox";
            this.destinoComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinoComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // precioField
            // 
            this.precioField.Location = new System.Drawing.Point(128, 116);
            this.precioField.Name = "precioField";
            this.precioField.Size = new System.Drawing.Size(121, 20);
            this.precioField.TabIndex = 5;
            this.precioField.TextChanged += new System.EventHandler(this.precioField_TextChanged);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(26, 175);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 6;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onGuardar);
            // 
            // AltaTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.precioField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinoComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.origenComboBox);
            this.Name = "AltaTramo";
            this.Text = "Tramo";
            this.Load += new System.EventHandler(this.label1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox origenComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox destinoComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox precioField;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button button2;
    }
}