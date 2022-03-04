namespace Miki1
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
            this.Calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VarA = new System.Windows.Forms.TextBox();
            this.VarB = new System.Windows.Forms.TextBox();
            this.VarC = new System.Windows.Forms.TextBox();
            this.Delta = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.Label();
            this.wynik_D = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(298, 319);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 0;
            this.Calc.Text = "Oblicz";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = " Podaj kolejno A,B i C ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VarA
            // 
            this.VarA.Location = new System.Drawing.Point(105, 384);
            this.VarA.Name = "VarA";
            this.VarA.Size = new System.Drawing.Size(100, 23);
            this.VarA.TabIndex = 2;
            // 
            // VarB
            // 
            this.VarB.Location = new System.Drawing.Point(289, 384);
            this.VarB.Name = "VarB";
            this.VarB.Size = new System.Drawing.Size(100, 23);
            this.VarB.TabIndex = 3;
            // 
            // VarC
            // 
            this.VarC.Location = new System.Drawing.Point(469, 384);
            this.VarC.Name = "VarC";
            this.VarC.Size = new System.Drawing.Size(105, 23);
            this.VarC.TabIndex = 4;
            // 
            // Delta
            // 
            this.Delta.AutoSize = true;
            this.Delta.Location = new System.Drawing.Point(650, 152);
            this.Delta.Name = "Delta";
            this.Delta.Size = new System.Drawing.Size(34, 15);
            this.Delta.TabIndex = 5;
            this.Delta.Text = "Delta";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Location = new System.Drawing.Point(650, 197);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(19, 15);
            this.x1.TabIndex = 6;
            this.x1.Text = "x1";
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Location = new System.Drawing.Point(650, 241);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(19, 15);
            this.x2.TabIndex = 7;
            this.x2.Text = "x2";
            // 
            // wynik_D
            // 
            this.wynik_D.AutoSize = true;
            this.wynik_D.Location = new System.Drawing.Point(322, 243);
            this.wynik_D.Name = "wynik_D";
            this.wynik_D.Size = new System.Drawing.Size(38, 15);
            this.wynik_D.TabIndex = 8;
            this.wynik_D.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wynik_D);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.Delta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VarC);
            this.Controls.Add(this.VarB);
            this.Controls.Add(this.VarA);
            this.Controls.Add(this.Calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Calc;
        private Label label1;
        private TextBox VarA;
        private TextBox VarB;
        private TextBox VarC;
        private Label Delta;
        private Label x1;
        private Label x2;
        private Label wynik_D;
    }
}