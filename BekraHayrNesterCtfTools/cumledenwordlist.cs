using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BekraHayrNesterCtfTools
{
    public partial class cumledenwordlist : Form
    {
        public cumledenwordlist()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        Thread th;
        private void wordlistOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(wordlistcreate);th.Start();
        }

        private void wordlistcreate()
        {
            try
            {
                var dizi = richTextBox1.Text.Replace("\n", " ").Split(' ');
                for (int i = 0; i < dizi.Length; i++)
                {
                    richTextBox2.AppendText(dizi[i].ToString() + "\n");
                }
            }
            catch{}
        }
    }
}
