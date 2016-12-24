using System;
using System.Windows.Forms;

namespace ProjectManagementTool
{
    public partial class InputDialog : Form
    {
        private String _result;

        public InputDialog()
        {
            InitializeComponent();
            _result = "";
        }

        public string Title
        {
            get { return textBox1.Text; }
        }

        public string Description
        {
            get { return textBox2.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
            }
        }
    }
}
