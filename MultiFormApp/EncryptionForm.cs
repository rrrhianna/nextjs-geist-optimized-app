using System;
using System.Text;
using System.Windows.Forms;

namespace MultiFormApp
{
    public partial class EncryptionForm : Form
    {
        private const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public EncryptionForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plaintext = txtInput.Text.ToUpper();
            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("Please enter text to encrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string encrypted = VigenereEncrypt(plaintext, ALPHABET);
            txtOutput.Text = encrypted;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = txtInput.Text.ToUpper();
            if (string.IsNullOrEmpty(ciphertext))
            {
                MessageBox.Show("Please enter text to decrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string decrypted = VigenereDecrypt(ciphertext, ALPHABET);
            txtOutput.Text = decrypted;
        }

        private string VigenereEncrypt(string plaintext, string key)
        {
            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    int plainIndex = c - 'A';
                    int keyChar = key[keyIndex % key.Length] - 'A';
                    int encryptedIndex = (plainIndex + keyChar) % 26;
                    result.Append((char)('A' + encryptedIndex));
                    keyIndex++;
                }
                else
                {
                    result.Append(c); // Keep non-alphabetic characters as is
                }
            }

            return result.ToString();
        }

        private string VigenereDecrypt(string ciphertext, string key)
        {
            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char c in ciphertext)
            {
                if (char.IsLetter(c))
                {
                    int cipherIndex = c - 'A';
                    int keyChar = key[keyIndex % key.Length] - 'A';
                    int decryptedIndex = (cipherIndex - keyChar + 26) % 26;
                    result.Append((char)('A' + decryptedIndex));
                    keyIndex++;
                }
                else
                {
                    result.Append(c); // Keep non-alphabetic characters as is
                }
            }

            return result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Vigenere Cipher Tool";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(30, 80);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(58, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input Text:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(30, 100);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(350, 80);
            this.txtInput.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(30, 200);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 30);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(150, 200);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 30);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(30, 250);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(68, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output Text:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(30, 270);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(350, 80);
            this.txtOutput.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(280, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInfo.Location = new System.Drawing.Point(30, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(320, 15);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Using full alphabet (A-Z) as key for Vigenere cipher";
            // 
            // EncryptionForm
            // 
            this.ClientSize = new System.Drawing.Size(410, 380);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblTitle);
            this.Name = "EncryptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption/Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInfo;
    }
}
