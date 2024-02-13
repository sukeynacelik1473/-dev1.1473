using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev1_1473
{
    public partial class Form1 : Form
    {
        Queue kuyruk = new Queue();
        int sira = 0;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Listele()
        {
            lbSiralar.Items.Clear();
            foreach (int sira in kuyruk)
            {
                lbSiralar.Items.Add(sira);
            }
        }

        private void btnSiraCikart_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            Listele();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSiraAl_Click_1(object sender, EventArgs e)
        {

            sira++;
            kuyruk.Enqueue(sira);
            Listele();
        }

        private void lbSiralar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSiraCikart_Click_1(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            Listele();
        }
    
    }
}
