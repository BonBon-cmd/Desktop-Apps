using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class BT : Form
    {
        public BT()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblMaSo_Click(object sender, EventArgs e)
        {

        }

        private void lblDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void lblView_Click(object sender, EventArgs e)
        {

        }

        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void frmLinkLabel_Load(object sender, EventArgs e)
        {
            string strURL = "mailto:ctk31@gmail.com";
            this.linkLabel1.Links.Add(0, strURL.Length, strURL);
            strURL = "http://www.cnttk31.net";
            this.linkLabel2.Links.Add(0, strURL.Length, strURL);
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("http://www."))
                Process.Start(strURL);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=hello");
        }

        private void NN_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.cboCNN.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemsselect = lbDanhsach.SelectedItems.Count - 1;
            for (int i = itemsselect; i >= 0; i--)
            {
                lbDanhsachChon.Items.Add(lbDanhsach.SelectedItems[i]);
                lbDanhsach.Items.Remove(lbDanhsach.SelectedItems[i]);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemore_Click(object sender, EventArgs e)
        {
            int i = lbDanhsachChon.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lbDanhsachChon.Items.RemoveAt(lbDanhsachChon.SelectedIndices[i]);
                i--;
            }
        }

        private void lbDanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rdGirl_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdGirl.Checked)
            {
                MessageBox.Show("Giới tính bạn là: " + rdGirl.Text);
            }
        }

        private void rdMen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdMen.Checked)
            {
                MessageBox.Show("Giới tính bạn là: " + rdMen.Text);
            }
        }

        private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauChu.Checked)
                this.btnButton.ForeColor = Color.Red;
            else
                this.btnButton.ForeColor = Color.Black;
        }

        private void ckbMauNen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauNen.Checked)
                this.btnButton.BackColor = Color.LightCyan;
            else
                this.btnButton.BackColor = this.btnButtonFlat.BackColor;
        }

        private void btnButton_Click(object sender, EventArgs e)
        {

        }

        private void rdFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdFlat.Checked)
                this.btnButtonFlat.FlatStyle = FlatStyle.Flat;
            else
                this.btnButtonFlat.FlatStyle = FlatStyle.Popup;
        }

        private void rdPopup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < clbMonHoc.Items.Count; i++ )
            {
                if (this.clbMonHoc.GetItemChecked(i) == true)
                {
                    s += this.clbMonHoc.Items[i].ToString() + ",";
                }
            }
            MessageBox.Show("Danh sách môn học: " + s);
        }
    }
}
