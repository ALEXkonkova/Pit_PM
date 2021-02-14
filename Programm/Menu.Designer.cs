namespace Dipl.Programm
{
    partial class MenuForm
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.exit2 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.OnOffElements = new System.Windows.Forms.CheckBox();
            this.Serch = new System.Windows.Forms.TextBox();
            this.cboColumn = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.exit1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ModelText = new System.Windows.Forms.TextBox();
            this.ProductText = new System.Windows.Forms.TextBox();
            this.comment = new System.Windows.Forms.TextBox();
            this.corpus = new System.Windows.Forms.TextBox();
            this.Problems = new System.Windows.Forms.TextBox();
            this.Nametext = new System.Windows.Forms.TextBox();
            this.imeitxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Oformit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IMEI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.label1Phone = new System.Windows.Forms.Label();
            this.NameUsers2 = new System.Windows.Forms.MaskedTextBox();
            this.conteiner = new System.Windows.Forms.TabControl();
            this.id_other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imei2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.conteiner.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.tabPage3.Controls.Add(this.exit2);
            this.tabPage3.Controls.Add(this.maskedTextBox1);
            this.tabPage3.Controls.Add(this.data);
            this.tabPage3.Controls.Add(this.OnOffElements);
            this.tabPage3.Controls.Add(this.Serch);
            this.tabPage3.Controls.Add(this.cboColumn);
            this.tabPage3.Controls.Add(this.maskedTextBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1148, 672);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Найти";
            // 
            // exit2
            // 
            this.exit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit2.Location = new System.Drawing.Point(1067, 28);
            this.exit2.Name = "exit2";
            this.exit2.Size = new System.Drawing.Size(75, 23);
            this.exit2.TabIndex = 84;
            this.exit2.Text = "Выход";
            this.exit2.UseVisualStyleBackColor = true;
            this.exit2.Click += new System.EventHandler(this.exit2_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(8, 0);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(1140, 22);
            this.maskedTextBox1.TabIndex = 66;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_other,
            this.id_client,
            this.imei2,
            this.brand,
            this.model,
            this.name});
            this.data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.data.Location = new System.Drawing.Point(0, 78);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.data.Size = new System.Drawing.Size(1142, 591);
            this.data.TabIndex = 65;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // OnOffElements
            // 
            this.OnOffElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OnOffElements.AutoSize = true;
            this.OnOffElements.Checked = true;
            this.OnOffElements.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OnOffElements.Location = new System.Drawing.Point(638, 49);
            this.OnOffElements.Name = "OnOffElements";
            this.OnOffElements.Size = new System.Drawing.Size(175, 17);
            this.OnOffElements.TabIndex = 64;
            this.OnOffElements.Text = "Скрыть закрытые/выданные";
            this.OnOffElements.UseVisualStyleBackColor = true;
            this.OnOffElements.CheckedChanged += new System.EventHandler(this.OnOffElements_CheckedChanged);
            // 
            // Serch
            // 
            this.Serch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Serch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Serch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serch.Location = new System.Drawing.Point(213, 44);
            this.Serch.MaxLength = 15;
            this.Serch.Name = "Serch";
            this.Serch.Size = new System.Drawing.Size(398, 22);
            this.Serch.TabIndex = 63;
            this.Serch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.surch_text_up);
            // 
            // cboColumn
            // 
            this.cboColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.cboColumn.CausesValidation = false;
            this.cboColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cboColumn.ForeColor = System.Drawing.Color.Black;
            this.cboColumn.FormattingEnabled = true;
            this.cboColumn.Items.AddRange(new object[] {
            "Телефон",
            "Номер заказа",
            "IMEI",
            "Модель",
            "Приёмщик"});
            this.cboColumn.Location = new System.Drawing.Point(8, 44);
            this.cboColumn.Name = "cboColumn";
            this.cboColumn.Size = new System.Drawing.Size(182, 28);
            this.cboColumn.TabIndex = 52;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox2.Location = new System.Drawing.Point(888, 6);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(254, 22);
            this.maskedTextBox2.TabIndex = 27;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.exit1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.ModelText);
            this.tabPage1.Controls.Add(this.ProductText);
            this.tabPage1.Controls.Add(this.comment);
            this.tabPage1.Controls.Add(this.corpus);
            this.tabPage1.Controls.Add(this.Problems);
            this.tabPage1.Controls.Add(this.Nametext);
            this.tabPage1.Controls.Add(this.imeitxt);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Oformit);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.IMEI);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Phone);
            this.tabPage1.Controls.Add(this.label1Phone);
            this.tabPage1.Controls.Add(this.NameUsers2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1148, 672);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Создать заказ";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1028, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 84;
            this.button2.Text = "Администрирование";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit1
            // 
            this.exit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit1.Location = new System.Drawing.Point(1028, 28);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(120, 23);
            this.exit1.TabIndex = 83;
            this.exit1.Text = "Выход";
            this.exit1.UseVisualStyleBackColor = true;
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(884, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 77);
            this.button1.TabIndex = 82;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(892, 96);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(253, 22);
            this.textBox9.TabIndex = 81;
            this.textBox9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup3);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(891, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 22);
            this.textBox1.TabIndex = 80;
            // 
            // ModelText
            // 
            this.ModelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelText.Location = new System.Drawing.Point(234, 435);
            this.ModelText.MaxLength = 30;
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(354, 22);
            this.ModelText.TabIndex = 75;
            // 
            // ProductText
            // 
            this.ProductText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductText.Location = new System.Drawing.Point(234, 401);
            this.ProductText.MaxLength = 10;
            this.ProductText.Name = "ProductText";
            this.ProductText.Size = new System.Drawing.Size(354, 22);
            this.ProductText.TabIndex = 73;
            // 
            // comment
            // 
            this.comment.AcceptsReturn = true;
            this.comment.AcceptsTab = true;
            this.comment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comment.Location = new System.Drawing.Point(233, 300);
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(355, 77);
            this.comment.TabIndex = 71;
            // 
            // corpus
            // 
            this.corpus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.corpus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.corpus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.corpus.Location = new System.Drawing.Point(234, 210);
            this.corpus.Multiline = true;
            this.corpus.Name = "corpus";
            this.corpus.Size = new System.Drawing.Size(354, 69);
            this.corpus.TabIndex = 69;
            // 
            // Problems
            // 
            this.Problems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Problems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Problems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Problems.Location = new System.Drawing.Point(234, 136);
            this.Problems.Name = "Problems";
            this.Problems.Size = new System.Drawing.Size(354, 22);
            this.Problems.TabIndex = 65;
            // 
            // Nametext
            // 
            this.Nametext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nametext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nametext.Location = new System.Drawing.Point(234, 56);
            this.Nametext.Name = "Nametext";
            this.Nametext.Size = new System.Drawing.Size(354, 22);
            this.Nametext.TabIndex = 63;
            // 
            // imeitxt
            // 
            this.imeitxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imeitxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imeitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imeitxt.Location = new System.Drawing.Point(234, 94);
            this.imeitxt.MaxLength = 15;
            this.imeitxt.Name = "imeitxt";
            this.imeitxt.Size = new System.Drawing.Size(354, 22);
            this.imeitxt.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(619, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 24);
            this.label9.TabIndex = 79;
            this.label9.Text = "Орентировачная стоимость:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(811, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 78;
            this.label8.Text = "Услуга:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Oformit
            // 
            this.Oformit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Oformit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oformit.Location = new System.Drawing.Point(233, 478);
            this.Oformit.Name = "Oformit";
            this.Oformit.Size = new System.Drawing.Size(348, 77);
            this.Oformit.TabIndex = 76;
            this.Oformit.Text = "Оформить заказ";
            this.Oformit.UseVisualStyleBackColor = true;
            this.Oformit.Click += new System.EventHandler(this.Oformit_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(141, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 74;
            this.label7.Text = "Модель:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(69, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 24);
            this.label6.TabIndex = 72;
            this.label6.Text = "Производитель:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(101, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 70;
            this.label5.Text = "Коментарий:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 68;
            this.label4.Text = "Состояние корпуса:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton);
            this.groupBox1.Location = new System.Drawing.Point(234, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 35);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(52, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 17);
            this.radioButton2.TabIndex = 48;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Нет";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(6, 12);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(40, 17);
            this.radioButton.TabIndex = 47;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "Да";
            this.radioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(81, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Следы залития:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "Причина обращения:";
            // 
            // IMEI
            // 
            this.IMEI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IMEI.AutoSize = true;
            this.IMEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IMEI.Location = new System.Drawing.Point(176, 94);
            this.IMEI.Name = "IMEI";
            this.IMEI.Size = new System.Drawing.Size(52, 24);
            this.IMEI.TabIndex = 62;
            this.IMEI.Text = "IMEI:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "Имя:";
            // 
            // Phone
            // 
            this.Phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Phone.BackColor = System.Drawing.Color.White;
            this.Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.ForeColor = System.Drawing.Color.Black;
            this.Phone.Location = new System.Drawing.Point(234, 22);
            this.Phone.Mask = "+0 (999) 000 00 00";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(354, 22);
            this.Phone.TabIndex = 60;
            this.Phone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Phone_KeyUp);
            // 
            // label1Phone
            // 
            this.label1Phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1Phone.AutoSize = true;
            this.label1Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Phone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1Phone.Location = new System.Drawing.Point(58, 22);
            this.label1Phone.Name = "label1Phone";
            this.label1Phone.Size = new System.Drawing.Size(169, 24);
            this.label1Phone.TabIndex = 59;
            this.label1Phone.Text = "Номер Телефона:";
            this.label1Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameUsers2
            // 
            this.NameUsers2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameUsers2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.NameUsers2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameUsers2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameUsers2.Location = new System.Drawing.Point(12, 0);
            this.NameUsers2.Name = "NameUsers2";
            this.NameUsers2.Size = new System.Drawing.Size(1140, 22);
            this.NameUsers2.TabIndex = 25;
            this.NameUsers2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // conteiner
            // 
            this.conteiner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conteiner.Controls.Add(this.tabPage1);
            this.conteiner.Controls.Add(this.tabPage3);
            this.conteiner.Location = new System.Drawing.Point(0, 0);
            this.conteiner.Name = "conteiner";
            this.conteiner.SelectedIndex = 0;
            this.conteiner.Size = new System.Drawing.Size(1156, 698);
            this.conteiner.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.conteiner.TabIndex = 26;
            // 
            // id_other
            // 
            this.id_other.HeaderText = "Номер заказа";
            this.id_other.Name = "id_other";
            this.id_other.ReadOnly = true;
            // 
            // id_client
            // 
            this.id_client.HeaderText = "Номер телефона";
            this.id_client.Name = "id_client";
            this.id_client.ReadOnly = true;
            // 
            // imei2
            // 
            this.imei2.HeaderText = "ime";
            this.imei2.Name = "imei2";
            this.imei2.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.HeaderText = "Бренд";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // model
            // 
            this.model.HeaderText = "Модель";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 698);
            this.Controls.Add(this.conteiner);
            this.Name = "MenuForm";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.conteiner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.CheckBox OnOffElements;
        private System.Windows.Forms.TextBox Serch;
        private System.Windows.Forms.ComboBox cboColumn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ModelText;
        private System.Windows.Forms.TextBox ProductText;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.TextBox corpus;
        private System.Windows.Forms.TextBox Problems;
        private System.Windows.Forms.TextBox Nametext;
        private System.Windows.Forms.TextBox imeitxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Oformit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IMEI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.Label label1Phone;
        private System.Windows.Forms.MaskedTextBox NameUsers2;
        private System.Windows.Forms.TabControl conteiner;
        private System.Windows.Forms.Button exit2;
        private System.Windows.Forms.Button exit1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_other;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn imei2;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}