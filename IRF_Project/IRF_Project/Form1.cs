using IRF_Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
