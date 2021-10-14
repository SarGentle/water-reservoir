namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSimul = new System.Windows.Forms.Button();
            this.tbHerbirove = new System.Windows.Forms.TextBox();
            this.tbPlants = new System.Windows.Forms.TextBox();
            this.tbPredators = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHerbiroveFood = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHerbiroveSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAvailabalArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCountOnAreaUnit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbGrowthSpeed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPredatorsFood = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbGrowthSpeedPred = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во растительноядных";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кол-во водорослей";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во хищных рыб";
            // 
            // chGraphic
            // 
            chartArea1.Name = "ChartArea1";
            this.chGraphic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chGraphic.Legends.Add(legend1);
            this.chGraphic.Location = new System.Drawing.Point(35, 21);
            this.chGraphic.Name = "chGraphic";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 5;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 3;
            this.chGraphic.Series.Add(series1);
            this.chGraphic.Size = new System.Drawing.Size(825, 321);
            this.chGraphic.TabIndex = 7;
            this.chGraphic.Text = "chGraphic";
            this.chGraphic.Click += new System.EventHandler(this.chGraphic_Click);
            // 
            // btnSimul
            // 
            this.btnSimul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSimul.Location = new System.Drawing.Point(40, 571);
            this.btnSimul.Name = "btnSimul";
            this.btnSimul.Size = new System.Drawing.Size(208, 40);
            this.btnSimul.TabIndex = 8;
            this.btnSimul.Text = "Симуляция";
            this.btnSimul.UseVisualStyleBackColor = true;
            this.btnSimul.Click += new System.EventHandler(this.btnSimul_Click);
            // 
            // tbHerbirove
            // 
            this.tbHerbirove.Location = new System.Drawing.Point(41, 409);
            this.tbHerbirove.Name = "tbHerbirove";
            this.tbHerbirove.Size = new System.Drawing.Size(100, 20);
            this.tbHerbirove.TabIndex = 9;
            this.tbHerbirove.Text = "100";
            // 
            // tbPlants
            // 
            this.tbPlants.Location = new System.Drawing.Point(362, 409);
            this.tbPlants.Name = "tbPlants";
            this.tbPlants.Size = new System.Drawing.Size(116, 20);
            this.tbPlants.TabIndex = 10;
            this.tbPlants.Text = "2000";
            // 
            // tbPredators
            // 
            this.tbPredators.Location = new System.Drawing.Point(680, 409);
            this.tbPredators.Name = "tbPredators";
            this.tbPredators.Size = new System.Drawing.Size(116, 20);
            this.tbPredators.TabIndex = 11;
            this.tbPredators.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Еды требуется растительноядным";
            // 
            // tbHerbiroveFood
            // 
            this.tbHerbiroveFood.Location = new System.Drawing.Point(40, 469);
            this.tbHerbiroveFood.Name = "tbHerbiroveFood";
            this.tbHerbiroveFood.Size = new System.Drawing.Size(101, 20);
            this.tbHerbiroveFood.TabIndex = 13;
            this.tbHerbiroveFood.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Скорость размножения растительноядных";
            // 
            // tbHerbiroveSpeed
            // 
            this.tbHerbiroveSpeed.Location = new System.Drawing.Point(41, 532);
            this.tbHerbiroveSpeed.Name = "tbHerbiroveSpeed";
            this.tbHerbiroveSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbHerbiroveSpeed.TabIndex = 15;
            this.tbHerbiroveSpeed.Text = "0,1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Площадь водоема";
            // 
            // tbAvailabalArea
            // 
            this.tbAvailabalArea.Location = new System.Drawing.Point(411, 578);
            this.tbAvailabalArea.Name = "tbAvailabalArea";
            this.tbAvailabalArea.Size = new System.Drawing.Size(100, 20);
            this.tbAvailabalArea.TabIndex = 17;
            this.tbAvailabalArea.Text = "10000";
            this.tbAvailabalArea.TextChanged += new System.EventHandler(this.tbAvailabalArea_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Количество водорослей на кв. м";
            // 
            // tbCountOnAreaUnit
            // 
            this.tbCountOnAreaUnit.Location = new System.Drawing.Point(362, 469);
            this.tbCountOnAreaUnit.Name = "tbCountOnAreaUnit";
            this.tbCountOnAreaUnit.Size = new System.Drawing.Size(116, 20);
            this.tbCountOnAreaUnit.TabIndex = 19;
            this.tbCountOnAreaUnit.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Скорость роста водорослей";
            // 
            // tbGrowthSpeed
            // 
            this.tbGrowthSpeed.Location = new System.Drawing.Point(362, 532);
            this.tbGrowthSpeed.Name = "tbGrowthSpeed";
            this.tbGrowthSpeed.Size = new System.Drawing.Size(116, 20);
            this.tbGrowthSpeed.TabIndex = 21;
            this.tbGrowthSpeed.Text = "500";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(679, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Еды требуется хищным";
            // 
            // tbPredatorsFood
            // 
            this.tbPredatorsFood.Location = new System.Drawing.Point(682, 469);
            this.tbPredatorsFood.Name = "tbPredatorsFood";
            this.tbPredatorsFood.Size = new System.Drawing.Size(114, 20);
            this.tbPredatorsFood.TabIndex = 23;
            this.tbPredatorsFood.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(682, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Скорость размножения хищных";
            // 
            // tbGrowthSpeedPred
            // 
            this.tbGrowthSpeedPred.Location = new System.Drawing.Point(680, 532);
            this.tbGrowthSpeedPred.Name = "tbGrowthSpeedPred";
            this.tbGrowthSpeedPred.Size = new System.Drawing.Size(116, 20);
            this.tbGrowthSpeedPred.TabIndex = 25;
            this.tbGrowthSpeedPred.Text = "0,1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(541, 581);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Длительность  жизненных циклов:";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(737, 575);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(109, 20);
            this.tbCount.TabIndex = 27;
            this.tbCount.Text = "30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 629);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbGrowthSpeedPred);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPredatorsFood);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbGrowthSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCountOnAreaUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAvailabalArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHerbiroveSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbHerbiroveFood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPredators);
            this.Controls.Add(this.tbPlants);
            this.Controls.Add(this.tbHerbirove);
            this.Controls.Add(this.btnSimul);
            this.Controls.Add(this.chGraphic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGraphic;
        private System.Windows.Forms.Button btnSimul;
        private System.Windows.Forms.TextBox tbHerbirove;
        private System.Windows.Forms.TextBox tbPlants;
        private System.Windows.Forms.TextBox tbPredators;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHerbiroveFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHerbiroveSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAvailabalArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCountOnAreaUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbGrowthSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPredatorsFood;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbGrowthSpeedPred;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCount;
    }
}

