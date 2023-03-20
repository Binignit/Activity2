using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Sortbuttonbox_Click(object sender, EventArgs e)
        {
            wishlist.Sorted = true;
        }

        private void Fillbuttonbox_Click(object sender, EventArgs e)
        {
            
        }

        private void Clearbuttonbox_Click(object sender, EventArgs e)
        {
            wishlist.Items.Clear();
        }

        private void Countbuttonbox_Click(object sender, EventArgs e)
        {
            Countbuttonbox.Text = Convert.ToString(wishlist.Items.Count);
        }

        private void Closebuttonbox_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Fillbutton_Click(object sender, EventArgs e)
        {
            wishlist2.Items.Add("House no roof");
            wishlist2.Items.Add("faucet no water");
            wishlist2.Items.Add("Bread");
            wishlist2.Items.Add("100000");
            wishlist2.Items.Add("Car no wheels");
        }

        private void Selection_Click(object sender, EventArgs e)
        {
           
        }

        private void Count_Click(object sender, EventArgs e)
        {

        }

        private void Sortbutton_Click(object sender, EventArgs e)
        {
            wishlist2.Sorted = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            selectionOutputBox.Text = wishlist2.Text;
        }

        private void wishlist2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            wishlist2.Items.Clear();
        }

        private void Countbutton_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(wishlist2.Items.Count);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
