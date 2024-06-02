namespace EncryptionApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.txtEncryptedTextASCII = new System.Windows.Forms.TextBox();
            this.txtEncryptedTextHEX = new System.Windows.Forms.TextBox();
            this.txtDecryptedTextASCII = new System.Windows.Forms.TextBox();
            this.txtDecryptedTextHEX = new System.Windows.Forms.TextBox();
            this.lblEncryptTime = new System.Windows.Forms.Label();
            this.lblDecryptTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(12, 12);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlgorithm.TabIndex = 0;
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(169, 31);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(364, 20);
            this.txtPlainText.TabIndex = 1;
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(12, 53);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(121, 23);
            this.btnGenerateKeys.TabIndex = 2;
            this.btnGenerateKeys.Text = "Generate Keys";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(12, 94);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(121, 23);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(12, 123);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(121, 23);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(169, 74);
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(364, 20);
            this.txtKey.TabIndex = 5;
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(169, 115);
            this.txtIV.Name = "txtIV";
            this.txtIV.ReadOnly = true;
            this.txtIV.Size = new System.Drawing.Size(364, 20);
            this.txtIV.TabIndex = 6;
            // 
            // txtEncryptedTextASCII
            // 
            this.txtEncryptedTextASCII.Location = new System.Drawing.Point(12, 221);
            this.txtEncryptedTextASCII.Name = "txtEncryptedTextASCII";
            this.txtEncryptedTextASCII.ReadOnly = true;
            this.txtEncryptedTextASCII.Size = new System.Drawing.Size(521, 20);
            this.txtEncryptedTextASCII.TabIndex = 7;
            // 
            // txtEncryptedTextHEX
            // 
            this.txtEncryptedTextHEX.Location = new System.Drawing.Point(12, 247);
            this.txtEncryptedTextHEX.Name = "txtEncryptedTextHEX";
            this.txtEncryptedTextHEX.ReadOnly = true;
            this.txtEncryptedTextHEX.Size = new System.Drawing.Size(521, 20);
            this.txtEncryptedTextHEX.TabIndex = 8;
            // 
            // txtDecryptedTextASCII
            // 
            this.txtDecryptedTextASCII.Location = new System.Drawing.Point(12, 317);
            this.txtDecryptedTextASCII.Name = "txtDecryptedTextASCII";
            this.txtDecryptedTextASCII.ReadOnly = true;
            this.txtDecryptedTextASCII.Size = new System.Drawing.Size(521, 20);
            this.txtDecryptedTextASCII.TabIndex = 9;
            // 
            // txtDecryptedTextHEX
            // 
            this.txtDecryptedTextHEX.Location = new System.Drawing.Point(12, 343);
            this.txtDecryptedTextHEX.Name = "txtDecryptedTextHEX";
            this.txtDecryptedTextHEX.ReadOnly = true;
            this.txtDecryptedTextHEX.Size = new System.Drawing.Size(521, 20);
            this.txtDecryptedTextHEX.TabIndex = 10;
            // 
            // lblEncryptTime
            // 
            this.lblEncryptTime.AutoSize = true;
            this.lblEncryptTime.Location = new System.Drawing.Point(149, 156);
            this.lblEncryptTime.Name = "lblEncryptTime";
            this.lblEncryptTime.Size = new System.Drawing.Size(72, 13);
            this.lblEncryptTime.TabIndex = 11;
            this.lblEncryptTime.Text = "Encrypt Time:";
            // 
            // lblDecryptTime
            // 
            this.lblDecryptTime.AutoSize = true;
            this.lblDecryptTime.Location = new System.Drawing.Point(148, 183);
            this.lblDecryptTime.Name = "lblDecryptTime";
            this.lblDecryptTime.Size = new System.Drawing.Size(73, 13);
            this.lblDecryptTime.TabIndex = 12;
            this.lblDecryptTime.Text = "Decrypt Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CipherText";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "PlainText";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "IV";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(545, 375);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDecryptTime);
            this.Controls.Add(this.lblEncryptTime);
            this.Controls.Add(this.txtDecryptedTextHEX);
            this.Controls.Add(this.txtDecryptedTextASCII);
            this.Controls.Add(this.txtEncryptedTextHEX);
            this.Controls.Add(this.txtEncryptedTextASCII);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.comboBoxAlgorithm);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.TextBox txtEncryptedTextASCII;
        private System.Windows.Forms.TextBox txtEncryptedTextHEX;
        private System.Windows.Forms.TextBox txtDecryptedTextASCII;
        private System.Windows.Forms.TextBox txtDecryptedTextHEX;
        private System.Windows.Forms.Label lblEncryptTime;
        private System.Windows.Forms.Label lblDecryptTime;


        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

