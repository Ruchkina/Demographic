
namespace Demographic.WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.start = new System.Windows.Forms.Button();
            this.Population = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartYear = new System.Windows.Forms.TextBox();
            this.EndYear = new System.Windows.Forms.TextBox();
            this.PopulationAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PopulationGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PopulationTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(706, 411);
            this.start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(172, 135);
            this.start.TabIndex = 19;
            this.start.Text = "!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Population
            // 
            this.Population.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Population.Location = new System.Drawing.Point(1094, 542);
            this.Population.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Population.Name = "Population";
            this.Population.Size = new System.Drawing.Size(164, 43);
            this.Population.TabIndex = 18;
            this.Population.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(917, 545);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Population";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1009, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "End";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1001, 411);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Start";
            // 
            // StartYear
            // 
            this.StartYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartYear.Location = new System.Drawing.Point(1094, 408);
            this.StartYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartYear.Name = "StartYear";
            this.StartYear.Size = new System.Drawing.Size(164, 43);
            this.StartYear.TabIndex = 14;
            this.StartYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EndYear
            // 
            this.EndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndYear.Location = new System.Drawing.Point(1094, 473);
            this.EndYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndYear.Name = "EndYear";
            this.EndYear.Size = new System.Drawing.Size(164, 43);
            this.EndYear.TabIndex = 13;
            this.EndYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PopulationAge
            // 
            chartArea1.Name = "ChartArea1";
            this.PopulationAge.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PopulationAge.Legends.Add(legend1);
            this.PopulationAge.Location = new System.Drawing.Point(-8, 349);
            this.PopulationAge.Name = "PopulationAge";
            this.PopulationAge.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "PopulationWomanAge";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "PopulationManAge";
            this.PopulationAge.Series.Add(series1);
            this.PopulationAge.Series.Add(series2);
            this.PopulationAge.Size = new System.Drawing.Size(638, 243);
            this.PopulationAge.TabIndex = 23;
            this.PopulationAge.Text = "PopulationAge";
            // 
            // PopulationGender
            // 
            chartArea2.Name = "ChartArea1";
            this.PopulationGender.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PopulationGender.Legends.Add(legend2);
            this.PopulationGender.Location = new System.Drawing.Point(654, 35);
            this.PopulationGender.Name = "PopulationGender";
            this.PopulationGender.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "PopulationWonam";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "PopulationMan";
            this.PopulationGender.Series.Add(series3);
            this.PopulationGender.Series.Add(series4);
            this.PopulationGender.Size = new System.Drawing.Size(638, 290);
            this.PopulationGender.TabIndex = 22;
            this.PopulationGender.Text = "PopulationGender";
            // 
            // PopulationTotal
            // 
            chartArea3.Name = "ChartArea1";
            this.PopulationTotal.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.PopulationTotal.Legends.Add(legend3);
            this.PopulationTotal.Location = new System.Drawing.Point(-8, 35);
            this.PopulationTotal.Name = "PopulationTotal";
            this.PopulationTotal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "population";
            this.PopulationTotal.Series.Add(series5);
            this.PopulationTotal.Size = new System.Drawing.Size(638, 290);
            this.PopulationTotal.TabIndex = 21;
            this.PopulationTotal.Text = "Population";
            this.PopulationTotal.Click += new System.EventHandler(this.PopulationTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 626);
            this.Controls.Add(this.PopulationAge);
            this.Controls.Add(this.PopulationGender);
            this.Controls.Add(this.PopulationTotal);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Population);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartYear);
            this.Controls.Add(this.EndYear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PopulationAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox Population;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StartYear;
        private System.Windows.Forms.TextBox EndYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart PopulationAge;
        private System.Windows.Forms.DataVisualization.Charting.Chart PopulationGender;
        private System.Windows.Forms.DataVisualization.Charting.Chart PopulationTotal;
    }
}

