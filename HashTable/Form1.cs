using System;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HashTable
{
    public partial class Form1 : Form
    {
        Hashtable fruitDictionary;
        public Form1()
        {
            InitializeComponent();
       
      
            fruitDictionary = new Hashtable();

            fruitDictionary.Add("Apple", 90.50);
            fruitDictionary.Add("Banana", "Php 25.00");
            fruitDictionary.Add("Grapes", "Violet");
            fruitDictionary.Add("Orange", 15);

            listBox1.Items.Clear();
            foreach(String key in fruitDictionary.Keys)
            {
                listBox1.Items.Add(key + ": " + fruitDictionary[key].ToString());
            }
 }
        private void button1_Click(object sender, EventArgs e)
        {
            String fruitSearch = textBox1.Text;
            String fruitValue = fruitDictionary[fruitSearch].ToString();
            textBox2.Text = fruitValue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
