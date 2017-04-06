using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        private static string fly;
        public Form3()
        {
            InitializeComponent();
            Select select = new Select("localhost", "root", "train", "3306", "");
            List<string>[] list = select.SelectA();
            BindingSource bs = new BindingSource();
            bs.DataSource = list[1];
            flyght.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fly = flyght.Text;
            this.Hide();
            new Form2().ShowDialog();
            
        }
        public string getId()
        {
            Select select = new Select("localhost", "root", "train", "3306", "");
            string id = select.SelectId(fly);
            return id;
        }

        private void flyght_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select select = new Select("localhost", "root", "train", "3306", "");
            string destination = flyght.Text;
            List<string> list = select.SelectD(destination);
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            vagon.DataSource = bs;
        }

        private void vagon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select select = new Select("localhost", "root", "train", "3306", "");
            string destination = flyght.Text;
            string vago = vagon.Text;
            List<string> list = select.SelectV(destination,vago);
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            time.DataSource = bs;
        }

        private void time_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Select select = new Select("localhost", "root", "train", "3306", "");
            string destination = flyght.Text;
            string vago = vagon.Text;
            string timeB = time.Text;
            List<string> list = select.SelectR(destination, vago, timeB);
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            race.DataSource = bs;

        }
    }
}
