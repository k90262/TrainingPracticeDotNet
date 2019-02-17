using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class MyNotepad : Form
    {
        public MyNotepad()
        {
            InitializeComponent();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String filename = openFileDialog1.FileName;
                this.Text = filename;

                //FileStream fs = new FileStream(filename, FileMode.Open);
                //StreamReader sr = new StreamReader(fs);
                StreamReader sr = new StreamReader(filename);
                txtBody.Text = sr.ReadToEnd();
                sr.Close();
                //fs.Close();
                MessageBox.Show("ok");
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {

        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            if (result == DialogResult.OK)
            {
                String filename = saveFileDialog1.FileName;
                this.Text = filename;

                //FileStream fs = new FileStream(filename,  FileMode.Create);
                //fs.Read();
                //StreamWriter sw = new StreamWriter(fs);
                StreamWriter sw = new StreamWriter(filename);
                sw.Write(txtBody.Text);
                sw.Close();
                //fs.Close();
                MessageBox.Show("ok");
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAutoWrap_Click(object sender, EventArgs e)
        {
            txtBody.WordWrap = mnuAutoWrap.Checked;
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                txtBody.Font = fontDialog1.Font;
            }
        }

        private void MyNotepad_Load(object sender, EventArgs e)
        {
            fontDialog1.Font = txtBody.Font;
        }

        private void mnuFontColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = txtBody.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                txtBody.ForeColor = colorDialog1.Color;
            }
        }

        private void mnuBackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = txtBody.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBody.BackColor = colorDialog1.Color;
            }
        }
    }
}
