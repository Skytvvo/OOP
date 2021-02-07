namespace oop_2
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Общая стоимость лабаратории:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(408, 408);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(177, 31);
            this.richTextBox1.TabIndex = 50;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(851, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 49;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.processor,
            this.videoCard,
            this.ramType,
            this.driveType,
            this.driveSize,
            this.perchaseDate,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 378);
            this.dataGridView1.TabIndex = 48;
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 125;
            // 
            // processor
            // 
            this.processor.HeaderText = "Процессор";
            this.processor.MinimumWidth = 6;
            this.processor.Name = "processor";
            this.processor.ReadOnly = true;
            this.processor.Width = 125;
            // 
            // videoCard
            // 
            this.videoCard.HeaderText = "Видеокарта";
            this.videoCard.MinimumWidth = 6;
            this.videoCard.Name = "videoCard";
            this.videoCard.ReadOnly = true;
            this.videoCard.Width = 125;
            // 
            // ramType
            // 
            this.ramType.HeaderText = "Тип ОЗУ";
            this.ramType.MinimumWidth = 6;
            this.ramType.Name = "ramType";
            this.ramType.ReadOnly = true;
            this.ramType.Width = 50;
            // 
            // driveType
            // 
            this.driveType.HeaderText = "Тип накопителя";
            this.driveType.MinimumWidth = 6;
            this.driveType.Name = "driveType";
            this.driveType.ReadOnly = true;
            this.driveType.Width = 125;
            // 
            // driveSize
            // 
            this.driveSize.HeaderText = "Размер накопителя(ГБ)";
            this.driveSize.MinimumWidth = 6;
            this.driveSize.Name = "driveSize";
            this.driveSize.ReadOnly = true;
            this.driveSize.Width = 125;
            // 
            // perchaseDate
            // 
            this.perchaseDate.HeaderText = "Дата приобретения";
            this.perchaseDate.MinimumWidth = 6;
            this.perchaseDate.Name = "perchaseDate";
            this.perchaseDate.ReadOnly = true;
            this.perchaseDate.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Стоимость";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn processor;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ramType;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn perchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}