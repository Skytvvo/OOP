namespace oop_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.richTextBox13 = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.richTextBox16 = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(7, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(258, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "Данные компьютера:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Тип";
            // 
            // richTextBox13
            // 
            this.richTextBox13.Location = new System.Drawing.Point(32, 121);
            this.richTextBox13.MaxLength = 100;
            this.richTextBox13.Name = "richTextBox13";
            this.richTextBox13.Size = new System.Drawing.Size(214, 29);
            this.richTextBox13.TabIndex = 29;
            this.richTextBox13.Text = "";
            this.richTextBox13.TextChanged += new System.EventHandler(this.richTextBox13_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "Тип ОЗУ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 17);
            this.label17.TabIndex = 34;
            this.label17.Text = "Тип накопителя";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(277, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "Размер накопителя";
            // 
            // richTextBox16
            // 
            this.richTextBox16.Location = new System.Drawing.Point(280, 67);
            this.richTextBox16.MaxLength = 8;
            this.richTextBox16.Name = "richTextBox16";
            this.richTextBox16.Size = new System.Drawing.Size(214, 29);
            this.richTextBox16.TabIndex = 35;
            this.richTextBox16.Text = "";
            this.richTextBox16.TextChanged += new System.EventHandler(this.richTextBox16_TextChanged);
            this.richTextBox16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox16_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(277, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 17);
            this.label19.TabIndex = 38;
            this.label19.Text = "Дата приобретения";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Видеокарта";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 27);
            this.button1.TabIndex = 39;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 27);
            this.button2.TabIndex = 40;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ReadLaboratory);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 29);
            this.button3.TabIndex = 41;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowLaboratoryEquipment);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(363, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 29);
            this.button4.TabIndex = 42;
            this.button4.Text = "Write";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.WriteLaboratory);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(280, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(214, 32);
            this.button5.TabIndex = 43;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AddProcessor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Процессор";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 22);
            this.dateTimePicker1.TabIndex = 45;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "s";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 24);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(32, 177);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 24);
            this.comboBox2.TabIndex = 47;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(32, 243);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(214, 24);
            this.comboBox3.TabIndex = 48;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(458, 293);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 28);
            this.button6.TabIndex = 49;
            this.button6.Text = "Close";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Close);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 333);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.richTextBox16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.richTextBox13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richTextBox13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox richTextBox16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button6;
    }
}