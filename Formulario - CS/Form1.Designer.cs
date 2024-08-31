
namespace Formulario___CS
{
    partial class Ventana
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.lbGenero = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.brnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(29, 46);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            this.lbNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(82, 45);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(41, 100);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(35, 13);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = "Edad:";
            this.lbEdad.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(21, 72);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(55, 13);
            this.lbApellidos.TabIndex = 3;
            this.lbApellidos.Text = "Apellidos: ";
            this.lbApellidos.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(82, 69);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 4;
            this.tbApellidos.TextChanged += new System.EventHandler(this.tbApellidos_TextChanged);
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(82, 95);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(100, 20);
            this.tbEdad.TabIndex = 5;
            this.tbEdad.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(26, 126);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(50, 13);
            this.lbNum.TabIndex = 6;
            this.lbNum.Text = "Numero: ";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(82, 123);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 20);
            this.tbNum.TabIndex = 7;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(101, 162);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 8;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            this.rbHombre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(101, 185);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 9;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(101, 208);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(45, 17);
            this.rbOtro.TabIndex = 10;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(108, 146);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(48, 13);
            this.lbGenero.TabIndex = 11;
            this.lbGenero.Text = "Genero: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(29, 231);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // brnLimpiar
            // 
            this.brnLimpiar.Location = new System.Drawing.Point(139, 231);
            this.brnLimpiar.Name = "brnLimpiar";
            this.brnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.brnLimpiar.TabIndex = 13;
            this.brnLimpiar.Text = "Limpiar";
            this.brnLimpiar.UseVisualStyleBackColor = true;
            this.brnLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese datos:";
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.rbOtro);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Name = "Ventana";
            this.Text = "Formulario - CS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button brnLimpiar;
        private System.Windows.Forms.Label label1;
    }
}

