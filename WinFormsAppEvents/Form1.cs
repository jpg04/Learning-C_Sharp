namespace WinFormsAppEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } 
        private void submitBtn_MouseHover_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Button Click");
        }
    }
}