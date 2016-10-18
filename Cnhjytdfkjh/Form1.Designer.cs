namespace CalculadoraMatriz
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CriarMatrizA = new System.Windows.Forms.Button();
            this.CriarMatrizB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DeterminanteA = new System.Windows.Forms.Button();
            this.OpostaA = new System.Windows.Forms.Button();
            this.InversaA = new System.Windows.Forms.Button();
            this.TranspostaA = new System.Windows.Forms.Button();
            this.Soma = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.LimparA = new System.Windows.Forms.Button();
            this.LinhaA = new System.Windows.Forms.NumericUpDown();
            this.ColunaA = new System.Windows.Forms.NumericUpDown();
            this.LinhaB = new System.Windows.Forms.NumericUpDown();
            this.ColunaB = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.DeterminanteB = new System.Windows.Forms.Button();
            this.OpostaB = new System.Windows.Forms.Button();
            this.TranspostaB = new System.Windows.Forms.Button();
            this.InversaB = new System.Windows.Forms.Button();
            this.LimparB = new System.Windows.Forms.Button();
            this.LimparR = new System.Windows.Forms.Button();
            this.groupMatriz1 = new System.Windows.Forms.GroupBox();
            this.Matriz1 = new System.Windows.Forms.Panel();
            this.groupMatriz2 = new System.Windows.Forms.GroupBox();
            this.Matriz2 = new System.Windows.Forms.Panel();
            this.groupMatrizResut = new System.Windows.Forms.GroupBox();
            this.MatrizResut = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LinhaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColunaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinhaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColunaB)).BeginInit();
            this.groupMatriz1.SuspendLayout();
            this.groupMatriz2.SuspendLayout();
            this.groupMatrizResut.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matriz A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matriz B";
            // 
            // CriarMatrizA
            // 
            this.CriarMatrizA.Location = new System.Drawing.Point(221, 55);
            this.CriarMatrizA.Name = "CriarMatrizA";
            this.CriarMatrizA.Size = new System.Drawing.Size(75, 23);
            this.CriarMatrizA.TabIndex = 6;
            this.CriarMatrizA.Text = "Criar matriz";
            this.CriarMatrizA.UseVisualStyleBackColor = true;
            this.CriarMatrizA.Click += new System.EventHandler(this.CriarMatrizA_Click);
            // 
            // CriarMatrizB
            // 
            this.CriarMatrizB.Location = new System.Drawing.Point(582, 55);
            this.CriarMatrizB.Name = "CriarMatrizB";
            this.CriarMatrizB.Size = new System.Drawing.Size(75, 23);
            this.CriarMatrizB.TabIndex = 7;
            this.CriarMatrizB.Text = "Criar matriz";
            this.CriarMatrizB.UseVisualStyleBackColor = true;
            this.CriarMatrizB.Click += new System.EventHandler(this.CriarMatrizB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Linhas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Colunas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Linhas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Colunas";
            // 
            // DeterminanteA
            // 
            this.DeterminanteA.Location = new System.Drawing.Point(144, 427);
            this.DeterminanteA.Name = "DeterminanteA";
            this.DeterminanteA.Size = new System.Drawing.Size(84, 23);
            this.DeterminanteA.TabIndex = 12;
            this.DeterminanteA.Text = "Determinante";
            this.DeterminanteA.UseVisualStyleBackColor = true;
            this.DeterminanteA.Click += new System.EventHandler(this.DeterminanteA_Click);
            // 
            // OpostaA
            // 
            this.OpostaA.Location = new System.Drawing.Point(246, 427);
            this.OpostaA.Name = "OpostaA";
            this.OpostaA.Size = new System.Drawing.Size(62, 23);
            this.OpostaA.TabIndex = 13;
            this.OpostaA.Text = "Oposta";
            this.OpostaA.UseVisualStyleBackColor = true;
            this.OpostaA.Click += new System.EventHandler(this.OpostaA_Click);
            // 
            // InversaA
            // 
            this.InversaA.Location = new System.Drawing.Point(105, 456);
            this.InversaA.Name = "InversaA";
            this.InversaA.Size = new System.Drawing.Size(63, 23);
            this.InversaA.TabIndex = 16;
            this.InversaA.Text = "Inversa";
            this.InversaA.UseVisualStyleBackColor = true;
            this.InversaA.Click += new System.EventHandler(this.InversaA_Click);
            // 
            // TranspostaA
            // 
            this.TranspostaA.Location = new System.Drawing.Point(48, 427);
            this.TranspostaA.Name = "TranspostaA";
            this.TranspostaA.Size = new System.Drawing.Size(82, 23);
            this.TranspostaA.TabIndex = 15;
            this.TranspostaA.Text = "Transposta";
            this.TranspostaA.UseVisualStyleBackColor = true;
            this.TranspostaA.Click += new System.EventHandler(this.TranspostaA_Click);
            // 
            // Soma
            // 
            this.Soma.Location = new System.Drawing.Point(337, 205);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(47, 23);
            this.Soma.TabIndex = 22;
            this.Soma.Text = "A + B";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(337, 234);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(47, 23);
            this.Sub.TabIndex = 23;
            this.Sub.Text = "A - B";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mult
            // 
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mult.Location = new System.Drawing.Point(337, 263);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(47, 23);
            this.Mult.TabIndex = 24;
            this.Mult.Text = "A * B";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // LimparA
            // 
            this.LimparA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LimparA.Location = new System.Drawing.Point(194, 456);
            this.LimparA.Name = "LimparA";
            this.LimparA.Size = new System.Drawing.Size(75, 23);
            this.LimparA.TabIndex = 25;
            this.LimparA.Text = "Limpar";
            this.LimparA.UseVisualStyleBackColor = false;
            this.LimparA.Click += new System.EventHandler(this.LimparA_Click);
            // 
            // LinhaA
            // 
            this.LinhaA.Location = new System.Drawing.Point(71, 55);
            this.LinhaA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LinhaA.Name = "LinhaA";
            this.LinhaA.Size = new System.Drawing.Size(69, 20);
            this.LinhaA.TabIndex = 27;
            // 
            // ColunaA
            // 
            this.ColunaA.Location = new System.Drawing.Point(146, 55);
            this.ColunaA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ColunaA.Name = "ColunaA";
            this.ColunaA.Size = new System.Drawing.Size(69, 20);
            this.ColunaA.TabIndex = 28;
            // 
            // LinhaB
            // 
            this.LinhaB.Location = new System.Drawing.Point(432, 58);
            this.LinhaB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LinhaB.Name = "LinhaB";
            this.LinhaB.Size = new System.Drawing.Size(69, 20);
            this.LinhaB.TabIndex = 29;
            // 
            // ColunaB
            // 
            this.ColunaB.Location = new System.Drawing.Point(507, 58);
            this.ColunaB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ColunaB.Name = "ColunaB";
            this.ColunaB.Size = new System.Drawing.Size(69, 20);
            this.ColunaB.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(706, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "=";
            // 
            // DeterminanteB
            // 
            this.DeterminanteB.Location = new System.Drawing.Point(519, 427);
            this.DeterminanteB.Name = "DeterminanteB";
            this.DeterminanteB.Size = new System.Drawing.Size(84, 23);
            this.DeterminanteB.TabIndex = 12;
            this.DeterminanteB.Text = "Determinante";
            this.DeterminanteB.UseVisualStyleBackColor = true;
            this.DeterminanteB.Click += new System.EventHandler(this.DeterminanteB_Click);
            // 
            // OpostaB
            // 
            this.OpostaB.Location = new System.Drawing.Point(609, 427);
            this.OpostaB.Name = "OpostaB";
            this.OpostaB.Size = new System.Drawing.Size(62, 23);
            this.OpostaB.TabIndex = 13;
            this.OpostaB.Text = "Oposta";
            this.OpostaB.UseVisualStyleBackColor = true;
            this.OpostaB.Click += new System.EventHandler(this.OpostaB_Click);
            // 
            // TranspostaB
            // 
            this.TranspostaB.Location = new System.Drawing.Point(431, 427);
            this.TranspostaB.Name = "TranspostaB";
            this.TranspostaB.Size = new System.Drawing.Size(82, 23);
            this.TranspostaB.TabIndex = 15;
            this.TranspostaB.Text = "Transposta";
            this.TranspostaB.UseVisualStyleBackColor = true;
            this.TranspostaB.Click += new System.EventHandler(this.TranspostaB_Click);
            // 
            // InversaB
            // 
            this.InversaB.Location = new System.Drawing.Point(479, 456);
            this.InversaB.Name = "InversaB";
            this.InversaB.Size = new System.Drawing.Size(63, 23);
            this.InversaB.TabIndex = 16;
            this.InversaB.Text = "Inversa";
            this.InversaB.UseVisualStyleBackColor = true;
            this.InversaB.Click += new System.EventHandler(this.InversaB_Click);
            // 
            // LimparB
            // 
            this.LimparB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LimparB.Location = new System.Drawing.Point(561, 456);
            this.LimparB.Name = "LimparB";
            this.LimparB.Size = new System.Drawing.Size(75, 23);
            this.LimparB.TabIndex = 25;
            this.LimparB.Text = "Limpar";
            this.LimparB.UseVisualStyleBackColor = false;
            this.LimparB.Click += new System.EventHandler(this.LimparB_Click);
            // 
            // LimparR
            // 
            this.LimparR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LimparR.Location = new System.Drawing.Point(879, 445);
            this.LimparR.Name = "LimparR";
            this.LimparR.Size = new System.Drawing.Size(75, 23);
            this.LimparR.TabIndex = 25;
            this.LimparR.Text = "Limpar";
            this.LimparR.UseVisualStyleBackColor = false;
            this.LimparR.Click += new System.EventHandler(this.LimparR_Click);
            // 
            // groupMatriz1
            // 
            this.groupMatriz1.Controls.Add(this.Matriz1);
            this.groupMatriz1.Location = new System.Drawing.Point(21, 126);
            this.groupMatriz1.Name = "groupMatriz1";
            this.groupMatriz1.Size = new System.Drawing.Size(310, 295);
            this.groupMatriz1.TabIndex = 42;
            this.groupMatriz1.TabStop = false;
            this.groupMatriz1.Text = "MatrizA";
            this.groupMatriz1.Enter += new System.EventHandler(this.groupMatriz1_Enter);
            // 
            // Matriz1
            // 
            this.Matriz1.Location = new System.Drawing.Point(6, 19);
            this.Matriz1.Name = "Matriz1";
            this.Matriz1.Size = new System.Drawing.Size(298, 270);
            this.Matriz1.TabIndex = 0;
            this.Matriz1.Paint += new System.Windows.Forms.PaintEventHandler(this.Matriz1_Paint);
            // 
            // groupMatriz2
            // 
            this.groupMatriz2.Controls.Add(this.Matriz2);
            this.groupMatriz2.Location = new System.Drawing.Point(390, 126);
            this.groupMatriz2.Name = "groupMatriz2";
            this.groupMatriz2.Size = new System.Drawing.Size(310, 295);
            this.groupMatriz2.TabIndex = 43;
            this.groupMatriz2.TabStop = false;
            this.groupMatriz2.Text = "MatrizB";
            // 
            // Matriz2
            // 
            this.Matriz2.Location = new System.Drawing.Point(6, 19);
            this.Matriz2.Name = "Matriz2";
            this.Matriz2.Size = new System.Drawing.Size(298, 270);
            this.Matriz2.TabIndex = 1;
            // 
            // groupMatrizResut
            // 
            this.groupMatrizResut.Controls.Add(this.MatrizResut);
            this.groupMatrizResut.Location = new System.Drawing.Point(735, 126);
            this.groupMatrizResut.Name = "groupMatrizResut";
            this.groupMatrizResut.Size = new System.Drawing.Size(310, 295);
            this.groupMatrizResut.TabIndex = 44;
            this.groupMatrizResut.TabStop = false;
            this.groupMatrizResut.Text = "MatrizResultado";
            // 
            // MatrizResut
            // 
            this.MatrizResut.Location = new System.Drawing.Point(6, 19);
            this.MatrizResut.Name = "MatrizResut";
            this.MatrizResut.Size = new System.Drawing.Size(298, 270);
            this.MatrizResut.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 534);
            this.Controls.Add(this.groupMatrizResut);
            this.Controls.Add(this.groupMatriz2);
            this.Controls.Add(this.groupMatriz1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ColunaB);
            this.Controls.Add(this.LinhaB);
            this.Controls.Add(this.ColunaA);
            this.Controls.Add(this.LinhaA);
            this.Controls.Add(this.LimparR);
            this.Controls.Add(this.LimparB);
            this.Controls.Add(this.LimparA);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.InversaB);
            this.Controls.Add(this.InversaA);
            this.Controls.Add(this.TranspostaB);
            this.Controls.Add(this.TranspostaA);
            this.Controls.Add(this.OpostaB);
            this.Controls.Add(this.DeterminanteB);
            this.Controls.Add(this.OpostaA);
            this.Controls.Add(this.DeterminanteA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CriarMatrizB);
            this.Controls.Add(this.CriarMatrizA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LinhaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColunaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinhaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColunaB)).EndInit();
            this.groupMatriz1.ResumeLayout(false);
            this.groupMatriz2.ResumeLayout(false);
            this.groupMatrizResut.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CriarMatrizA;
        private System.Windows.Forms.Button CriarMatrizB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeterminanteA;
        private System.Windows.Forms.Button OpostaA;
        private System.Windows.Forms.Button InversaA;
        private System.Windows.Forms.Button TranspostaA;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button LimparA;
        private System.Windows.Forms.NumericUpDown LinhaA;
        private System.Windows.Forms.NumericUpDown ColunaA;
        private System.Windows.Forms.NumericUpDown LinhaB;
        private System.Windows.Forms.NumericUpDown ColunaB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeterminanteB;
        private System.Windows.Forms.Button OpostaB;
        private System.Windows.Forms.Button TranspostaB;
        private System.Windows.Forms.Button InversaB;
        private System.Windows.Forms.Button LimparB;
        private System.Windows.Forms.Button LimparR;
        private System.Windows.Forms.GroupBox groupMatriz1;
        private System.Windows.Forms.GroupBox groupMatriz2;
        private System.Windows.Forms.GroupBox groupMatrizResut;
        private System.Windows.Forms.Panel Matriz1;
        private System.Windows.Forms.Panel Matriz2;
        private System.Windows.Forms.Panel MatrizResut;
    }
}

