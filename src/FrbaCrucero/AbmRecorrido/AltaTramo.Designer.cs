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
            this.components = new System.ComponentModel.Container();
            this.origenComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destinoComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.precioField = new System.Windows.Forms.TextBox();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // origenComboBox
            // 
            this.origenComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.origenComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.origenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origenComboBox.FormattingEnabled = true;
            this.origenComboBox.Location = new System.Drawing.Point(171, 39);
            this.origenComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.origenComboBox.Name = "origenComboBox";
            this.origenComboBox.Size = new System.Drawing.Size(160, 24);
            this.origenComboBox.TabIndex = 0;
            this.origenComboBox.SelectedIndexChanged += new System.EventHandler(this.fromComboBox_SelectedIndexChanged);
            this.origenComboBox.TextUpdate += new System.EventHandler(this.origen_TextUpdate);
            this.origenComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.origenComboBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudad origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudad destino";
            // 
            // destinoComboBox
            // 
            this.destinoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.destinoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.destinoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinoComboBox.FormattingEnabled = true;
            this.destinoComboBox.Location = new System.Drawing.Point(171, 89);
            this.destinoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.destinoComboBox.Name = "destinoComboBox";
            this.destinoComboBox.Size = new System.Drawing.Size(160, 24);
            this.destinoComboBox.TabIndex = 3;
            this.destinoComboBox.SelectedIndexChanged += new System.EventHandler(this.destinoComboBox_SelectedIndexChanged);
            this.destinoComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.destinoComboBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // precioField
            // 
            this.precioField.Location = new System.Drawing.Point(171, 143);
            this.precioField.Margin = new System.Windows.Forms.Padding(4);
            this.precioField.Name = "precioField";
            this.precioField.Size = new System.Drawing.Size(160, 22);
            this.precioField.TabIndex = 5;
            this.precioField.TextChanged += new System.EventHandler(this.precioField_TextChanged);
            this.precioField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioField_KeyPress);
            this.precioField.Validating += new System.ComponentModel.CancelEventHandler(this.precioField_Validating);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(34, 209);
            this.limpiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(100, 28);
            this.limpiarButton.TabIndex = 6;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(231, 209);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 28);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.onGuardar);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(34, 302);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(97, 31);
            this.btn_atras.TabIndex = 22;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // AltaTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(392, 383);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.precioField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinoComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.origenComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AltaTramo";
            this.Text = "Tramo";
            this.Load += new System.EventHandler(this.label1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btn_atras;
    }
}