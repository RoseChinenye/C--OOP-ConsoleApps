using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        const string AttachedWord = "ay";
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string translation = "";
            string input = textBox1.Text;

            string[] arrInput = input.Split(' ');

            for (int i = 0; i < arrInput.Length; i++)
            {
                translation += getPigLatin(arrInput[i]);
            }

            textBox2.Text = translation;
     }

        private string getPigLatin(string input)
        {
            string Insertedword;
            string firstLetter = input.Substring(0, 1);

            Insertedword = input.Substring(1) + firstLetter + AttachedWord + " ";

            return Insertedword;
        }
    }
}
