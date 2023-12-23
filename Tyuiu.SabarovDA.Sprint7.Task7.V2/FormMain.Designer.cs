
namespace Tyuiu.SabarovDA.Sprint7.Task7.V2
{
    partial class FormProject_SDA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TaskButton_SDA = new System.Windows.Forms.Panel();
            this.labelSearch_SDA = new System.Windows.Forms.Label();
            this.textBoxSearch_SDA = new System.Windows.Forms.TextBox();
            this.buttonSearch_SDA = new System.Windows.Forms.Button();
            this.buttonHelp_SDA = new System.Windows.Forms.Button();
            this.buttonSaveIn_SDA = new System.Windows.Forms.Button();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.buttonInPut_SDA = new System.Windows.Forms.Button();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.panelInPut_SDA = new System.Windows.Forms.Panel();
            this.groupBoxInPut_SDA = new System.Windows.Forms.GroupBox();
            this.labelCash_SDA = new System.Windows.Forms.Label();
            this.labelPhone_SDA = new System.Windows.Forms.Label();
            this.labelAdres_SDA = new System.Windows.Forms.Label();
            this.labelFIO_SDA = new System.Windows.Forms.Label();
            this.labelNum_SDA = new System.Windows.Forms.Label();
            this.textBoxFIO_SDA = new System.Windows.Forms.TextBox();
            this.textBoxCash_SDA = new System.Windows.Forms.TextBox();
            this.textBoxNum_SDA = new System.Windows.Forms.TextBox();
            this.textBoxPhone_SDA = new System.Windows.Forms.TextBox();
            this.textBoxAdres_SDA = new System.Windows.Forms.TextBox();
            this.panelRes_SDA = new System.Windows.Forms.Panel();
            this.groupBoxRes_SDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_SDA = new System.Windows.Forms.DataGridView();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адресс = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Телефон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Выручка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartRes_SDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip_SDA = new System.Windows.Forms.ToolTip(this.components);
            this.TaskButton_SDA.SuspendLayout();
            this.groupBoxTask_SDA.SuspendLayout();
            this.panelInPut_SDA.SuspendLayout();
            this.groupBoxInPut_SDA.SuspendLayout();
            this.panelRes_SDA.SuspendLayout();
            this.groupBoxRes_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_SDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskButton_SDA
            // 
            this.TaskButton_SDA.Controls.Add(this.labelSearch_SDA);
            this.TaskButton_SDA.Controls.Add(this.textBoxSearch_SDA);
            this.TaskButton_SDA.Controls.Add(this.buttonSearch_SDA);
            this.TaskButton_SDA.Controls.Add(this.buttonHelp_SDA);
            this.TaskButton_SDA.Controls.Add(this.buttonSaveIn_SDA);
            this.TaskButton_SDA.Controls.Add(this.buttonDone_SDA);
            this.TaskButton_SDA.Controls.Add(this.buttonInPut_SDA);
            this.TaskButton_SDA.Controls.Add(this.groupBoxTask_SDA);
            this.TaskButton_SDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskButton_SDA.Location = new System.Drawing.Point(0, 0);
            this.TaskButton_SDA.Name = "TaskButton_SDA";
            this.TaskButton_SDA.Size = new System.Drawing.Size(1433, 100);
            this.TaskButton_SDA.TabIndex = 0;
            // 
            // labelSearch_SDA
            // 
            this.labelSearch_SDA.AutoSize = true;
            this.labelSearch_SDA.Location = new System.Drawing.Point(717, 9);
            this.labelSearch_SDA.Name = "labelSearch_SDA";
            this.labelSearch_SDA.Size = new System.Drawing.Size(95, 13);
            this.labelSearch_SDA.TabIndex = 8;
            this.labelSearch_SDA.Text = "Поиск в таблице:";
            // 
            // textBoxSearch_SDA
            // 
            this.textBoxSearch_SDA.Location = new System.Drawing.Point(720, 25);
            this.textBoxSearch_SDA.Multiline = true;
            this.textBoxSearch_SDA.Name = "textBoxSearch_SDA";
            this.textBoxSearch_SDA.Size = new System.Drawing.Size(176, 69);
            this.textBoxSearch_SDA.TabIndex = 7;
            // 
            // buttonSearch_SDA
            // 
            this.buttonSearch_SDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSearch_SDA.Location = new System.Drawing.Point(902, 6);
            this.buttonSearch_SDA.Name = "buttonSearch_SDA";
            this.buttonSearch_SDA.Size = new System.Drawing.Size(94, 91);
            this.buttonSearch_SDA.TabIndex = 6;
            this.buttonSearch_SDA.Text = "Поиск";
            this.toolTip_SDA.SetToolTip(this.buttonSearch_SDA, "Поиск определенного слова или символа в таблице");
            this.buttonSearch_SDA.UseVisualStyleBackColor = false;
            this.buttonSearch_SDA.Click += new System.EventHandler(this.buttonSearch_SDA_Click);
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonHelp_SDA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SDA.Location = new System.Drawing.Point(1336, 6);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(94, 91);
            this.buttonHelp_SDA.TabIndex = 5;
            this.buttonHelp_SDA.Text = "Справка";
            this.toolTip_SDA.SetToolTip(this.buttonHelp_SDA, "Инструкция пользования, данные создателя");
            this.buttonHelp_SDA.UseVisualStyleBackColor = false;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            // 
            // buttonSaveIn_SDA
            // 
            this.buttonSaveIn_SDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSaveIn_SDA.Location = new System.Drawing.Point(603, 6);
            this.buttonSaveIn_SDA.Name = "buttonSaveIn_SDA";
            this.buttonSaveIn_SDA.Size = new System.Drawing.Size(94, 91);
            this.buttonSaveIn_SDA.TabIndex = 4;
            this.buttonSaveIn_SDA.Text = "Сохранить в";
            this.toolTip_SDA.SetToolTip(this.buttonSaveIn_SDA, "Сохранение по выбранному пути таблицы из программы");
            this.buttonSaveIn_SDA.UseVisualStyleBackColor = false;
            this.buttonSaveIn_SDA.Click += new System.EventHandler(this.buttonSaveIn_SDA_Click);
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_SDA.Location = new System.Drawing.Point(403, 6);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(94, 91);
            this.buttonDone_SDA.TabIndex = 3;
            this.buttonDone_SDA.Text = "Добавить";
            this.toolTip_SDA.SetToolTip(this.buttonDone_SDA, "Добавление новой строки с учетом введенных данных");
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // buttonInPut_SDA
            // 
            this.buttonInPut_SDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonInPut_SDA.Location = new System.Drawing.Point(503, 6);
            this.buttonInPut_SDA.Name = "buttonInPut_SDA";
            this.buttonInPut_SDA.Size = new System.Drawing.Size(94, 91);
            this.buttonInPut_SDA.TabIndex = 2;
            this.buttonInPut_SDA.Text = "Выбрать файл";
            this.toolTip_SDA.SetToolTip(this.buttonInPut_SDA, "Добавление таблицы в программу, из выбранного файла CSV");
            this.buttonInPut_SDA.UseVisualStyleBackColor = false;
            this.buttonInPut_SDA.Click += new System.EventHandler(this.buttonInPut_SDA_Click);
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(400, 91);
            this.groupBoxTask_SDA.TabIndex = 1;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.ReadOnly = true;
            this.textBoxTask_SDA.Size = new System.Drawing.Size(387, 65);
            this.textBoxTask_SDA.TabIndex = 0;
            this.textBoxTask_SDA.Text = "Разработать Desktop приложение на основе Windows Forms по предметной области.\r\n В" +
    "се данные должны храниться в формате файла CSV \r\nПРЕДМЕТНАЯ ОБЛАСТЬ: Сеть магази" +
    "нов";
            // 
            // panelInPut_SDA
            // 
            this.panelInPut_SDA.Controls.Add(this.groupBoxInPut_SDA);
            this.panelInPut_SDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_SDA.Location = new System.Drawing.Point(0, 100);
            this.panelInPut_SDA.Name = "panelInPut_SDA";
            this.panelInPut_SDA.Size = new System.Drawing.Size(403, 350);
            this.panelInPut_SDA.TabIndex = 1;
            // 
            // groupBoxInPut_SDA
            // 
            this.groupBoxInPut_SDA.Controls.Add(this.labelCash_SDA);
            this.groupBoxInPut_SDA.Controls.Add(this.labelPhone_SDA);
            this.groupBoxInPut_SDA.Controls.Add(this.labelAdres_SDA);
            this.groupBoxInPut_SDA.Controls.Add(this.labelFIO_SDA);
            this.groupBoxInPut_SDA.Controls.Add(this.labelNum_SDA);
            this.groupBoxInPut_SDA.Controls.Add(this.textBoxFIO_SDA);
            this.groupBoxInPut_SDA.Controls.Add(this.textBoxCash_SDA);
            this.groupBoxInPut_SDA.Controls.Add(this.textBoxNum_SDA);
            this.groupBoxInPut_SDA.Controls.Add(this.textBoxPhone_SDA);
            this.groupBoxInPut_SDA.Controls.Add(this.textBoxAdres_SDA);
            this.groupBoxInPut_SDA.Location = new System.Drawing.Point(3, 6);
            this.groupBoxInPut_SDA.Name = "groupBoxInPut_SDA";
            this.groupBoxInPut_SDA.Size = new System.Drawing.Size(394, 341);
            this.groupBoxInPut_SDA.TabIndex = 0;
            this.groupBoxInPut_SDA.TabStop = false;
            this.groupBoxInPut_SDA.Text = "Ввод данных";
            // 
            // labelCash_SDA
            // 
            this.labelCash_SDA.AutoSize = true;
            this.labelCash_SDA.Location = new System.Drawing.Point(49, 321);
            this.labelCash_SDA.Name = "labelCash_SDA";
            this.labelCash_SDA.Size = new System.Drawing.Size(105, 13);
            this.labelCash_SDA.TabIndex = 2;
            this.labelCash_SDA.Text = "Выручка магазина:";
            // 
            // labelPhone_SDA
            // 
            this.labelPhone_SDA.AutoSize = true;
            this.labelPhone_SDA.Location = new System.Drawing.Point(49, 254);
            this.labelPhone_SDA.Name = "labelPhone_SDA";
            this.labelPhone_SDA.Size = new System.Drawing.Size(55, 13);
            this.labelPhone_SDA.TabIndex = 2;
            this.labelPhone_SDA.Text = "Телефон:";
            // 
            // labelAdres_SDA
            // 
            this.labelAdres_SDA.AutoSize = true;
            this.labelAdres_SDA.Location = new System.Drawing.Point(49, 178);
            this.labelAdres_SDA.Name = "labelAdres_SDA";
            this.labelAdres_SDA.Size = new System.Drawing.Size(47, 13);
            this.labelAdres_SDA.TabIndex = 2;
            this.labelAdres_SDA.Text = "Адресс:";
            // 
            // labelFIO_SDA
            // 
            this.labelFIO_SDA.AutoSize = true;
            this.labelFIO_SDA.Location = new System.Drawing.Point(49, 108);
            this.labelFIO_SDA.Name = "labelFIO_SDA";
            this.labelFIO_SDA.Size = new System.Drawing.Size(37, 13);
            this.labelFIO_SDA.TabIndex = 2;
            this.labelFIO_SDA.Text = "ФИО:";
            // 
            // labelNum_SDA
            // 
            this.labelNum_SDA.AutoSize = true;
            this.labelNum_SDA.Location = new System.Drawing.Point(49, 47);
            this.labelNum_SDA.Name = "labelNum_SDA";
            this.labelNum_SDA.Size = new System.Drawing.Size(96, 13);
            this.labelNum_SDA.TabIndex = 2;
            this.labelNum_SDA.Text = "Номер магазина:";
            // 
            // textBoxFIO_SDA
            // 
            this.textBoxFIO_SDA.BackColor = System.Drawing.Color.White;
            this.textBoxFIO_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFIO_SDA.Location = new System.Drawing.Point(161, 92);
            this.textBoxFIO_SDA.Multiline = true;
            this.textBoxFIO_SDA.Name = "textBoxFIO_SDA";
            this.textBoxFIO_SDA.Size = new System.Drawing.Size(169, 29);
            this.textBoxFIO_SDA.TabIndex = 1;
            // 
            // textBoxCash_SDA
            // 
            this.textBoxCash_SDA.BackColor = System.Drawing.Color.White;
            this.textBoxCash_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCash_SDA.Location = new System.Drawing.Point(161, 304);
            this.textBoxCash_SDA.Multiline = true;
            this.textBoxCash_SDA.Name = "textBoxCash_SDA";
            this.textBoxCash_SDA.Size = new System.Drawing.Size(169, 30);
            this.textBoxCash_SDA.TabIndex = 1;
            // 
            // textBoxNum_SDA
            // 
            this.textBoxNum_SDA.BackColor = System.Drawing.Color.White;
            this.textBoxNum_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNum_SDA.Location = new System.Drawing.Point(161, 30);
            this.textBoxNum_SDA.Multiline = true;
            this.textBoxNum_SDA.Name = "textBoxNum_SDA";
            this.textBoxNum_SDA.Size = new System.Drawing.Size(169, 30);
            this.textBoxNum_SDA.TabIndex = 1;
            // 
            // textBoxPhone_SDA
            // 
            this.textBoxPhone_SDA.BackColor = System.Drawing.Color.White;
            this.textBoxPhone_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone_SDA.Location = new System.Drawing.Point(161, 237);
            this.textBoxPhone_SDA.Multiline = true;
            this.textBoxPhone_SDA.Name = "textBoxPhone_SDA";
            this.textBoxPhone_SDA.Size = new System.Drawing.Size(169, 30);
            this.textBoxPhone_SDA.TabIndex = 1;
            // 
            // textBoxAdres_SDA
            // 
            this.textBoxAdres_SDA.BackColor = System.Drawing.Color.White;
            this.textBoxAdres_SDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAdres_SDA.Location = new System.Drawing.Point(161, 161);
            this.textBoxAdres_SDA.Multiline = true;
            this.textBoxAdres_SDA.Name = "textBoxAdres_SDA";
            this.textBoxAdres_SDA.Size = new System.Drawing.Size(169, 30);
            this.textBoxAdres_SDA.TabIndex = 0;
            // 
            // panelRes_SDA
            // 
            this.panelRes_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRes_SDA.Controls.Add(this.groupBoxRes_SDA);
            this.panelRes_SDA.Location = new System.Drawing.Point(403, 100);
            this.panelRes_SDA.Name = "panelRes_SDA";
            this.panelRes_SDA.Size = new System.Drawing.Size(1030, 350);
            this.panelRes_SDA.TabIndex = 2;
            // 
            // groupBoxRes_SDA
            // 
            this.groupBoxRes_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRes_SDA.Controls.Add(this.dataGridViewRes_SDA);
            this.groupBoxRes_SDA.Controls.Add(this.chartRes_SDA);
            this.groupBoxRes_SDA.Location = new System.Drawing.Point(6, 6);
            this.groupBoxRes_SDA.Name = "groupBoxRes_SDA";
            this.groupBoxRes_SDA.Size = new System.Drawing.Size(1021, 341);
            this.groupBoxRes_SDA.TabIndex = 0;
            this.groupBoxRes_SDA.TabStop = false;
            this.groupBoxRes_SDA.Text = "Вывод данных";
            // 
            // dataGridViewRes_SDA
            // 
            this.dataGridViewRes_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRes_SDA.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRes_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_SDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Номер,
            this.ФИО,
            this.Адресс,
            this.Телефон,
            this.Выручка});
            this.dataGridViewRes_SDA.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewRes_SDA.Name = "dataGridViewRes_SDA";
            this.dataGridViewRes_SDA.Size = new System.Drawing.Size(579, 337);
            this.dataGridViewRes_SDA.TabIndex = 1;
            // 
            // Номер
            // 
            this.Номер.HeaderText = "Номер";
            this.Номер.Name = "Номер";
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            // 
            // Адресс
            // 
            this.Адресс.HeaderText = "Адресс";
            this.Адресс.Name = "Адресс";
            // 
            // Телефон
            // 
            this.Телефон.HeaderText = "Телефон";
            this.Телефон.Name = "Телефон";
            // 
            // Выручка
            // 
            this.Выручка.HeaderText = "Выручка";
            this.Выручка.Name = "Выручка";
            // 
            // chartRes_SDA
            // 
            this.chartRes_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartRes_SDA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRes_SDA.Legends.Add(legend1);
            this.chartRes_SDA.Location = new System.Drawing.Point(591, 19);
            this.chartRes_SDA.Name = "chartRes_SDA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRes_SDA.Series.Add(series1);
            this.chartRes_SDA.Size = new System.Drawing.Size(421, 322);
            this.chartRes_SDA.TabIndex = 0;
            this.chartRes_SDA.Text = "Выручка";
            // 
            // toolTip_SDA
            // 
            this.toolTip_SDA.IsBalloon = true;
            this.toolTip_SDA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FormProject_SDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1433, 450);
            this.Controls.Add(this.panelRes_SDA);
            this.Controls.Add(this.panelInPut_SDA);
            this.Controls.Add(this.TaskButton_SDA);
            this.MinimumSize = new System.Drawing.Size(1449, 489);
            this.Name = "FormProject_SDA";
            this.Text = "Проект";
            this.TaskButton_SDA.ResumeLayout(false);
            this.TaskButton_SDA.PerformLayout();
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            this.panelInPut_SDA.ResumeLayout(false);
            this.groupBoxInPut_SDA.ResumeLayout(false);
            this.groupBoxInPut_SDA.PerformLayout();
            this.panelRes_SDA.ResumeLayout(false);
            this.groupBoxRes_SDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_SDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TaskButton_SDA;
        private System.Windows.Forms.Button buttonHelp_SDA;
        private System.Windows.Forms.Button buttonSaveIn_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.Button buttonInPut_SDA;
        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.Panel panelInPut_SDA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SDA;
        private System.Windows.Forms.Panel panelRes_SDA;
        private System.Windows.Forms.GroupBox groupBoxRes_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.Windows.Forms.TextBox textBoxFIO_SDA;
        private System.Windows.Forms.TextBox textBoxCash_SDA;
        private System.Windows.Forms.TextBox textBoxNum_SDA;
        private System.Windows.Forms.TextBox textBoxPhone_SDA;
        private System.Windows.Forms.TextBox textBoxAdres_SDA;
        private System.Windows.Forms.DataGridView dataGridViewRes_SDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_SDA;
        private System.Windows.Forms.Label labelFIO_SDA;
        private System.Windows.Forms.Label labelNum_SDA;
        private System.Windows.Forms.Label labelCash_SDA;
        private System.Windows.Forms.Label labelPhone_SDA;
        private System.Windows.Forms.Label labelAdres_SDA;
        private System.Windows.Forms.Label labelSearch_SDA;
        private System.Windows.Forms.TextBox textBoxSearch_SDA;
        private System.Windows.Forms.Button buttonSearch_SDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адресс;
        private System.Windows.Forms.DataGridViewTextBoxColumn Телефон;
        private System.Windows.Forms.DataGridViewTextBoxColumn Выручка;
        private System.Windows.Forms.ToolTip toolTip_SDA;
    }
}

