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

namespace oop_2
{
    public delegate void processorHandler(Processor processor);
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

        }

        List<Computer> Laboratory;

        Computer currentComputer;


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
            Form2 addProcessorForm = new Form2(this.AddProcessorInComputer);
            addProcessorForm.Show();
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
                        break;
                    }
                case 1:
                    {
                        this.currentComputer.Type = Computer.ComputerTypes.workingStation;
                        break;
                    }
                case 2:
                    {
                        this.currentComputer.Type = Computer.ComputerTypes.notebook;
                        break;
                    }
                case 3:
                    {
                        this.currentComputer.Type = Computer.ComputerTypes.PC;
                        break;
                    }
            }
            
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
        }

        private void ShowLaboratoryEquipment(object sender, EventArgs e)
        {
            Form4 LaboratoryDiagram = new Form4(this.Laboratory);
            LaboratoryDiagram.Show();
        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox16.Text == "" || this.richTextBox16.Text == "0")
            {
                this.richTextBox16.Text = "";
                return;
            }
            this.currentComputer.DriveSize = Convert.ToInt32(this.richTextBox16.Text);
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
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.currentComputer.PurchaseTime = Convert.ToString( dateTimePicker1.Value);
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, EventArgs e)
        {
            if(
                this.currentComputer.Videocard == null ||
                this.currentComputer.Videocard == "" ||
                this.currentComputer.DriveSize == 0 ||
                this.currentComputer._Processor == null ||
                this.currentComputer.PurchaseTime == null
                )
            {
                //
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
        }

        private void ReadLaboratory(object sender, EventArgs e)
        {
            using (FileStream File = new FileStream(path, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonFile = new DataContractJsonSerializer(typeof(Wrapper));
                Wrapper savedData = (Wrapper)jsonFile.ReadObject(File);
                this.Laboratory = savedData.data;
            }
        }
    }
}