namespace TFI_CANZIANI
{
    partial class Muestra
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(318, 41);
            button1.Name = "button1";
            button1.Size = new Size(174, 46);
            button1.TabIndex = 0;
            button1.Text = "Descendente";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(550, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(570, 558);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(160, 125);
            button2.Name = "button2";
            button2.Size = new Size(301, 46);
            button2.TabIndex = 2;
            button2.Text = "Crear Nuevo Producto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(135, 258);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(345, 40);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 378);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 39);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 496);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 39);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Image = Properties.Resources._4829869_arrow_next_right_icon;
            label1.ImageAlign = ContentAlignment.BottomRight;
            label1.Location = new Point(160, 41);
            label1.Name = "label1";
            label1.Size = new Size(135, 46);
            label1.TabIndex = 6;
            label1.Text = "Orden";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.ForeColor = Color.Red;
            label2.ImageAlign = ContentAlignment.BottomRight;
            label2.Location = new Point(135, 198);
            label2.Name = "label2";
            label2.Size = new Size(229, 46);
            label2.TabIndex = 7;
            label2.Text = "Filtrar por Categoria";
            // 
            // label3
            // 
            label3.ForeColor = Color.Red;
            label3.ImageAlign = ContentAlignment.BottomRight;
            label3.Location = new Point(135, 315);
            label3.Name = "label3";
            label3.Size = new Size(160, 46);
            label3.TabIndex = 8;
            label3.Text = "Filtrar por Id";
            // 
            // label4
            // 
            label4.ForeColor = Color.Red;
            label4.ImageAlign = ContentAlignment.BottomRight;
            label4.Location = new Point(131, 438);
            label4.Name = "label4";
            label4.Size = new Size(233, 46);
            label4.TabIndex = 9;
            label4.Text = "Filtrar por Productos";
            // 
            // Muestra
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1185, 654);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Muestra";
            Text = "Muestra";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}