using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;

namespace oop_2
{
    public partial class Form3 : Form
    {

        public event ChangeStatusHandler Changestatus;
        public Form3(List<Computer> lab, ChangeStatusHandler ChangeStatus)
        {
            InitializeComponent();
            this.Changestatus += ChangeStatus;
            this.lab = lab;
        }

        string currentManafacture;
        string currentModel;
        List<Computer> lab;
        IEnumerable<Computer> matches;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.currentManafacture = this.richTextBox1.Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            this.currentModel = this.richTextBox2.Text; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearMessages();
            this.matches = RegexHandler(this.lab);
            printReult(this.matches);
            Changestatus("Search");
          
        }

      List<Computer> RegexHandler(List<Computer> data)
        {
            List<Computer> response = new List<Computer>();

            foreach (var comp in data)
            {
                if (Regex.IsMatch(comp._Processor.Manufactor, $@"(\w*){this.currentManafacture}(\w)*"))
                {
                    if (Regex.IsMatch(comp._Processor.Model, $@"(\w*){this.currentModel}(\w)*"))
                    {
                        /* this.richTextBox3.Text += comp._Processor.Manufactor + ' ' + comp._Processor.Model + '\n';*/
                        response.Add(comp);
                    }
                }
            }
            return response;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearMessages();
            this.matches = this.matches.OrderBy(ITEM=>ITEM._Processor.Frenquecy).OrderBy(item => item.DriveSize);
            printReult(this.matches);
            Changestatus("Sort");
        }
        void printReult(IEnumerable<Computer> data)
        {
            foreach (var item in data)
            {
                this.richTextBox3.Text += item._Processor.Manufactor + " " + item._Processor.Model + " " + item.DriveSize + " " + item._Processor.Frenquecy + '\n';
            }
        }
        void ClearMessages()
        {
            this.richTextBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(FileStream searchResults = new FileStream(@"search.json", FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer JSONFILE = new DataContractJsonSerializer(typeof(List<Computer>));
                JSONFILE.WriteObject(searchResults, this.matches);
            }
            Changestatus("Wrotte json");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Changestatus("OK");
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "v1.1b. Kazaou Ilya Vasilievich",
                "About",
                MessageBoxButtons.OK
                );
            Changestatus("About");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
    }
    
}
