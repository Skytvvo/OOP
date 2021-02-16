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
        public Form2(processorHandler AddProcessorInComputer, ChangeStatusHandler ChnageStatus)
        {
            InitializeComponent();

            this.AddProcessor += AddProcessorInComputer;
            this.ChangeStatus += ChnageStatus;

            this.processor = new Processor();

            this.comboBox1.Items.Add(Processor.processorBit.x32);
            this.comboBox1.Items.Add(Processor.processorBit.x64);
            this.comboBox1.SelectedIndex = 1;
        }

       

        public Processor processor;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void okClick(object sender, EventArgs e)
        {

            /*  if (
                  (this.processor.Manufactor == null || this.processor.Manufactor == "") ||
                  (this.processor.Model == null || this.processor.Model == "") ||
                  (this.processor.Series == null || this.processor.Series == "") ||
                  this.processor.Cores == 0 ||
                  this.processor.Frenquecy == 0 ||
                  this.processor.sizeL1 == 0 ||
                  this.processor.sizeL2 == 0 ||
                  this.processor.sizeL3 == 0
              )
                  return;*/

            if(!Validate(this.processor))
            {
                return;
            }
            ChangeStatus("Added processor");
            this.AddProcessor(this.processor);
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
            this.processor.Manufactor = this.richTextBox1.Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            this.processor.Series = this.richTextBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboBox1.SelectedIndex)
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
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            this.processor.Model = this.richTextBox3.Text;
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox4.Text == "" || this.richTextBox4.Text == "0")
            {
                this.richTextBox4.Text = "";
                return;
            }
            this.processor.Cores = Convert.ToInt16(this.richTextBox4.Text);
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
            this.processor.Frenquecy = Convert.ToInt32(this.richTextBox5.Text);
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox8.Text == "" || this.richTextBox8.Text == "0")
            {
                this.richTextBox8.Text = "";
                return;
            }
            this.processor.sizeL1 = Convert.ToInt32(richTextBox8.Text);
        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox9.Text == "" || this.richTextBox9.Text == "0")
            {
                this.richTextBox9.Text = "";
                return;
            }
            this.processor.sizeL2 = Convert.ToInt32(this.richTextBox9.Text);
        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox10.Text == "" || this.richTextBox10.Text == "0")
            {
                this.richTextBox10.Text = "";
                return;
            }
            this.processor.sizeL3 = Convert.ToInt32(this.richTextBox10.Text);
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
