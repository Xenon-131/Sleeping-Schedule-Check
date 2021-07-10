namespace Sleeping_Schedule_Check
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.add_s_button = new System.Windows.Forms.Button();
      this.sleep_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.awake_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.going_to_sleep = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.waking_up = new System.Windows.Forms.DateTimePicker();
      this.getting_up = new System.Windows.Forms.DateTimePicker();
      this.add_w_button = new System.Windows.Forms.Button();
      this.add_g_button = new System.Windows.Forms.Button();
      this.add_r_button = new System.Windows.Forms.Button();
      this.ready = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.sleep_chart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.awake_chart)).BeginInit();
      this.SuspendLayout();
      // 
      // add_s_button
      // 
      this.add_s_button.Cursor = System.Windows.Forms.Cursors.Hand;
      this.add_s_button.Location = new System.Drawing.Point(167, 52);
      this.add_s_button.Name = "add_s_button";
      this.add_s_button.Size = new System.Drawing.Size(75, 37);
      this.add_s_button.TabIndex = 3;
      this.add_s_button.Text = "Add";
      this.add_s_button.UseVisualStyleBackColor = true;
      this.add_s_button.Click += new System.EventHandler(this.add_s_button_Click);
      // 
      // sleep_chart
      // 
      chartArea3.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
      chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
      chartArea3.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
      chartArea3.AxisX.ScrollBar.BackColor = System.Drawing.Color.Transparent;
      chartArea3.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Transparent;
      chartArea3.AxisX.ScrollBar.LineColor = System.Drawing.Color.Transparent;
      chartArea3.BackColor = System.Drawing.Color.Transparent;
      chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
      chartArea3.BorderColor = System.Drawing.Color.Transparent;
      chartArea3.BorderWidth = 0;
      chartArea3.Name = "ChartArea1";
      chartArea3.ShadowColor = System.Drawing.Color.Transparent;
      this.sleep_chart.ChartAreas.Add(chartArea3);
      this.sleep_chart.Location = new System.Drawing.Point(297, 25);
      this.sleep_chart.Name = "sleep_chart";
      series5.ChartArea = "ChartArea1";
      series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series5.CustomProperties = "IsXAxisQuantitative=False";
      series5.Name = "Series1";
      series5.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
      series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
      series5.YValuesPerPoint = 4;
      series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
      this.sleep_chart.Series.Add(series5);
      this.sleep_chart.Size = new System.Drawing.Size(889, 233);
      this.sleep_chart.TabIndex = 4;
      this.sleep_chart.Text = "chart1";
      // 
      // awake_chart
      // 
      chartArea4.Name = "ChartArea1";
      this.awake_chart.ChartAreas.Add(chartArea4);
      this.awake_chart.Location = new System.Drawing.Point(297, 267);
      this.awake_chart.Name = "awake_chart";
      series6.ChartArea = "ChartArea1";
      series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series6.Name = "W";
      series6.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
      series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
      series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
      series7.ChartArea = "ChartArea1";
      series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series7.Name = "G";
      series7.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
      series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
      series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
      series8.ChartArea = "ChartArea1";
      series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series8.Name = "R";
      series8.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
      series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
      series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
      this.awake_chart.Series.Add(series6);
      this.awake_chart.Series.Add(series7);
      this.awake_chart.Series.Add(series8);
      this.awake_chart.Size = new System.Drawing.Size(889, 370);
      this.awake_chart.TabIndex = 5;
      this.awake_chart.Text = "chart2";
      // 
      // going_to_sleep
      // 
      this.going_to_sleep.Cursor = System.Windows.Forms.Cursors.Default;
      this.going_to_sleep.CustomFormat = "  hh : mm";
      this.going_to_sleep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.going_to_sleep.Location = new System.Drawing.Point(49, 61);
      this.going_to_sleep.MinDate = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
      this.going_to_sleep.Name = "going_to_sleep";
      this.going_to_sleep.Size = new System.Drawing.Size(87, 26);
      this.going_to_sleep.TabIndex = 6;
      this.going_to_sleep.Value = System.DateTime.Today.AddDays(-1);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(45, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(108, 20);
      this.label1.TabIndex = 7;
      this.label1.Text = "going to sleep";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(45, 107);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 20);
      this.label2.TabIndex = 8;
      this.label2.Text = "waking up";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(45, 197);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 20);
      this.label3.TabIndex = 9;
      this.label3.Text = "getting up";
      // 
      // waking_up
      // 
      this.waking_up.CustomFormat = "  hh : mm";
      this.waking_up.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.waking_up.Location = new System.Drawing.Point(49, 149);
      this.waking_up.Name = "waking_up";
      this.waking_up.Size = new System.Drawing.Size(87, 26);
      this.waking_up.TabIndex = 10;
      this.waking_up.Value = System.DateTime.Today;
      // 
      // getting_up
      // 
      this.getting_up.CustomFormat = "  hh : mm";
      this.getting_up.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.getting_up.Location = new System.Drawing.Point(49, 239);
      this.getting_up.Name = "getting_up";
      this.getting_up.Size = new System.Drawing.Size(87, 26);
      this.getting_up.TabIndex = 11;
      this.getting_up.Value = System.DateTime.Today;
      // 
      // add_w_button
      // 
      this.add_w_button.Location = new System.Drawing.Point(167, 138);
      this.add_w_button.Name = "add_w_button";
      this.add_w_button.Size = new System.Drawing.Size(75, 37);
      this.add_w_button.TabIndex = 12;
      this.add_w_button.Text = "Add";
      this.add_w_button.UseVisualStyleBackColor = true;
      this.add_w_button.Click += new System.EventHandler(this.add_w_button_Click);
      // 
      // add_g_button
      // 
      this.add_g_button.Location = new System.Drawing.Point(167, 229);
      this.add_g_button.Name = "add_g_button";
      this.add_g_button.Size = new System.Drawing.Size(75, 37);
      this.add_g_button.TabIndex = 13;
      this.add_g_button.Text = "Add";
      this.add_g_button.UseVisualStyleBackColor = true;
      this.add_g_button.Click += new System.EventHandler(this.add_g_button_Click);
      // 
      // add_r_button
      // 
      this.add_r_button.Location = new System.Drawing.Point(167, 316);
      this.add_r_button.Name = "add_r_button";
      this.add_r_button.Size = new System.Drawing.Size(75, 37);
      this.add_r_button.TabIndex = 17;
      this.add_r_button.Text = "Add";
      this.add_r_button.UseVisualStyleBackColor = true;
      this.add_r_button.Click += new System.EventHandler(this.add_r_button_Click);
      // 
      // ready
      // 
      this.ready.CustomFormat = "  hh : mm";
      this.ready.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.ready.Location = new System.Drawing.Point(49, 327);
      this.ready.Name = "ready";
      this.ready.Size = new System.Drawing.Size(87, 26);
      this.ready.TabIndex = 16;
      this.ready.Value = System.DateTime.Today;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(45, 289);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 20);
      this.label4.TabIndex = 15;
      this.label4.Text = "ready";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1468, 649);
      this.Controls.Add(this.add_r_button);
      this.Controls.Add(this.ready);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.add_g_button);
      this.Controls.Add(this.add_w_button);
      this.Controls.Add(this.getting_up);
      this.Controls.Add(this.waking_up);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.going_to_sleep);
      this.Controls.Add(this.awake_chart);
      this.Controls.Add(this.sleep_chart);
      this.Controls.Add(this.add_s_button);
      this.Name = "Form1";
      this.Text = "Sleeping schedule check";
      ((System.ComponentModel.ISupportInitialize)(this.sleep_chart)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.awake_chart)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button add_s_button;
    private System.Windows.Forms.DataVisualization.Charting.Chart sleep_chart;
    private System.Windows.Forms.DataVisualization.Charting.Chart awake_chart;
    private System.Windows.Forms.DateTimePicker going_to_sleep;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DateTimePicker waking_up;
    private System.Windows.Forms.DateTimePicker getting_up;
    private System.Windows.Forms.Button add_w_button;
    private System.Windows.Forms.Button add_g_button;
    private System.Windows.Forms.Button add_r_button;
    private System.Windows.Forms.DateTimePicker ready;
    private System.Windows.Forms.Label label4;
  }
}

