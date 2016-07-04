using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin;
using Xamarin.Android;
using Xamarin.Android.Net;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace MemPass
{
    [Activity(Label = "MemPass", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
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
            AlertDialog.Builder builder;
            builder = new AlertDialog.Builder(this);
            builder.SetTitle(title);
            builder.SetMessage(message);
            builder.SetCancelable(false);
            builder.SetPositiveButton("OK", delegate { });
            builder.Show();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.generateButton);

            button.Click += delegate
            {
                EditText length_edit = FindViewById<EditText>(Resource.Id.lengthEdit);
                int length = Int32.Parse(length_edit.Text);
                if (length < 1)
                {
                    ShowAlert("Error", "Password length cannot be less than 1");
                    return;
                }

                if (length > 64)
                {
                    length = 64;
                }

                bool lowercaseSelected = FindViewById<Switch>(Resource.Id.lowercaseSelect).Checked;
                bool uppercaseSelected = FindViewById<Switch>(Resource.Id.uppercaseSelect).Checked;
                bool numberSelected = FindViewById<Switch>(Resource.Id.numberSelect).Checked;
                bool specialSelected = FindViewById<Switch>(Resource.Id.specialSelect).Checked;
                bool spaceSelected = FindViewById<Switch>(Resource.Id.spaceSelect).Checked;

                if (!lowercaseSelected && !uppercaseSelected && !numberSelected && !specialSelected && !spaceSelected)
                {
                    ShowAlert("Error", "Cannot use an empty character set");
                    return;
                }

                // character sets prepare

                string character_set = "";

                if(lowercaseSelected)
                {
                    character_set += "abcdefghijklmnopqrstuvwxyz";
                }
                if (uppercaseSelected)
                {
                    character_set += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                }
                if(numberSelected)
                {
                    character_set += "0123456789";
                }
                if (spaceSelected)
                {
                    character_set += " ";
                }
                if(specialSelected)
                {
                    character_set += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
                }
                character_set = String.Concat(character_set.OrderBy(c => c)); // order characters by decimal value / alphabetically

                //

                EditText password_1 = FindViewById<EditText>(Resource.Id.masterPasswordEdit);
                EditText password_2 = FindViewById<EditText>(Resource.Id.masterPasswordRepeatEdit);

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

                EditText sequence_edit = FindViewById<EditText>(Resource.Id.sequenceEdit);
                EditText login_edit = FindViewById<EditText>(Resource.Id.loginEdit);
                EditText name_edit = FindViewById<EditText>(Resource.Id.nameEdit);

                byte[] login_bytes = Encoding.UTF8.GetBytes(login_edit.Text);
                byte[] name_bytes = Encoding.UTF8.GetBytes(name_edit.Text);
                byte[] zeroes = new byte[1] { 0 };
                byte[] sequence_bytes = Encoding.UTF8.GetBytes(sequence_edit.Text);
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

                if(length > data.Length)
                {
                    length = data.Length;
                }

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < length; i++)
                {
                    generated_password += character_set[(int)data[i] % character_set.Length];
                }

                // 

                var clipBoard = (Android.Content.ClipboardManager)this.GetSystemService(Context.ClipboardService);
                clipBoard.Text = generated_password;

                password_1.Text = "";
                password_2.Text = "";

                ShowAlert("Generated", "Your password is now in the clipboard");
            };
        }

        protected override void OnPause()
        {
            FindViewById<EditText>(Resource.Id.masterPasswordEdit).Text = "";
            FindViewById<EditText>(Resource.Id.masterPasswordRepeatEdit).Text = "";
            FindViewById<EditText>(Resource.Id.sequenceEdit).Text = "0";
            FindViewById<EditText>(Resource.Id.loginEdit).Text = "";
            FindViewById<EditText>(Resource.Id.nameEdit).Text = "";
            FindViewById<EditText>(Resource.Id.lengthEdit).Text = "31";

            FindViewById<Switch>(Resource.Id.lowercaseSelect).Checked = true;
            FindViewById<Switch>(Resource.Id.uppercaseSelect).Checked = true;
            FindViewById<Switch>(Resource.Id.numberSelect).Checked = true;
            FindViewById<Switch>(Resource.Id.specialSelect).Checked = true;
            FindViewById<Switch>(Resource.Id.spaceSelect).Checked = false;
        }
    }
}

