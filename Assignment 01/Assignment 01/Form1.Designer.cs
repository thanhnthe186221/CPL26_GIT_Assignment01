namespace Assignment_01
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
            btnHello = new Button();
            btnGoodbye = new Button();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.Location = new Point(238, 140);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(94, 29);
            btnHello.TabIndex = 0;
            btnHello.Text = "Xin chào";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click_1;
            // 
            // btnGoodbye
            // 
            btnGoodbye.Location = new Point(464, 140);
            btnGoodbye.Name = "btnGoodbye";
            btnGoodbye.Size = new Size(94, 29);
            btnGoodbye.TabIndex = 1;
            btnGoodbye.Text = "Tạm biệt";
            btnGoodbye.UseVisualStyleBackColor = true;
            btnGoodbye.Click += btnGoodbye_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoodbye);
            Controls.Add(btnHello);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHello;
        private Button btnGoodbye;
    }
}
