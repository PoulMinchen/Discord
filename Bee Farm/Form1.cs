using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeFarm
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Queen queen;
        public Form()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                                                    "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            queen = new Queen(workers);
        }
        
        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Для этого задания рабочих нет ‘"
                + workerBeeJob.Text + "’", "Матка говорит...");
            else
                MessageBox.Show("Задание ‘" + workerBeeJob.Text + "’ будет закончено через "
                + shifts.Value + " смен", "Матка говорит...");
        }
    }
}
