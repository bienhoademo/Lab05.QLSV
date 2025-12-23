using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Lab05.BUS.Services;

namespace Lab05.GUI
{
    public partial class ucDashboard : UserControl
    {
        private readonly DashboardService dashboardService = new DashboardService();

        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            try
            {
                lblTotalStudents.Text = dashboardService.GetTotalStudents().ToString();
                lblTotalFaculties.Text = dashboardService.GetTotalFaculties().ToString();

                SetupStudentByFacultyChart();
                SetupGpaStatisticsChart();
                SetupAverageGpaChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải Dashboard: " + ex.Message);
            }
        }

        private void SetupStudentByFacultyChart()
        {
            chartFaculty.Series.Clear();
            Series series = new Series
            {
                Name = "Students",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };
            chartFaculty.Series.Add(series);

            var data = dashboardService.GetStudentCountByFaculty();
            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value);
            }
            chartFaculty.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        private void SetupGpaStatisticsChart()
        {
            chartGPA.Series.Clear();
            Series series = new Series
            {
                Name = "GPA",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Column
            };
            chartGPA.Series.Add(series);

            var data = dashboardService.GetGpaStatistics();
            foreach (var item in data)
            {
                var point = series.Points.AddXY(item.Key, item.Value);
            }
            series["PointWidth"] = "0.6";
        }

        private void SetupAverageGpaChart()
        {
            chartAvgGPA.Series.Clear();
            Series series = new Series
            {
                Name = "Avg GPA",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Bar
            };
            chartAvgGPA.Series.Add(series);

            var data = dashboardService.GetAverageGpaByFaculty();
            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, Math.Round(item.Value, 2));
            }
        }
    }
}
