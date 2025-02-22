namespace WinFormsAppWithAPIINtegration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            OutPutBox = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 74);
            label1.Name = "label1";
            label1.Size = new Size(289, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter Medical Treatment: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 189);
            label2.Name = "label2";
            label2.Size = new Size(211, 32);
            label2.TabIndex = 1;
            label2.Text = "Enter Patient Age: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lavender;
            label3.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 302);
            label3.Name = "label3";
            label3.Size = new Size(292, 32);
            label3.TabIndex = 2;
            label3.Text = "Enter Regional Language: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Emoji", 18F);
            textBox1.Location = new Point(416, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Emoji", 18F);
            textBox3.Location = new Point(416, 299);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(294, 39);
            textBox3.TabIndex = 5;
            // 
            // OutPutBox
            // 
            OutPutBox.AutoSize = true;
            OutPutBox.BackColor = Color.Lavender;
            OutPutBox.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutPutBox.Location = new Point(72, 431);
            OutPutBox.MaximumSize = new Size(650, 400);
            OutPutBox.Name = "OutPutBox";
            OutPutBox.Size = new Size(93, 21);
            OutPutBox.TabIndex = 6;
            OutPutBox.Text = "PlaceHolder";
            OutPutBox.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(635, 378);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(616, 200);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(94, 29);
            numericUpDown1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(834, 811);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(OutPutBox);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Happy Pills";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label OutPutBox;
        private Button button1;
        private NumericUpDown numericUpDown1;
    }
}
