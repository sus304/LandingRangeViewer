using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LandingRangeViewer
{
  public partial class LandingRangeViewer : Form
  {
    LandingRange landingrange = new LandingRange();
    LaunchPointImege LPImage = new LaunchPointImege();
    int flag_LaunchPoint = 999;
    int flag_LandingStatus = 0;

    public LandingRangeViewer()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      LaunchPoint_combo.Items.Add("Noshiro_Asanai_Land");
      LaunchPoint_combo.Items.Add("Noshiro_Ochiai_Sea_3km");
      LaunchPoint_combo.Items.Add("Noshiro_Ochiai_Sea_4.5km");

      LandingStatus_combo.Items.Add("Ballistic");
      LandingStatus_combo.Items.Add("Decent");

      //色指定
      Graph_Range.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
      Graph_Range.BorderlineColor = Color.Black;
      //グラフminmaxの指定=>射点に合わせて変えるのでここのはあまり意味なし
      Graph_Range.ChartAreas[0].AxisX.Minimum = -4000.0;
      Graph_Range.ChartAreas[0].AxisX.Maximum = 4000.0;
      Graph_Range.ChartAreas[0].AxisX.Interval = 100.0;
      Graph_Range.ChartAreas[0].AxisY.Minimum = -4000.0;
      Graph_Range.ChartAreas[0].AxisY.Maximum = 4000.0;
      Graph_Range.ChartAreas[0].AxisY.Interval = 100.0;
      //サイズ指定
      Graph_Range.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
      Graph_Range.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
      Graph_Range.ChartAreas[0].InnerPlotPosition.Auto = false;
      Graph_Range.ChartAreas[0].InnerPlotPosition.Width = 100;
      Graph_Range.ChartAreas[0].InnerPlotPosition.Height = 100;
      Graph_Range.ChartAreas[0].InnerPlotPosition.X = 0;
      Graph_Range.ChartAreas[0].InnerPlotPosition.Y = 0;
      Graph_Range.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
      Graph_Range.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
      Graph_Range.ChartAreas[0].Position.Height = 100;
      Graph_Range.ChartAreas[0].Position.Width = 100;
      
    }

    //LandingRangeファイルのRead
    private void LRopen_button_Click(object sender, EventArgs e)
    {
      string file_path = null;
      int i;

      LandingRangeFile.InitialDirectory = System.IO.Path.GetFullPath("../result");
      LandingRangeFile.Title = "Select Landing Range File";
      LandingRangeFile.CheckFileExists = true;
      LandingRangeFile.CheckPathExists = true;
      if (LandingRangeFile.ShowDialog() == DialogResult.OK) file_path = System.IO.Path.GetFullPath(LandingRangeFile.FileName);

      if (file_path != null)
      {
        System.IO.StreamReader dataFile;
        string line;
        string[] linearray;
        file_textbox.Text = file_path;
        dataFile = new System.IO.StreamReader(file_path);
        for (i = 0; i <= 55; i++)
        {
          line = dataFile.ReadLine();
          if (line == null) break;
          linearray = line.Split(',');
          landingrange.setValue(i, linearray);
        }
        dataFile.Close();
        Plot(flag_LandingStatus);
      }
    }

    //射点選択イベント
    //画像は正方形であること
    private void LaunchPoint_combo_SelectedIndexChanged(object sender, EventArgs e)
    {
      flag_LaunchPoint = LaunchPoint_combo.SelectedIndex;

      switch (flag_LaunchPoint)
      {
        case 0:
          LPImage.NoshiroLand3rd();
          break;
        case 1:
          LPImage.NoshiroSea3km();
          break;
        case 2:
          LPImage.NoshiroSea45km();
          break;
      }
      DrawImg();
      FigName_textBox.Text = getFigName();
    }

    // 背景画像の描画
    public void DrawImg()
    {
      double PixelScale;
      double ScaleFactor_;
      
      Graph_Range.BackImage = LPImage.ImageName;
      Graph_Range.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;

      //Width =>グラフminmaxの指定
      PixelScale = (double)Graph_Range.Size.Width / LPImage.ImgWidth;
      ScaleFactor_ = LPImage.ScaleFactor / PixelScale;
      Graph_Range.ChartAreas[0].AxisX.Minimum = -LPImage.launchpoint[0] * PixelScale * ScaleFactor_;
      Graph_Range.ChartAreas[0].AxisX.Maximum = ((LPImage.ImgWidth * PixelScale) - (LPImage.launchpoint[0] * PixelScale)) * ScaleFactor_;
      Graph_Range.ChartAreas[0].AxisX.Interval = LPImage.interval;
      //Height =>グラフminmaxの指定
      PixelScale = (double)Graph_Range.Size.Height / LPImage.ImgHeight;
      ScaleFactor_ = LPImage.ScaleFactor / PixelScale;
      Graph_Range.ChartAreas[0].AxisY.Minimum = -((LPImage.ImgHeight * PixelScale) - (LPImage.launchpoint[1] * PixelScale)) * ScaleFactor_;
      Graph_Range.ChartAreas[0].AxisY.Maximum = LPImage.launchpoint[1] * PixelScale * ScaleFactor_;
      Graph_Range.ChartAreas[0].AxisY.Interval = LPImage.interval;
    }    
    
    //着地選択イベント
    private void LandingStatus_combo_SelectedIndexChanged(object sender, EventArgs e)
    {
      flag_LandingStatus = LandingStatus_combo.SelectedIndex;
      Plot(flag_LandingStatus);
      FigName_textBox.Text = getFigName();
    }

    //分散プロット
    public void Plot(int flag_landingstatus)
    {
      int i, k;
      int landingstatus_x = 0, landingstatus_y = 1;
      double[] pos = new double[2];
      Graph_Range.Series.Clear();
      Graph_Range.Series.Add("1m/s");
      Graph_Range.Series.Add("2m/s");
      Graph_Range.Series.Add("3m/s");
      Graph_Range.Series.Add("4m/s");
      Graph_Range.Series.Add("5m/s");
      Graph_Range.Series.Add("6m/s");
      Graph_Range.Series.Add("7m/s");

      if (flag_landingstatus == 0)
      {
        landingstatus_x = 0;
        landingstatus_y = 1;
      }
      if (flag_landingstatus == 1)
      {
        landingstatus_x = 2;
        landingstatus_y = 3;
      }

      for (i = 0; i <= 55; i++)
      {
        k = (int)Math.Floor((double)i / 8.0);
        if (i % 8 == 0)
        {
          Graph_Range.Series[k].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
          Graph_Range.Series[k].Color = Color.Orange;

          if (i != 0)
          {
            pos = landingrange.getValue(i - 8, landingstatus_x, landingstatus_y);
            Graph_Range.Series[k-1].Points.AddXY(pos[0], pos[1]);
          }
        }

        pos = landingrange.getValue(i, landingstatus_x, landingstatus_y);
        Graph_Range.Series[k].Points.AddXY(pos[0], pos[1]);
      }
      pos = landingrange.getValue(i - 8, landingstatus_x, landingstatus_y);
      Graph_Range.Series[6].Points.AddXY(pos[0], pos[1]);

      for (i = 0; i <= 6; i++)
      {
        Graph_Range.Series[i].IsVisibleInLegend = false;
      }

      return;
    }

    //画像ファイル名生成
    public string getFigName()
    {
      string LP = "None";
      string LS = "None";

      if (LaunchPoint_combo.SelectedItem != null)
      {
        LP = LaunchPoint_combo.SelectedItem.ToString();
      }
        
      if (LandingStatus_combo.SelectedItem != null)
      {
        LS = LandingStatus_combo.SelectedItem.ToString();
      }

      return LP + "_" + LS;
    }

    //分散画像保存
    private void button_save_Click(object sender, EventArgs e)
    {
      string filename;
      Bitmap bmp = new Bitmap(Graph_Range.Width, Graph_Range.Height);
      Graph_Range.DrawToBitmap(bmp, new Rectangle(0, 0, Graph_Range.Width, Graph_Range.Height));
      filename = System.IO.Path.GetFullPath("./") + "/" + FigName_textBox.Text + ".png";
      bmp.Save(filename);
      bmp.Dispose();
    }

  }

  //落下地点
  class LandingRange
  {
    double[,] range = new double[56,4];

    public void setValue(int index, string[] array)
    {
      int i;
      for (i = 0; i <= 3; i++)
      {
        range[index, i] = double.Parse(array[i]);
      }
      return;
    }

    public double[] getValue(int index,int i, int j)
    {
      double[] pos = new double[2];
      pos[0] = range[index, i];
      pos[1] = range[index, j];
      
      return pos;
    }    
  }

  // 背景画像とその縮尺
  class LaunchPointImege
  {
    public double ScaleFactor;
    public int[] launchpoint = new int[2];
    public string ImageName;
    public double interval;
    public double ImgWidth;
    public double ImgHeight;

    //能代陸.第3鉱滓堆積場
    public void NoshiroLand3rd()
    {
      launchpoint[0] = 326;
      launchpoint[1] = 367;
      ScaleFactor = 100.0 / 58.0; // m/px
      ImageName = "NoshiroLand";
      interval = 50.0;
      ImgWidth = (double)LRV.Properties.Resources.NoshiroLand.Width;
      ImgHeight = (double)LRV.Properties.Resources.NoshiroLand.Height;
    }

    //能代海.保安円3.0km
    public void NoshiroSea3km()
    {
      launchpoint[0] = 890;
      launchpoint[1] = 655;
      ScaleFactor = 500.0 / 129.0; // m/px
      ImageName = "_3km";
      interval = 200.0;
      ImgWidth = (double)LRV.Properties.Resources._3km.Width;
      ImgHeight = (double)LRV.Properties.Resources._3km.Height;
    }

    //能代海.保安円4.5km
    public void NoshiroSea45km()
    {
      launchpoint[0] = 900;
      launchpoint[1] = 658;
      ScaleFactor = 1000.0 / 84.0; // m/px
      ImageName = "_4_5km";
      interval = 200.0;
      ImgWidth = (double)LRV.Properties.Resources._4_5km.Width;
      ImgHeight = (double)LRV.Properties.Resources._4_5km.Height;
    }
  }
}
