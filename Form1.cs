namespace MDIdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register reg = new register();
           
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login lo = new login();
           
            lo.Show();
        }
    }
}