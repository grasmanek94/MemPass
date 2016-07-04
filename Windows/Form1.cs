using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemPass
{
    public partial class Form1 : Form
    {
        bool closing;
        NotifyIcon notifyIcon;

        public static byte[] Combine(byte[] first, byte[] second, byte[] third)
        {
            byte[] ret = new byte[first.Length + second.Length + third.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            Buffer.BlockCopy(third, 0, ret, first.Length + second.Length, third.Length);
            return ret;
        }

        public void ShowAlert(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public Form1()
        {
            InitializeComponent();
            closing = false;
            notifyIcon = new NotifyIcon();
            notifyIcon.BalloonTipTitle = "MemPass";
            notifyIcon.Icon = this.Icon;
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = (int)lengthEdit.Value;
            if (length < 1)
            {
                ShowAlert("Error", "Password length cannot be less than 1");
                return;
            }

            if (length > 64)
            {
                length = 64;
            }

            bool lowercaseSelected = lowercaseSelect.Checked;
            bool uppercaseSelected = uppercaseSelect.Checked;
            bool numberSelected = numberSelect.Checked;
            bool specialSelected = specialSelect.Checked;
            bool spaceSelected = spaceSelect.Checked;

            if (!lowercaseSelected && !uppercaseSelected && !numberSelected && !specialSelected && !spaceSelected)
            {
                ShowAlert("Error", "Cannot use an empty character set");
                return;
            }

            // character sets prepare

            string character_set = "";

            if (lowercaseSelected)
            {
                character_set += "abcdefghijklmnopqrstuvwxyz";
            }
            if (uppercaseSelected)
            {
                character_set += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (numberSelected)
            {
                character_set += "0123456789";
            }
            if (spaceSelected)
            {
                character_set += " ";
            }
            if (specialSelected)
            {
                character_set += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            }
            character_set = String.Concat(character_set.OrderBy(c => c)); // order characters by decimal value / alphabetically

            //

            TextBox password_1 = masterPasswordEdit;
            TextBox password_2 = masterPasswordRepeatEdit;

            if (password_1.Text != password_2.Text)
            {
                ShowAlert("Error", "Master Passwords do not match");
                return;
            }

            if (password_1.Text.Length < 1)
            {
                ShowAlert("Error", "Master Password cannot be empty");
                return;
            }

            string generated_password = "";

            // Generation routine here

            SHA512 shaM = new SHA512Managed();

            byte[] login_bytes = Encoding.UTF8.GetBytes(loginEdit.Text);
            byte[] name_bytes = Encoding.UTF8.GetBytes(nameEdit.Text);
            byte[] zeroes = new byte[1] { 0 };
            byte[] sequence_bytes = Encoding.UTF8.GetBytes(sequenceEdit.Value.ToString());
            byte[] password_bytes = Encoding.UTF8.GetBytes(password_1.Text);
            byte[] config_bytes = new byte[13] {
                    (byte)0,
                    lowercaseSelected ? (byte)1 : (byte)0,
                    (byte)0,
                    uppercaseSelected ? (byte)1 : (byte)0,
                    (byte)0,
                    numberSelected ? (byte)1 : (byte)0,
                    (byte)0,
                    specialSelected ? (byte)1 : (byte)0,
                    (byte)0,
                    spaceSelected ? (byte)1 : (byte)0,
                    (byte)0,
                    (byte)length,
                    (byte)0
                };

            byte[] data = shaM.ComputeHash(
                Combine(Combine(sequence_bytes, config_bytes, name_bytes), zeroes, Combine(login_bytes, zeroes, password_bytes))
            );

            if (length > data.Length)
            {
                length = data.Length;
            }

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                generated_password += character_set[(int)data[i] % character_set.Length];
            }

            // 

            Clipboard.SetText(generated_password);

            password_1.Text = "";
            password_2.Text = "";

            ShowAlert("Generated", "Your password is now in the clipboard");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing == false)
            {
                masterPasswordEdit.Text = "";
                masterPasswordRepeatEdit.Text = "";
                lengthEdit.Value = 31;
                lowercaseSelect.Checked = true;
                uppercaseSelect.Checked = true;
                numberSelect.Checked = true;
                specialSelect.Checked = true;
                spaceSelect.Checked = false;
                nameEdit.Text = "";
                sequenceEdit.Value = 0;
                loginEdit.Text = "";

                notifyIcon.Visible = true;
                e.Cancel = true;
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            closing = true;
            this.Close();
        }
    }
}
