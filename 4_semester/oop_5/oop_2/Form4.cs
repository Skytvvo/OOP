using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_2
{
    public partial class Form4 : Form
    {
        public Form4(List<Computer> laboratory)
        {
            InitializeComponent();
            this.laboratory = laboratory;
            this.dataGridView1.RowCount = this.laboratory.Count();
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = this.laboratory[i].config.CType;
                this.dataGridView1.Rows[i].Cells[1].Value = this.laboratory[i].hardware.Processor.Manufactur.Model;
                this.dataGridView1.Rows[i].Cells[2].Value = this.laboratory[i].hardware.Videocard;
                this.dataGridView1.Rows[i].Cells[3].Value = this.laboratory[i].config.RType;
                this.dataGridView1.Rows[i].Cells[4].Value = this.laboratory[i].config.DType;
                this.dataGridView1.Rows[i].Cells[5].Value = this.laboratory[i].hardware.DriveSize;
                this.dataGridView1.Rows[i].Cells[6].Value = this.laboratory[i].hardware.PurchaseTime;
                this.dataGridView1.Rows[i].Cells[7].Value = (this.laboratory[i].hardware.Processor.Power.Cores * this.laboratory[i].hardware.Processor.Cache.L1 * this.laboratory[i].hardware.DriveSize);
            }
            int price = 0;
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                price += Convert.ToInt32(this.dataGridView1.Rows[i].Cells[7].Value);
            }
            this.richTextBox1.Text = price.ToString();
        }
        List<Computer> laboratory;
        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
