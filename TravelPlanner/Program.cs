using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TravelPlanner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
        }
        public static List<Journey> journeys = new List<Journey>();
        public static void Serialize()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(journeys.GetType());
                using (StreamWriter sw = new StreamWriter("journeys.xml"))
                {
                    serializer.Serialize(sw, journeys);
                    
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Deserialize()
        {
            try
            {
                if (File.Exists("journeys.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(journeys.GetType());
                    using (StreamReader sr = new StreamReader("journeys.xml"))
                    {
                        journeys = (List<Journey>)serializer.Deserialize(sr);
                    }
                }
                else throw new FileNotFoundException("File not found");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
    
    
}


 
