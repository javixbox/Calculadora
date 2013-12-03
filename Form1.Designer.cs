namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultado = new System.Windows.Forms.TextBox();
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.bSigno = new System.Windows.Forms.Button();
            this.bIgual = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bDividir = new System.Windows.Forms.Button();
            this.bMultiplicar = new System.Windows.Forms.Button();
            this.bRestar = new System.Windows.Forms.Button();
            this.bSumar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(12, 12);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(226, 20);
            this.resultado.TabIndex = 0;
            this.resultado.Text = "0";
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(12, 221);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(42, 33);
            this.b0.TabIndex = 1;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 182);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(42, 33);
            this.b1.TabIndex = 2;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 143);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(42, 33);
            this.b4.TabIndex = 3;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 104);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(42, 33);
            this.b7.TabIndex = 4;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(60, 104);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(42, 33);
            this.b8.TabIndex = 5;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(60, 143);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(42, 33);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(60, 182);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(42, 33);
            this.b2.TabIndex = 7;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // bSigno
            // 
            this.bSigno.Location = new System.Drawing.Point(60, 221);
            this.bSigno.Name = "bSigno";
            this.bSigno.Size = new System.Drawing.Size(42, 33);
            this.bSigno.TabIndex = 8;
            this.bSigno.Text = "+/-";
            this.bSigno.UseVisualStyleBackColor = true;
            this.bSigno.Click += new System.EventHandler(this.bSigno_Click);
            // 
            // bIgual
            // 
            this.bIgual.Location = new System.Drawing.Point(108, 221);
            this.bIgual.Name = "bIgual";
            this.bIgual.Size = new System.Drawing.Size(42, 33);
            this.bIgual.TabIndex = 9;
            this.bIgual.Text = "=";
            this.bIgual.UseVisualStyleBackColor = true;
            this.bIgual.Click += new System.EventHandler(this.bIgual_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(108, 182);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(42, 33);
            this.b3.TabIndex = 10;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(108, 143);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(42, 33);
            this.b6.TabIndex = 11;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(108, 104);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(42, 33);
            this.b9.TabIndex = 12;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bDividir
            // 
            this.bDividir.Location = new System.Drawing.Point(196, 221);
            this.bDividir.Name = "bDividir";
            this.bDividir.Size = new System.Drawing.Size(42, 33);
            this.bDividir.TabIndex = 13;
            this.bDividir.Text = "/";
            this.bDividir.UseVisualStyleBackColor = true;
            this.bDividir.Click += new System.EventHandler(this.bDividir_Click);
            // 
            // bMultiplicar
            // 
            this.bMultiplicar.Location = new System.Drawing.Point(196, 182);
            this.bMultiplicar.Name = "bMultiplicar";
            this.bMultiplicar.Size = new System.Drawing.Size(42, 33);
            this.bMultiplicar.TabIndex = 14;
            this.bMultiplicar.Text = "*";
            this.bMultiplicar.UseVisualStyleBackColor = true;
            this.bMultiplicar.Click += new System.EventHandler(this.bMultiplicar_Click);
            // 
            // bRestar
            // 
            this.bRestar.Location = new System.Drawing.Point(196, 143);
            this.bRestar.Name = "bRestar";
            this.bRestar.Size = new System.Drawing.Size(42, 33);
            this.bRestar.TabIndex = 15;
            this.bRestar.Text = "-";
            this.bRestar.UseVisualStyleBackColor = true;
            this.bRestar.Click += new System.EventHandler(this.bRestar_Click);
            // 
            // bSumar
            // 
            this.bSumar.Location = new System.Drawing.Point(196, 104);
            this.bSumar.Name = "bSumar";
            this.bSumar.Size = new System.Drawing.Size(42, 33);
            this.bSumar.TabIndex = 16;
            this.bSumar.Text = "+";
            this.bSumar.UseVisualStyleBackColor = true;
            this.bSumar.Click += new System.EventHandler(this.bSumar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(12, 65);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 17;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(163, 65);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 18;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 266);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bSumar);
            this.Controls.Add(this.bRestar);
            this.Controls.Add(this.bMultiplicar);
            this.Controls.Add(this.bDividir);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.bIgual);
            this.Controls.Add(this.bSigno);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.resultado);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button bSigno;
        private System.Windows.Forms.Button bIgual;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bDividir;
        private System.Windows.Forms.Button bMultiplicar;
        private System.Windows.Forms.Button bRestar;
        private System.Windows.Forms.Button bSumar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bBorrar;

    }
}

