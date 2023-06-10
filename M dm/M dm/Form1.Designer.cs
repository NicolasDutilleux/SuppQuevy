namespace M_dm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MetreBox = new TextBox();
            DMetreBox = new TextBox();
            CMetreBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 58);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Metres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 150);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "DMetres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 253);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "CMetres";
            // 
            // MetreBox
            // 
            MetreBox.Location = new Point(76, 93);
            MetreBox.Name = "MetreBox";
            MetreBox.Size = new Size(198, 23);
            MetreBox.TabIndex = 3;
            MetreBox.TextChanged += Metre_change;
            MetreBox.KeyDown += verif2;
            MetreBox.KeyPress += verif1;
            // 
            // DMetreBox
            // 
            DMetreBox.Location = new Point(76, 195);
            DMetreBox.Name = "DMetreBox";
            DMetreBox.Size = new Size(198, 23);
            DMetreBox.TabIndex = 4;
            DMetreBox.TextChanged += DMetre_change;
            DMetreBox.KeyDown += verif2;
            DMetreBox.KeyPress += verif1;
            // 
            // CMetreBox
            // 
            CMetreBox.Location = new Point(72, 312);
            CMetreBox.Name = "CMetreBox";
            CMetreBox.Size = new Size(202, 23);
            CMetreBox.TabIndex = 5;
            CMetreBox.TextChanged += CMetre_change;
            CMetreBox.KeyDown += verif2;
            CMetreBox.KeyPress += verif1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CMetreBox);
            Controls.Add(DMetreBox);
            Controls.Add(MetreBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox MetreBox;
        private TextBox DMetreBox;
        private TextBox CMetreBox;
    }
}