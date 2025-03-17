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
            maisButton1 = new Button();
            menosButton1 = new Button();
            divisaoButton1 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            displayTextBox = new TextBox();
            numeroButton1 = new Button();
            numeroButton2 = new Button();
            numeroButton4 = new Button();
            numeroButton5 = new Button();
            numeroButton8 = new Button();
            numeroButton9 = new Button();
            numeroButton7 = new Button();
            numeroButton6 = new Button();
            numeroButton3 = new Button();
            numeroButton0 = new Button();
            clearButton = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // maisButton1
            // 
            maisButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maisButton1.Location = new Point(0, 5);
            maisButton1.Name = "maisButton1";
            maisButton1.Size = new Size(46, 32);
            maisButton1.TabIndex = 3;
            maisButton1.Text = "+";
            maisButton1.UseVisualStyleBackColor = true;
            maisButton1.Click += BotaoClicadoOperador;
            // 
            // menosButton1
            // 
            menosButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menosButton1.Location = new Point(0, 39);
            menosButton1.Name = "menosButton1";
            menosButton1.Size = new Size(46, 32);
            menosButton1.TabIndex = 4;
            menosButton1.Text = "-";
            menosButton1.UseVisualStyleBackColor = true;
            menosButton1.Click += BotaoClicadoOperador;
            // 
            // divisaoButton1
            // 
            divisaoButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divisaoButton1.Location = new Point(0, 107);
            divisaoButton1.Name = "divisaoButton1";
            divisaoButton1.Size = new Size(46, 32);
            divisaoButton1.TabIndex = 5;
            divisaoButton1.Text = "÷";
            divisaoButton1.UseVisualStyleBackColor = true;
            divisaoButton1.Click += BotaoClicadoOperador;
            // 
            // button1
            // 
            button1.Location = new Point(0, 145);
            button1.Name = "button1";
            button1.Size = new Size(46, 41);
            button1.TabIndex = 9;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += igualButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(divisaoButton1);
            panel1.Controls.Add(menosButton1);
            panel1.Controls.Add(maisButton1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(180, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(46, 199);
            panel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 73);
            button2.Name = "button2";
            button2.Size = new Size(46, 32);
            button2.TabIndex = 6;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BotaoClicadoOperador;
            // 
            // displayTextBox
            // 
            displayTextBox.Location = new Point(24, 18);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.ReadOnly = true;
            displayTextBox.Size = new Size(202, 23);
            displayTextBox.TabIndex = 12;
            // 
            // numeroButton1
            // 
            numeroButton1.Location = new Point(24, 48);
            numeroButton1.Name = "numeroButton1";
            numeroButton1.Size = new Size(46, 41);
            numeroButton1.TabIndex = 13;
            numeroButton1.Text = "1";
            numeroButton1.UseVisualStyleBackColor = true;
            numeroButton1.Click += numeroButtonClicado;
            // 
            // numeroButton2
            // 
            numeroButton2.Location = new Point(76, 48);
            numeroButton2.Name = "numeroButton2";
            numeroButton2.Size = new Size(46, 41);
            numeroButton2.TabIndex = 14;
            numeroButton2.Text = "2";
            numeroButton2.UseVisualStyleBackColor = true;
            numeroButton2.Click += numeroButtonClicado;
            // 
            // numeroButton4
            // 
            numeroButton4.Location = new Point(24, 95);
            numeroButton4.Name = "numeroButton4";
            numeroButton4.Size = new Size(46, 41);
            numeroButton4.TabIndex = 21;
            numeroButton4.Text = "4";
            numeroButton4.UseVisualStyleBackColor = true;
            numeroButton4.Click += numeroButtonClicado;
            // 
            // numeroButton5
            // 
            numeroButton5.Location = new Point(76, 95);
            numeroButton5.Name = "numeroButton5";
            numeroButton5.Size = new Size(46, 41);
            numeroButton5.TabIndex = 22;
            numeroButton5.Text = "5";
            numeroButton5.UseVisualStyleBackColor = true;
            numeroButton5.Click += numeroButtonClicado;
            // 
            // numeroButton8
            // 
            numeroButton8.Location = new Point(76, 142);
            numeroButton8.Name = "numeroButton8";
            numeroButton8.Size = new Size(46, 41);
            numeroButton8.TabIndex = 23;
            numeroButton8.Text = "8";
            numeroButton8.UseVisualStyleBackColor = true;
            numeroButton8.Click += numeroButtonClicado;
            // 
            // numeroButton9
            // 
            numeroButton9.Location = new Point(128, 142);
            numeroButton9.Name = "numeroButton9";
            numeroButton9.Size = new Size(46, 41);
            numeroButton9.TabIndex = 24;
            numeroButton9.Text = "9";
            numeroButton9.UseVisualStyleBackColor = true;
            numeroButton9.Click += numeroButtonClicado;
            // 
            // numeroButton7
            // 
            numeroButton7.Location = new Point(24, 142);
            numeroButton7.Name = "numeroButton7";
            numeroButton7.Size = new Size(46, 41);
            numeroButton7.TabIndex = 25;
            numeroButton7.Text = "7";
            numeroButton7.UseVisualStyleBackColor = true;
            numeroButton7.Click += numeroButtonClicado;
            // 
            // numeroButton6
            // 
            numeroButton6.Location = new Point(128, 95);
            numeroButton6.Name = "numeroButton6";
            numeroButton6.Size = new Size(46, 41);
            numeroButton6.TabIndex = 26;
            numeroButton6.Text = "6";
            numeroButton6.UseVisualStyleBackColor = true;
            numeroButton6.Click += numeroButtonClicado;
            // 
            // numeroButton3
            // 
            numeroButton3.Location = new Point(128, 48);
            numeroButton3.Name = "numeroButton3";
            numeroButton3.Size = new Size(46, 41);
            numeroButton3.TabIndex = 27;
            numeroButton3.Text = "3";
            numeroButton3.UseVisualStyleBackColor = true;
            numeroButton3.Click += numeroButtonClicado;
            // 
            // numeroButton0
            // 
            numeroButton0.Location = new Point(76, 190);
            numeroButton0.Name = "numeroButton0";
            numeroButton0.Size = new Size(46, 41);
            numeroButton0.TabIndex = 28;
            numeroButton0.Text = "0";
            numeroButton0.UseVisualStyleBackColor = true;
            numeroButton0.Click += numeroButtonClicado;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(128, 189);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(46, 41);
            clearButton.TabIndex = 29;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(24, 189);
            button3.Name = "button3";
            button3.Size = new Size(46, 41);
            button3.TabIndex = 30;
            button3.Text = "⌫";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 251);
            Controls.Add(button3);
            Controls.Add(clearButton);
            Controls.Add(numeroButton0);
            Controls.Add(numeroButton3);
            Controls.Add(numeroButton6);
            Controls.Add(numeroButton7);
            Controls.Add(numeroButton9);
            Controls.Add(numeroButton8);
            Controls.Add(numeroButton5);
            Controls.Add(numeroButton4);
            Controls.Add(numeroButton2);
            Controls.Add(numeroButton1);
            Controls.Add(displayTextBox);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Calculadora";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button maisButton1;
        private Button menosButton1;
        private Button divisaoButton1;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private TextBox displayTextBox;
        private Button numeroButton1;
        private Button numeroButton2;
        private Button numeroButton4;
        private Button numeroButton5;
        private Button numeroButton8;
        private Button numeroButton9;
        private Button numeroButton7;
        private Button numeroButton6;
        private Button numeroButton3;
        private Button numeroButton0;
        private Button clearButton;
        private Button button3;
    }
}
