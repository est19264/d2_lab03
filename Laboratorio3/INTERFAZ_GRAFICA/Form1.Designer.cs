
namespace INTERFAZ
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
            this.Conectar = new System.Windows.Forms.Button();
            this.Enviar = new System.Windows.Forms.Button();
            this.varcontador = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.CONTADOR = new System.Windows.Forms.Label();
            this.POTENCIOMETRO1 = new System.Windows.Forms.Label();
            this.POTENCIOMETRO2 = new System.Windows.Forms.Label();
            this.V1 = new System.Windows.Forms.Label();
            this.V2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(12, 213);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(75, 47);
            this.Conectar.TabIndex = 0;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(461, 213);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 49);
            this.Enviar.TabIndex = 1;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // varcontador
            // 
            this.varcontador.Location = new System.Drawing.Point(234, 169);
            this.varcontador.Name = "varcontador";
            this.varcontador.Size = new System.Drawing.Size(141, 20);
            this.varcontador.TabIndex = 2;
            this.varcontador.Text = "0";
            this.varcontador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(234, 88);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(160, 26);
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(234, 37);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(161, 27);
            this.progressBar2.TabIndex = 4;
            // 
            // CONTADOR
            // 
            this.CONTADOR.AutoSize = true;
            this.CONTADOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CONTADOR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CONTADOR.Location = new System.Drawing.Point(141, 176);
            this.CONTADOR.Name = "CONTADOR";
            this.CONTADOR.Size = new System.Drawing.Size(73, 15);
            this.CONTADOR.TabIndex = 6;
            this.CONTADOR.Text = "CONTADOR:";
            // 
            // POTENCIOMETRO1
            // 
            this.POTENCIOMETRO1.AutoSize = true;
            this.POTENCIOMETRO1.BackColor = System.Drawing.Color.Lime;
            this.POTENCIOMETRO1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.POTENCIOMETRO1.Location = new System.Drawing.Point(99, 37);
            this.POTENCIOMETRO1.Name = "POTENCIOMETRO1";
            this.POTENCIOMETRO1.Size = new System.Drawing.Size(115, 15);
            this.POTENCIOMETRO1.TabIndex = 7;
            this.POTENCIOMETRO1.Text = "POTENCIOMETRO 1:";
            // 
            // POTENCIOMETRO2
            // 
            this.POTENCIOMETRO2.AutoSize = true;
            this.POTENCIOMETRO2.BackColor = System.Drawing.Color.Lime;
            this.POTENCIOMETRO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.POTENCIOMETRO2.Location = new System.Drawing.Point(99, 88);
            this.POTENCIOMETRO2.Name = "POTENCIOMETRO2";
            this.POTENCIOMETRO2.Size = new System.Drawing.Size(115, 15);
            this.POTENCIOMETRO2.TabIndex = 8;
            this.POTENCIOMETRO2.Text = "POTENCIOMETRO 2:";
            // 
            // V1
            // 
            this.V1.AutoSize = true;
            this.V1.Location = new System.Drawing.Point(401, 51);
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(14, 13);
            this.V1.TabIndex = 9;
            this.V1.Text = "V";
            // 
            // V2
            // 
            this.V2.AutoSize = true;
            this.V2.Location = new System.Drawing.Point(401, 101);
            this.V2.Name = "V2";
            this.V2.Size = new System.Drawing.Size(14, 13);
            this.V2.TabIndex = 10;
            this.V2.Text = "V";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(548, 287);
            this.Controls.Add(this.V2);
            this.Controls.Add(this.V1);
            this.Controls.Add(this.POTENCIOMETRO2);
            this.Controls.Add(this.POTENCIOMETRO1);
            this.Controls.Add(this.CONTADOR);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.varcontador);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.Conectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.TextBox varcontador;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label CONTADOR;
        private System.Windows.Forms.Label POTENCIOMETRO1;
        private System.Windows.Forms.Label POTENCIOMETRO2;
        private System.Windows.Forms.Label V1;
        private System.Windows.Forms.Label V2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

