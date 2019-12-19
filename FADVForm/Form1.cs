using System;
using System.Windows.Forms;
using FADVLib;

namespace FADVForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(testRoslyn.build("hoge.exe","hoge"));
        }

        private void projectCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ProjectCreateForm())
                form.ShowDialog(this);
        }
    }
}
