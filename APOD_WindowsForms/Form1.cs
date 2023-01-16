using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json.Linq;

namespace APOD_WindowsForms
{
    public partial class Form1 : Form
    {
        //API del portal de la NASA
        const string EndpointURL = "https://api.nasa.gov/planetary/apod";

        //16 de Junio, 1995: fecha de lanzamiento del APOD
        DateTime launchDate = new DateTime(1995, 6, 16);

        //Contador de imagenes descargadas
        int imageCountToday;
        public Form1()
        {
            InitializeComponent();

            MonthCalendar.MaxDate = DateTime.Today;
            MonthCalendar.MinDate = launchDate; 
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            LimitRangeCheckBox.Checked = false;

            MonthCalendar.SelectionEnd = launchDate;
        }

        private void LimitRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LimitRangeCheckBox.Checked)
            {
                var thisYear = new DateTime(DateTime.Today.Year, 1, 1);
                MonthCalendar.MinDate = thisYear;
            }
            else
            {
                MonthCalendar.MinDate = launchDate;
            }
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private bool IsSupportedFormat(string photoURL)
        {
            string ext = Path.GetExtension(photoURL).ToLower();

            return (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif" ||
                ext == ".bmp" || ext == ".tif");
        }


    }
}
