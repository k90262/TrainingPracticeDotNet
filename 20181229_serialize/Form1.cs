using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _20181229_serialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 obj = new Class1()
            {
                Name = "Cortana",
                Age=20
            };

            BinaryFormatter serializer = new BinaryFormatter();
            FileStream fs = new FileStream(@"C:\Demo\object.txt", FileMode.Create);
            serializer.Serialize(fs, obj);
            fs.Close();

            MessageBox.Show("OK");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            FileStream fs = new FileStream(@"C:\Demo\object.txt", FileMode.Open);
            Class1 obj = (Class1)serializer.Deserialize(fs);
            fs.Close();

            MessageBox.Show(obj.Name);
            MessageBox.Show(obj.Age.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 obj = new Class1()
            {
                Name = "Mary",
                Age = 22
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Class1)) ;
            FileStream fs = new FileStream(@"C:\Demo\object.xml", FileMode.Create);
            serializer.Serialize(fs, obj);
            fs.Close();

            MessageBox.Show("OK");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Class1));
            FileStream fs = new FileStream(@"C:\Demo\object.xml", FileMode.Open);
            Class1 obj = (Class1)serializer.Deserialize(fs);
            fs.Close();

            MessageBox.Show(obj.Name);
            MessageBox.Show(obj.Age.ToString());
        }
    }
}
