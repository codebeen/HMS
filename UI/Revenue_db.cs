using HOTEL_MANAGEMENT_SYSTEM.Models;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Revenue_db : UserControl
    {
        public Revenue_db()
        {
            InitializeComponent();
        }

        private void Revenue_db_Load(object sender, EventArgs e)
        {
            PlotView PV = new PlotView();
            PV.Dock = DockStyle.Fill;
            this.Controls.Add(PV);

            // Define PlotModel and set background color
            PlotModel plotModel = new PlotModel
            {
                Title = "Revenue",
                Background = OxyColor.FromRgb(240, 240, 240) // Light gray color
            };

            // Define X Axis as CategoryAxis for months
            CategoryAxis categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Month"
            };

            // Define Y Axis as LinearAxis for revenues
            LinearAxis linearAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Revenue"
            };

            // Retrieve data from database and calculate revenues
            using (var context = new DataContext())
            {
                var revenueData = context.Payments
                    .GroupBy(p => new { p.PaymentDate.Month, p.PaymentMethod })
                    .Select(g => new
                    {
                        Month = g.Key.Month,
                        PaymentMethod = g.Key.PaymentMethod,
                        TotalAmount = g.Sum(p => p.Amount)
                    })
                    .ToList();

                // Determine months with data
                var availableMonths = revenueData.Select(r => r.Month).Distinct().OrderBy(m => m).ToList();

                // Create a dictionary to map payment methods to numerical values
                Dictionary<string, double> paymentMethodMap = new Dictionary<string, double>();
                int index = 0;
                foreach (var method in revenueData.Select(r => r.PaymentMethod).Distinct())
                {
                    paymentMethodMap[method] = index++;
                }

                // Create LineSeries for each month's revenue
                foreach (var month in availableMonths)
                {
                    var monthRevenueData = revenueData.Where(r => r.Month == month).ToList();

                    LineSeries monthSeries = new LineSeries
                    {
                        Title = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month),
                        StrokeThickness = 2
                    };

                    foreach (var data in monthRevenueData)
                    {
                        // Use the mapped value for PaymentMethod as X, and TotalAmount as Y
                        double xValue = paymentMethodMap[data.PaymentMethod];
                        double yValue = data.TotalAmount;
                        monthSeries.Points.Add(new DataPoint(xValue, yValue));
                    }

                    plotModel.Series.Add(monthSeries);
                }

                // Add Axes to the PlotModel
                plotModel.Axes.Add(categoryAxis);
                plotModel.Axes.Add(linearAxis);

                // Set the PlotModel to the PlotView
                PV.Model = plotModel;
            }
        }

    }
}