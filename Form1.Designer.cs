namespace Gymnasiearbete
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
            btnremove1 = new Button();
            btnremove2 = new Button();
            btnremove3 = new Button();
            btnremove4 = new Button();
            btnremove5 = new Button();
            BtnReady = new Button();
            lbltest = new Label();
            SuspendLayout();
            // 
            // btnremove1
            // 
            btnremove1.Location = new Point(12, 299);
            btnremove1.Name = "btnremove1";
            btnremove1.Size = new Size(94, 23);
            btnremove1.TabIndex = 1;
            btnremove1.Text = "Remove card 1";
            btnremove1.UseVisualStyleBackColor = true;
            btnremove1.Click += button1_Click;
            // 
            // btnremove2
            // 
            btnremove2.Location = new Point(12, 328);
            btnremove2.Name = "btnremove2";
            btnremove2.Size = new Size(94, 23);
            btnremove2.TabIndex = 2;
            btnremove2.Text = "Remove card 2";
            btnremove2.UseVisualStyleBackColor = true;
            btnremove2.Click += button2_Click;
            // 
            // btnremove3
            // 
            btnremove3.Location = new Point(12, 357);
            btnremove3.Name = "btnremove3";
            btnremove3.Size = new Size(94, 23);
            btnremove3.TabIndex = 3;
            btnremove3.Text = "Remove card 3";
            btnremove3.UseVisualStyleBackColor = true;
            btnremove3.Click += button3_Click;
            // 
            // btnremove4
            // 
            btnremove4.Location = new Point(12, 386);
            btnremove4.Name = "btnremove4";
            btnremove4.Size = new Size(94, 23);
            btnremove4.TabIndex = 4;
            btnremove4.Text = "Remove card 4";
            btnremove4.UseVisualStyleBackColor = true;
            btnremove4.Click += button4_Click;
            // 
            // btnremove5
            // 
            btnremove5.Location = new Point(12, 415);
            btnremove5.Name = "btnremove5";
            btnremove5.Size = new Size(94, 23);
            btnremove5.TabIndex = 5;
            btnremove5.Text = "Remove card 5";
            btnremove5.UseVisualStyleBackColor = true;
            btnremove5.Click += button5_Click;
            // 
            // BtnReady
            // 
            BtnReady.Location = new Point(648, 249);
            BtnReady.Name = "BtnReady";
            BtnReady.Size = new Size(75, 23);
            BtnReady.TabIndex = 6;
            BtnReady.Text = "Play";
            BtnReady.UseVisualStyleBackColor = true;
            BtnReady.Click += BtnReady_Click;
            // 
            // lbltest
            // 
            lbltest.AutoSize = true;
            lbltest.Location = new Point(12, 9);
            lbltest.Name = "lbltest";
            lbltest.Size = new Size(39, 15);
            lbltest.TabIndex = 7;
            lbltest.Text = "lbltest";
            lbltest.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbltest);
            Controls.Add(BtnReady);
            Controls.Add(btnremove5);
            Controls.Add(btnremove4);
            Controls.Add(btnremove3);
            Controls.Add(btnremove2);
            Controls.Add(btnremove1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lblshowcards;
        private Button btnremove1;
        private Button btnremove2;
        private Button btnremove3;
        private Button btnremove4;
        private Button btnremove5;
        private Button BtnReady;
        private Label lbltest;
    }
}