
namespace Lab2
{
    partial class Form1
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
            this.Computer_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Processor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Video_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeOZU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Type_OZU = new System.Windows.Forms.ComboBox();
            this.SizeHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TypeHD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.ProcCreator = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ProcCount = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MemoryCount = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DirectX = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерОЗУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерДискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Back = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Computer_Type
            // 
            this.Computer_Type.FormattingEnabled = true;
            this.Computer_Type.Items.AddRange(new object[] {
            "Стационарный компьютер",
            "Ноутбук",
            "Сервер",
            "Рабочая станция"});
            this.Computer_Type.Location = new System.Drawing.Point(16, 49);
            this.Computer_Type.Name = "Computer_Type";
            this.Computer_Type.Size = new System.Drawing.Size(110, 23);
            this.Computer_Type.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип компьютера";
            // 
            // Processor
            // 
            this.Processor.Location = new System.Drawing.Point(16, 93);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(110, 23);
            this.Processor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Процессор";
            // 
            // Video_Name
            // 
            this.Video_Name.Location = new System.Drawing.Point(16, 146);
            this.Video_Name.Name = "Video_Name";
            this.Video_Name.Size = new System.Drawing.Size(110, 23);
            this.Video_Name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Видеокарта";
            // 
            // SizeOZU
            // 
            this.SizeOZU.Location = new System.Drawing.Point(16, 201);
            this.SizeOZU.Name = "SizeOZU";
            this.SizeOZU.Size = new System.Drawing.Size(110, 23);
            this.SizeOZU.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Размер ОЗУ (ГБ)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тип ОЗУ";
            // 
            // Type_OZU
            // 
            this.Type_OZU.FormattingEnabled = true;
            this.Type_OZU.Items.AddRange(new object[] {
            "DDR3",
            "DDR4"});
            this.Type_OZU.Location = new System.Drawing.Point(16, 256);
            this.Type_OZU.Name = "Type_OZU";
            this.Type_OZU.Size = new System.Drawing.Size(110, 23);
            this.Type_OZU.TabIndex = 9;
            // 
            // SizeHD
            // 
            this.SizeHD.Location = new System.Drawing.Point(16, 315);
            this.SizeHD.Name = "SizeHD";
            this.SizeHD.Size = new System.Drawing.Size(110, 23);
            this.SizeHD.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Размер Диска(ГБ)";
            // 
            // TypeHD
            // 
            this.TypeHD.FormattingEnabled = true;
            this.TypeHD.Items.AddRange(new object[] {
            "HDD",
            "SSD"});
            this.TypeHD.Location = new System.Drawing.Point(16, 367);
            this.TypeHD.Name = "TypeHD";
            this.TypeHD.Size = new System.Drawing.Size(110, 23);
            this.TypeHD.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Тип Диска";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(16, 432);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(110, 23);
            this.Date.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Дата Приобретения";
            // 
            // ProcCreator
            // 
            this.ProcCreator.Location = new System.Drawing.Point(154, 49);
            this.ProcCreator.Name = "ProcCreator";
            this.ProcCreator.Size = new System.Drawing.Size(110, 23);
            this.ProcCreator.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Производитель";
            // 
            // ProcCount
            // 
            this.ProcCount.FormattingEnabled = true;
            this.ProcCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ProcCount.Location = new System.Drawing.Point(299, 49);
            this.ProcCount.Name = "ProcCount";
            this.ProcCount.Size = new System.Drawing.Size(110, 23);
            this.ProcCount.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Кол-во Ядер";
            // 
            // MemoryCount
            // 
            this.MemoryCount.FormattingEnabled = true;
            this.MemoryCount.Items.AddRange(new object[] {
            "1 ГБ",
            "2 ГБ",
            "4 ГБ",
            "8 ГБ"});
            this.MemoryCount.Location = new System.Drawing.Point(154, 102);
            this.MemoryCount.Name = "MemoryCount";
            this.MemoryCount.Size = new System.Drawing.Size(110, 23);
            this.MemoryCount.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Объем Памяти";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "DirectX";
            // 
            // DirectX
            // 
            this.DirectX.FormattingEnabled = true;
            this.DirectX.Items.AddRange(new object[] {
            "v. 9",
            "v. 10",
            "v. 11"});
            this.DirectX.Location = new System.Drawing.Point(299, 102);
            this.DirectX.Name = "DirectX";
            this.DirectX.Size = new System.Drawing.Size(110, 23);
            this.DirectX.TabIndex = 23;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(16, 479);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(110, 23);
            this.Add.TabIndex = 24;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(16, 523);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(110, 23);
            this.Save.TabIndex = 25;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(16, 571);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(110, 23);
            this.Open.TabIndex = 26;
            this.Open.Text = "Загрузить";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(167, 179);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(128, 385);
            this.textBox1.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(167, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(845, 407);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Тип компьютера";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Процессор";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Видеокарта";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Размер ОЗУ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Тип ОЗУ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Размер Диска";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Тип Диска";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Дата приобретения";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортироватьПоToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // сортироватьПоToolStripMenuItem
            // 
            this.сортироватьПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерОЗУToolStripMenuItem,
            this.размерДискаToolStripMenuItem});
            this.сортироватьПоToolStripMenuItem.Name = "сортироватьПоToolStripMenuItem";
            this.сортироватьПоToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.сортироватьПоToolStripMenuItem.Text = "Сортировать по";
            // 
            // размерОЗУToolStripMenuItem
            // 
            this.размерОЗУToolStripMenuItem.Name = "размерОЗУToolStripMenuItem";
            this.размерОЗУToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.размерОЗУToolStripMenuItem.Text = "Размер ОЗУ";
            this.размерОЗУToolStripMenuItem.Click += new System.EventHandler(this.размерОЗУToolStripMenuItem_Click);
            // 
            // размерДискаToolStripMenuItem
            // 
            this.размерДискаToolStripMenuItem.Name = "размерДискаToolStripMenuItem";
            this.размерДискаToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.размерДискаToolStripMenuItem.Text = "Размер Диска";
            this.размерДискаToolStripMenuItem.Click += new System.EventHandler(this.размерДискаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(557, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(455, 23);
            this.Status.TabIndex = 30;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1057, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(334, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 32;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(415, 0);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(75, 23);
            this.Forward.TabIndex = 33;
            this.Forward.Text = "Вперед";
            this.Forward.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1057, 627);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DirectX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MemoryCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProcCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProcCreator);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TypeHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SizeHD);
            this.Controls.Add(this.Type_OZU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SizeOZU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Video_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Processor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Computer_Type);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Computer_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Processor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Video_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SizeOZU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Type_OZU;
        private System.Windows.Forms.TextBox SizeHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TypeHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ProcCreator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ProcCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox MemoryCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox DirectX;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерОЗУToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерДискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
    }
}

