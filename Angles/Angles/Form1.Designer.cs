namespace Angles
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
            degre_box = new TextBox();
            radian_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // degre_box
            // 
            degre_box.Location = new Point(89, 109);
            degre_box.Name = "degre_box";
            degre_box.Size = new Size(100, 23);
            degre_box.TabIndex = 0;
            degre_box.TextChanged += Degre_change;
            degre_box.KeyDown += verif2;
            degre_box.KeyPress += verif1;
            // 
            // radian_box
            // 
            radian_box.Location = new Point(89, 188);
            radian_box.Name = "radian_box";
            radian_box.Size = new Size(100, 23);
            radian_box.TabIndex = 1;
            radian_box.TextChanged += radian_change;
            radian_box.KeyDown += verif2;
            radian_box.KeyPress += verif1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 71);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Degre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 163);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "radian";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radian_box);
            Controls.Add(degre_box);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox degre_box;
        private TextBox radian_box;
        private Label label1;
        private Label label2;
    }
}