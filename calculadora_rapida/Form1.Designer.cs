namespace calculadora_rapida
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Tx_Suma = new TextBox();
            Tx_Resta = new TextBox();
            Tx_Multiplicacion = new TextBox();
            Tx_Division = new TextBox();
            Tx_Valor1 = new TextBox();
            Tx_Valor2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Calcular = new Button();
            Close = new Button();
            Limpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 36);
            label1.Name = "label1";
            label1.Size = new Size(197, 24);
            label1.TabIndex = 0;
            label1.Text = "Calculadora Rapida";
            label1.Click += label1_Click;
            // 
            // Tx_Suma
            // 
            Tx_Suma.Location = new Point(182, 116);
            Tx_Suma.Name = "Tx_Suma";
            Tx_Suma.Size = new Size(100, 23);
            Tx_Suma.TabIndex = 1;
            // 
            // Tx_Resta
            // 
            Tx_Resta.Location = new Point(182, 188);
            Tx_Resta.Name = "Tx_Resta";
            Tx_Resta.Size = new Size(100, 23);
            Tx_Resta.TabIndex = 2;
            // 
            // Tx_Multiplicacion
            // 
            Tx_Multiplicacion.Location = new Point(182, 256);
            Tx_Multiplicacion.Name = "Tx_Multiplicacion";
            Tx_Multiplicacion.Size = new Size(100, 23);
            Tx_Multiplicacion.TabIndex = 3;
            // 
            // Tx_Division
            // 
            Tx_Division.Location = new Point(182, 326);
            Tx_Division.Name = "Tx_Division";
            Tx_Division.Size = new Size(100, 23);
            Tx_Division.TabIndex = 4;
            // 
            // Tx_Valor1
            // 
            Tx_Valor1.Location = new Point(398, 116);
            Tx_Valor1.Name = "Tx_Valor1";
            Tx_Valor1.Size = new Size(100, 23);
            Tx_Valor1.TabIndex = 5;
            // 
            // Tx_Valor2
            // 
            Tx_Valor2.Location = new Point(398, 188);
            Tx_Valor2.Name = "Tx_Valor2";
            Tx_Valor2.Size = new Size(100, 23);
            Tx_Valor2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(102, 116);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 7;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(329, 188);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 8;
            label3.Text = "Valor 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(329, 119);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 9;
            label4.Text = "Valor 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(84, 324);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 10;
            label5.Text = "Division";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(47, 254);
            label6.Name = "label6";
            label6.Size = new Size(107, 21);
            label6.TabIndex = 11;
            label6.Text = "Multiplicacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(102, 191);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 12;
            label7.Text = "Resta";
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Segoe UI", 12F);
            Calcular.Location = new Point(339, 326);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 36);
            Calcular.TabIndex = 13;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Close
            // 
            Close.Font = new Font("Segoe UI", 12F);
            Close.Location = new Point(563, 326);
            Close.Name = "Close";
            Close.Size = new Size(75, 36);
            Close.TabIndex = 14;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Font = new Font("Segoe UI", 12F);
            Limpiar.Location = new Point(447, 326);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 36);
            Limpiar.TabIndex = 15;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(736, 405);
            Controls.Add(Limpiar);
            Controls.Add(Close);
            Controls.Add(Calcular);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Tx_Valor2);
            Controls.Add(Tx_Valor1);
            Controls.Add(Tx_Division);
            Controls.Add(Tx_Multiplicacion);
            Controls.Add(Tx_Resta);
            Controls.Add(Tx_Suma);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Tx_Suma;
        private TextBox Tx_Resta;
        private TextBox Tx_Multiplicacion;
        private TextBox Tx_Division;
        private TextBox Tx_Valor1;
        private TextBox Tx_Valor2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button Calcular;
        private Button Close;
        private Button Limpiar;
    }
}
