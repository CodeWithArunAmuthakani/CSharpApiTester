using System.Windows.Forms;

namespace ApiTester
{
    partial class ApiTesterForm
    {
        private System.Windows.Forms.TextBox txtUrl; private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Button btnSend; private System.Windows.Forms.DataGridView dgvHeaders;
        private System.Windows.Forms.TextBox txtBody; private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TextBox txtStatus; private System.Windows.Forms.TextBox txtTime;
        private void InitializeComponent()
        {
            this.txtUrl = new TextBox() { Left = 10, Top = 10, Width = 600 };
            this.cmbMethod = new ComboBox() { Left = 620, Top = 10, Width = 80 }; cmbMethod.Items.AddRange(new string[] { "GET", "POST", "PUT", "DELETE" }); cmbMethod.SelectedIndex = 0;
            this.btnSend = new Button() { Left = 710, Top = 10, Width = 80, Text = "Send" }; btnSend.Click += btnSend_Click;
            this.dgvHeaders = new DataGridView() { Left = 10, Top = 45, Width = 780, Height = 120, AllowUserToAddRows = true }; dgvHeaders.Columns.Add("Key", "Key"); dgvHeaders.Columns.Add("Value", "Value");
            this.txtBody = new TextBox() { Left = 10, Top = 170, Width = 780, Height = 120, Multiline = true };
            this.txtResponse = new TextBox() { Left = 10, Top = 320, Width = 780, Height = 220, Multiline = true, ScrollBars = ScrollBars.Both };
            this.txtStatus = new TextBox() { Left = 10, Top = 295, Width = 150 };
            this.txtTime = new TextBox() { Left = 170, Top = 295, Width = 150 };
            this.Controls.AddRange(new Control[] { txtUrl, cmbMethod, btnSend, dgvHeaders, txtBody, txtStatus, txtTime, txtResponse });
            this.Text = "C# API Tester (.NET 10)"; this.Width = 820; this.Height = 600;
        }
    }
}
