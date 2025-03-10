namespace Calculadora
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
            primeiroNumeroTextBox1 = new TextBox();
            segundoNumeroTextBox = new TextBox();
            label1 = new Label();
            maisButton1 = new Button();
            menosButton1 = new Button();
            divisaoButton1 = new Button();
            button1 = new Button();
            resultadoLabel2 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // primeiroNumeroTextBox1
            // 
            primeiroNumeroTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primeiroNumeroTextBox1.Location = new Point(12, 31);
            primeiroNumeroTextBox1.Multiline = true;
            primeiroNumeroTextBox1.Name = "primeiroNumeroTextBox1";
            primeiroNumeroTextBox1.Size = new Size(247, 32);
            primeiroNumeroTextBox1.TabIndex = 0;
            primeiroNumeroTextBox1.Text = "Digite o primeiro numero";
            primeiroNumeroTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // segundoNumeroTextBox
            // 
            segundoNumeroTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            segundoNumeroTextBox.Location = new Point(12, 153);
            segundoNumeroTextBox.Multiline = true;
            segundoNumeroTextBox.Name = "segundoNumeroTextBox";
            segundoNumeroTextBox.Size = new Size(247, 32);
            segundoNumeroTextBox.TabIndex = 1;
            segundoNumeroTextBox.Text = "Digite o segundo numero";
            segundoNumeroTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 76);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 2;
            label1.Text = "Qual operação deseja realizar?";
            // 
            // maisButton1
            // 
            maisButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maisButton1.Location = new Point(12, 7);
            maisButton1.Name = "maisButton1";
            maisButton1.Size = new Size(35, 32);
            maisButton1.TabIndex = 3;
            maisButton1.Text = "+";
            maisButton1.UseVisualStyleBackColor = true;
            maisButton1.Click += BotaoClicado;
            // 
            // menosButton1
            // 
            menosButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menosButton1.Location = new Point(53, 7);
            menosButton1.Name = "menosButton1";
            menosButton1.Size = new Size(35, 32);
            menosButton1.TabIndex = 4;
            menosButton1.Text = "-";
            menosButton1.UseVisualStyleBackColor = true;
            menosButton1.Click += BotaoClicado;
            // 
            // divisaoButton1
            // 
            divisaoButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divisaoButton1.Location = new Point(135, 7);
            divisaoButton1.Name = "divisaoButton1";
            divisaoButton1.Size = new Size(35, 32);
            divisaoButton1.TabIndex = 5;
            divisaoButton1.Text = "÷";
            divisaoButton1.UseVisualStyleBackColor = true;
            divisaoButton1.Click += BotaoClicado;
            // 
            // button1
            // 
            button1.Location = new Point(58, 194);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 9;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BotaoClicado;
            // 
            // resultadoLabel2
            // 
            resultadoLabel2.BorderStyle = BorderStyle.Fixed3D;
            resultadoLabel2.Location = new Point(12, 229);
            resultadoLabel2.Name = "resultadoLabel2";
            resultadoLabel2.Size = new Size(247, 30);
            resultadoLabel2.TabIndex = 10;
            resultadoLabel2.Text = "0";
            resultadoLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(divisaoButton1);
            panel1.Controls.Add(menosButton1);
            panel1.Controls.Add(maisButton1);
            panel1.Location = new Point(46, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 48);
            panel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(94, 7);
            button2.Name = "button2";
            button2.Size = new Size(35, 32);
            button2.TabIndex = 6;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BotaoClicado;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 298);
            Controls.Add(panel1);
            Controls.Add(resultadoLabel2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(segundoNumeroTextBox);
            Controls.Add(primeiroNumeroTextBox1);
            Name = "Form1";
            Text = "Calculadora";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox primeiroNumeroTextBox1;
        private TextBox segundoNumeroTextBox;
        private Label label1;
        private Button maisButton1;
        private Button menosButton1;
        private Button divisaoButton1;
        private Button button1;
        private Label resultadoLabel2;
        private Panel panel1;
        private Button button2;
    }
}
