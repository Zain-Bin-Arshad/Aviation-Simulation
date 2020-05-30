using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingOnPriority
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        Plane plane;
        PriorityQueue<Plane> queue = new PriorityQueue<Plane>();
        int planeID, planeFuel, planeBurning, planePasssenger, planePriority, planeRunwayTime;
        int totalPlanes = 0; int totalLanded = 0; int totalCrashed = 0;
        string status = "Requested ...";
        string[] row;

        // when Generate button is presed
        private void generatePlane_button_Click(object sender, EventArgs e)
        {
            try
            {
                planeID = random.Next(1, 1000);
                planePasssenger = random.Next(200, 400);
                if (planePasssenger > 300)
                {
                    planeRunwayTime = random.Next(2000, 4000);
                    planeFuel = random.Next(25, 35);
                    planeBurning = 2;
                }
                else
                {
                    planeBurning = 1;
                    planeFuel = random.Next(25, 30);
                    planeRunwayTime = random.Next(1000, 2000);
                }
                planePriority = random.Next(7, 100) + (planeFuel / (planePasssenger * (1 + planeBurning)));
                id_textBox.Text = planeID.ToString();
                pass_textBox.Text = planePasssenger.ToString();
                fuel_textBox.Text = planeFuel.ToString();
                rate_textBox.Text = planeBurning.ToString();
                priority_textBox.Text = planePriority.ToString();   
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //when Insert is pressed
        private void insertPlane_button_Click(object sender, EventArgs e)
        {
            try
            {
                // creating new plane object
                plane = new Plane(planeID, planePasssenger, planeFuel, planeBurning, planePriority, status, planeRunwayTime);
                queue.Enqueue(plane); // inserting in priorty queue 
                totalPlanes++;
                // inserting in datagridview
                row = new[]
                {
                    planeID.ToString(),planePasssenger.ToString(),planeRunwayTime.ToString(),
                    planeFuel.ToString(),planeBurning.ToString(),planePriority.ToString(),status
                };
                planeDataGridView.Rows.Add(row); //new row added in datagridview
                planelabel.Text = totalPlanes.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void showQueue_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queue.ToString());
        }

        public void run_button_Click(object sender, EventArgs e)
        {
            try
            {
               while (!(queue.isEmpty()))
               {
                    Plane p = queue.Peek(); // gets the maximum priority plane 
                    //itearete from datagridview to change the status
                    foreach (DataGridViewRow row in planeDataGridView.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[0].Value) == p.ID)
                        {
                            row.Cells[6].Value = "Request Granted...";
                            planeDataGridView.Refresh();
                            Thread.Sleep(600); //just to show that request granted
                            row.Cells[6].Value = "Landing...";
                            planeDataGridView.Refresh();
                            Thread.Sleep(p.runway);
                            row.Cells[6].Value = "Landed !";
                            row.Cells[5].Value = "--";
                            totalLanded++;
                            landedlabel.Text = totalLanded.ToString();
                            landedlabel.Refresh();

                            List<Plane> list = queue.getList();
                            for(int z=0;z<list.Count;z++)
                            {
                                list[z].fuel -= (list[z].buringRate * (p.runway/1000)); //updatig fuel
                                if (list[z].fuel <= 0)
                                {
                                    row.Cells[6].Value = "Crashed !!!";
                                    totalCrashed++;
                                    crashedlabel.Text = totalCrashed.ToString();
                                    crashedlabel.Refresh();
                                }
                                if (list[z].fuel < 4)
                                    list[z].priority = random.Next(0, 7);//updating priority
                                else
                                    list[z].priority -= (list[z].priority / 2) - (list[z].fuel / 2);

                            }
                            queue.Dequeue();
                            foreach (DataGridViewRow row1 in planeDataGridView.Rows)
                            {
                                if (!(row1.Cells[5].Value.Equals("--") || row.Cells[6].Value.Equals("Crashed !!!")) )
                                {
                                    for (int z = 0; z < list.Count; z++)
                                    {
                                       if(row1.Cells[0].Value.Equals((list[z].ID).ToString()))
                                       {
                                            row1.Cells[3].Value = list[z].fuel;
                                            row1.Cells[5].Value = list[z].priority;
                                       }
                                    }
                                }
                            }
                            planeDataGridView.Refresh();   
                        }  
                    }
               }  
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
