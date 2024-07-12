using HOTEL_MANAGEMENT_SYSTEM.Controllers;
using HOTEL_MANAGEMENT_SYSTEM.Models;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Guestdemographics_db : UserControl
    {
        private List<Guest> guests; // List to store guest data

        public Guestdemographics_db()
        {
            InitializeComponent();
            LoadGuestData(); // Load guest data from the database
        }

        private void LoadGuestData()
        {
            GuestController guestList = new GuestController();
            guests = guestList.GetAllGuests();

            // Now you can use 'guests' list for your data visualization or other operations
        }

        private void Guestdemographics_db_Load(object sender, EventArgs e)
        {
            PlotView PV = new PlotView();
            PV.Dock = DockStyle.Fill;
            this.Controls.Add(PV);

            // Define PlotModel and set background color
            PlotModel plotModel = new PlotModel
            {
                Title = "Guest Demographics",
                Background = OxyColor.FromRgb(240, 240, 240) // Light gray color
            };

            // Define X Axis as CategoryAxis for classifications
            CategoryAxis categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Classification"
            };
            categoryAxis.Labels.Add("25 to 34");
            categoryAxis.Labels.Add("45 to 54");
            categoryAxis.Labels.Add("64 or over");
            categoryAxis.Labels.Add("Male");
            categoryAxis.Labels.Add("Female");

            // Define Y Axis as LinearAxis for frequencies
            LinearAxis linearAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Frequency"
            };

            // Calculate age groups and sex frequencies based on 'guests' list
            int count18to34 = 0, count35to54 = 0, count54andUp = 0;
            int countMale = 0, countFemale = 0;

            foreach (var guest in guests)
            {
                int age = CalculateAge(guest.DateOfBirth);

                // Count guests in age groups
                if (age >= 18 && age <= 34)
                    count18to34++;
                else if (age >= 35 && age <= 54)
                    count35to54++;
                else if (age >= 55)
                    count54andUp++;

              /* // Count guests by sex
                if (guest.Gender == "Male")
                    countMale++;
                else if (guest.Gender == "Female")
                    countFemale++;*/ 
            }

            // Define LineSeries for Age groups
            LineSeries ageSeries = new LineSeries { Title = "Age" };
            ageSeries.Points.Add(new DataPoint(0, count18to34)); // 25 to 34
            ageSeries.Points.Add(new DataPoint(1, count35to54)); // 45 to 54
            ageSeries.Points.Add(new DataPoint(2, count54andUp)); // 64 or over

            // Define LineSeries for Sex groups
            LineSeries sexSeries = new LineSeries { Title = "Sex" };
            sexSeries.Points.Add(new DataPoint(3, countMale)); // Male
            sexSeries.Points.Add(new DataPoint(4, countFemale)); // Female

            // Add Axes and Series to the PlotModel
            plotModel.Axes.Add(categoryAxis);
            plotModel.Axes.Add(linearAxis);
            plotModel.Series.Add(ageSeries);
            plotModel.Series.Add(sexSeries);

            // Set the PlotModel to the PlotView
            PV.Model = plotModel;
        }

        private int CalculateAge(DateTime birthDate)
        {
            // Calculate age based on birth date
            DateTime now = DateTime.Today;
            int age = now.Year - birthDate.Year;
            if (birthDate > now.AddYears(-age))
                age--;

            return age;
        }
    }
}
