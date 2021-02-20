using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoProject
{
    public partial class Form1 : Form
    {
        private Tasks tasks;
        public Form1()
        {
            InitializeComponent();
            tasks = new Tasks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var task in tasks.AddTask(textBox1.Text))
            {
                listBox1.Items.Add(task);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex != -1)
            {
                tasks.DeleteTask(listBox1.SelectedIndex);
                listBox1.Items.Clear();
                foreach (var task in tasks.GetTasks())
                {
                    listBox1.Items.Add(task);
                }
                            
            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                tasks.ChangeTask(listBox1.SelectedIndex, textBox2.Text);
                listBox1.Items.Clear();
                foreach (var task in tasks.GetTasks())
                {
                    
                    listBox1.Items.Add(task);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
    }

