using System;
using System.Windows.Forms;

namespace MultiFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            TemperatureForm tempForm = new TemperatureForm();
            tempForm.ShowDialog();
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            CurrencyForm currencyForm = new CurrencyForm();
            currencyForm.ShowDialog();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.ShowDialog();
        }

        private void btnEncryption_Click(object sender, EventArgs e)
        {
            EncryptionForm encryptionForm = new EncryptionForm();
            encryptionForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            this.btnTemperature = new System.Windows.Forms.Button();
            this.btnCurrency = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTemperature
            // 
            this.btnTemperature.Location = new System.Drawing.Point(50, 80);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(150, 50);
            this.btnTemperature.TabIndex = 0;
            this.btnTemperature.Text = "Temperature Converter";
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // btnCurrency
            // 
            this.btnCurrency.Location = new System.Drawing.Point(220, 80);
            this.btnCurrency.Name = "btnCurrency";
            this.btnCurrency.Size = new System.Drawing.Size(150, 50);
            this.btnCurrency.TabIndex = 1;
            this.btnCurrency.Text = "Currency Converter";
            this.btnCurrency.UseVisualStyleBackColor = true;
            this.btnCurrency.Click += new System.EventHandler(this.btnCurrency_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(50, 150);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(150, 50);
            this.btnCalculator.TabIndex = 2;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnEncryption
            // 
            this.btnEncryption.Location = new System.Drawing.Point(220, 150);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(150, 50);
            this.btnEncryption.TabIndex = 3;
            this.btnEncryption.Text = "Encryption/Decryption";
            this.btnEncryption.UseVisualStyleBackColor = true;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(150, 220);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 30);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(120, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 26);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Main Dashboard";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEncryption);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnCurrency);
            this.Controls.Add(this.btnTemperature);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.Button btnCurrency;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
    }
}
