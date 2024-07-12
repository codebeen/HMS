    using HOTEL_MANAGEMENT_SYSTEM.Models;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class OccupancyRate_db : UserControl
    {
        public OccupancyRate_db()
        {
            InitializeComponent();
        }

        private void OccupancyRate_db_Load(object sender, EventArgs e)
        {
            PlotView PV = new PlotView();
            PV.Dock = DockStyle.Fill;
            this.Controls.Add(PV);

            // Define PlotModel and set background color
            PlotModel plotModel = new PlotModel
            {
                Title = "Occupancy Rate",
                Background = OxyColor.FromRgb(240, 240, 240) // Light gray color
            };

            // Define X Axis as CategoryAxis for classifications
            CategoryAxis categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Room Type",
                TextColor = OxyColors.Black, // Set text color
                TitleColor = OxyColors.Black // Set title color
            };
            categoryAxis.Labels.Add("Standard Room");
            categoryAxis.Labels.Add("Deluxe Room");
            categoryAxis.Labels.Add("Suites");

            // Define Y Axis as LinearAxis for occupancy rates
            LinearAxis linearAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Occupancy Rate (%)",
                TextColor = OxyColors.Black, // Set text color
                TitleColor = OxyColors.Black // Set title color
            };

            // Retrieve data from database and calculate occupancy rates
            using (var context = new DataContext())
            {
                var standardRoomCount = context.Bookings.Count(b => b.RoomType == "Standard Room");
                var deluxeRoomCount = context.Bookings.Count(b => b.RoomType == "Deluxe Room");
                var suitesCount = context.Bookings.Count(b => b.RoomType == "Suites");

                // Define LineSeries for different room types
                LineSeries occupancySeries = new LineSeries { Title = "Occupancy Rate" };
                occupancySeries.Points.Add(new DataPoint(0, standardRoomCount)); // Standard Room
                occupancySeries.Points.Add(new DataPoint(1, deluxeRoomCount)); // Deluxe Room
                occupancySeries.Points.Add(new DataPoint(2, suitesCount)); // Suites

                // Add Axes and Series to the PlotModel
                plotModel.Axes.Add(categoryAxis);
                plotModel.Axes.Add(linearAxis);
                plotModel.Series.Add(occupancySeries);

                // Set the PlotModel to the PlotView
                PV.Model = plotModel;
            }
        }
    }
}