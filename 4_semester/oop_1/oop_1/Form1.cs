using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_1
{
    public partial class Calculator : Form
    {

        protected int leftValue;
        protected int rightValue;

        protected bool IsNextOperation = false;
        protected bool recentlyOperation = false;
        protected bool errrorDetected = false;

        protected char lastOperation;

        protected int savedValue;

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            this.leftValue = 0;
            this.rightValue = 0;
        }

        //ввод цифр
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.recentlyOperation)
                {
                    this.recentlyOperation = false;
                    richTextBox1.Text = "";
                }

                if (richTextBox1.Text == "0" || this.errrorDetected)
                {
                    richTextBox1.Text = (sender as Button).Text;
                }
                else
                {
                    richTextBox1.Text += (sender as Button).Text;
                }

                if (this.IsNextOperation)
                {
                    this.rightValue = Convert.ToInt32(richTextBox1.Text);
                }
                else
                {
                    this.leftValue = Convert.ToInt32(richTextBox1.Text);
                    if (this.errrorDetected)
                        this.errrorDetected = false;
                }
            }
            catch(OverflowException excep)
            {
                this.exceptionClear();

            }
        }

        //операторы
        private void operatorAction(object sender, EventArgs e)
        {

            try
            {

                if (!this.errrorDetected)
                {
                    if (this.IsNextOperation && !this.recentlyOperation)
                    {
                        //если это уже второй оператор, то нужно вычислить предыдущее значение
                        this.operationProcess();
                    }


                    this.recentlyOperation = true;
                    this.IsNextOperation = true;
                    this.lastOperation = (sender as Button).Text[0];
                    richTextBox1.Text = (sender as Button).Text;


                }
            }
            catch (DivideByZeroException ex)
            {
                this.exceptionClear();
            }
            catch (OverflowException ex)
            {
                this.exceptionClear();
            }
        }

        //выполнение операторов
        private void operationProcess()
        {
            int result = 0;
            
                switch (this.lastOperation)
                {
                    case '+':
                        {
                            result = this.leftValue + this.rightValue;
                            break;
                        }
                    case '-':
                        {
                            result = this.leftValue - this.rightValue;
                            break;
                        }
                    case '*':
                        {
                            result = this.leftValue * this.rightValue;
                            break;
                        }
                    case '/':
                        {
                            result = this.leftValue / this.rightValue;
                            break;
                        }
                    case '%':
                        {
                            result = this.leftValue % this.rightValue;
                            break;
                        }
                }
                this.leftValue = result;
                this.rightValue = 0;
            
           
        }

        private void getResult(object sender, EventArgs e)
        {
            try
            {
                if (this.IsNextOperation)
                {

                    operationProcess();


                    this.IsNextOperation = false;
                }

                richTextBox1.Text = this.leftValue.ToString();
            }
            catch (DivideByZeroException zeroEx)
            {
                this.exceptionClear();
            }
            catch(OverflowException ex)
            {
                this.exceptionClear();            }
        }

        private void setValue(object sender, EventArgs e)
        {
            if (!this.recentlyOperation)
            {
                this.savedValue = Convert.ToInt32(richTextBox1.Text);
            }
        }

        private void getValue(object sender, EventArgs e)
        {
           
                richTextBox1.Text = this.savedValue.ToString();
                if (this.recentlyOperation)
                    this.rightValue = savedValue;
                this.leftValue = this.savedValue;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exceptionClear()
        {
            this.richTextBox1.Text = "Error!";

            this.errrorDetected = true;
            this.leftValue = 0;
            this.rightValue = 0;
            this.recentlyOperation = false;
            this.IsNextOperation = false;
        }
    }
}
