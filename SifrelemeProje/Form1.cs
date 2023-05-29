using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SifrelemeProje
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
         

        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            string veri = "";
            label2.Text = "";
            veri = textBox1.Text;
            char[] karakterler = veri.ToCharArray();
            foreach (char eleman in karakterler)
            {
                
                label2.Text += Convert.ToChar(eleman + 3).ToString();
          
            }
            string[] row = { textBox2.Text, dateTimePicker1.Text, comboBox1.Text,label2.Text};
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);
            foreach (string item in row)
            {
                richTextBox1.Text = richTextBox1.Text+item +"\t";
            }
   



            try
            {
                saveFileDialog.Title = "kayıt yerini seçin";
                saveFileDialog.Filter = "Metin Dosyası(*.txt) | *.txt";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.ShowDialog();
                StreamWriter kaydet = new StreamWriter(saveFileDialog.FileName);
                kaydet.WriteLine(richTextBox1.Text);
                kaydet.Close();
                MessageBox.Show("işlem tamam");
           }
            catch (Exception)
            {

                MessageBox.Show("işlem tamamlanamadodı");
            }
             

            textBox2.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox2.Text = listView1.SelectedItems[0].SubItems[0].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                comboBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
               
            }
            string sifre = "";
            sifre= listView1.SelectedItems[0].SubItems[3].Text;
            char[]karakterler2=sifre.ToCharArray();
            foreach(char eleman2 in karakterler2)
            {
                textBox1.Text += Convert.ToChar(eleman2 - 3).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text=textBox2.Text;
            listView1.SelectedItems[0].SubItems[1].Text=dateTimePicker1.Text;
            listView1.SelectedItems[0].SubItems[2].Text=comboBox1.Text;
            listView1.SelectedItems[0].SubItems[3].Text = "";
            string sifrem = "";
            sifrem =textBox1.Text;
            char[] karakterler3 = sifrem.ToCharArray();
            foreach (char eleman3 in karakterler3)
            {
                listView1.SelectedItems[0].SubItems[3].Text += Convert.ToChar(eleman3+3).ToString();
            }
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Focus();



        }
    }
}
