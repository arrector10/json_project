using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace json_project_form
{
    public partial class Form1 : Form
    {
        private readonly string _path = @"C:\Users\alici\source\repos\json_project\artists.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_output.Clear();
            txt_enter.Clear();

        }

        private void btn_json_file_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonFromFile;
                using (var sreader = new StreamReader(_path))
                {
                    jsonFromFile = sreader.ReadToEnd();
                }

                txt_output.Text = jsonFromFile;

                //var artistFromJson = JsonConvert.DeserializeObject<Artist>(jsonFromFile);


            }
            catch (Exception ex)
            {

            }
        }
    }


    public class Rootobject
    {
        public Artist[] artists { get; set; }
    }

    public class Artist
    {
        public string name { get; set; }
        public string DOB { get; set; }
        public string DOD { get; set; }
        public string married { get; set; }
        public Work[] works { get; set; }
    }

    public class Work
    {
        public string title { get; set; }
        public string type { get; set; }
        public string year { get; set; }
    }

}
