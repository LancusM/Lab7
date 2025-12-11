namespace Lab7
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
            userBox = new TextBox();
            passBox = new TextBox();
            label3 = new Label();
            logButton = new Button();
            newUseButton = new Button();
            newpassBox1 = new TextBox();
            label4 = new Label();
            newuserBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            newpassBox2 = new TextBox();
            label7 = new Label();
            createAffirm = new Label();
            logoutAffirm = new Label();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 100);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // userBox
            // 
            userBox.Location = new Point(50, 120);
            userBox.Name = "userBox";
            userBox.Size = new Size(100, 23);
            userBox.TabIndex = 2;
            // 
            // passBox
            // 
            passBox.Location = new Point(50, 180);
            passBox.Name = "passBox";
            passBox.Size = new Size(100, 23);
            passBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 160);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // logButton
            // 
            logButton.Location = new Point(60, 220);
            logButton.Name = "logButton";
            logButton.Size = new Size(75, 23);
            logButton.TabIndex = 5;
            logButton.Text = "Login";
            logButton.UseVisualStyleBackColor = true;
            logButton.Click += logButton_Click;
            // 
            // newUseButton
            // 
            newUseButton.Location = new Point(560, 280);
            newUseButton.Name = "newUseButton";
            newUseButton.Size = new Size(75, 23);
            newUseButton.TabIndex = 11;
            newUseButton.Text = "Create";
            newUseButton.UseVisualStyleBackColor = true;
            newUseButton.Click += newUseButton_Click;
            // 
            // newpassBox1
            // 
            newpassBox1.Location = new Point(550, 180);
            newpassBox1.Name = "newpassBox1";
            newpassBox1.Size = new Size(100, 23);
            newpassBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 160);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Password:";
            // 
            // newuserBox
            // 
            newuserBox.Location = new Point(550, 120);
            newuserBox.Name = "newuserBox";
            newuserBox.Size = new Size(100, 23);
            newuserBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(550, 100);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 7;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 50);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 6;
            label6.Text = "Create User";
            // 
            // newpassBox2
            // 
            newpassBox2.Location = new Point(550, 240);
            newpassBox2.Name = "newpassBox2";
            newpassBox2.Size = new Size(100, 23);
            newpassBox2.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(550, 220);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 12;
            label7.Text = "Confirm Password:";
            // 
            // createAffirm
            // 
            createAffirm.AutoSize = true;
            createAffirm.Location = new Point(550, 320);
            createAffirm.Name = "createAffirm";
            createAffirm.Size = new Size(0, 15);
            createAffirm.TabIndex = 14;
            // 
            // logoutAffirm
            // 
            logoutAffirm.AutoSize = true;
            logoutAffirm.Location = new Point(50, 280);
            logoutAffirm.Name = "logoutAffirm";
            logoutAffirm.Size = new Size(0, 15);
            logoutAffirm.TabIndex = 15;
            // 
            // exit
            // 
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(296, 145);
            exit.Name = "exit";
            exit.Size = new Size(127, 118);
            exit.TabIndex = 22;
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(logoutAffirm);
            Controls.Add(createAffirm);
            Controls.Add(newpassBox2);
            Controls.Add(label7);
            Controls.Add(newUseButton);
            Controls.Add(newpassBox1);
            Controls.Add(label4);
            Controls.Add(newuserBox);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(logButton);
            Controls.Add(passBox);
            Controls.Add(label3);
            Controls.Add(userBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            this.Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userBox;
        private TextBox passBox;
        private Label label3;
        private Button logButton;
        private Button newUseButton;
        private TextBox newpassBox1;
        private Label label4;
        private TextBox newuserBox;
        private Label label5;
        private Label label6;
        private TextBox newpassBox2;
        private Label label7;
        private Label createAffirm;
        private Label logoutAffirm;
        private Button exit;
    }
}
