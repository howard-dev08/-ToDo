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
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 74);
            label1.Name = "label1";
            label1.Size = new Size(291, 34);
            label1.TabIndex = 0;
            label1.Text = "Enter Medical Treatment: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 189);
            label2.Name = "label2";
            label2.Size = new Size(213, 34);
            label2.TabIndex = 1;
            label2.Text = "Enter Patient Age: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 302);
            label3.Name = "label3";
            label3.Size = new Size(294, 34);
            label3.TabIndex = 2;
            label3.Text = "Enter Regional Language: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Segoe UI Emoji", 18F);
            textBox1.Location = new Point(416, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Font = new Font("Segoe UI Emoji", 18F);
            textBox3.ForeColor = SystemColors.ControlText;
            textBox3.Location = new Point(416, 299);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(294, 39);
            textBox3.TabIndex = 5;
            // 
            // OutPutBox
            // 
            OutPutBox.AutoSize = true;
            OutPutBox.BackColor = SystemColors.Info;
            OutPutBox.BorderStyle = BorderStyle.Fixed3D;
            OutPutBox.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutPutBox.Location = new Point(72, 431);
            OutPutBox.MaximumSize = new Size(650, 400);
            OutPutBox.Name = "OutPutBox";
            OutPutBox.Size = new Size(95, 23);
            OutPutBox.TabIndex = 6;
            OutPutBox.Text = "PlaceHolder";
            OutPutBox.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.BackgroundImage = Properties.Resources.redBackGround;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(562, 378);
            button1.Name = "button1";
            button1.Size = new Size(148, 28);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.Info;
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(616, 200);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(94, 29);
            numericUpDown1.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.BackgroundImage = Properties.Resources.redBackGround;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(549, 12);
            button2.Name = "button2";
            button2.Size = new Size(161, 30);
            button2.TabIndex = 9;
            button2.Text = "Add Treatment";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = Properties.Resources.download__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 811);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(OutPutBox);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Desktop;
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
        private Button button2;
    }
}
