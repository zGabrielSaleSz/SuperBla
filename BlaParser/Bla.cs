using BlaParser.Model;

namespace BlaParser
{
    public partial class Bla : Form
    {
        public Bla()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFrom.Text == null || txtFrom.Text.Length == 0)
                {
                    HandleError($"Please put something into {BlaConstants.BLA} field");
                    return;
                }
                string textToLower = txtFrom.Text.ToLower();
                if (textToLower.Contains($"{BlaConstants.BLA} ") || textToLower.Contains($" {BlaConstants.BLA}"))
                {
                    HandleError("bla blabla, Your input shouldnt contains the 'bla' word or many bla (s) like 'blabla'");
                    return;
                }
                BlaContainer message = new BlaContainer(txtFrom.Text);
                string result = result = message.Parse();
                txtTo.Text = result;
            }
            catch (Exception ex)
            {
                HandleError(ex.Message);
            }
        }

        private void btUnparse_Click(object sender, EventArgs e)
        {
            try
            {
                BlaContainer message = new BlaContainer(txtFrom.Text);
                string result = message.Unparse();
                txtTo.Text = result;
            }
            catch (Exception ex)
            {
                HandleError(ex.Message);
            }
        }

        private static void HandleError(string errorMessage)
        {
            var container = new BlaContainer(errorMessage);
            BlaBla blablablabla = new BlaBla(container.Parse(), true);
            blablablabla.ShowDialog();
        }

        private void blaInfo_Click(object sender, EventArgs e)
        {
            var container = new BlaContainer("1=Messages should be shord\r\n2=That why this 'Info' is short");
            BlaBla blablablabla = new BlaBla(container.Parse(), false);
            blablablabla.ShowDialog();
        }
    }
}