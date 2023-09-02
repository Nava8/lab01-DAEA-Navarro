namespace caso1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.N1 = new System.Windows.Forms.TextBox();
            this.N2 = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.TextBox();
            this.Convertir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Primos = new System.Windows.Forms.TextBox();
            this.ImprimirNP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPERACIONES BASICAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESAR EL PRIMER NUMERO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESAR EL SEGUNGO NUMERO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RESULTADO:";
            // 
            // N1
            // 
            this.N1.Location = new System.Drawing.Point(298, 95);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(264, 20);
            this.N1.TabIndex = 4;
            this.N1.TextChanged += new System.EventHandler(this.N1_TextChanged);
            // 
            // N2
            // 
            this.N2.Location = new System.Drawing.Point(298, 208);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(264, 20);
            this.N2.TabIndex = 5;
            this.N2.TextChanged += new System.EventHandler(this.N2_TextChanged);
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(298, 311);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(264, 20);
            this.R.TabIndex = 6;
            this.R.TextChanged += new System.EventHandler(this.R_TextChanged);
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(718, 91);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 7;
            this.Suma.Text = "SUMA";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(718, 145);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(75, 23);
            this.Resta.TabIndex = 8;
            this.Resta.Text = "RESTA";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.Location = new System.Drawing.Point(718, 201);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(121, 23);
            this.Multiplicacion.TabIndex = 9;
            this.Multiplicacion.Text = "MULTIPLICACION";
            this.Multiplicacion.UseVisualStyleBackColor = true;
            this.Multiplicacion.Click += new System.EventHandler(this.Multiplicacion_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(718, 250);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 10;
            this.Division.Text = "DIVISION";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(718, 382);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 11;
            this.Limpiar.Text = "LIMPIAR";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(718, 426);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 12;
            this.Salir.Text = "SALIR";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CELSIUS:";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(298, 366);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(264, 20);
            this.C.TabIndex = 16;
            this.C.TextChanged += new System.EventHandler(this.C_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "FARENHEIT:";
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(298, 411);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(264, 20);
            this.F.TabIndex = 18;
            this.F.TextChanged += new System.EventHandler(this.F_TextChanged);
            // 
            // Convertir
            // 
            this.Convertir.Location = new System.Drawing.Point(718, 292);
            this.Convertir.Name = "Convertir";
            this.Convertir.Size = new System.Drawing.Size(146, 23);
            this.Convertir.TabIndex = 19;
            this.Convertir.Text = "Convertir a C y F";
            this.Convertir.UseVisualStyleBackColor = true;
            this.Convertir.Click += new System.EventHandler(this.Convertir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "PRIMOS:";
            // 
            // Primos
            // 
            this.Primos.Location = new System.Drawing.Point(298, 473);
            this.Primos.Name = "Primos";
            this.Primos.Size = new System.Drawing.Size(264, 20);
            this.Primos.TabIndex = 21;
            this.Primos.TextChanged += new System.EventHandler(this.Primos_TextChanged);
            // 
            // ImprimirNP
            // 
            this.ImprimirNP.Location = new System.Drawing.Point(718, 334);
            this.ImprimirNP.Name = "ImprimirNP";
            this.ImprimirNP.Size = new System.Drawing.Size(146, 23);
            this.ImprimirNP.TabIndex = 22;
            this.ImprimirNP.Text = "NUMEROS PRIMOS";
            this.ImprimirNP.UseVisualStyleBackColor = true;
            this.ImprimirNP.Click += new System.EventHandler(this.ImprimirNP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 584);
            this.Controls.Add(this.ImprimirNP);
            this.Controls.Add(this.Primos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Convertir);
            this.Controls.Add(this.F);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.C);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.R);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox N1;
        private System.Windows.Forms.TextBox N2;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox F;
        private System.Windows.Forms.Button Convertir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Primos;
        private System.Windows.Forms.Button ImprimirNP;
    }
}

