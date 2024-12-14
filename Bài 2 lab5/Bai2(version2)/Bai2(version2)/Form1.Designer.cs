namespace Bai2_version2_
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
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtRecent = new TextBox();
            txtTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLogin = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(118, 53);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(290, 27);
            txtPassword.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(118, 20);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtRecent
            // 
            txtRecent.Location = new Point(316, 137);
            txtRecent.Name = "txtRecent";
            txtRecent.ReadOnly = true;
            txtRecent.Size = new Size(92, 27);
            txtRecent.TabIndex = 2;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(115, 137);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(92, 27);
            txtTotal.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 56);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 140);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 6;
            label3.Text = "Recent:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 140);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 7;
            label4.Text = "Total:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(453, 20);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 60);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 189);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 249);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(txtRecent);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Name = "Form1";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtRecent;
        private TextBox txtTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnLogin;
        private ListView listView1;
    }
}
