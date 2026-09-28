namespace bailop
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
            Button button1;
            Button button2;
            Label label3;
            tb1 = new TextBox();
            tb2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(191, 306);
            button1.Name = "button1";
            button1.Size = new Size(172, 60);
            button1.TabIndex = 4;
            button1.Text = "XÁC NHẬN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(406, 306);
            button2.Name = "button2";
            button2.Size = new Size(172, 60);
            button2.TabIndex = 5;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(349, 409);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // tb1
            // 
            tb1.BackColor = Color.White;
            tb1.ForeColor = Color.Black;
            tb1.Location = new Point(369, 117);
            tb1.Name = "tb1";
            tb1.Size = new Size(240, 23);
            tb1.TabIndex = 0;
            tb1.TextChanged += textBox1_TextChanged_1;
            // 
            // tb2
            // 
            tb2.BackColor = Color.White;
            tb2.ForeColor = Color.Black;
            tb2.Location = new Point(369, 164);
            tb2.Name = "tb2";
            tb2.Size = new Size(240, 23);
            tb2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 20F);
            label1.Location = new Point(149, 97);
            label1.Name = "label1";
            label1.Size = new Size(214, 51);
            label1.TabIndex = 2;
            label1.Text = "ĐĂNG NHẬP :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20F);
            label2.Location = new Point(166, 153);
            label2.Name = "label2";
            label2.Size = new Size(169, 32);
            label2.TabIndex = 3;
            label2.Text = "MẬT KHẨU :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb1;
        private TextBox tb2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
