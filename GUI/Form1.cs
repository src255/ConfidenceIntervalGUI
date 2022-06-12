using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.DataVisualization.Charting;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate1_Click(object sender, EventArgs e)
        {
            if (NumOfSamples1.Text == "" || Mean.Text == "" || SampleStdDev.Text == "" || ConfLvl1.Text == "")
            {
                value1.Text = "ValueError:";
                error1.Text = "All values are required.";
                error1.BackColor = Color.White;
                return;
            }
            else
            {
                error1.Text = "";
                error1.BackColor = Color.Transparent;
            }

            // load field values into variables
            int.TryParse(NumOfSamples1.Text, out int N);
            double.TryParse(Mean.Text, out double mu_y);
            double.TryParse(SampleStdDev.Text, out double S_y);
            double.TryParse(ConfLvl1.Text, out double alpha);
            alpha  = 1 - alpha / 100;
            if (N < 2)
            {
                value1.Text = "RangeError:";
                error1.Text = "Number of samples must be a positive integer greater than 1.";
                error1.BackColor = Color.White;
                return;
            }
            else if (S_y < 0)
            {
                value1.Text = "RangeError:";
                error1.Text = "Sample standard deviation must be nonnegative.";
                error1.BackColor = Color.White;
                return;
            }
            else if (alpha < 0 || alpha > 100)
            {
                value1.Text = "RangeError:";
                error1.Text = "Confidence level must be between 0 and 100 (inclusive).";
                error1.BackColor = Color.White;
                return;
            }

            // find z-value for confidence level α, standard error, and marigin of error
            Chart chart = new Chart();
            double t = chart.DataManipulator.Statistics.InverseTDistribution(alpha, N - 1);
            double stdErr = (N != 0) ? S_y / Math.Sqrt(N) : 0;
            double marginErr = t * stdErr;

            double[] interval = { mu_y - marginErr, mu_y + marginErr };

            value1.Text = $"Interval: [{interval[0]:F3}, {interval[1]:F3}]";

        }

        private void Calculate2_Click(object sender, EventArgs e)
        {
            if (NumOfSamples2.Text == "" || Instances.Text == "" || ConfLvl2.Text == "")
            {
                value2.Text = "ValueError:";
                error2.Text = "All values are required.";
                error2.BackColor = Color.White;
                return;
            }
            else
            {
                error2.Text = "";
                error2.BackColor = Color.Transparent;
            }
            // load field values
            int.TryParse(NumOfSamples2.Text, out int N);
            int.TryParse(Instances.Text, out int occurrences);
            double.TryParse(ConfLvl2.Text, out double alpha);
            alpha = 1 - alpha / 100;
            if (N <= 0)
            {
                value2.Text = "RangeError:";
                error2.Text = "Number of samples must be a positive integer.";
                error2.BackColor = Color.White;
            }
            else if (occurrences < 0)
            {
                value2.Text = "RangeError:";
                error2.Text = "Occurrences must be a nonnegative integer.";
                error2.BackColor = Color.White;
            }
            else if (alpha < 0 || alpha > 100)
            {
                value2.Text = "RangeError:";
                error2.Text = "Confidence level must be between 0 and 100 (inclusive).";
                error2.BackColor = Color.White;
                return;
            }

            // compute point estimate
            double point_estimate = (N != 0) ? Convert.ToDouble(occurrences) / N : 0;

            // find z-value for confidence level α
            Chart chart = new Chart();
            double z = chart.DataManipulator.Statistics.InverseNormalDistribution(1 - alpha / 2);

            // compute standard error and margin of error
            double stdErr = Math.Sqrt((point_estimate * (1 - point_estimate)) / N);
            double marginErr = z * stdErr;

            double[] interval = { point_estimate - marginErr, point_estimate + marginErr };

            value2.Text = $"Interval: [{interval[0] * 100:F3}%, {interval[1] * 100:F3}%]";

        }

        private void NumOfSamples1_GotFocus(object sender, EventArgs e)
        {
            AcceptButton = Calculate1;
        }

        private void Mean_GotFocus(object sender, EventArgs e)
        {
            AcceptButton = Calculate1;
        }

        private void SampleStdDev_GotFocus(object sender, EventArgs e)
        {
            AcceptButton = Calculate1;
        }

        private void ConfLvl1_GotFocus(object sender, EventArgs e)
        {
            AcceptButton = Calculate1;
        }
        private void NumOfSamples2_GotFocus(object sender, EventArgs e)
        {
            AcceptButton = Calculate2;
        }

        private void Instances_GotFocus(object sender, EventArgs e)
        {
            AcceptButton = Calculate2;
        }

        private void ConfLvl2_GotFocus(object sender, EventArgs e)
        {
            AcceptButton = Calculate2;
        }

    }
}
