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
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json.Serialization;


namespace json_project_form
{
    public class ArtistGroup
    {
        public List<Artist> artists { get; set; }
        //public Artist[] artists { get; set; }
    }

    public class Artist
    {
        public string name { get; set; }
        public string DOB { get; set; }
        public string DOD { get; set; }
        public bool married { get; set; }
        //public Work[] works { get; set; }
        public List<Work> works { get; set; }
    
    }

    public class Work
    {
        public string title { get; set; }
        public string type { get; set; }
        public string year { get; set; }
    }

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
                /*string jsonFromFile;
                using (var sreader = new StreamReader(_path))
                {
                    jsonFromFile = sreader.ReadToEnd();
                }

                txt_output.Text = jsonFromFile;*/

                //var artistFromJson = JsonConvert.DeserializeObject<Artist>(jsonFromFile);

                var jsonFromFile = File.ReadAllText(_path);
                txt_output.Text = jsonFromFile;

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_artist_Click(object sender, EventArgs e)
        {
            string json_input = txt_enter.Text;
            JObject myJson = JObject.Parse(json_input);

           //string artistName = myJson.GetValue("name").ToString();


            var artist = GetArtist(myJson);

            var jsonFromFile = System.IO.File.ReadAllText(_path);

            //var newArtist = JsonConvert.SerializeObject(artist, Formatting.Indented);
            ArtistGroup artistsData = JsonConvert.DeserializeObject<ArtistGroup>(jsonFromFile);
            //string blah = "";
            artistsData.artists.Add(artist);
            
            var convertedJson = JsonConvert.SerializeObject(artistsData, Formatting.Indented);
            
            System.IO.File.WriteAllText(_path, convertedJson );
            //break here

        }

        private Artist GetArtist(JObject transferObject)
        {

            var artist = new Artist
            {
                name = transferObject.GetValue("name").ToString(),
                DOB = transferObject.GetValue("DOB").ToString(),
                DOD = transferObject.GetValue("DOD").ToString(),
                married = transferObject.GetValue("married").ToObject<bool>(),

                works = new List<Work>

            {
                new Work

                {
                    /*title = "one",
                    type = "two",
                    year = "three"*/
        
                    title = (string)transferObject["works"][0]["title"],
                    type = (string)transferObject["works"][0]["type"],
                    year = (string)transferObject["works"][0]["year"]
                }
                }

            };

            return artist;

        }

    }



   /* public class Rootobject
    {
        public Artist[] artists { get; set; }
    }

    public class Artist
    {
        public string name { get; set; }
        public string DOB { get; set; }
        public string DOD { get; set; }
        public bool married { get; set; }
        public Work[] works { get; set; }
    }

    public class Work
    {
        public string title { get; set; }
        public string type { get; set; }
        public string year { get; set; }
    }

    */
}
