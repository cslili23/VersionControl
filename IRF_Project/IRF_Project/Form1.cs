using IRF_Project.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        private List<Video> videos = new List<Video>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                videos.Clear();
                using (StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split(';');
                        try
                        {
                            videos.Add(new Video()
                            {
                                Type = line[1],
                                Title = line[2],
                                Director = line[3],
                                Cast = line[4],
                                Country = line[5],
                                DateAdded = line[6],
                                ReleaseYear = int.Parse(line[7]),
                                Rating = line[8],
                                Duration = line[9],
                                Listedin = line[10],
                                Description = line[11],
                                Category = GetCategory(line[7]),
                            });
                        }

                        catch (Exception) { }
                    }
                }

                foreach(var video in videos)
                {
                    string[] data = new string[5];
                    data[0] = video.Title;
                    data[1] = video.Type;
                    data[2] = video.ReleaseYear.ToString();
                    data[3] = video.Duration;
                    data[4] = video.Country;
                    
                    dataGridView.Rows.Add(data);
                }
            }
        }

        private Category GetCategory(string year)
        {
            int category = int.Parse(year);
            if (category < 2000)
            {
                return Category.Old;
            }
            return Category.Modern;
        }
       
        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }

        private void export_Click(object sender, EventArgs e)
        {
            object[,] values = new object[videos.Count, 12];

            int counter = 0;
            foreach (Video video in videos)
            {
                values[counter, 0] = video.Type;
                values[counter, 1] = video.Title;
                values[counter, 2] = video.Director;
                values[counter, 3] = video.Cast;
                values[counter, 4] = video.Country;
                values[counter, 5] = video.DateAdded;
                values[counter, 6] = video.ReleaseYear;
                values[counter, 7] = video.Rating;
                values[counter, 8] = video.Duration;
                values[counter, 9] = video.Listedin;
                values[counter, 10] = video.Description;
                values[counter, 11] = video.Category;

                counter++;
            }

            Excel.Application xlApp = null;
            Excel.Workbook xlWB = null;
            Excel.Worksheet xlSheet = null;
            try
            {
                xlApp = new Excel.Application();

                xlWB = xlApp.Workbooks.Add(Missing.Value);

                xlSheet = xlWB.ActiveSheet;

                xlSheet.get_Range(
                    GetCell(1, 1),
                    GetCell(values.GetLength(0), values.GetLength(1))).Value2 = values;


                xlApp.Visible = true;
                xlApp.UserControl = true;
                xlWB.SaveAs("selected_videos");
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, System.Type.Missing, System.Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
    }
}
