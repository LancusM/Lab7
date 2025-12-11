using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public string newUser = "admin";
        public string newPass1 = "123";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void SetLogoutMessage(string message)
        {
            logoutAffirm.Text = message;
        }

        // ================================
        //  CAESAR CIPHER (Shift = 3)
        // ================================
        public static class CaesarCipher
        {
            private const int Shift = 3;

            public static string Encrypt(string input)
            {
                char[] buffer = input.ToCharArray();
                for (int i = 0; i < buffer.Length; i++)
                {
                    char c = buffer[i];

                    if (char.IsLetter(c))
                    {
                        char offset = char.IsUpper(c) ? 'A' : 'a';
                        c = (char)(((c + Shift - offset) % 26) + offset);
                    }

                    buffer[i] = c;
                }
                return new string(buffer);
            }

            public static string Decrypt(string input)
            {
                char[] buffer = input.ToCharArray();
                for (int i = 0; i < buffer.Length; i++)
                {
                    char c = buffer[i];

                    if (char.IsLetter(c))
                    {
                        char offset = char.IsUpper(c) ? 'A' : 'a';
                        c = (char)(((c - Shift - offset + 26) % 26) + offset);
                    }

                    buffer[i] = c;
                }
                return new string(buffer);
            }
        }

        // ================================
        //  LOGIN BUTTON
        // ================================
        private void logButton_Click(object sender, EventArgs e)
        {
            string inputUser = userBox.Text;
            string inputPass = passBox.Text;

            if (!string.IsNullOrEmpty(inputUser) && !string.IsNullOrEmpty(inputPass))
            {
                string connectionM =
                    @"Data Source=BB21302\WHUH_HAPPUN; 
                      Initial Catalog=whuh; 
                      User ID=MSYN; 
                      Password=mysong,yournote; 
                      TrustServerCertificate=True;";

                SqlConnection connectionS = new SqlConnection(connectionM);
                connectionS.Open();

                string connectionC = "SELECT * FROM dbo.login";
                SqlCommand cmd = new SqlCommand(connectionC, connectionS);

                SqlDataReader reader = cmd.ExecuteReader();

                string connectionY = "";
                string connectionN = "";

                while (reader.Read())
                {
                    connectionY = reader["Username"].ToString();
                    connectionN = reader["Password"].ToString(); // stored encrypted
                }

                connectionS.Close();

                // Encrypt the entered password before comparing
                string encryptedInputPass = CaesarCipher.Encrypt(inputPass);

                if ((inputUser == connectionY && encryptedInputPass == connectionN))
                {
                    logoutAffirm.Text = "Logged in successfully!";
                    Form2 form2 = new Form2(this);
                    form2.Show();
                }
                else
                {
                    logoutAffirm.Text = "Invalid username or password.";
                }
            }
            else
            {
                logoutAffirm.Text = "Enter a username or password.";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ================================
        //  CREATE NEW USER
        // ================================
        private void newUseButton_Click(object sender, EventArgs e)
        {
            newUser = newuserBox.Text;
            newPass1 = newpassBox1.Text;

            if (newPass1 != newpassBox2.Text)
            {
                createAffirm.Text = "Passwords do not match.";
            }
            else if (string.IsNullOrEmpty(newUser) || string.IsNullOrEmpty(newPass1))
            {
                createAffirm.Text = "Username and password cannot be empty.";
            }
            else
            {
                string connectionM =
                    @"Data Source=BB21302\WHUH_HAPPUN; 
                      Initial Catalog=whuh; 
                      User ID=MSYN; 
                      Password=mysong,yournote; 
                      TrustServerCertificate=True;";

                SqlConnection connectionS = new SqlConnection(connectionM);
                connectionS.Open();

                // Encrypt before storing
                string encryptedPass = CaesarCipher.Encrypt(newPass1);

                string connectionC = "INSERT INTO dbo.login (Username, Password) VALUES (@connectionY, @connectionN)";

                SqlCommand cmd = new SqlCommand(connectionC, connectionS);
                cmd.Parameters.AddWithValue("@connectionY", newUser);
                cmd.Parameters.AddWithValue("@connectionN", encryptedPass);
                cmd.ExecuteNonQuery();

                connectionS.Close();

                createAffirm.Text = "Account created successfully!";
                MessageBox.Show("New account:\nUsername: " + newUser + "\nPassword: " + newPass1 +
                                "\n(Encrypted stored value: " + encryptedPass + ")");
            }
        }
    }
}
