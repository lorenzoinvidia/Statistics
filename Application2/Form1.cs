using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application2
{
    public partial class Form1 : Form
    {
        private List<Person> buffer;
        private FileManager file;
        private ApplicationLogic application;

        public Form1()
        {
            InitializeComponent();

            file = new FileManager();
            application = new ApplicationLogic();
            buffer = application.createDataBuffer(file);

            printData(buffer);

        }


        private void Form1_Load(object sender, EventArgs e){}


        private void printData(List<Person> people)
        {
            //Add the proper text
            foreach (Person p in people)
            {
                string currStr = "Gender:" + p.Gender + ", " + "Age:" + p.Age + ", " + "Weight:" + p.Weight + ", " + "Height:" + p.Height;
                Console.WriteLine(currStr);//DEBUG
            }
        }//printData()

    }
}
