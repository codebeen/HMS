using HOTEL_MANAGEMENT_SYSTEM.Models;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
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

            // Define X Axis as CategoryAxis for dates
            CategoryAxis categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Date"
            };
            categoryAxis.Labels.Add("Day Before Yesterday");
            categoryAxis.Labels.Add("Yesterday");
            categoryAxis.Labels.Add("Today");

            // Define Y Axis as LinearAxis for revenues
            LinearAxis linearAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Amount per Type of Payment (PHP)"
            };

            // Retrieve data from database and calculate revenues
            using (var context = new DataContext())
            {
                DateTime today = DateTime.Today;
                DateTime yesterday = today.AddDays(-1);
                DateTime dayBeforeYesterday = today.AddDays(-2);

                var revenueData = context.Payments
                    .Where(p => p.PaymentDate.Date == today || p.PaymentDate.Date == yesterday || p.PaymentDate.Date == dayBeforeYesterday)
                    .GroupBy(p => new { p.PaymentDate.Date, p.PaymentMethod })
                    .Select(g => new
                    {
                        Date = g.Key.Date,
                        PaymentMethod = g.Key.PaymentMethod,
                        TotalAmount = g.Sum(p => p.Amount)
                    })
                    .ToList();

                // Define BarSeries for different dates
                BarSeries dayBeforeYesterdaySeries = new BarSeries { Title = "Day Before Yesterday" };
                BarSeries yesterdaySeries = new BarSeries { Title = "Yesterday" };
                BarSeries todaySeries = new BarSeries { Title = "Today" };

                foreach (var data in revenueData)
                {
                    BarItem barItem = new BarItem(data.TotalAmount);

                    if (data.Date == dayBeforeYesterday)
                    {
                        dayBeforeYesterdaySeries.Items.Add(barItem);
                    }
                    else if (data.Date == yesterday)
                    {
                        yesterdaySeries.Items.Add(barItem);
                    }
                    else if (data.Date == today)
                    {
                        todaySeries.Items.Add(barItem);
                    }
                }

                // Add Axes and Series to the PlotModel
                plotModel.Axes.Add(categoryAxis);
                plotModel.Axes.Add(linearAxis);
                plotModel.Series.Add(dayBeforeYesterdaySeries);
                plotModel.Series.Add(yesterdaySeries);
                plotModel.Series.Add(todaySeries);

                // Set the PlotModel to the PlotView
                PV.Model = plotModel;
            }
        }
    }   
}