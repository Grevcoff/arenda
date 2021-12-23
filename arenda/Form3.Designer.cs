namespace arenda
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.Добавить = new System.Windows.Forms.Button();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arendaDataSet = new arenda.arendaDataSet();
            this.автомобилиTableAdapter = new arenda.arendaDataSetTableAdapters.АвтомобилиTableAdapter();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new arenda.arendaDataSetTableAdapters.КлиентыTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.arendaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKВыданныеАвтомобилиКлиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выданные_автомобилиTableAdapter = new arenda.arendaDataSetTableAdapters.Выданные_автомобилиTableAdapter();
            this.клиентыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.клиентыBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.arendaDataSet1 = new arenda.arendaDataSet1();
            this.клиентыTableAdapter1 = new arenda.arendaDataSet1TableAdapters.КлиентыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKВыданныеАвтомобилиКлиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(807, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Добавить
            // 
            this.Добавить.BackColor = System.Drawing.Color.Lime;
            this.Добавить.Location = new System.Drawing.Point(807, 87);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(87, 35);
            this.Добавить.TabIndex = 17;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = false;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.arendaDataSet;
            // 
            // arendaDataSet
            // 
            this.arendaDataSet.DataSetName = "arendaDataSet";
            this.arendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.arendaDataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(623, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(623, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(623, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Телефон";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(623, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Паспорт";
            // 
            // arendaDataSetBindingSource
            // 
            this.arendaDataSetBindingSource.DataSource = this.arendaDataSet;
            this.arendaDataSetBindingSource.Position = 0;
            // 
            // клиентыBindingSource1
            // 
            this.клиентыBindingSource1.DataMember = "Клиенты";
            this.клиентыBindingSource1.DataSource = this.arendaDataSetBindingSource;
            // 
            // fKВыданныеАвтомобилиКлиентыBindingSource
            // 
            this.fKВыданныеАвтомобилиКлиентыBindingSource.DataMember = "FK_Выданные автомобили_Клиенты";
            this.fKВыданныеАвтомобилиКлиентыBindingSource.DataSource = this.клиентыBindingSource;
            // 
            // выданные_автомобилиTableAdapter
            // 
            this.выданные_автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыBindingSource2
            // 
            this.клиентыBindingSource2.DataMember = "Клиенты";
            this.клиентыBindingSource2.DataSource = this.arendaDataSet;
            // 
            // клиентыBindingSource3
            // 
            this.клиентыBindingSource3.DataMember = "Клиенты";
            this.клиентыBindingSource3.DataSource = this.arendaDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 272);
            this.dataGridView1.TabIndex = 31;
            // 
            // клиентыBindingSource4
            // 
            this.клиентыBindingSource4.DataMember = "Клиенты";
            this.клиентыBindingSource4.DataSource = this.arendaDataSet1;
            // 
            // arendaDataSet1
            // 
            this.arendaDataSet1.DataSetName = "arendaDataSet1";
            this.arendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыTableAdapter1
            // 
            this.клиентыTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(906, 298);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Добавить);
            this.Name = "Form3";
            this.Text = "Доб";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKВыданныеАвтомобилиКлиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Добавить;
        private arendaDataSet arendaDataSet;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private arendaDataSetTableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private arendaDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource клиентыBindingSource1;
        private System.Windows.Forms.BindingSource arendaDataSetBindingSource;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource fKВыданныеАвтомобилиКлиентыBindingSource;
        private arendaDataSetTableAdapters.Выданные_автомобилиTableAdapter выданные_автомобилиTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource2;
        private System.Windows.Forms.BindingSource клиентыBindingSource3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private arendaDataSet1 arendaDataSet1;
        private System.Windows.Forms.BindingSource клиентыBindingSource4;
        private arendaDataSet1TableAdapters.КлиентыTableAdapter клиентыTableAdapter1;
    }
}