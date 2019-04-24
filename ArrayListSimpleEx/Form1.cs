using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList sentence = new ArrayList();
        bool isReverse = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sentence.Add("I");
            sentence.Add("Love");
            sentence.Add("Programming");
            sentence.Add("So");
            sentence.Add("Much");

        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            if (isReverse == true)
            {
                sentence.Reverse();
            }
            isReverse = false;
            Display();
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sentence.Insert(1, txtSecondPos.Text);
     
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (isReverse == false)
            {
                sentence.Reverse();
            }
            isReverse = true;
            Display();
            
            
        }

        private void Display()
        {
            string a = "";
            for (int i = 0; i <= sentence.Count-1; i++)
            {
                a += sentence[i] + " ";
         
            }
            lblMessage.Text = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sentence.RemoveAt(1);
        }
    }
} 
