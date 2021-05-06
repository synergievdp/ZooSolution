using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooModels;

namespace ZooFormsApp
{
    public partial class Form1 : Form
    {
        Zoo zoo = new();
        BindingList<Animal> animals;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            animals = new(zoo.Animals);
            bindingSource1.DataSource = zoo.Animals;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = animals;
            listBox1.DataSource = bindingSource1;
            listBox2.DataSource = bindingSource1;
            listBox1.DisplayMember = "Name";
            listBox2.DisplayMember = "Energy";
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
        }

        private void AddAnimal(object sender, EventArgs e)
        {
            var button = sender as Button;
            switch (button.Name)
            {
                case "AddMonkey":

                    zoo.AddAnimal(typeof(Monkey));
                    break;
                case "AddLion":

                    zoo.AddAnimal(typeof(Lion));
                    break;
                case "AddElephant":

                    zoo.AddAnimal(typeof(Elephant));
                    break;
                default:
                    break;
            }
            animals.ResetBindings();

        }

        private void FeedAnimal(object sender, EventArgs e)
        {
            var button = sender as Button;
            
            switch (button.Name)
            {
                case "FeedMonkey":

                    zoo.FeedAnimals(typeof(Monkey));
                    break;
                case "FeedLion":

                    zoo.FeedAnimals(typeof(Lion));
                    break;
                case "FeedElephant":

                    zoo.FeedAnimals(typeof(Elephant));
                    break;
                case "FeedAll":

                    zoo.FeedAnimals(typeof(Animal));
                    break;
                default:
                    break;
            }
            animals.ResetBindings();
        }

        private void StartTimer_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                StartTimer.Text = "Start";
            }
            else
            {
                timer.Start();
                StartTimer.Text = "Stop";
            }
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            zoo.ElapseTime();
            animals.ResetBindings();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
