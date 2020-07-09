namespace Despertador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTodos = new System.Windows.Forms.CheckBox();
            this.cbLunes = new System.Windows.Forms.CheckBox();
            this.cbMartes = new System.Windows.Forms.CheckBox();
            this.cbMiercoles = new System.Windows.Forms.CheckBox();
            this.cbJueves = new System.Windows.Forms.CheckBox();
            this.cbViernes = new System.Windows.Forms.CheckBox();
            this.cbSabado = new System.Windows.Forms.CheckBox();
            this.cbDomingo = new System.Windows.Forms.CheckBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblCancion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.tbMinutos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblminutos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl1.Location = new System.Drawing.Point(276, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(430, 52);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Despertador JARVIS";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(10, 85);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(122, 52);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbTodos
            // 
            this.cbTodos.AutoSize = true;
            this.cbTodos.Location = new System.Drawing.Point(19, 170);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(70, 21);
            this.cbTodos.TabIndex = 5;
            this.cbTodos.Text = "Todos";
            this.cbTodos.UseVisualStyleBackColor = true;
            this.cbTodos.CheckedChanged += new System.EventHandler(this.cbTodos_CheckedChanged);
            // 
            // cbLunes
            // 
            this.cbLunes.AutoSize = true;
            this.cbLunes.Location = new System.Drawing.Point(19, 197);
            this.cbLunes.Name = "cbLunes";
            this.cbLunes.Size = new System.Drawing.Size(69, 21);
            this.cbLunes.TabIndex = 6;
            this.cbLunes.Text = "Lunes";
            this.cbLunes.UseVisualStyleBackColor = true;
            // 
            // cbMartes
            // 
            this.cbMartes.AutoSize = true;
            this.cbMartes.Location = new System.Drawing.Point(19, 224);
            this.cbMartes.Name = "cbMartes";
            this.cbMartes.Size = new System.Drawing.Size(73, 21);
            this.cbMartes.TabIndex = 7;
            this.cbMartes.Text = "Martes";
            this.cbMartes.UseVisualStyleBackColor = true;
            // 
            // cbMiercoles
            // 
            this.cbMiercoles.AutoSize = true;
            this.cbMiercoles.Location = new System.Drawing.Point(19, 251);
            this.cbMiercoles.Name = "cbMiercoles";
            this.cbMiercoles.Size = new System.Drawing.Size(90, 21);
            this.cbMiercoles.TabIndex = 8;
            this.cbMiercoles.Text = "Miércoles";
            this.cbMiercoles.UseVisualStyleBackColor = true;
            // 
            // cbJueves
            // 
            this.cbJueves.AutoSize = true;
            this.cbJueves.Location = new System.Drawing.Point(19, 278);
            this.cbJueves.Name = "cbJueves";
            this.cbJueves.Size = new System.Drawing.Size(75, 21);
            this.cbJueves.TabIndex = 9;
            this.cbJueves.Text = "Jueves";
            this.cbJueves.UseVisualStyleBackColor = true;
            // 
            // cbViernes
            // 
            this.cbViernes.AutoSize = true;
            this.cbViernes.Location = new System.Drawing.Point(19, 305);
            this.cbViernes.Name = "cbViernes";
            this.cbViernes.Size = new System.Drawing.Size(78, 21);
            this.cbViernes.TabIndex = 10;
            this.cbViernes.Text = "Viernes";
            this.cbViernes.UseVisualStyleBackColor = true;
            // 
            // cbSabado
            // 
            this.cbSabado.AutoSize = true;
            this.cbSabado.Location = new System.Drawing.Point(19, 332);
            this.cbSabado.Name = "cbSabado";
            this.cbSabado.Size = new System.Drawing.Size(79, 21);
            this.cbSabado.TabIndex = 11;
            this.cbSabado.Text = "Sabado";
            this.cbSabado.UseVisualStyleBackColor = true;
            // 
            // cbDomingo
            // 
            this.cbDomingo.AutoSize = true;
            this.cbDomingo.Location = new System.Drawing.Point(19, 359);
            this.cbDomingo.Name = "cbDomingo";
            this.cbDomingo.Size = new System.Drawing.Size(86, 21);
            this.cbDomingo.TabIndex = 12;
            this.cbDomingo.Text = "Domingo";
            this.cbDomingo.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(638, 91);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(290, 46);
            this.btnSeleccionar.TabIndex = 13;
            this.btnSeleccionar.Text = "Seleccionar canción";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(638, 153);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(290, 46);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancion.Location = new System.Drawing.Point(414, 421);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(336, 27);
            this.lblCancion.TabIndex = 15;
            this.lblCancion.Text = "No se ha seleccionado una pista";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbHoras
            // 
            this.tbHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoras.Location = new System.Drawing.Point(138, 99);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(94, 30);
            this.tbHoras.TabIndex = 17;
            // 
            // tbMinutos
            // 
            this.tbMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinutos.Location = new System.Drawing.Point(285, 99);
            this.tbMinutos.Name = "tbMinutos";
            this.tbMinutos.Size = new System.Drawing.Size(94, 30);
            this.tbMinutos.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(638, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 46);
            this.button1.TabIndex = 19;
            this.button1.Text = "Activar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(242, 174);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(37, 17);
            this.lblhora.TabIndex = 21;
            this.lblhora.Text = "hora";
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // lblminutos
            // 
            this.lblminutos.AutoSize = true;
            this.lblminutos.Location = new System.Drawing.Point(312, 174);
            this.lblminutos.Name = "lblminutos";
            this.lblminutos.Size = new System.Drawing.Size(30, 17);
            this.lblminutos.TabIndex = 22;
            this.lblminutos.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hora Actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = ":";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Red;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(362, 359);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(222, 29);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Alarma desactivada";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(238, 198);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(27, 17);
            this.lblDia.TabIndex = 26;
            this.lblDia.Text = "dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Día Actual:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 471);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblminutos);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMinutos);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.cbDomingo);
            this.Controls.Add(this.cbSabado);
            this.Controls.Add(this.cbViernes);
            this.Controls.Add(this.cbJueves);
            this.Controls.Add(this.cbMiercoles);
            this.Controls.Add(this.cbMartes);
            this.Controls.Add(this.cbLunes);
            this.Controls.Add(this.cbTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1035, 518);
            this.MinimumSize = new System.Drawing.Size(1035, 518);
            this.Name = "Form1";
            this.Text = "Alarma JARVIS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTodos;
        private System.Windows.Forms.CheckBox cbLunes;
        private System.Windows.Forms.CheckBox cbMartes;
        private System.Windows.Forms.CheckBox cbMiercoles;
        private System.Windows.Forms.CheckBox cbJueves;
        private System.Windows.Forms.CheckBox cbViernes;
        private System.Windows.Forms.CheckBox cbSabado;
        private System.Windows.Forms.CheckBox cbDomingo;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.TextBox tbMinutos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblminutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label label5;
    }
}

