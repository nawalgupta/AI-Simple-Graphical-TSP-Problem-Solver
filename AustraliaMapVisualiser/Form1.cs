using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Simple_Graphical_TSP.environment.map;

namespace AustraliaMapVisualizer
{
    public partial class Form1 : Form
    {
        public readonly List<City> AllCities;
        public readonly SimplifiedRoadMapOfAustralia MapWithCities;
        public readonly int NumberOfCities;
        private int _temperature;
        public List<City> FinalCityPath;

        public Form1()
        {
            InitializeComponent();
            MapWithCities = new SimplifiedRoadMapOfAustralia();
            Algorithms = new Algorithms(this);
            NumberOfCities = MapWithCities.getLocations().Count;
            AllCities = new List<City>();
            foreach (var location in MapWithCities.getLocations())
                AllCities.Add(new City(location,
                    MapWithCities.getPosition(location),
                    MapWithCities.getPossibleNextLocations(location)));
            solveButton.Enabled = true;
            panelMain.Paint += PanelMainPaint;
        }

        public string RouteStartPosition { get; set; }
        public string RouteEndPosition { get; set; }
        public double TourDistance { get; set; }

        public void PanelMainPaint(object sender, PaintEventArgs e) => new PanelMainPainter(this).PanelMainPaint(sender, e);

        private async void SolveButton_ClickAsync(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();

            FinalCityPath = await Algorithms.GreedyAlgorithm();

            textBoxLeftSide.Text += "Cities in total: \r\n";
            textBoxLeftSide.Text += $"{NumberOfCities}\r\n";

            #region Comment

            //switch (method)
            //{
            //    case 0:
            //        for (int i = 0; i < 40000 * restarts; i++)
            //        {
            //            SS = algos.SDLS(numberOfCitys, S, out fS);
            //            S = new List<City>(SS);

            //            if (fS < bestfS)
            //            {
            //                bestfS = fS;
            //                best = S.ToArray();
            //            }
            //        }

            //        break;
            //    case 1:
            //        for (int i = 0; i < restarts; i++)
            //        {
            //            SS = algos.TabuSearch(numberOfCitys, 1000 * numberOfCitys, S, out fS);
            //            S = new List<City>(SS);

            //            if (fS < bestfS)
            //            {
            //                bestfS = fS;
            //                best = S.ToArray();
            //            }
            //        }

            //        break;
            //    case 2:
            //        for (int i = 0; i < restarts; i++)
            //        {
            //            result = algos.EvolutionaryHillClimber(numberOfCitys, 10000 * numberOfCitys, 100 * numberOfCitys,
            //                S.ToArray(), out fS, ref chromosome, ref fitness);
            //            S = new List<City>(result);

            //            if (fS < bestfS)
            //            {
            //                bestfS = fS;
            //                best = S.ToArray();
            //            }
            //        }

            //        break;
            //    case 3:
            //        for (int i = 0; i < restarts; i++)
            //        {
            //            result = algos.GeneticAlgortihm(0.10, 1.00, numberOfCitys, 10000 * numberOfCitys, 100 * numberOfCitys,
            //                S.ToArray(), out fS, ref chromosome, ref fitness);
            //            S = new List<City>(result);

            //            if (fS < bestfS)
            //            {
            //                bestfS = fS;
            //                best = S.ToArray();
            //            }
            //        }

            //        break;
            //    case 4:
            //        int count1, count2, count3, count4;

            //        for (int i = 0; i < restarts; i++)
            //        {
            //            algos.GreedyAlgorithm(numberOfCitys, 10000, 10000 * numberOfCitys, numberOfCitys, S.ToArray(),
            //                out result, out fS, out count1, out count2, out count3, out count4);
            //            S = new List<City>(result);

            //            if (fS < bestfS)
            //            {
            //                bestfS = fS;
            //                best = S.ToArray();
            //            }
            //        }

            //        if (saga)
            //            goto case 3;

            //        break;
            //    case 5:
            //        saga = true;
            //        goto case 4;
            //    case 6:
            //        for (int i = 0; i < restarts; i++)
            //        {
            //            algos.GreedyAlgorithm(numberOfCitys, 10000, 100000, 20, S.ToArray(),
            //                out result, out fS, out count1, out count2, out count3, out count4);
            //            S = new List<City>(result);

            //            if (fS < bestfS)
            //            {
            //                bestfS = fS;
            //                best = S.ToArray();
            //            }

            //            result = algos.GeneticAlgortihm(0.10, 1.00, numberOfCitys, 10000 * numberOfCitys, 100 * numberOfCitys,
            //                S.ToArray(), out fS, ref chromosome, ref fitness);
            //            S = new List<City>(result);

            //            if (fS < bestfS)
            //            {
            //                bestfS = fS;
            //                best = S.ToArray();
            //            }
            //        }

            //        break;
            //    case 7:
            //        for (int i = 0; i < restarts; i++)
            //        {
            //            algos.SASDLS(numberOfCitys, 10000, 5000, 10, S.ToArray(),
            //                out result, out fS, out count1, out count2, out count3, out count4);
            //            S = new List<City>(result);

            //            if (fS < bestfS)
            //            {
            //                bestfS = fS;
            //                best = S.ToArray();
            //            }
            //        }

            //        break;
            //    case 8:
            //        if (numberOfCitys <= 9)
            //            best = algos.BruteForce(numberOfCitys, lCity.ToArray(), out bestfS);

            //        else
            //        {
            //            MessageBox.Show("For Brute Force numberOfCitys must be < 10", "Warning Message",
            //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //        break;
            //}

            #endregion

            textBoxLeftSide.Text += "Cities in Solution: \r\n";
            textBoxLeftSide.Text += $"{FinalCityPath.Count.ToString("F2")}\r\n";
            sw.Stop();
            PrintTime(sw);

            panelMain.Invalidate();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void PrintTime(Stopwatch sw)
        {
            TimeSpan ts = sw.Elapsed;

            textBoxLeftSide.Text += "Time needed: \r\n";
            textBoxLeftSide.Text += $"{ts.Minutes.ToString("D2")}:";
            textBoxLeftSide.Text += $"{ts.Seconds.ToString("D2")}.";
            textBoxLeftSide.Text += $"{ts.Milliseconds.ToString("D3")}\r\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxStartPoint.DataSource = AllCities.Select(city => city.Name).ToList();
            comboBoxStartPoint.SelectedIndex = 7;
            comboBoxEndPoint.DataSource = AllCities.Select(city => city.Name).ToList();
            comboBoxEndPoint.SelectedIndex = 10;
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {
        }

        private void ComboBoxEndPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            RouteEndPosition = comboBoxEndPoint?.SelectedItem?.ToString();
            panelMain.Invalidate();
        }

        private void ComboBoxStartPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            RouteStartPosition = comboBoxStartPoint?.SelectedItem?.ToString();
            panelMain.Invalidate();
        }

        private void NumericUpDownTemperature_ValueChanged(object sender, EventArgs e) => _temperature = (int)numericUpDownTemprature.Value;
    }
}