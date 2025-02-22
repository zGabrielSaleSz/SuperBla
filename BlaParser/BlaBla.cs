namespace BlaParser
{
    public partial class BlaBla : Form
    {
        public BlaBla(string message, bool isError)
        {
            InitializeComponent();
            if (isError)
            {
                this.BackColor = Color.Red;
                blablabla.BackColor = Color.Orange;
                blablablabla.BackColor = Color.Orange;
            } else
            {
                this.BackColor = Color.Blue;
                blablabla.BackColor = Color.LightBlue;
                blablablabla.BackColor = Color.LightBlue;
            }
            blablabla.Text = message;
        }
    }
}
