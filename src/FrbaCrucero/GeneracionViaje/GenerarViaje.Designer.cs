namespace FrbaCrucero.GeneracionViaje
{
    partial class GenerarViaje
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
            this.label4 = new System.Windows.Forms.Label();
            this.recorridoText = new System.Windows.Forms.TextBox();
            this.cruceroText = new System.Windows.Forms.TextBox();
            this.seleccionarRecorrido = new System.Windows.Forms.Button();
            this.seleccionarCrucero = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.salidaText = new System.Windows.Forms.TextBox();
            this.llegadaText = new System.Windows.Forms.TextBox();
            this.btn_seleccionar_salida = new System.Windows.Forms.Button();
            this.btn_seleccionar_llegada = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.panel_date = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de salida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de llegada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Recorrido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Crucero";
            // 
            // recorridoText
            // 
            this.recorridoText.Location = new System.Drawing.Point(148, 131);
            this.recorridoText.Name = "recorridoText";
            this.recorridoText.ReadOnly = true;
            this.recorridoText.Size = new System.Drawing.Size(121, 20);
            this.recorridoText.TabIndex = 6;
            this.recorridoText.Validating += new System.ComponentModel.CancelEventHandler(this.field_Validating);
            // 
            // cruceroText
            // 
            this.cruceroText.Location = new System.Drawing.Point(148, 174);
            this.cruceroText.Name = "cruceroText";
            this.cruceroText.ReadOnly = true;
            this.cruceroText.Size = new System.Drawing.Size(121, 20);
            this.cruceroText.TabIndex = 7;
            this.cruceroText.Validating += new System.ComponentModel.CancelEventHandler(this.field_Validating);
            // 
            // seleccionarRecorrido
            // 
            this.seleccionarRecorrido.Location = new System.Drawing.Point(286, 129);
            this.seleccionarRecorrido.Name = "seleccionarRecorrido";
            this.seleccionarRecorrido.Size = new System.Drawing.Size(75, 23);
            this.seleccionarRecorrido.TabIndex = 8;
            this.seleccionarRecorrido.Text = "Seleccionar";
            this.seleccionarRecorrido.UseVisualStyleBackColor = true;
            this.seleccionarRecorrido.Click += new System.EventHandler(this.seleccionarRecorrido_Click);
            // 
            // seleccionarCrucero
            // 
            this.seleccionarCrucero.Location = new System.Drawing.Point(286, 172);
            this.seleccionarCrucero.Name = "seleccionarCrucero";
            this.seleccionarCrucero.Size = new System.Drawing.Size(75, 23);
            this.seleccionarCrucero.TabIndex = 9;
            this.seleccionarCrucero.Text = "Seleccionar";
            this.seleccionarCrucero.UseVisualStyleBackColor = true;
            this.seleccionarCrucero.Click += new System.EventHandler(this.seleccionarCrucero_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(385, 290);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 10;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // salidaText
            // 
            this.salidaText.Location = new System.Drawing.Point(148, 33);
            this.salidaText.Name = "salidaText";
            this.salidaText.ReadOnly = true;
            this.salidaText.Size = new System.Drawing.Size(121, 20);
            this.salidaText.TabIndex = 12;
            this.salidaText.Validating += new System.ComponentModel.CancelEventHandler(this.field_Validating);
            // 
            // llegadaText
            // 
            this.llegadaText.Location = new System.Drawing.Point(148, 81);
            this.llegadaText.Name = "llegadaText";
            this.llegadaText.ReadOnly = true;
            this.llegadaText.Size = new System.Drawing.Size(121, 20);
            this.llegadaText.TabIndex = 13;
            this.llegadaText.Validating += new System.ComponentModel.CancelEventHandler(this.field_Validating);
            // 
            // btn_seleccionar_salida
            // 
            this.btn_seleccionar_salida.Location = new System.Drawing.Point(286, 33);
            this.btn_seleccionar_salida.Name = "btn_seleccionar_salida";
            this.btn_seleccionar_salida.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar_salida.TabIndex = 14;
            this.btn_seleccionar_salida.Text = "Seleccionar";
            this.btn_seleccionar_salida.UseVisualStyleBackColor = true;
            this.btn_seleccionar_salida.Click += new System.EventHandler(this.btn_seleccionar_salida_Click);
            // 
            // btn_seleccionar_llegada
            // 
            this.btn_seleccionar_llegada.Location = new System.Drawing.Point(286, 79);
            this.btn_seleccionar_llegada.Name = "btn_seleccionar_llegada";
            this.btn_seleccionar_llegada.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar_llegada.TabIndex = 15;
            this.btn_seleccionar_llegada.Text = "Seleccionar";
            this.btn_seleccionar_llegada.UseVisualStyleBackColor = true;
            this.btn_seleccionar_llegada.Click += new System.EventHandler(this.btn_seleccionar_llegada_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 16;
            // 
            // panel_date
            // 
            this.panel_date.Controls.Add(this.btn_cancelar);
            this.panel_date.Controls.Add(this.btn_aceptar);
            this.panel_date.Controls.Add(this.label5);
            this.panel_date.Controls.Add(this.dateTimePicker);
            this.panel_date.Controls.Add(this.monthCalendar);
            this.panel_date.Location = new System.Drawing.Point(385, 33);
            this.panel_date.Name = "panel_date";
            this.panel_date.Size = new System.Drawing.Size(193, 238);
            this.panel_date.TabIndex = 17;
            this.panel_date.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(3, 212);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(115, 212);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 19;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hora";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(74, 174);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(72, 20);
            this.dateTimePicker.TabIndex = 17;
            this.dateTimePicker.Value = new System.DateTime(2019, 6, 9, 0, 0, 0, 0);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // GenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(624, 344);
            this.Controls.Add(this.panel_date);
            this.Controls.Add(this.btn_seleccionar_llegada);
            this.Controls.Add(this.btn_seleccionar_salida);
            this.Controls.Add(this.llegadaText);
            this.Controls.Add(this.salidaText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.seleccionarCrucero);
            this.Controls.Add(this.seleccionarRecorrido);
            this.Controls.Add(this.cruceroText);
            this.Controls.Add(this.recorridoText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenerarViaje";
            this.Text = "GenerarViaje";
            this.panel_date.ResumeLayout(false);
            this.panel_date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recorridoText;
        private System.Windows.Forms.TextBox cruceroText;
        private System.Windows.Forms.Button seleccionarRecorrido;
        private System.Windows.Forms.Button seleccionarCrucero;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox salidaText;
        private System.Windows.Forms.TextBox llegadaText;
        private System.Windows.Forms.Button btn_seleccionar_salida;
        private System.Windows.Forms.Button btn_seleccionar_llegada;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Panel panel_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}