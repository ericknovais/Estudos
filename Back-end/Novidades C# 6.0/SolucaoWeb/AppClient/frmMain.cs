using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;

namespace AppClient
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private async void btnExecut_Click(object sender, EventArgs e)
        {
            try
            {
                int r = await Somar();
                txtResult.Text = r.ToString();
            }
            catch (Exception ex)
            {
                await Log(ex.Message);
            }
            finally
            {

            }
        }

        private async Task<int> Somar()
        {
            var calc = new Proxy.CalcWebService();
            return calc.Somar(ToInt32(txtX.Text), ToInt32(txtY.Text));
        }

        private async Task Log(string mensagem)
        {
            txtResult.Text = mensagem;
        }
    }
}
