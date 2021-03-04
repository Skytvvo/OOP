using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_2
{
    
    public partial class Form2 : Form
    {

        public event processorHandler AddProcessor;
        public event ChangeStatusHandler ChangeStatus;
        public Form2(processorHandler AddProcessorInComputer, ChangeStatusHandler ChnageStatus, ComputerTypes computerType)
        {
            InitializeComponent();

            this.AddProcessor += AddProcessorInComputer;
            this.ChangeStatus += ChnageStatus;

            this.processor = new Processor();


            this.computerType = computerType;
            SetBuilder();

            this.comboBox1.Items.Add(Bits.processorBit.x32);
            this.comboBox1.Items.Add(Bits.processorBit.x64);
            this.comboBox1.SelectedIndex = 1;
        }

        //builder
        private ProcessorBuilder ProcessorBuilder;
        private ComputerTypes computerType;

        public Processor processor;


        private void SetBuilder()
        {
            switch (this.computerType)
            {
                case ComputerTypes.Server:
                    {
                        this.ProcessorBuilder = new ServerProcessorBuilder();
                        break;
                    }

                case ComputerTypes.PC:
                    {
                        this.ProcessorBuilder = new PCProcessorBuilder();
                        break;
                    }

                case ComputerTypes.notebook:
                    {
                        this.ProcessorBuilder = new LaptopProcessorBuilder();
                        break;
                    }

                case ComputerTypes.workingStation:
                    {
                        this.ProcessorBuilder = new WorkStationProcessorBuilder();
                        break;
                    }

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private Bits.processorBit GetProcessorBit(int index)
        {
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        return Bits.processorBit.x32;
                    }
                case 1:
                    {
                        return Bits.processorBit.x64;
                    }
            default:
                    {
                        return Bits.processorBit.x64;
                    }
            }
        }
        private void okClick(object sender, EventArgs e)
        {

            
            this.ProcessorBuilder.SetBits(new Bits {
                BitArchitecture = GetProcessorBit(comboBox1.SelectedIndex)
            });

            this.ProcessorBuilder.SetCache(new Cache
            {
                L1 = Convert.ToInt32(richTextBox8.Text),
                L2 = Convert.ToInt32(richTextBox9.Text),
                L3 = Convert.ToInt32(richTextBox10.Text)
            });

            this.ProcessorBuilder.SetManufacter(new Manufactur
            {
                man = richTextBox1.Text,
                Model = richTextBox2.Text,
                Series = richTextBox3.Text
            });

            this.ProcessorBuilder.SetPower(new Power
            {
                Cores = Convert.ToInt32(richTextBox4.Text),
                Frenquecy = Convert.ToInt32(richTextBox5.Text)
            });

            if(!Validate(this.ProcessorBuilder.Processor))
            {
                return;
            }

            ChangeStatus("Added processor");

            this.AddProcessor(this.ProcessorBuilder.Processor);
            this.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            AddProcessor(null);
            ChangeStatus("Cancel");
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
         }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* switch(this.comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        this.processor.BitArchitecture = Processor.processorBit.x32;
                        break;
                    }
                case 1:
                    {
                        this.processor.BitArchitecture = Processor.processorBit.x64;
                        break;
                    }
            }*/
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox4.Text == "" || this.richTextBox4.Text == "0")
            {
                this.richTextBox4.Text = "";
                return;
            }
        }

        private void digitLimitation(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if ((!Char.IsDigit(sym)))
                e.Handled = true;
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox5.Text == "" || this.richTextBox5.Text == "0")
            {
                this.richTextBox5.Text = "";
                return; 
            }
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox8.Text == "" || this.richTextBox8.Text == "0")
            {
                this.richTextBox8.Text = "";
                return;
            }
       }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox9.Text == "" || this.richTextBox9.Text == "0")
            {
                this.richTextBox9.Text = "";
                return;
            }
/*            this.processor.sizeL2 = Convert.ToInt32(this.richTextBox9.Text);
*/        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox10.Text == "" || this.richTextBox10.Text == "0")
            {
                this.richTextBox10.Text = "";
                return;
            }
        }
        private static bool Validate(Processor processor)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(processor);
            if (!Validator.TryValidateObject(processor, context, results, true))
            {
                foreach (var error in results)
                    MessageBox.Show(
                        error.ErrorMessage,
                        "Error",
                        MessageBoxButtons.OK
                        );
                return false;
            }
            return true;
        }
    }
}
