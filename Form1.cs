using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            MessageBox.Show("Your name is:  " + text);
        }
    }
}
