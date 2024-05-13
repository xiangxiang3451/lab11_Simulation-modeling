using MathNet.Numerics.Distributions;
using MathNet.Numerics.Statistics;

namespace Lab8._3
{
    // Partial class Form1, representing the main form of a Windows Forms application
    public partial class Form1 : Form
    {
        // Constructor, initializes the form components
        public Form1()
        {
            InitializeComponent();
        }

        // Create a random number generator
        private Random rand = new Random();
        // Significance level
        private const double alpha = 0.05;

        // Event handler method triggered when the text in the textbox changes
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // Enable the button and hide the error label
            button1.Enabled = true;
            errLabel.Visible = false;
        }

        // Event handler method for the "Button1" click event
        private void button1_Click(object sender, EventArgs e)
        {
            double a1;
            double a2;
            // Get the sample size N and the number of intervals K
            int N = (int)numericUpDown1.Value;
            int K = (int)intervalUpDawn.Value;

            // Throw an exception if K is greater than N
            if (K > N)
            {
                throw new Exception("");
            }

            // Create an array to store the normal distribution sample
            double[] normalDistribution = new double[N];
            // Get the mean and variance
            double mean = Double.Parse(Meaninput.Text);
            double variance = double.Parse(Varnput.Text);

            // Generate N random numbers following the specified mean and variance of a normal distribution
            for (int i = 0; i < N; i++)
            {
                a1 = rand.NextDouble();
                a2 = rand.NextDouble();
                normalDistribution[i] = (mean + variance * Math.Sqrt(-2 * Math.Log(a1)) * Math.Sin(2 * Math.PI * a2));
            }

            // Get the minimum and maximum values in the sample
            double min = normalDistribution.Min();
            double max = normalDistribution.Max();

            // Create a statistics array
            int[] statistic = new int[K];

            // Calculate the number of observations in each interval
            double step = (max - min) / K;
            for (int i = 0; i < N; i++)
            {
                int j = 0;
                while (j < K && normalDistribution[i] >= min + step * j)
                {
                    j++;
                }
                statistic[j - 1]++;
            }

            // Clear the chart data
            chart.Series[0].Points.Clear();
            // Add the statistics results to the chart
            for (int j = 0; j < K; j++)
            {
                chart.Series[0].Points.AddXY(j, statistic[j]);
            }

            // Calculate frequencies
            double[] freqs = statistic.Select(interval => (double)interval / (double)N).ToArray();

            // Calculate the expected mean and variance
            double eMean = getMean(freqs, step, min);
            double eVar = getVar(freqs, mean, step, min);
            // Display the mean and variance along with their relative errors
            Mean.Text = $"{eMean} ({(Math.Abs(eMean - mean) / mean) * 100}%)";
            Dispersion.Text = $"{eVar} ({(Math.Abs(eVar - variance) / variance) * 100}%)";

            // Calculate probabilities for each interval
            double[] probs = new double[K];
            for (int i = 0; i < K; i++)
            {
                double a = min + i * step;
                double b = min + (i + 1) * step;
                probs[i] = (b - a) * NormalPDF((b + a) / 2, mean, variance);
            }

            // Calculate the chi-square value
            double chiSquare = getChiSquare(statistic, probs, N);
            ChiSquare.Text = chiSquare.ToString();

            // Calculate the degrees of freedom
            int df = N - 1;
            // Get the critical value of the chi-square distribution
            double tableValue = ChiSquared.InvCDF(df, 1 - alpha);
            // Check if the hypothesis is accepted
            bool isAccepted = chiSquare <= tableValue;
            HypRes.Text = isAccepted ? "Accepted" : "Rejected";
        }

        // Normal distribution probability density function
        static double NormalPDF(double x, double mean, double stdDev)
        {
            double coefficient = 1.0 / (Math.Sqrt(2 * Math.PI) * stdDev);
            double exponent = Math.Exp(-(Math.Pow(x - mean, 2)) / (2 * Math.Pow(stdDev, 2)));

            return coefficient * exponent;
        }

        // Calculate the chi-square value
        private double getChiSquare(int[] observed, double[] expected, int N)
        {
            double chiSquare = 0;

            for (int i = 0; i < observed.Length; i++)
            {
                if (expected[i] > 0)
                    chiSquare += (observed[i] - (expected[i] * N)) * (observed[i] - (expected[i] * N)) / (expected[i] * N);
            }

            return chiSquare;
        }

        // Calculate the variance
        private double getVar(IList<double> freqs, double mean, double step, double min = 0)
        {
            double variance = 0;
            for (int i = 0; i < freqs.Count(); i++)
            {
                variance += freqs[i] * Math.Pow(min + step * i, 2);
            }
            return variance - Math.Pow(mean, 2);
        }

        // Calculate the mean
        private double getMean(IList<double> freqs, double step, double min = 0)
        {
            double sum = 0;
            for (int i = 0; i < freqs.Count(); i++)
            {
                sum += (double)freqs[i] * (min + i * step);
            }

            return sum;
        }

        // Button1 click event handler method overload
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Call the original button click event handler method
            button1_Click(sender, e);
        }
    }
}
