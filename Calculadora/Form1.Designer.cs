namespace Calculadora
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
            Display = new Label();
            btn_mais_ou_menos = new Button();
            btn_1 = new Button();
            btn_4 = new Button();
            btn_7 = new Button();
            btn_excluir = new Button();
            btn_parenteses = new Button();
            btn_8 = new Button();
            btn_5 = new Button();
            btn_2 = new Button();
            btn_porcentagem = new Button();
            btn_9 = new Button();
            btn_6 = new Button();
            btn_3 = new Button();
            btn_virgula = new Button();
            btn_divisão = new Button();
            btn_multiplicação = new Button();
            btn_subtração = new Button();
            btn_somatoria = new Button();
            btn_0 = new Button();
            btn_resultado = new Button();
            SuspendLayout();
            // 
            // Display
            // 
            Display.AutoSize = true;
            Display.BorderStyle = BorderStyle.Fixed3D;
            Display.FlatStyle = FlatStyle.Popup;
            Display.Font = new Font("Segoe UI", 50F);
            Display.Location = new Point(11, 24);
            Display.MaximumSize = new Size(500, 150);
            Display.MinimumSize = new Size(370, 150);
            Display.Name = "Display";
            Display.Size = new Size(370, 150);
            Display.TabIndex = 2;
            Display.TextAlign = ContentAlignment.MiddleRight;
            Display.Click += label1_Click;
            // 
            // btn_mais_ou_menos
            // 
            btn_mais_ou_menos.Font = new Font("Segoe UI", 19F);
            btn_mais_ou_menos.Location = new Point(23, 552);
            btn_mais_ou_menos.Name = "btn_mais_ou_menos";
            btn_mais_ou_menos.Size = new Size(75, 81);
            btn_mais_ou_menos.TabIndex = 41;
            btn_mais_ou_menos.Text = "+ / -";
            btn_mais_ou_menos.UseVisualStyleBackColor = true;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI", 20F);
            btn_1.Location = new Point(23, 465);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(75, 81);
            btn_1.TabIndex = 40;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += button19_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI", 20F);
            btn_4.Location = new Point(23, 378);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(75, 81);
            btn_4.TabIndex = 39;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += button18_Click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Segoe UI", 20F);
            btn_7.Location = new Point(23, 291);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(75, 81);
            btn_7.TabIndex = 38;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += button17_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Font = new Font("Segoe UI", 20F);
            btn_excluir.ForeColor = Color.Red;
            btn_excluir.Location = new Point(23, 204);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(75, 81);
            btn_excluir.TabIndex = 37;
            btn_excluir.Text = "C";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += button16_Click;
            // 
            // btn_parenteses
            // 
            btn_parenteses.Font = new Font("Segoe UI", 20F);
            btn_parenteses.Location = new Point(104, 204);
            btn_parenteses.Name = "btn_parenteses";
            btn_parenteses.Size = new Size(75, 81);
            btn_parenteses.TabIndex = 36;
            btn_parenteses.Text = "( )";
            btn_parenteses.UseVisualStyleBackColor = true;
            btn_parenteses.Click += button15_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Segoe UI", 20F);
            btn_8.Location = new Point(104, 291);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(75, 81);
            btn_8.TabIndex = 35;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += button14_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI", 20F);
            btn_5.Location = new Point(104, 378);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(75, 81);
            btn_5.TabIndex = 34;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += button13_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI", 20F);
            btn_2.Location = new Point(104, 465);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(75, 81);
            btn_2.TabIndex = 33;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += button12_Click;
            // 
            // btn_porcentagem
            // 
            btn_porcentagem.Font = new Font("Segoe UI", 20F);
            btn_porcentagem.Location = new Point(185, 204);
            btn_porcentagem.Name = "btn_porcentagem";
            btn_porcentagem.Size = new Size(75, 81);
            btn_porcentagem.TabIndex = 31;
            btn_porcentagem.Text = "%";
            btn_porcentagem.UseVisualStyleBackColor = true;
            btn_porcentagem.Click += button10_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Segoe UI", 20F);
            btn_9.Location = new Point(185, 291);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(75, 81);
            btn_9.TabIndex = 30;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += button9_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI", 20F);
            btn_6.Location = new Point(185, 378);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(75, 81);
            btn_6.TabIndex = 29;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += button8_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI", 20F);
            btn_3.Location = new Point(185, 465);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(75, 81);
            btn_3.TabIndex = 28;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += button7_Click;
            // 
            // btn_virgula
            // 
            btn_virgula.Font = new Font("Segoe UI", 20F);
            btn_virgula.Location = new Point(185, 552);
            btn_virgula.Name = "btn_virgula";
            btn_virgula.Size = new Size(75, 81);
            btn_virgula.TabIndex = 27;
            btn_virgula.Text = ",";
            btn_virgula.UseVisualStyleBackColor = true;
            btn_virgula.Click += button6_Click;
            // 
            // btn_divisão
            // 
            btn_divisão.Font = new Font("Segoe UI", 20F);
            btn_divisão.Location = new Point(298, 204);
            btn_divisão.Name = "btn_divisão";
            btn_divisão.Size = new Size(75, 81);
            btn_divisão.TabIndex = 26;
            btn_divisão.Text = "/";
            btn_divisão.UseVisualStyleBackColor = true;
            btn_divisão.Click += button5_Click;
            // 
            // btn_multiplicação
            // 
            btn_multiplicação.Font = new Font("Segoe UI", 20F);
            btn_multiplicação.Location = new Point(298, 291);
            btn_multiplicação.Name = "btn_multiplicação";
            btn_multiplicação.Size = new Size(75, 81);
            btn_multiplicação.TabIndex = 25;
            btn_multiplicação.Text = "*";
            btn_multiplicação.UseVisualStyleBackColor = true;
            btn_multiplicação.Click += button4_Click;
            // 
            // btn_subtração
            // 
            btn_subtração.Font = new Font("Segoe UI", 20F);
            btn_subtração.Location = new Point(298, 378);
            btn_subtração.Name = "btn_subtração";
            btn_subtração.Size = new Size(75, 81);
            btn_subtração.TabIndex = 24;
            btn_subtração.Text = "-";
            btn_subtração.UseVisualStyleBackColor = true;
            btn_subtração.Click += button3_Click;
            // 
            // btn_somatoria
            // 
            btn_somatoria.Font = new Font("Segoe UI", 20F);
            btn_somatoria.Location = new Point(298, 465);
            btn_somatoria.Name = "btn_somatoria";
            btn_somatoria.Size = new Size(75, 81);
            btn_somatoria.TabIndex = 23;
            btn_somatoria.Text = "+";
            btn_somatoria.UseVisualStyleBackColor = true;
            btn_somatoria.Click += button2_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Segoe UI", 20F);
            btn_0.Location = new Point(104, 552);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(75, 81);
            btn_0.TabIndex = 43;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += button21_Click;
            // 
            // btn_resultado
            // 
            btn_resultado.Font = new Font("Segoe UI", 20F);
            btn_resultado.Location = new Point(298, 552);
            btn_resultado.Name = "btn_resultado";
            btn_resultado.Size = new Size(75, 81);
            btn_resultado.TabIndex = 45;
            btn_resultado.Text = "=";
            btn_resultado.UseVisualStyleBackColor = true;
            btn_resultado.Click += button22_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 645);
            Controls.Add(btn_resultado);
            Controls.Add(btn_0);
            Controls.Add(btn_mais_ou_menos);
            Controls.Add(btn_1);
            Controls.Add(btn_4);
            Controls.Add(btn_7);
            Controls.Add(btn_excluir);
            Controls.Add(btn_parenteses);
            Controls.Add(btn_8);
            Controls.Add(btn_5);
            Controls.Add(btn_2);
            Controls.Add(btn_porcentagem);
            Controls.Add(btn_9);
            Controls.Add(btn_6);
            Controls.Add(btn_3);
            Controls.Add(btn_virgula);
            Controls.Add(btn_divisão);
            Controls.Add(btn_multiplicação);
            Controls.Add(btn_subtração);
            Controls.Add(btn_somatoria);
            Controls.Add(Display);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Display;
        private Button btn_mais_ou_menos;
        private Button btn_1;
        private Button btn_4;
        private Button btn_7;
        private Button btn_excluir;
        private Button btn_parenteses;
        private Button btn_8;
        private Button btn_5;
        private Button btn_2;
        private Button btn_porcentagem;
        private Button btn_9;
        private Button btn_6;
        private Button btn_3;
        private Button btn_virgula;
        private Button btn_divisão;
        private Button btn_multiplicação;
        private Button btn_subtração;
        private Button btn_somatoria;
        private Button btn_0;
        private Button btn_resultado;
    }
}