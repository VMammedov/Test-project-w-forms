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

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1inClicki(object sender, EventArgs e)
        {
            string fileName = textBox1.Text.Trim();
            string path = Directory.GetCurrentDirectory() + @"\..\..\..\..\" + fileName + ".txt";
            // C:Users\vusal\Desktop\{fayl_adi}.txt
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamWriter streamWriter = new StreamWriter(fileStream);
            if(!String.IsNullOrEmpty(richTextBox1.Text))
                streamWriter.WriteLine(richTextBox1.Text);

            streamWriter.Close();

            MessageBox.Show("Fayl ugurla yaradildi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Fayl ugurla yaradildi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\..\..\..\..\" + textBox1.Text + ".txt";
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Delete();
            MessageBox.Show("Fayl ugurla silindi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Fayl ugurla silindi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Fayl ugurla silindi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Fayl ugurla silindi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Fayl ugurla silindi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Fayl ugurla silindi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Fayl ugurla silindi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Fayl ugurla silindi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Fayl ugurla silindi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Fayl ugurla silindi!", "Ugurlu Emeliyyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
