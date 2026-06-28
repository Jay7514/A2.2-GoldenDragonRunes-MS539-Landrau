namespace GoldenDragonRune
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
            this.btn1 = new Button();
            this.btn2 = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            cBx1 = new ComboBox();
            MeadowMountain = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MeadowMountain).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new Point(12, 87);
            this.btn1.Name = "btn1";
            this.btn1.Size = new Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Shangri La";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new Point(12, 138);
            this.btn2.Name = "btn2";
            this.btn2.Size = new Size(75, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Explore More";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(12, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(36, 17);
            lbl1.TabIndex = 4;
            lbl1.Text = "Gold";
            lbl1.Click += lbl1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(164, 9);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(45, 17);
            lbl2.TabIndex = 5;
            lbl2.Text = "Health";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(469, 9);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(128, 17);
            lbl3.TabIndex = 6;
            lbl3.Text = "% Journey Complete";
            // 
            // cBx1
            // 
            cBx1.FormattingEnabled = true;
            cBx1.Items.AddRange(new object[] { "Meadow Mountain", "In Flight", "Grasslands of Veda", "In Flight", "Shangri La", "In Flight", "The Hidden Oasis", "Completion" });
            cBx1.Location = new Point(469, 85);
            cBx1.Name = "cBx1";
            cBx1.Size = new Size(121, 25);
            cBx1.TabIndex = 9;
            // 
            // MeadowMountain
            // 
            MeadowMountain.Image = (Image)resources.GetObject("MeadowMountain.Image");
            MeadowMountain.Location = new Point(2, -1);
            MeadowMountain.Name = "MeadowMountain";
            MeadowMountain.Size = new Size(798, 448);
            MeadowMountain.SizeMode = PictureBoxSizeMode.StretchImage;
            MeadowMountain.TabIndex = 10;
            MeadowMountain.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cBx1);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(this.btn2);
            Controls.Add(this.btn1);
            Controls.Add(MeadowMountain);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)MeadowMountain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox cBx1;
        private PictureBox MeadowMountain;
    }
}
