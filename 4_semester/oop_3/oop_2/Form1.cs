using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace oop_2
{
    public delegate void processorHandler(Processor processor);
    public delegate void ChangeStatusHandler(string message);
    
    public partial class Form1 : Form
    {
        const string path = @".\Laboratory.json";

        public Form1()
        {
            InitializeComponent();
            this.Laboratory = new List<Computer>();
            this.currentComputer = new Computer();
            this.currentComputer.PurchaseTime = Convert.ToString(dateTimePicker1.Value);


            this.comboBox1.Items.Add(Computer.ComputerTypes.notebook);
            this.comboBox1.Items.Add(Computer.ComputerTypes.PC);
            this.comboBox1.Items.Add(Computer.ComputerTypes.Server);
            this.comboBox1.Items.Add(Computer.ComputerTypes.workingStation);
            this.comboBox1.SelectedIndex = 1;

            this.comboBox2.Items.Add(Computer.RamTypes.ddr1);
            this.comboBox2.Items.Add(Computer.RamTypes.ddr2);
            this.comboBox2.Items.Add(Computer.RamTypes.ddr3);
            this.comboBox2.Items.Add(Computer.RamTypes.ddr4);
            this.comboBox2.Items.Add(Computer.RamTypes.ddr5);
            this.comboBox2.SelectedIndex = 3;

            this.comboBox3.Items.Add(Computer.DriveTypes.hdd);
            this.comboBox3.Items.Add(Computer.DriveTypes.ssd);
            this.comboBox3.Items.Add(Computer.DriveTypes.shdd);
            this.comboBox3.SelectedIndex = 1;
            this.pictureBox1.Image = Image.FromFile(@"D:\projects\labs\3-semester\oop\4_semester\oop_2\oop_2\2.jfif");
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.currentStatus = $"Computers({Laboratory.Count}, ";

            

            
            ToolStripMenuItem Search = new ToolStripMenuItem("Search");
            Search.Click += button7_Click;
            
            this.toolsToolStripMenuItem.DropDownItems.Add(Search);

            ToolStripMenuItem Clear = new ToolStripMenuItem("Clear");
            Clear.Click += button8_Click;
            this.toolsToolStripMenuItem.DropDownItems.Add(Clear);

            ToolStripMenuItem Next = new ToolStripMenuItem("Next");
            Clear.Click += button9_Click;
            this.toolsToolStripMenuItem.DropDownItems.Add(Next);

            ToolStripMenuItem Back = new ToolStripMenuItem("Back");
            Clear.Click += button10_Click;
            this.toolsToolStripMenuItem.DropDownItems.Add(Back);

        }

        List<Computer> Laboratory;

        Computer currentComputer;

        List<Computer> backList = new List<Computer>(); 
        

        public string currentStatus;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddProcessor(object sender, EventArgs e)
        {
            Form2 addProcessorForm = new Form2(this.AddProcessorInComputer, this.ChangeStatus);
            addProcessorForm.Show();
            ChangeStatus("Open processor editor");

        }

        public void AddProcessorInComputer(Processor processor)
        {
            this.currentComputer._Processor = processor;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        this.currentComputer.Type = Computer.ComputerTypes.Server;
                        this.pictureBox1.Image = Image.FromFile(@"D:\projects\labs\3-semester\oop\4_semester\oop_2\oop_2\1.jfif");
                        break;
                    }
                case 1:
                    {
                        this.currentComputer.Type = Computer.ComputerTypes.workingStation;
                        this.pictureBox1.Image = Image.FromFile(@"D:\projects\labs\3-semester\oop\4_semester\oop_2\oop_2\2.jfif");
                        break;
                    }
                case 2:
                    {
                        this.currentComputer.Type = Computer.ComputerTypes.notebook;
                        this.pictureBox1.Image = Image.FromFile(@"D:\projects\labs\3-semester\oop\4_semester\oop_2\oop_2\3.jfif");
                        break;
                    }
                case 3:
                    {
                        this.currentComputer.Type = Computer.ComputerTypes.PC;
                        this.pictureBox1.Image = Image.FromFile(@"D:\projects\labs\3-semester\oop\4_semester\oop_2\oop_2\4.jfif");
                        break;
                    }
            }
            ChangeStatus("Change computer type");


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        this.currentComputer.TypeOfRam = Computer.RamTypes.ddr1;
                        break;
                    }
                case 1:
                    {
                        this.currentComputer.TypeOfRam = Computer.RamTypes.ddr2;
                        break;
                    }
                case 2:
                    {
                        this.currentComputer.TypeOfRam = Computer.RamTypes.ddr3;
                        break;
                    }
                case 3:
                    {
                        this.currentComputer.TypeOfRam = Computer.RamTypes.ddr4;
                        break;
                    }
                case 4:
                    {
                        this.currentComputer.TypeOfRam = Computer.RamTypes.ddr5;
                        break;
                    }
            }
            ChangeStatus("Changed ram type");

        }

        private void ShowLaboratoryEquipment(object sender, EventArgs e)
        {
            if (this.Laboratory.Count == 0)
                return;
            Form4 LaboratoryDiagram = new Form4(this.Laboratory);
            LaboratoryDiagram.Show();
            ChangeStatus("Printed laboratory");

        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox16.Text == "" || this.richTextBox16.Text == "0")
            {
                this.richTextBox16.Text = "";
                return;
            }
            this.currentComputer.DriveSize = Convert.ToInt32(this.richTextBox16.Text);
            ChangeStatus("Changed size of drive");

        }

        private void richTextBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
                char sym = e.KeyChar;
                if (!Char.IsDigit(sym))
                    e.Handled = true;
        }

        private void richTextBox13_TextChanged(object sender, EventArgs e)
        {
            this.currentComputer.Videocard = this.richTextBox13.Text;
            ChangeStatus("Changed videocard");

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboBox3.SelectedIndex)
            {
                case 0:
                    {
                        this.currentComputer.DriveType = Computer.DriveTypes.ssd;
                        break;
                    }
                case 1:
                    {
                        this.currentComputer.DriveType = Computer.DriveTypes.hdd;
                        break;
                    }
                case 2:
                    {
                        this.currentComputer.DriveType = Computer.DriveTypes.shdd;
                        break;
                    }
            }
            ChangeStatus("Changed drive type");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.currentComputer.PurchaseTime = Convert.ToString( dateTimePicker1.Value);
           ChangeStatus("Changed date");

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, EventArgs e)
        {
            /* if(
                 this.currentComputer.Videocard == null ||
                 this.currentComputer.Videocard == "" ||
                 this.currentComputer.DriveSize == 0 ||
                 this.currentComputer._Processor == null ||
                 this.currentComputer.PurchaseTime == null
                 )
             {
                 //
                 return;*/
            //}

            var results = new List<ValidationResult>();
            var context = new ValidationContext(this.currentComputer);
            if (!Validator.TryValidateObject(this.currentComputer, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(
                        error.ErrorMessage,
                        "Invalid Error"
                        );
                    //Console.WriteLine(error.ErrorMessage);
                }
                return;
            }
            this.Laboratory.Add(this.currentComputer);
            this.currentComputer = new Computer();

            this.comboBox3.SelectedIndex = 1;
            this.comboBox2.SelectedIndex = 3;
            this.comboBox1.SelectedIndex = 1;
            this.richTextBox13.Text = "";
            this.richTextBox16.Text = "";
            this.dateTimePicker1.Value = DateTime.Now;

            ChangeStatus("Added computer");
        }

        private void WriteLaboratory(object sender, EventArgs e)
        {
            using(FileStream File = new FileStream(path, FileMode.OpenOrCreate) )
            {
                DataContractJsonSerializer jsonFile = new DataContractJsonSerializer(typeof(Wrapper));
                Wrapper data = new Wrapper();
                data.data = this.Laboratory;
                jsonFile.WriteObject(File,data);
            }
           ChangeStatus("Wrote data to json file");

        }

        private void ReadLaboratory(object sender, EventArgs e)
        {
            using (FileStream File = new FileStream(path, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonFile = new DataContractJsonSerializer(typeof(Wrapper));
                Wrapper savedData =     (Wrapper)jsonFile.ReadObject(File);
                this.Laboratory = savedData.data;
            }
            this.currentStatus = $"Computers({Laboratory.Count}), ";
            ChangeStatus("Read from json file");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (this.Laboratory.Count == 0)
                return;
            Form3 fr = new Form3(this.Laboratory, this.ChangeStatus);
            fr.Show();
            ChangeStatus("Open search menu");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void ChangeStatus(string message)
        {
            this.toolStripStatusLabel1.Text = $"Computers({Laboratory.Count}, " + $" Time({DateTime.Now.ToString()}), " + $"Last operation({message})";
        }

      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Laboratory = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (backList.Count == 0)
                return;
            Laboratory.Add(backList.First());
            backList.RemoveAt(0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Laboratory.Count == null || Laboratory.Count == 0)
                return;
            backList.Add(Laboratory[Laboratory.Count - 1]);
            Laboratory.RemoveAt(Laboratory.Count - 1);
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}