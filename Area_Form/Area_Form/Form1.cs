using cs实验;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = cs实验.Rectangle;

namespace Area_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            if (this.comboBox1.SelectedItem.Equals("Random"))
            {
                dataMaker maker = new dataMaker();
                List<double> list = maker.list;
                _Random _random = new _Random(list);
                foreach (int j in list)
                {
                    for (int tmp = 0; tmp < j; ++tmp)
                        textBox1.AppendText("*");
                    textBox1.AppendText("\n"); 
                }
                Console.WriteLine(_random.Area());
                textBox1.AppendText("Random \n Area = " + _random.Area());
            }
            else if (this.comboBox1.SelectedItem.Equals("Triangle"))
            {
                Random random = new Random();
                Triangle triangle = new Triangle(Math.Round(random.NextDouble() * 10, 2),
                        Math.Round(random.NextDouble() * 10, 2));
                textBox1.AppendText("Triangle"+" Width = " + triangle.width.ToString() +
                    " Height = " + triangle.height + "\n Area = " + triangle.Area());

            }
            else if (this.comboBox1.SelectedItem.Equals("Rectangle"))
            {
                Random random = new Random();
                Rectangle rectangle = new Rectangle(Math.Round(random.NextDouble() * 10, 2),
                        Math.Round(random.NextDouble() * 10, 2));
                textBox1.AppendText("Rectangle"+" Width = " + rectangle.width.ToString() +
                    " Height = " + rectangle.height + "\nArea = " + rectangle.Area());
            }
            else if (this.comboBox1.SelectedItem.Equals("Circle"))
            {
                Random random= new Random();
                Circle circle = new Circle(Math.Round(random.NextDouble() * 10, 2));
                textBox1.AppendText("Circle"+" Radius = " + circle.radius + "\nArea = " + circle.Area());
            }


        }
    }
}
