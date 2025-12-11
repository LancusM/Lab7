namespace Lab7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            exit = new Button();
            logoutButton = new Button();
            loggedin = new Label();
            loginAffirm = new Label();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(67, 260);
            exit.Name = "exit";
            exit.Size = new Size(127, 118);
            exit.TabIndex = 21;
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(67, 160);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 23);
            logoutButton.TabIndex = 20;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // loggedin
            // 
            loggedin.AutoSize = true;
            loggedin.Location = new Point(1, 23);
            loggedin.Name = "loggedin";
            loggedin.Size = new Size(275, 120);
            loggedin.TabIndex = 19;
            loggedin.Text = resources.GetString("loggedin.Text");
            // 
            // loginAffirm
            // 
            loginAffirm.AutoSize = true;
            loginAffirm.Location = new Point(47, 200);
            loginAffirm.Name = "loginAffirm";
            loginAffirm.Size = new Size(0, 15);
            loginAffirm.TabIndex = 22;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 436);
            Controls.Add(loginAffirm);
            Controls.Add(exit);
            Controls.Add(logoutButton);
            Controls.Add(loggedin);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit;
        private Button logoutButton;
        private Label loggedin;
        private Label loginAffirm;
    }
}