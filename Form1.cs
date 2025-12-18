using System;
using System.Diagnostics;
using System.Windows.Forms;
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要關閉電腦嗎？", "關機確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ProcessStartInfo psi = new ProcessStartInfo();

                psi.FileName = "shutdown";
                psi.Arguments = "/s /t 0";
                psi.CreateNoWindow = true;


                psi.UseShellExecute = false;


                Process.Start(psi);
            }
        }
    }
}
