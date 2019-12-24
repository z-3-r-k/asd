using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string[] usernames = { "username1", "username2" };
        string[] passwords = { "password1", "password2" };
        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        private void Button1_Click(object sender, EventArgs e)
        {
            if (usernames.Contains(textBox1.Text) && passwords.Contains(textBox2.Text) && Array.IndexOf(usernames, textBox1.Text) == Array.IndexOf(passwords, textBox2.Text))
            {
                S1uzduotis.Form1 f1 = new S1uzduotis.Form1();
                f1.ShowDialog();
            }
            else if(users.Contains(textBox1.Text) && pass.Contains(textBox2.Text) && Array.IndexOf(users.ToArray(), textBox1.Text) == Array.IndexOf(pass.ToArray(), textBox2.Text))
                {
                S1uzduotis.Form1 f1 = new S1uzduotis.Form1();
                f1.ShowDialog();

            }
            else
                MessageBox.Show("neteisingas");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("vars.txt");
            string line = " ";
            while ((line = sr.ReadLine()) != null)
            {
                string[] prisijungimai = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(prisijungimai[0]);
                pass.Add(prisijungimai[1]);
            }
            sr.Close();
        }
    }

}
