using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sleeping_Schedule_Check
{
  public partial class Form1 : Form
  {

    public void show_chart_points(DataPointCollection points, string path)
    {
      using (StreamReader sr = new StreamReader(path))
      {
        System.DateTime x;
        string line;
        while ((line = sr.ReadLine()) != null)
        {
          x = System.DateTime.Parse(line);
          points.AddXY(x, x);
        }
      }
    }

    public void add_point(DateTimePicker input, DataPointCollection points, string path)
    {
      System.DateTime x = input.Value;
      points.AddXY(x, x);

      using (StreamWriter sw = new StreamWriter(path, true))
      {
        sw.WriteLine(x.ToString());
      }
    }

    public Form1()
    {
      InitializeComponent();

      this.sleep_chart.Series[0].Points.Clear();
      this.awake_chart.Series[0].Points.Clear();
      this.awake_chart.Series[1].Points.Clear();
      this.awake_chart.Series[2].Points.Clear();

      show_chart_points(sleep_chart.Series[0].Points, @"C:\Users\kseni\source\repos\Sleeping Schedule Check\points\points_for_sleep_chart.txt");
      show_chart_points(awake_chart.Series[0].Points, @"C:\Users\kseni\source\repos\Sleeping Schedule Check\points\points_for_w.txt");
      show_chart_points(awake_chart.Series[1].Points, @"C:\Users\kseni\source\repos\Sleeping Schedule Check\points\points_for_g.txt");
      show_chart_points(awake_chart.Series[2].Points, @"C:\Users\kseni\source\repos\Sleeping Schedule Check\points\points_for_r.txt");
    }

    private void add_s_button_Click(object sender, EventArgs e)
    {
      add_point(going_to_sleep, sleep_chart.Series[0].Points, @"C:\Users\kseni\source\repos\Sleeping Schedule Check\points\points_for_sleep_chart.txt");     
    }

    private void add_w_button_Click(object sender, EventArgs e)
    {
      add_point(waking_up, awake_chart.Series[0].Points, @"C:\Users\kseni\source\repos\Sleeping Schedule Check\points\points_for_w.txt");
    }

    private void add_g_button_Click(object sender, EventArgs e)
    {
      add_point(getting_up, awake_chart.Series[1].Points, @"C:\Users\kseni\source\repos\Sleeping Schedule Check\points\points_for_g.txt");
    }

    private void add_r_button_Click(object sender, EventArgs e)
    {
      add_point(ready, awake_chart.Series[2].Points, @"C:\Users\kseni\source\repos\Sleeping Schedule Check\points\points_for_r.txt");
    }
  }
}
