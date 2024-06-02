using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EncryptionApp
{
    public partial class Form1 : Form
    {
        private Aes aes = Aes.Create();
        private DESCryptoServiceProvider des = new DESCryptoServiceProvider();
        private Stopwatch stopwatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            comboBoxAlgorithm.Items.Add("AES");
            comboBoxAlgorithm.Items.Add("DES");
            comboBoxAlgorithm.SelectedIndex = 0;
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            if (comboBoxAlgorithm.SelectedItem.ToString() == "AES")
            {
                aes.GenerateKey();
                aes.GenerateIV();
                txtKey.Text = BitConverter.ToString(aes.Key).Replace("-", "");
                txtIV.Text = BitConverter.ToString(aes.IV).Replace("-", "");
            }
            else if (comboBoxAlgorithm.SelectedItem.ToString() == "DES")
            {
                des.GenerateKey();
                des.GenerateIV();
                txtKey.Text = BitConverter.ToString(des.Key).Replace("-", "");
                txtIV.Text = BitConverter.ToString(des.IV).Replace("-", "");
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            byte[] encrypted;
            byte[] plainText = Encoding.ASCII.GetBytes(txtPlainText.Text);

            stopwatch.Reset();
            stopwatch.Start();

            if (comboBoxAlgorithm.SelectedItem.ToString() == "AES")
            {
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                encrypted = encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
            }
            else // DES
            {
                ICryptoTransform encryptor = des.CreateEncryptor(des.Key, des.IV);
                encrypted = encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
            }

            stopwatch.Stop();
            lblEncryptTime.Text = $"Encrypt Time: {stopwatch.ElapsedMilliseconds} ms";

            txtEncryptedTextASCII.Text = Encoding.ASCII.GetString(encrypted);
            txtEncryptedTextHEX.Text = BitConverter.ToString(encrypted).Replace("-", "");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            byte[] decrypted;
            byte[] encryptedText = StringToByteArray(txtEncryptedTextHEX.Text);

            stopwatch.Reset();
            stopwatch.Start();

            if (comboBoxAlgorithm.SelectedItem.ToString() == "AES")
            {
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                decrypted = decryptor.TransformFinalBlock(encryptedText, 0, encryptedText.Length);
            }
            else // DES
            {
                ICryptoTransform decryptor = des.CreateDecryptor(des.Key, des.IV);
                decrypted = decryptor.TransformFinalBlock(encryptedText, 0, encryptedText.Length);
            }

            stopwatch.Stop();
            lblDecryptTime.Text = $"Decrypt Time: {stopwatch.ElapsedMilliseconds} ms";

            txtDecryptedTextASCII.Text = Encoding.ASCII.GetString(decrypted);
            txtDecryptedTextHEX.Text = BitConverter.ToString(decrypted).Replace("-", "");
        }

        private byte[] StringToByteArray(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
