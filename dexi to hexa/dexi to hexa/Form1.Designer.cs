namespace dexi_to_hexa
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
            deci_box = new TextBox();
            hexa_box = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 53);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Decimal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 218);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Hexadecimal";
            // 
            // deci_box
            // 
            deci_box.Location = new Point(63, 106);
            deci_box.Name = "deci_box";
            deci_box.Size = new Size(100, 23);
            deci_box.TabIndex = 2;
            deci_box.TextChanged += Deci_change;
            deci_box.KeyDown += verif2;
            deci_box.KeyPress += verif1;
            // 
            // hexa_box
            // 
            hexa_box.Location = new Point(67, 274);
            hexa_box.Name = "hexa_box";
            hexa_box.Size = new Size(100, 23);
            hexa_box.TabIndex = 3;
            hexa_box.TextChanged += hexa_change;
            hexa_box.KeyDown += verif2;
            hexa_box.KeyPress += verif1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hexa_box);
            Controls.Add(deci_box);
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
        private TextBox deci_box;
        private TextBox hexa_box;
    }
}