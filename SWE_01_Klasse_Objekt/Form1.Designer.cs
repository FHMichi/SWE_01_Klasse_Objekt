namespace SWE_01_Klasse_Objekt
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
            btnShow = new Button();
            lblShow = new Label();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.Location = new Point(53, 66);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(363, 46);
            btnShow.TabIndex = 0;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // lblShow
            // 
            lblShow.AutoSize = true;
            lblShow.Location = new Point(215, 182);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(25, 32);
            lblShow.TabIndex = 1;
            lblShow.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 825);
            Controls.Add(lblShow);
            Controls.Add(btnShow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShow;
        private Label lblShow;
    }
}
