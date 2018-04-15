namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numPadAdd = new System.Windows.Forms.Button();
            this.numPadDivide = new System.Windows.Forms.Button();
            this.numPadSub = new System.Windows.Forms.Button();
            this.numPadMult = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numPad8 = new System.Windows.Forms.Button();
            this.numPad9 = new System.Windows.Forms.Button();
            this.numPad5 = new System.Windows.Forms.Button();
            this.numPad6 = new System.Windows.Forms.Button();
            this.numPad2 = new System.Windows.Forms.Button();
            this.numPad3 = new System.Windows.Forms.Button();
            this.numPad7 = new System.Windows.Forms.Button();
            this.numPad4 = new System.Windows.Forms.Button();
            this.numPad1 = new System.Windows.Forms.Button();
            this.numPad0 = new System.Windows.Forms.Button();
            this.numPad = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numPadAdd
            // 
            this.numPadAdd.Location = new System.Drawing.Point(455, 115);
            this.numPadAdd.Name = "numPadAdd";
            this.numPadAdd.Size = new System.Drawing.Size(30, 30);
            this.numPadAdd.TabIndex = 0;
            this.numPadAdd.Text = "+";
            this.numPadAdd.UseVisualStyleBackColor = true;
            this.numPadAdd.Click += new System.EventHandler(this.numPadAdd_Click);
            // 
            // numPadDivide
            // 
            this.numPadDivide.Location = new System.Drawing.Point(455, 181);
            this.numPadDivide.Name = "numPadDivide";
            this.numPadDivide.Size = new System.Drawing.Size(30, 30);
            this.numPadDivide.TabIndex = 1;
            this.numPadDivide.Text = "/";
            this.numPadDivide.UseVisualStyleBackColor = true;
            this.numPadDivide.Click += new System.EventHandler(this.numPadDivide_Click);
            // 
            // numPadSub
            // 
            this.numPadSub.Location = new System.Drawing.Point(455, 149);
            this.numPadSub.Name = "numPadSub";
            this.numPadSub.Size = new System.Drawing.Size(30, 30);
            this.numPadSub.TabIndex = 2;
            this.numPadSub.Text = "-";
            this.numPadSub.UseVisualStyleBackColor = true;
            this.numPadSub.Click += new System.EventHandler(this.numPadSub_Click);
            // 
            // numPadMult
            // 
            this.numPadMult.Location = new System.Drawing.Point(419, 217);
            this.numPadMult.Name = "numPadMult";
            this.numPadMult.Size = new System.Drawing.Size(30, 30);
            this.numPadMult.TabIndex = 3;
            this.numPadMult.Text = "*";
            this.numPadMult.UseVisualStyleBackColor = true;
            this.numPadMult.Click += new System.EventHandler(this.numPadMult_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            // 
            // numPad8
            // 
            this.numPad8.Location = new System.Drawing.Point(371, 115);
            this.numPad8.Name = "numPad8";
            this.numPad8.Size = new System.Drawing.Size(30, 30);
            this.numPad8.TabIndex = 11;
            this.numPad8.Text = "8";
            this.numPad8.UseVisualStyleBackColor = true;
            this.numPad8.Click += new System.EventHandler(this.numPad8_Click);
            // 
            // numPad9
            // 
            this.numPad9.Location = new System.Drawing.Point(419, 115);
            this.numPad9.Name = "numPad9";
            this.numPad9.Size = new System.Drawing.Size(30, 30);
            this.numPad9.TabIndex = 12;
            this.numPad9.Text = "9";
            this.numPad9.UseVisualStyleBackColor = true;
            this.numPad9.Click += new System.EventHandler(this.numPad9_Click);
            // 
            // numPad5
            // 
            this.numPad5.Location = new System.Drawing.Point(371, 149);
            this.numPad5.Name = "numPad5";
            this.numPad5.Size = new System.Drawing.Size(30, 30);
            this.numPad5.TabIndex = 13;
            this.numPad5.Text = "5";
            this.numPad5.UseVisualStyleBackColor = true;
            this.numPad5.Click += new System.EventHandler(this.numPad5_Click);
            // 
            // numPad6
            // 
            this.numPad6.Location = new System.Drawing.Point(419, 149);
            this.numPad6.Name = "numPad6";
            this.numPad6.Size = new System.Drawing.Size(30, 30);
            this.numPad6.TabIndex = 14;
            this.numPad6.Text = "6";
            this.numPad6.UseVisualStyleBackColor = true;
            this.numPad6.Click += new System.EventHandler(this.numPad6_Click);
            // 
            // numPad2
            // 
            this.numPad2.Location = new System.Drawing.Point(371, 181);
            this.numPad2.Name = "numPad2";
            this.numPad2.Size = new System.Drawing.Size(30, 30);
            this.numPad2.TabIndex = 15;
            this.numPad2.Text = "2";
            this.numPad2.UseVisualStyleBackColor = true;
            this.numPad2.Click += new System.EventHandler(this.numPad2_Click);
            // 
            // numPad3
            // 
            this.numPad3.Location = new System.Drawing.Point(419, 181);
            this.numPad3.Name = "numPad3";
            this.numPad3.Size = new System.Drawing.Size(30, 30);
            this.numPad3.TabIndex = 16;
            this.numPad3.Text = "3";
            this.numPad3.UseVisualStyleBackColor = true;
            this.numPad3.Click += new System.EventHandler(this.numPad3_Click);
            // 
            // numPad7
            // 
            this.numPad7.Location = new System.Drawing.Point(329, 115);
            this.numPad7.Name = "numPad7";
            this.numPad7.Size = new System.Drawing.Size(30, 30);
            this.numPad7.TabIndex = 17;
            this.numPad7.Text = "7";
            this.numPad7.UseVisualStyleBackColor = true;
            this.numPad7.Click += new System.EventHandler(this.numPad7_Click);
            // 
            // numPad4
            // 
            this.numPad4.Location = new System.Drawing.Point(329, 149);
            this.numPad4.Name = "numPad4";
            this.numPad4.Size = new System.Drawing.Size(30, 30);
            this.numPad4.TabIndex = 18;
            this.numPad4.Text = "4";
            this.numPad4.UseVisualStyleBackColor = true;
            this.numPad4.Click += new System.EventHandler(this.numPad4_Click);
            // 
            // numPad1
            // 
            this.numPad1.Location = new System.Drawing.Point(329, 181);
            this.numPad1.Name = "numPad1";
            this.numPad1.Size = new System.Drawing.Size(30, 30);
            this.numPad1.TabIndex = 19;
            this.numPad1.Text = "1";
            this.numPad1.UseVisualStyleBackColor = true;
            this.numPad1.Click += new System.EventHandler(this.numPad1_Click);
            // 
            // numPad0
            // 
            this.numPad0.Location = new System.Drawing.Point(329, 217);
            this.numPad0.Name = "numPad0";
            this.numPad0.Size = new System.Drawing.Size(30, 30);
            this.numPad0.TabIndex = 20;
            this.numPad0.Text = "0";
            this.numPad0.UseVisualStyleBackColor = true;
            this.numPad0.Click += new System.EventHandler(this.numPad0_Click);
            // 
            // numPad
            // 
            this.numPad.Location = new System.Drawing.Point(371, 217);
            this.numPad.Name = "numPad";
            this.numPad.Size = new System.Drawing.Size(30, 30);
            this.numPad.TabIndex = 21;
            this.numPad.Text = ",";
            this.numPad.UseVisualStyleBackColor = true;
            this.numPad.Click += new System.EventHandler(this.numPad_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(455, 217);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(30, 30);
            this.Answer.TabIndex = 22;
            this.Answer.Text = "=";
            this.Answer.UseVisualStyleBackColor = true;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(326, 73);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(0, 13);
            this.log.TabIndex = 23;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(329, 254);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = "C";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteOne
            // 
            this.deleteOne.Location = new System.Drawing.Point(410, 253);
            this.deleteOne.Name = "deleteOne";
            this.deleteOne.Size = new System.Drawing.Size(75, 23);
            this.deleteOne.TabIndex = 25;
            this.deleteOne.Text = "←";
            this.deleteOne.UseVisualStyleBackColor = true;
            this.deleteOne.Click += new System.EventHandler(this.deleteOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteOne);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.numPad);
            this.Controls.Add(this.numPad0);
            this.Controls.Add(this.numPad1);
            this.Controls.Add(this.numPad4);
            this.Controls.Add(this.numPad7);
            this.Controls.Add(this.numPad3);
            this.Controls.Add(this.numPad2);
            this.Controls.Add(this.numPad6);
            this.Controls.Add(this.numPad5);
            this.Controls.Add(this.numPad9);
            this.Controls.Add(this.numPad8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numPadMult);
            this.Controls.Add(this.numPadSub);
            this.Controls.Add(this.numPadDivide);
            this.Controls.Add(this.numPadAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numPadAdd;
        private System.Windows.Forms.Button numPadDivide;
        private System.Windows.Forms.Button numPadSub;
        private System.Windows.Forms.Button numPadMult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button numPad8;
        private System.Windows.Forms.Button numPad9;
        private System.Windows.Forms.Button numPad5;
        private System.Windows.Forms.Button numPad6;
        private System.Windows.Forms.Button numPad2;
        private System.Windows.Forms.Button numPad3;
        private System.Windows.Forms.Button numPad7;
        private System.Windows.Forms.Button numPad4;
        private System.Windows.Forms.Button numPad1;
        private System.Windows.Forms.Button numPad0;
        private System.Windows.Forms.Button numPad;
        private System.Windows.Forms.Button Answer;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteOne;
    }
}

