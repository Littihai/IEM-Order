using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace IEM_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "schtasks",
                    Arguments = @"/run /s TSEDB /u tse\administrator /p scsadmin /tn ""IEM-Order.""",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process.Start(psi);

                MessageBox.Show("สั่งรัน IEM-Order. สำเร็จ",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
