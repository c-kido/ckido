namespace ckido
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
            txtStudentName = new TextBox();
            lstOut = new ListBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 39);
            label1.Name = "label1";
            label1.Size = new Size(499, 30);
            label1.TabIndex = 0;
            label1.Text = "Introduction to Computer Programming for Business";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 98);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Student Name ";
            label2.Click += label2_Click;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(220, 95);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(359, 23);
            txtStudentName.TabIndex = 2;
            txtStudentName.TextChanged += textBox1_TextChanged;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(111, 180);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(539, 94);
            lstOut.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(122, 326);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(lstOut);
            Controls.Add(txtStudentName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "kido 102";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStudentName;
        private ListBox lstOut;
        private Button btnSubmit;
    }
}
