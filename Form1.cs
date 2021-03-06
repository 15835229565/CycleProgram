﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace CycleComputerProgram
{
    public partial class Form1 : Form
    {
        List<string> ls = new List<string>();
        List<string> heartRateLs = new List<string>();
        List<string> speedLs = new List<string>();
        List<string> cadenceLs = new List<string>();
        List<string> altitudeLs = new List<string>();
        List<string> powerLs = new List<string>();
        List<string> powerBalanceAndPedallingIndexLs = new List<string>();
        String[] lsString, splitTabs, heartRate, speed, cadence, altitude, power, powerBalanceAndPedallingIndex;
        String splitLine, heartRateVal, speedVal, cadenceVal, altitudeVal, powerVal, powerBalanceAndPedallingIndexVal;
        int EuroUsType;
        double averagePower, maxPower, minPower, averageAltitude, maxAltitude;
        public GraphPane GraphPane;
        public GraphPane GraphPane2;
        int BPMPerType = 0;
        int maxHR = 1;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMaxHR_Click(object sender, EventArgs e)
        {
            // Get User's max HR
            maxHR = Convert.ToInt32(txtMaxHR.Text);
        }

        private void btnUpdateUnits_Click(object sender, EventArgs e)
        {
            if (checkBoxUS.Checked == true)
            {
                EuroUsType = 1;
            }
            else if (checkBoxEuro.Checked == true)
            {
                EuroUsType = 0;
            }
            if(checkBpm.Checked == true)
            {
                BPMPerType = 0;
            }
            else if(checkPer.Checked == true)
            {
                BPMPerType = 1;
            }
            findMainData();
        }

        private void lblAverageHeartRateTitle_Click(object sender, EventArgs e)
        {


        }

        private void lblSmode_Click(object sender, EventArgs e)
        {

        }

        int intHeartRate, intCadence, intAltitude, intPowerBalanceAndPedallingIndex;
        double intSpeed;
        DateTime date;
        DateTime startTime;
        int Interval;
        int intInterval = 0;
        public Form1()
        {
            InitializeComponent();
            zedGraphControl1.Visible = false;

        }


        private void importFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open File";
            theDialog.Filter = "HRM files|*.hrm";
            theDialog.InitialDirectory = @"C:\";

            string line;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {   // Open the text file using a stream reader.
                    using (StreamReader sr = new StreamReader(theDialog.FileName))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            // Read the stream to a string
                            String lines = line;
                            ls.Add(lines);
                        }

                        lsString = File.ReadAllLines(theDialog.FileName);
                        findHeaderData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading in file" + ex.Message);
                }
            }


        }
        private void enterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        public void findHeaderData()
        {
            String dateLine = "Date hasn't been succesfully extracted from file";
            String startTime = "Start Time hasn't been succesfully extracted from file";
            String interval = "Interval hasn't been extracted";
            String smode = "Smode hasn't been sucessfully extracted from file";

            // Using index of function is probably a better way
            smode = ls[3].ToString().Substring(6, 9);
            dateLine = ls[4].ToString().Substring(5, 8);
            startTime = ls[5].ToString().Substring(10, 10);
            interval = (ls[7].ToString().Substring(9, 1));


            //Get Us or Euro type from SMode
            EuroUsType = Int32.Parse(smode.Substring(7, 1));
            //Change interval from string to int 
            intInterval = Convert.ToInt32(interval);
            //Change the date into dd/mm/yyyy format
            DateTime dateLineUk = DateTime.ParseExact(dateLine, "yyyyddMM", CultureInfo.InvariantCulture);

            //Displaying the variable onto labels
            lblDate.Text = dateLineUk.ToString("yyyyddMM");
            lblTime.Text = startTime;
            lblInterval.Text = interval;
            lblSmode.Text = smode;

            Console.WriteLine(lsString);
            findMainData();
        }
        public void findMainData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            //Getting interval and displaying in dataGridView
            DateTime dateTime = new DateTime(2018, 01, 01, 0, 0, 0);

            

            dataGridView1.Columns.Add("Time", "Time");
            if (BPMPerType== 0)
            {
                checkBpm.Checked = true;
                checkPer.Checked = false;
                dataGridView1.Columns.Add("HeartRate", "Heart Rate (BPM)");
            }
            else if (BPMPerType == 1)
            {
                checkBpm.Checked = false;
                checkPer.Checked = true;
                dataGridView1.Columns.Add("HeartRate", "Heart Rate (Max HR %)");
            }
            
            if (EuroUsType == 0)
            {
                checkBoxEuro.Checked = true;
                checkBoxUS.Checked = false;
                dataGridView1.Columns.Add("Speed", "Speed (km/h)");
            }
            else if (EuroUsType == 1)
            {
                checkBoxUS.Checked = true;
                checkBoxEuro.Checked = false;
                dataGridView1.Columns.Add("Speed", "Speed (mph)");
            }
            dataGridView1.Columns.Add("Cadence", "Cadence(RPM)");
            if (EuroUsType == 0)
            {
                dataGridView1.Columns.Add("Altitude", "Altitude(m)");
            }
            else
            {
                dataGridView1.Columns.Add("Altitude", "Altitude(ft)");
            }
            dataGridView1.Columns.Add("Power", "Power");
            dataGridView1.Columns.Add("PowerBalanceandPedalingIndex", "Power Balance + Pedaling Index");
            for (int i = 0; i < lsString.Length; i++)
            {
                splitLine = lsString[i];

                if (splitLine.Contains("[HRData]"))
                {
                    //finds the line number of HRData then reads the rest of the file
                    for (int a = (i + 1); a < lsString.Length; a++)
                    {
                        dateTime = dateTime.AddSeconds(intInterval);
                        string splitA = lsString[a];
                        splitTabs = splitA.Split('\t');

                        heartRateVal = splitTabs[0];
                        speedVal = splitTabs[1];
                        cadenceVal = splitTabs[2];
                        altitudeVal = splitTabs[3];
                        powerVal = splitTabs[4];
                        powerBalanceAndPedallingIndexVal = splitTabs[5];

                        heartRateLs.Add(heartRateVal);
                        speedLs.Add(speedVal);
                        cadenceLs.Add(cadenceVal);
                        altitudeLs.Add(altitudeVal);
                        powerLs.Add(powerVal);
                        powerBalanceAndPedallingIndexLs.Add(powerBalanceAndPedallingIndexVal);

                        //Converting the value to integers for the calculations
                        intHeartRate = Convert.ToInt32(splitTabs[0]);
                        intSpeed = Convert.ToInt32(splitTabs[1]);
                        intCadence = Convert.ToInt32(splitTabs[2]);
                        intAltitude = Convert.ToInt32(splitTabs[3]);
                        intPowerBalanceAndPedallingIndex = Convert.ToInt32(splitTabs[4]);
                        //Getting heart rate as a percentage of the person max HR

                        double dintHeartRate = Convert.ToDouble(intHeartRate);
                        double dmaxHR = Convert.ToDouble(maxHR);

                        double perHR = (dintHeartRate/dmaxHR)*100;

                        double rperHR = Math.Round(perHR, 2);

                        //Converting speed between KM and MPH for US and Euro
                        double speedKM = (intSpeed / 10);
                        double speedMPH = (speedKM * 0.6214);

                        //Converting altitude between ft and m
                        double altitudeFT = (intAltitude * 3.28084);
                        //Round US altitude and speed to 2DP
                        speedMPH = Math.Round(speedMPH, 2);
                        altitudeFT = Math.Round(altitudeFT, 2);
                        if (EuroUsType == 0 && BPMPerType == 0)
                        {
                            dataGridView1.Rows.Add(dateTime.ToString("HH:mm:ss"), splitTabs[0], speedKM, splitTabs[2], splitTabs[3], splitTabs[4], splitTabs[5]);
                        }
                        else if(EuroUsType == 1 && BPMPerType == 0)
                        {
                            dataGridView1.Rows.Add(dateTime.ToString("HH:mm:ss"), splitTabs[0], speedMPH, splitTabs[2], altitudeFT, splitTabs[4], splitTabs[5]);
                        }
                        else if(EuroUsType == 0 && BPMPerType == 1)
                        {
                            dataGridView1.Rows.Add(dateTime.ToString("HH:mm:ss"), rperHR, speedKM, splitTabs[2], splitTabs[3], splitTabs[4], splitTabs[5]);
                        }
                        else if (EuroUsType == 1 && BPMPerType == 1)
                        {
                            dataGridView1.Rows.Add(dateTime.ToString("HH:mm:ss"), rperHR, speedMPH, splitTabs[2], altitudeFT, splitTabs[4], splitTabs[5]);
                        }
                    }

                }
                else
                {

                }


            }
            calculateSummaryData();
        }
        public void calculateSummaryData()
        {
            double averageSpeed, maxSpeed, totalDistance;
            averageSpeed = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                averageSpeed += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }

            averageSpeed = averageSpeed / dataGridView1.Rows.Count;
            averageSpeed = Math.Round(averageSpeed, 2);
            lblAverageSpeed.Text = averageSpeed.ToString();
            if (EuroUsType == 0)
            {
                lblAverageSpeedTitle.Text = "Average Speed (km/h)";
            }
            else if (EuroUsType == 1)
            {
                lblAverageSpeedTitle.Text = "Average Speed (MPH)";
            }
            maxSpeed = dataGridView1.Rows.Cast<DataGridViewRow>()
                       .Max(r => Convert.ToInt32(r.Cells[2].Value));

            lblMaxSpeed.Text = maxSpeed.ToString();
            if (EuroUsType == 0)
            {
                lblMaxSpeedTitle.Text = "Max Speed (km/h)";
            }
            else if (EuroUsType == 1)
            {
                lblMaxSpeedTitle.Text = "Max Speed (MPH)";
            }
            //Calculate total distance travelled 







            double averageHR, maxHR, minHR;
            //Calculate average HR
            averageHR = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                averageHR += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }

            averageHR = averageHR / dataGridView1.Rows.Count;
            averageHR = Math.Round(averageHR, 2);

            lblAverageHeartRate.Text = averageHR.ToString();


            //Calculate max HR
            maxHR = dataGridView1.Rows.Cast<DataGridViewRow>()
                       .Max(r => Convert.ToInt32(r.Cells[1].Value));

            lblMaxHeartRate.Text = maxHR.ToString();


            //Calculate min HR
            minHR = dataGridView1.Rows.Cast<DataGridViewRow>()
                        .Min(r => Convert.ToInt32(r.Cells[1].Value));
            lblMinHeartRate.Text = minHR.ToString();



            averagePower = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                averagePower += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            averagePower = averagePower / dataGridView1.Rows.Count;


            //Maximum power
            maxPower = dataGridView1.Rows.Cast<DataGridViewRow>()
                      .Max(r => Convert.ToInt32(r.Cells[5].Value));
            //Minimum power
            minPower = dataGridView1.Rows.Cast<DataGridViewRow>()
                       .Min(r => Convert.ToInt32(r.Cells[5].Value));

            //Prints max and average power too labels
            averagePower = Math.Round(averagePower, 2);
            lblAveragePower.Text = averagePower.ToString();
            lblMaxPower.Text = maxPower.ToString();




            averageAltitude = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                averageAltitude += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            averageAltitude = averageAltitude / dataGridView1.Rows.Count;

            //Maximum Altitude
            maxAltitude = dataGridView1.Rows.Cast<DataGridViewRow>()
                      .Max(r => Convert.ToInt32(r.Cells[4].Value));
            averageAltitude = Math.Round(averageAltitude, 2);

            lblAverageAltitude.Text = averageAltitude.ToString();
            lblMaxAltitude.Text = maxAltitude.ToString();

            if (EuroUsType == 0)
            {
                lblAverageAltitudeTitle.Text = "Average Altitude (m)";
                lblMaxAltitudeTitle.Text = "Max Altitude (m)";
            }
            else if (EuroUsType == 1)
            {
                lblAverageAltitudeTitle.Text = "Average Altitude (ft)";
                lblMaxAltitudeTitle.Text = "Max Altitude (ft)";
            }

            CreateGraph();
        }

        private void CreateGraph()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.CurveList.Clear();
            myPane.Title = "Cycling Data";
            myPane.XAxis.Title = "Time";
            myPane.YAxis.Title = "Values";

            

            //Creates data arrays based on the Sine function
            double x, y1, y2,y3,y4,y5;
            PointPairList hrList = new PointPairList();
            PointPairList speedList = new PointPairList();
            PointPairList rpmList = new PointPairList();
            PointPairList altitudeList = new PointPairList();
            PointPairList powerList = new PointPairList();

            //HR,Speed,RPM,Altitude,Power
            for (int i = 0; i < dataGridView1.Rows.Count; i = i + 30)
            {
                x = i;
                y1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                y2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                y3 = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                y4 = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                y5 = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);

                hrList.Add(x, y1);
                speedList.Add(x, y2);
                rpmList.Add(x, y3);
                altitudeList.Add(x, y4);
                powerList.Add(x, y5);
            }
            
            //Add heart rate
            LineItem curve;
            curve = myPane.AddCurve("Heart Rate", hrList, Color.Blue);
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.Size = 1;
            curve.Line.Width = 4.0F;

            //Add Speed
            LineItem curve1;
            curve1 = myPane.AddCurve("Speed", speedList, Color.Yellow);
            curve1.Symbol.Fill = new Fill(Color.White);
            curve1.Symbol.Size = 1;
            curve1.Line.Width = 4.0F;

            //Add RPM
            LineItem curve2;
            curve2 = myPane.AddCurve("RPM", rpmList, Color.LightCyan);
            curve2.Symbol.Fill = new Fill(Color.White);
            curve2.Symbol.Size = 1;
            curve2.Line.Width = 4.0F;

            //Add Altitude
            LineItem curve3;
            curve3 = myPane.AddCurve("Altitude", altitudeList, Color.ForestGreen);
            curve3.Symbol.Fill = new Fill(Color.White);
            curve3.Symbol.Size = 1;
            curve3.Line.Width = 4.0F;

            //Add Power
            LineItem curve4;
            curve4 = myPane.AddCurve("Power", powerList, Color.Honeydew);
            curve4.Symbol.Fill = new Fill(Color.White);
            curve4.Symbol.Size = 1;
            curve4.Line.Width = 4.0F;
            zedGraphControl1.AxisChange();
            SetSize();

        }


        private void SetSize()
        {
            zedGraphControl1.Visible = true;
            zedGraphControl1.Location = new Point(200, 30);
            zedGraphControl1.IsShowPointValues = true;
            // Leave a small margin around the outside of the control
            zedGraphControl1.Size = new Size(700, 275);

        }
    }
}


