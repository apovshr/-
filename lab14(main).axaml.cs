using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Globalization;

namespace lab14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static bool Parse(string s, out double v)
        {
            s = (s ?? string.Empty).Trim().Replace(',', '.');
            return double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out v);
        }

        private void ClearButton_Click(object? sender, RoutedEventArgs e)
        {
            ResultsList.Items.Clear();
        }

        private void StartButton_Click(object? sender, RoutedEventArgs e)
        {
            ResultsList.Items.Clear();

            if (!Parse(XMinBox.Text, out double xMin)
                || !Parse(XMaxBox.Text, out double xMax)
                || !Parse(DxBox.Text, out double dx)
                || !Parse(KBox.Text, out double k)
                || !Parse(BetaBox.Text, out double beta))
            {
                ResultsList.Items.Add("Invalid input");
                return;
            }

            if (dx == 0)
            {
                ResultsList.Items.Add("dx cannot be zero");
                return;
            }

            bool forward = dx > 0;
            if (forward && xMin > xMax)
            {
                ResultsList.Items.Add("x_min must be <= x_max for positive dx");
                return;
            }
            if (!forward && xMin < xMax)
            {
                ResultsList.Items.Add("x_min must be >= x_max for negative dx");
                return;
            }

            const int maxIter = 100000;
            int iter = 0;

            for (double x = xMin; forward ? x <= xMax : x >= xMax; x += dx)
            {
                if (++iter > maxIter)
                {
                    ResultsList.Items.Add("Iteration limit exceeded");
                    break;
                }

                double rad = Math.Cos(x) - x * x * x;
                if (rad < 0)
                {
                    ResultsList.Items.Add($"For x={x:G6}: sqrt(cos(x)-x^3) < 0");
                    continue;
                }

                double cb = Math.Cos(beta * x);
                if (Math.Abs(cb) < 1e-12)
                {
                    ResultsList.Items.Add($"For x={x:G6}: cos(beta*x) = 0");
                    continue;
                }

                double z = Math.Sqrt(rad) + (0.628 * x + k) / (cb * cb);
                ResultsList.Items.Add($"For x={x:G6} result y={z:G6}");
            }
        }
    }
}
