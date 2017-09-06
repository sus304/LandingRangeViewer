namespace LandingRangeViewer
{
  partial class LandingRangeViewer
  {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingRangeViewer));
      this.Graph_Range = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.LRopen_button = new System.Windows.Forms.Button();
      this.LandingRangeFile = new System.Windows.Forms.OpenFileDialog();
      this.LaunchPoint_combo = new System.Windows.Forms.ComboBox();
      this.LandingStatus_combo = new System.Windows.Forms.ComboBox();
      this.file_textbox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button_save = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.FigName_textBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.Graph_Range)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Graph_Range
      // 
      this.Graph_Range.BackColor = System.Drawing.Color.Transparent;
      this.Graph_Range.BorderlineColor = System.Drawing.Color.Black;
      this.Graph_Range.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
      chartArea1.BackColor = System.Drawing.Color.Transparent;
      chartArea1.Name = "ChartArea1";
      this.Graph_Range.ChartAreas.Add(chartArea1);
      legend1.BackColor = System.Drawing.Color.Transparent;
      legend1.Name = "Legend1";
      this.Graph_Range.Legends.Add(legend1);
      this.Graph_Range.Location = new System.Drawing.Point(467, 13);
      this.Graph_Range.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Graph_Range.Name = "Graph_Range";
      this.Graph_Range.Size = new System.Drawing.Size(675, 675);
      this.Graph_Range.TabIndex = 0;
      this.Graph_Range.Text = "chart1";
      // 
      // LRopen_button
      // 
      this.LRopen_button.Location = new System.Drawing.Point(18, 28);
      this.LRopen_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.LRopen_button.Name = "LRopen_button";
      this.LRopen_button.Size = new System.Drawing.Size(87, 34);
      this.LRopen_button.TabIndex = 1;
      this.LRopen_button.Text = "Open";
      this.LRopen_button.UseVisualStyleBackColor = true;
      this.LRopen_button.Click += new System.EventHandler(this.LRopen_button_Click);
      // 
      // LandingRangeFile
      // 
      this.LandingRangeFile.FileName = "Landing_Range_v2.csv";
      // 
      // LaunchPoint_combo
      // 
      this.LaunchPoint_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.LaunchPoint_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.LaunchPoint_combo.FormattingEnabled = true;
      this.LaunchPoint_combo.Location = new System.Drawing.Point(127, 101);
      this.LaunchPoint_combo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.LaunchPoint_combo.Name = "LaunchPoint_combo";
      this.LaunchPoint_combo.Size = new System.Drawing.Size(301, 26);
      this.LaunchPoint_combo.TabIndex = 2;
      this.LaunchPoint_combo.SelectedIndexChanged += new System.EventHandler(this.LaunchPoint_combo_SelectedIndexChanged);
      // 
      // LandingStatus_combo
      // 
      this.LandingStatus_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.LandingStatus_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.LandingStatus_combo.FormattingEnabled = true;
      this.LandingStatus_combo.Location = new System.Drawing.Point(127, 135);
      this.LandingStatus_combo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.LandingStatus_combo.Name = "LandingStatus_combo";
      this.LandingStatus_combo.Size = new System.Drawing.Size(127, 26);
      this.LandingStatus_combo.TabIndex = 3;
      this.LandingStatus_combo.SelectedIndexChanged += new System.EventHandler(this.LandingStatus_combo_SelectedIndexChanged);
      // 
      // file_textbox
      // 
      this.file_textbox.Location = new System.Drawing.Point(18, 69);
      this.file_textbox.Name = "file_textbox";
      this.file_textbox.ReadOnly = true;
      this.file_textbox.Size = new System.Drawing.Size(425, 25);
      this.file_textbox.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 138);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(106, 18);
      this.label2.TabIndex = 6;
      this.label2.Text = "Ballistic / Decent";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 104);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(82, 18);
      this.label3.TabIndex = 7;
      this.label3.Text = "Launch Point";
      // 
      // button_save
      // 
      this.button_save.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.button_save.Location = new System.Drawing.Point(18, 246);
      this.button_save.Name = "button_save";
      this.button_save.Size = new System.Drawing.Size(413, 48);
      this.button_save.TabIndex = 8;
      this.button_save.Text = "Image Save";
      this.button_save.UseVisualStyleBackColor = true;
      this.button_save.Click += new System.EventHandler(this.button_save_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.FigName_textBox);
      this.groupBox1.Controls.Add(this.button_save);
      this.groupBox1.Controls.Add(this.LRopen_button);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.file_textbox);
      this.groupBox1.Controls.Add(this.LaunchPoint_combo);
      this.groupBox1.Controls.Add(this.LandingStatus_combo);
      this.groupBox1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.groupBox1.Location = new System.Drawing.Point(12, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(449, 321);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Landing Range File";
      // 
      // FigName_textBox
      // 
      this.FigName_textBox.Location = new System.Drawing.Point(18, 215);
      this.FigName_textBox.Name = "FigName_textBox";
      this.FigName_textBox.Size = new System.Drawing.Size(413, 25);
      this.FigName_textBox.TabIndex = 9;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 194);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(109, 18);
      this.label1.TabIndex = 10;
      this.label1.Text = "Image File Name";
      // 
      // LandingRangeViewer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1148, 703);
      this.Controls.Add(this.Graph_Range);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "LandingRangeViewer";
      this.ShowIcon = false;
      this.Text = "Landing Range Viewer";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.Graph_Range)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart Graph_Range;
    private System.Windows.Forms.Button LRopen_button;
    private System.Windows.Forms.OpenFileDialog LandingRangeFile;
    private System.Windows.Forms.ComboBox LaunchPoint_combo;
    private System.Windows.Forms.ComboBox LandingStatus_combo;
    private System.Windows.Forms.TextBox file_textbox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button_save;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox FigName_textBox;
    private System.Windows.Forms.Label label1;
  }
}

