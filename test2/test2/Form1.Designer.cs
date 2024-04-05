
namespace test2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries1 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries2 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartSeries easyChartSeries1 = new SeeSharpTools.JY.GUI.EasyChartSeries();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.easyChartX1 = new SeeSharpTools.JY.GUI.EasyChartX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.led1 = new SeeSharpTools.JY.GUI.LED();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.textBoxI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxVA = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxQ2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxphi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxpp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.easyChartX2 = new SeeSharpTools.JY.GUI.EasyChartX();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.fl = new System.Windows.Forms.Label();
            this.fh = new System.Windows.Forms.Label();
            this.textlow = new System.Windows.Forms.TextBox();
            this.textfh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxfs = new System.Windows.Forms.TextBox();
            this.easyChart2 = new SeeSharpTools.JY.GUI.EasyChart();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1381, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "停止采集";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1255, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "开始采集";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // easyChartX1
            // 
            this.easyChartX1.AutoClear = true;
            this.easyChartX1.AxisX.AutoScale = true;
            this.easyChartX1.AxisX.AutoScalingMode = SeeSharpTools.JY.GUI.EasyChartXAxis.AutoScaleMode.ByGridCount;
            this.easyChartX1.AxisX.AutoZoomReset = false;
            this.easyChartX1.AxisX.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisX.InitWithScaleView = false;
            this.easyChartX1.AxisX.IsLogarithmic = false;
            this.easyChartX1.AxisX.LabelAngle = 0;
            this.easyChartX1.AxisX.LabelEnabled = true;
            this.easyChartX1.AxisX.LabelFormat = null;
            this.easyChartX1.AxisX.LogarithmBase = 10D;
            this.easyChartX1.AxisX.LogLabelStyle = SeeSharpTools.JY.GUI.EasyChartXAxis.LogarithmicLabelStyle.E2;
            this.easyChartX1.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX.MajorGridCount = -1;
            this.easyChartX1.AxisX.MajorGridEnabled = true;
            this.easyChartX1.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX1.AxisX.MaxGridCountPerPixel = 0.012D;
            this.easyChartX1.AxisX.Maximum = 1000D;
            this.easyChartX1.AxisX.MinGridCountPerPixel = 0.004D;
            this.easyChartX1.AxisX.Minimum = 1D;
            this.easyChartX1.AxisX.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX1.AxisX.MinorGridEnabled = false;
            this.easyChartX1.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX1.AxisX.ShowLogarithmicLines = false;
            this.easyChartX1.AxisX.TickLineColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX.TickWidth = 1F;
            this.easyChartX1.AxisX.Title = "";
            this.easyChartX1.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisX.ViewMaximum = 1000D;
            this.easyChartX1.AxisX.ViewMinimum = 0D;
            this.easyChartX1.AxisX2.AutoScale = true;
            this.easyChartX1.AxisX2.AutoScalingMode = SeeSharpTools.JY.GUI.EasyChartXAxis.AutoScaleMode.ByGridCount;
            this.easyChartX1.AxisX2.AutoZoomReset = false;
            this.easyChartX1.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisX2.InitWithScaleView = false;
            this.easyChartX1.AxisX2.IsLogarithmic = false;
            this.easyChartX1.AxisX2.LabelAngle = 0;
            this.easyChartX1.AxisX2.LabelEnabled = true;
            this.easyChartX1.AxisX2.LabelFormat = null;
            this.easyChartX1.AxisX2.LogarithmBase = 10D;
            this.easyChartX1.AxisX2.LogLabelStyle = SeeSharpTools.JY.GUI.EasyChartXAxis.LogarithmicLabelStyle.E2;
            this.easyChartX1.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX2.MajorGridCount = -1;
            this.easyChartX1.AxisX2.MajorGridEnabled = true;
            this.easyChartX1.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX1.AxisX2.MaxGridCountPerPixel = 0.012D;
            this.easyChartX1.AxisX2.Maximum = 1000D;
            this.easyChartX1.AxisX2.MinGridCountPerPixel = 0.004D;
            this.easyChartX1.AxisX2.Minimum = 0D;
            this.easyChartX1.AxisX2.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX1.AxisX2.MinorGridEnabled = false;
            this.easyChartX1.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX1.AxisX2.ShowLogarithmicLines = false;
            this.easyChartX1.AxisX2.TickLineColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX2.TickWidth = 1F;
            this.easyChartX1.AxisX2.Title = "";
            this.easyChartX1.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisX2.ViewMaximum = 1000D;
            this.easyChartX1.AxisX2.ViewMinimum = 0D;
            this.easyChartX1.AxisY.AutoScale = true;
            this.easyChartX1.AxisY.AutoScalingMode = SeeSharpTools.JY.GUI.EasyChartXAxis.AutoScaleMode.ByGridCount;
            this.easyChartX1.AxisY.AutoZoomReset = false;
            this.easyChartX1.AxisY.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisY.InitWithScaleView = false;
            this.easyChartX1.AxisY.IsLogarithmic = false;
            this.easyChartX1.AxisY.LabelAngle = 0;
            this.easyChartX1.AxisY.LabelEnabled = true;
            this.easyChartX1.AxisY.LabelFormat = null;
            this.easyChartX1.AxisY.LogarithmBase = 10D;
            this.easyChartX1.AxisY.LogLabelStyle = SeeSharpTools.JY.GUI.EasyChartXAxis.LogarithmicLabelStyle.E2;
            this.easyChartX1.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY.MajorGridCount = 6;
            this.easyChartX1.AxisY.MajorGridEnabled = true;
            this.easyChartX1.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX1.AxisY.MaxGridCountPerPixel = 0.012D;
            this.easyChartX1.AxisY.Maximum = 3D;
            this.easyChartX1.AxisY.MinGridCountPerPixel = 0.004D;
            this.easyChartX1.AxisY.Minimum = 0D;
            this.easyChartX1.AxisY.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX1.AxisY.MinorGridEnabled = false;
            this.easyChartX1.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX1.AxisY.ShowLogarithmicLines = false;
            this.easyChartX1.AxisY.TickLineColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY.TickWidth = 1F;
            this.easyChartX1.AxisY.Title = "";
            this.easyChartX1.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisY.ViewMaximum = 3.5D;
            this.easyChartX1.AxisY.ViewMinimum = 0.5D;
            this.easyChartX1.AxisY2.AutoScale = true;
            this.easyChartX1.AxisY2.AutoScalingMode = SeeSharpTools.JY.GUI.EasyChartXAxis.AutoScaleMode.ByGridCount;
            this.easyChartX1.AxisY2.AutoZoomReset = false;
            this.easyChartX1.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisY2.InitWithScaleView = false;
            this.easyChartX1.AxisY2.IsLogarithmic = false;
            this.easyChartX1.AxisY2.LabelAngle = 0;
            this.easyChartX1.AxisY2.LabelEnabled = true;
            this.easyChartX1.AxisY2.LabelFormat = null;
            this.easyChartX1.AxisY2.LogarithmBase = 10D;
            this.easyChartX1.AxisY2.LogLabelStyle = SeeSharpTools.JY.GUI.EasyChartXAxis.LogarithmicLabelStyle.E2;
            this.easyChartX1.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY2.MajorGridCount = 6;
            this.easyChartX1.AxisY2.MajorGridEnabled = true;
            this.easyChartX1.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX1.AxisY2.MaxGridCountPerPixel = 0.012D;
            this.easyChartX1.AxisY2.Maximum = 3.5D;
            this.easyChartX1.AxisY2.MinGridCountPerPixel = 0.004D;
            this.easyChartX1.AxisY2.Minimum = 0.5D;
            this.easyChartX1.AxisY2.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX1.AxisY2.MinorGridEnabled = false;
            this.easyChartX1.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX1.AxisY2.ShowLogarithmicLines = false;
            this.easyChartX1.AxisY2.TickLineColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY2.TickWidth = 1F;
            this.easyChartX1.AxisY2.Title = "";
            this.easyChartX1.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisY2.ViewMaximum = 3.5D;
            this.easyChartX1.AxisY2.ViewMinimum = 0.5D;
            this.easyChartX1.BackColor = System.Drawing.Color.White;
            this.easyChartX1.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartX1.Cumulitive = false;
            this.easyChartX1.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX1.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChartX1.LegendForeColor = System.Drawing.Color.Black;
            this.easyChartX1.LegendVisible = true;
            easyChartXSeries1.Color = System.Drawing.Color.Red;
            easyChartXSeries1.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries1.Name = "Series1";
            easyChartXSeries1.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries1.Visible = true;
            easyChartXSeries1.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX1.LineSeries.Add(easyChartXSeries1);
            this.easyChartX1.Location = new System.Drawing.Point(15, 15);
            this.easyChartX1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.easyChartX1.Miscellaneous.CheckInfinity = false;
            this.easyChartX1.Miscellaneous.CheckNaN = false;
            this.easyChartX1.Miscellaneous.CheckNegtiveOrZero = false;
            this.easyChartX1.Miscellaneous.DataStorage = SeeSharpTools.JY.GUI.DataStorageType.Clone;
            this.easyChartX1.Miscellaneous.DirectionChartCount = 3;
            this.easyChartX1.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChartX1.Miscellaneous.MarkerSize = 7;
            this.easyChartX1.Miscellaneous.MaxSeriesCount = 32;
            this.easyChartX1.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChartX1.Miscellaneous.ShowFunctionMenu = true;
            this.easyChartX1.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChartX1.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChartX1.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChartX1.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChartX1.Name = "easyChartX1";
            this.easyChartX1.SeriesCount = 0;
            this.easyChartX1.Size = new System.Drawing.Size(897, 283);
            this.easyChartX1.SplitView = false;
            this.easyChartX1.TabIndex = 2;
            this.easyChartX1.XCursor.AutoInterval = true;
            this.easyChartX1.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX1.XCursor.Interval = 0.001D;
            this.easyChartX1.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Zoom;
            this.easyChartX1.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX1.XCursor.Value = double.NaN;
            this.easyChartX1.YCursor.AutoInterval = true;
            this.easyChartX1.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX1.YCursor.Interval = 0.001D;
            this.easyChartX1.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Disabled;
            this.easyChartX1.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX1.YCursor.Value = double.NaN;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // led1
            // 
            this.led1.BlinkColor = System.Drawing.Color.Lime;
            this.led1.BlinkInterval = 1000;
            this.led1.BlinkOn = false;
            this.led1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.led1.Interacton = SeeSharpTools.JY.GUI.LED.InteractionStyle.Indicator;
            this.led1.Location = new System.Drawing.Point(1072, 53);
            this.led1.Margin = new System.Windows.Forms.Padding(4);
            this.led1.Name = "led1";
            this.led1.OffColor = System.Drawing.Color.Gray;
            this.led1.OnColor = System.Drawing.Color.Lime;
            this.led1.Size = new System.Drawing.Size(90, 90);
            this.led1.Style = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.led1.TabIndex = 3;
            this.led1.Value = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1255, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 91);
            this.button3.TabIndex = 4;
            this.button3.Text = "导出采集数据为csv格式";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1391, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 91);
            this.button4.TabIndex = 5;
            this.button4.Text = "多功能电表计算";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(1241, 382);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(100, 35);
            this.textBoxV.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1173, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vrms";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Location = new System.Drawing.Point(1387, 388);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(58, 24);
            this.labelI.TabIndex = 8;
            this.labelI.Text = "Irms";
            // 
            // textBoxI
            // 
            this.textBoxI.Location = new System.Drawing.Point(1434, 382);
            this.textBoxI.Name = "textBoxI";
            this.textBoxI.Size = new System.Drawing.Size(100, 35);
            this.textBoxI.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1211, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "P";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(1241, 431);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 35);
            this.textBoxP.TabIndex = 11;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(1434, 431);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 35);
            this.textBoxQ.TabIndex = 12;
            // 
            // textBoxVA
            // 
            this.textBoxVA.Location = new System.Drawing.Point(1241, 485);
            this.textBoxVA.Name = "textBoxVA";
            this.textBoxVA.Size = new System.Drawing.Size(100, 35);
            this.textBoxVA.TabIndex = 13;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(1434, 485);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 35);
            this.textBoxT.TabIndex = 14;
            // 
            // textBoxQ2
            // 
            this.textBoxQ2.Location = new System.Drawing.Point(1241, 544);
            this.textBoxQ2.Name = "textBoxQ2";
            this.textBoxQ2.Size = new System.Drawing.Size(100, 35);
            this.textBoxQ2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1411, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Q";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1212, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "S";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1409, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "T";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1207, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Q2";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1537, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 84);
            this.button5.TabIndex = 20;
            this.button5.Text = "生成测试数据";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1541, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "ms";
            // 
            // textBoxphi
            // 
            this.textBoxphi.Location = new System.Drawing.Point(1434, 544);
            this.textBoxphi.Name = "textBoxphi";
            this.textBoxphi.Size = new System.Drawing.Size(100, 35);
            this.textBoxphi.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1394, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "θ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1135, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "功率因数";
            // 
            // textBoxpp
            // 
            this.textBoxpp.Location = new System.Drawing.Point(1241, 606);
            this.textBoxpp.Name = "textBoxpp";
            this.textBoxpp.Size = new System.Drawing.Size(100, 35);
            this.textBoxpp.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1345, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "V";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1541, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1345, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 24);
            this.label12.TabIndex = 29;
            this.label12.Text = "W";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1345, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 24);
            this.label13.TabIndex = 30;
            this.label13.Text = "VA";
            // 
            // easyChartX2
            // 
            this.easyChartX2.AutoClear = true;
            this.easyChartX2.AutoSize = true;
            this.easyChartX2.AxisX.AutoScale = true;
            this.easyChartX2.AxisX.AutoScalingMode = SeeSharpTools.JY.GUI.EasyChartXAxis.AutoScaleMode.ByGridCount;
            this.easyChartX2.AxisX.AutoZoomReset = false;
            this.easyChartX2.AxisX.Color = System.Drawing.Color.Black;
            this.easyChartX2.AxisX.InitWithScaleView = false;
            this.easyChartX2.AxisX.IsLogarithmic = false;
            this.easyChartX2.AxisX.LabelAngle = 0;
            this.easyChartX2.AxisX.LabelEnabled = true;
            this.easyChartX2.AxisX.LabelFormat = null;
            this.easyChartX2.AxisX.LogarithmBase = 10D;
            this.easyChartX2.AxisX.LogLabelStyle = SeeSharpTools.JY.GUI.EasyChartXAxis.LogarithmicLabelStyle.E2;
            this.easyChartX2.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX2.AxisX.MajorGridCount = -1;
            this.easyChartX2.AxisX.MajorGridEnabled = true;
            this.easyChartX2.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX2.AxisX.MaxGridCountPerPixel = 0.012D;
            this.easyChartX2.AxisX.Maximum = 1000D;
            this.easyChartX2.AxisX.MinGridCountPerPixel = 0.004D;
            this.easyChartX2.AxisX.Minimum = 0D;
            this.easyChartX2.AxisX.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX2.AxisX.MinorGridEnabled = false;
            this.easyChartX2.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX2.AxisX.ShowLogarithmicLines = false;
            this.easyChartX2.AxisX.TickLineColor = System.Drawing.Color.Black;
            this.easyChartX2.AxisX.TickWidth = 1F;
            this.easyChartX2.AxisX.Title = "";
            this.easyChartX2.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX2.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX2.AxisX.ViewMaximum = 1000D;
            this.easyChartX2.AxisX.ViewMinimum = 0D;
            this.easyChartX2.AxisX2.AutoScale = true;
            this.easyChartX2.AxisX2.AutoScalingMode = SeeSharpTools.JY.GUI.EasyChartXAxis.AutoScaleMode.ByGridCount;
            this.easyChartX2.AxisX2.AutoZoomReset = false;
            this.easyChartX2.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChartX2.AxisX2.InitWithScaleView = false;
            this.easyChartX2.AxisX2.IsLogarithmic = false;
            this.easyChartX2.AxisX2.LabelAngle = 0;
            this.easyChartX2.AxisX2.LabelEnabled = true;
            this.easyChartX2.AxisX2.LabelFormat = null;
            this.easyChartX2.AxisX2.LogarithmBase = 10D;
            this.easyChartX2.AxisX2.LogLabelStyle = SeeSharpTools.JY.GUI.EasyChartXAxis.LogarithmicLabelStyle.E2;
            this.easyChartX2.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX2.AxisX2.MajorGridCount = -1;
            this.easyChartX2.AxisX2.MajorGridEnabled = true;
            this.easyChartX2.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX2.AxisX2.MaxGridCountPerPixel = 0.012D;
            this.easyChartX2.AxisX2.Maximum = 1000D;
            this.easyChartX2.AxisX2.MinGridCountPerPixel = 0.004D;
            this.easyChartX2.AxisX2.Minimum = 0D;
            this.easyChartX2.AxisX2.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX2.AxisX2.MinorGridEnabled = false;
            this.easyChartX2.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX2.AxisX2.ShowLogarithmicLines = false;
            this.easyChartX2.AxisX2.TickLineColor = System.Drawing.Color.Black;
            this.easyChartX2.AxisX2.TickWidth = 1F;
            this.easyChartX2.AxisX2.Title = "";
            this.easyChartX2.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX2.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX2.AxisX2.ViewMaximum = 1000D;
            this.easyChartX2.AxisX2.ViewMinimum = 0D;
            this.easyChartX2.AxisY.AutoScale = true;
            this.easyChartX2.AxisY.AutoScalingMode = SeeSharpTools.JY.GUI.EasyChartXAxis.AutoScaleMode.ByGridCount;
            this.easyChartX2.AxisY.AutoZoomReset = false;
            this.easyChartX2.AxisY.Color = System.Drawing.Color.Black;
            this.easyChartX2.AxisY.InitWithScaleView = false;
            this.easyChartX2.AxisY.IsLogarithmic = false;
            this.easyChartX2.AxisY.LabelAngle = 0;
            this.easyChartX2.AxisY.LabelEnabled = true;
            this.easyChartX2.AxisY.LabelFormat = null;
            this.easyChartX2.AxisY.LogarithmBase = 10D;
            this.easyChartX2.AxisY.LogLabelStyle = SeeSharpTools.JY.GUI.EasyChartXAxis.LogarithmicLabelStyle.E2;
            this.easyChartX2.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX2.AxisY.MajorGridCount = 6;
            this.easyChartX2.AxisY.MajorGridEnabled = true;
            this.easyChartX2.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX2.AxisY.MaxGridCountPerPixel = 0.012D;
            this.easyChartX2.AxisY.Maximum = 3.5D;
            this.easyChartX2.AxisY.MinGridCountPerPixel = 0.004D;
            this.easyChartX2.AxisY.Minimum = 0.5D;
            this.easyChartX2.AxisY.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX2.AxisY.MinorGridEnabled = false;
            this.easyChartX2.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX2.AxisY.ShowLogarithmicLines = false;
            this.easyChartX2.AxisY.TickLineColor = System.Drawing.Color.Black;
            this.easyChartX2.AxisY.TickWidth = 1F;
            this.easyChartX2.AxisY.Title = "";
            this.easyChartX2.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX2.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX2.AxisY.ViewMaximum = 3.5D;
            this.easyChartX2.AxisY.ViewMinimum = 0.5D;
            this.easyChartX2.AxisY2.AutoScale = true;
            this.easyChartX2.AxisY2.AutoScalingMode = SeeSharpTools.JY.GUI.EasyChartXAxis.AutoScaleMode.ByGridCount;
            this.easyChartX2.AxisY2.AutoZoomReset = false;
            this.easyChartX2.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChartX2.AxisY2.InitWithScaleView = false;
            this.easyChartX2.AxisY2.IsLogarithmic = false;
            this.easyChartX2.AxisY2.LabelAngle = 0;
            this.easyChartX2.AxisY2.LabelEnabled = true;
            this.easyChartX2.AxisY2.LabelFormat = null;
            this.easyChartX2.AxisY2.LogarithmBase = 10D;
            this.easyChartX2.AxisY2.LogLabelStyle = SeeSharpTools.JY.GUI.EasyChartXAxis.LogarithmicLabelStyle.E2;
            this.easyChartX2.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX2.AxisY2.MajorGridCount = 6;
            this.easyChartX2.AxisY2.MajorGridEnabled = true;
            this.easyChartX2.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChartX2.AxisY2.MaxGridCountPerPixel = 0.012D;
            this.easyChartX2.AxisY2.Maximum = 3.5D;
            this.easyChartX2.AxisY2.MinGridCountPerPixel = 0.004D;
            this.easyChartX2.AxisY2.Minimum = 0.5D;
            this.easyChartX2.AxisY2.MinorGridColor = System.Drawing.Color.DimGray;
            this.easyChartX2.AxisY2.MinorGridEnabled = false;
            this.easyChartX2.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChartX2.AxisY2.ShowLogarithmicLines = false;
            this.easyChartX2.AxisY2.TickLineColor = System.Drawing.Color.Black;
            this.easyChartX2.AxisY2.TickWidth = 1F;
            this.easyChartX2.AxisY2.Title = "";
            this.easyChartX2.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX2.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX2.AxisY2.ViewMaximum = 3.5D;
            this.easyChartX2.AxisY2.ViewMinimum = 0.5D;
            this.easyChartX2.BackColor = System.Drawing.Color.White;
            this.easyChartX2.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartX2.Cumulitive = false;
            this.easyChartX2.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX2.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX2.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChartX2.LegendForeColor = System.Drawing.Color.Black;
            this.easyChartX2.LegendVisible = true;
            easyChartXSeries2.Color = System.Drawing.Color.Red;
            easyChartXSeries2.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries2.Name = "Series1";
            easyChartXSeries2.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries2.Visible = true;
            easyChartXSeries2.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries2.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries2.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX2.LineSeries.Add(easyChartXSeries2);
            this.easyChartX2.Location = new System.Drawing.Point(15, 296);
            this.easyChartX2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.easyChartX2.Miscellaneous.CheckInfinity = false;
            this.easyChartX2.Miscellaneous.CheckNaN = false;
            this.easyChartX2.Miscellaneous.CheckNegtiveOrZero = false;
            this.easyChartX2.Miscellaneous.DataStorage = SeeSharpTools.JY.GUI.DataStorageType.Clone;
            this.easyChartX2.Miscellaneous.DirectionChartCount = 3;
            this.easyChartX2.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChartX2.Miscellaneous.MarkerSize = 7;
            this.easyChartX2.Miscellaneous.MaxSeriesCount = 32;
            this.easyChartX2.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChartX2.Miscellaneous.ShowFunctionMenu = true;
            this.easyChartX2.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChartX2.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChartX2.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChartX2.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChartX2.Name = "easyChartX2";
            this.easyChartX2.SeriesCount = 0;
            this.easyChartX2.Size = new System.Drawing.Size(897, 337);
            this.easyChartX2.SplitView = false;
            this.easyChartX2.TabIndex = 31;
            this.easyChartX2.XCursor.AutoInterval = true;
            this.easyChartX2.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX2.XCursor.Interval = 0.001D;
            this.easyChartX2.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Zoom;
            this.easyChartX2.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX2.XCursor.Value = double.NaN;
            this.easyChartX2.YCursor.AutoInterval = true;
            this.easyChartX2.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChartX2.YCursor.Interval = 0.001D;
            this.easyChartX2.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Disabled;
            this.easyChartX2.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX2.YCursor.Value = double.NaN;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1537, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 48);
            this.button6.TabIndex = 32;
            this.button6.Text = "读取数据";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1569, 649);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 46);
            this.button8.TabIndex = 34;
            this.button8.Text = "确定滤波";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // fl
            // 
            this.fl.AutoSize = true;
            this.fl.Location = new System.Drawing.Point(1158, 660);
            this.fl.Name = "fl";
            this.fl.Size = new System.Drawing.Size(70, 24);
            this.fl.TabIndex = 35;
            this.fl.Text = "fPass";
            // 
            // fh
            // 
            this.fh.AutoSize = true;
            this.fh.Location = new System.Drawing.Point(1368, 666);
            this.fh.Name = "fh";
            this.fh.Size = new System.Drawing.Size(70, 24);
            this.fh.TabIndex = 36;
            this.fh.Text = "fStop";
            // 
            // textlow
            // 
            this.textlow.Location = new System.Drawing.Point(1241, 661);
            this.textlow.Name = "textlow";
            this.textlow.Size = new System.Drawing.Size(100, 35);
            this.textlow.TabIndex = 37;
            // 
            // textfh
            // 
            this.textfh.Location = new System.Drawing.Point(1433, 658);
            this.textfh.Name = "textfh";
            this.textfh.Size = new System.Drawing.Size(100, 35);
            this.textfh.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(922, 662);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 24);
            this.label14.TabIndex = 39;
            this.label14.Text = "采样频率";
            // 
            // textBoxfs
            // 
            this.textBoxfs.Location = new System.Drawing.Point(1034, 659);
            this.textBoxfs.Name = "textBoxfs";
            this.textBoxfs.Size = new System.Drawing.Size(100, 35);
            this.textBoxfs.TabIndex = 40;
            // 
            // easyChart2
            // 
            this.easyChart2.AxisX.AutoScale = true;
            this.easyChart2.AxisX.InitWithScaleView = false;
            this.easyChart2.AxisX.LabelEnabled = true;
            this.easyChart2.AxisX.LabelFormat = "";
            this.easyChart2.AxisX.Maximum = 1001D;
            this.easyChart2.AxisX.Minimum = 0D;
            this.easyChart2.AxisX.Orientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart2.AxisX.Position = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChart2.AxisX.Title = "";
            this.easyChart2.AxisX.ViewMaximum = 1001D;
            this.easyChart2.AxisX.ViewMinimum = 0D;
            this.easyChart2.AxisY.AutoScale = true;
            this.easyChart2.AxisY.InitWithScaleView = false;
            this.easyChart2.AxisY.LabelEnabled = true;
            this.easyChart2.AxisY.LabelFormat = "";
            this.easyChart2.AxisY.Maximum = 3.5D;
            this.easyChart2.AxisY.Minimum = 0D;
            this.easyChart2.AxisY.Orientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart2.AxisY.Position = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChart2.AxisY.Title = "";
            this.easyChart2.AxisY.ViewMaximum = 3.5D;
            this.easyChart2.AxisY.ViewMinimum = 0D;
            this.easyChart2.AxisYMax = 3.5D;
            this.easyChart2.AxisYMin = 0D;
            this.easyChart2.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChart2.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChart2.GradientStyle = SeeSharpTools.JY.GUI.EasyChart.EasyChartGradientStyle.None;
            this.easyChart2.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart2.LegendVisible = true;
            easyChartSeries1.InterpolationStyle = SeeSharpTools.JY.GUI.EasyChartSeries.Interpolation.FastLine;
            easyChartSeries1.MarkerType = SeeSharpTools.JY.GUI.EasyChartSeries.PointStyle.None;
            easyChartSeries1.Width = SeeSharpTools.JY.GUI.EasyChartSeries.LineWidth.Thin;
            this.easyChart2.LineSeries.Add(easyChartSeries1);
            this.easyChart2.Location = new System.Drawing.Point(15, 630);
            this.easyChart2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart2.MajorGridEnabled = true;
            this.easyChart2.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart2.MinorGridEnabled = false;
            this.easyChart2.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart2.Name = "easyChart2";
            this.easyChart2.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart2.SeriesNames = new string[] {
        "Series1",
        "Series2",
        "Series3",
        "Series4",
        "Series5",
        "Series6",
        "Series7",
        "Series8",
        "Series9",
        "Series10",
        "Series11",
        "Series12",
        "Series13",
        "Series14",
        "Series15",
        "Series16",
        "Series17",
        "Series18",
        "Series19",
        "Series20",
        "Series21",
        "Series22",
        "Series23",
        "Series24",
        "Series25",
        "Series26",
        "Series27",
        "Series28",
        "Series29",
        "Series30",
        "Series31",
        "Series32"};
            this.easyChart2.Size = new System.Drawing.Size(897, 361);
            this.easyChart2.TabIndex = 42;
            this.easyChart2.XAxisLogarithmic = false;
            this.easyChart2.XAxisTitle = "";
            this.easyChart2.XCursor.AutoInterval = true;
            this.easyChart2.XCursor.Color = System.Drawing.Color.Red;
            this.easyChart2.XCursor.Interval = 1D;
            this.easyChart2.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartCursor.CursorMode.Zoom;
            this.easyChart2.XCursor.Value = double.NaN;
            this.easyChart2.XTitleOrientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart2.XTitlePosition = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChart2.YAutoEnable = true;
            this.easyChart2.YAxisLogarithmic = false;
            this.easyChart2.YAxisTitle = "";
            this.easyChart2.YCursor.AutoInterval = true;
            this.easyChart2.YCursor.Color = System.Drawing.Color.Red;
            this.easyChart2.YCursor.Interval = 0.001D;
            this.easyChart2.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartCursor.CursorMode.Disabled;
            this.easyChart2.YCursor.Value = double.NaN;
            this.easyChart2.YTitleOrientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart2.YTitlePosition = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1130, 738);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 46);
            this.button7.TabIndex = 43;
            this.button7.Text = "电压FFT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(967, 738);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(123, 46);
            this.button9.TabIndex = 44;
            this.button9.Text = "电流FFT";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1072, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 35);
            this.textBox1.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(984, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 24);
            this.label15.TabIndex = 46;
            this.label15.Text = "文件名";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1728, 996);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.easyChart2);
            this.Controls.Add(this.textBoxfs);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textfh);
            this.Controls.Add(this.textlow);
            this.Controls.Add(this.fh);
            this.Controls.Add(this.fl);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.easyChartX2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxpp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxphi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQ2);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxVA);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxI);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.easyChartX1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX1;
        private System.Windows.Forms.Timer timer1;
        private SeeSharpTools.JY.GUI.LED led1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.TextBox textBoxI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxVA;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxQ2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxphi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxpp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textfh;
        private System.Windows.Forms.TextBox textlow;
        private System.Windows.Forms.Label fh;
        private System.Windows.Forms.Label fl;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBoxfs;
        private System.Windows.Forms.Label label14;
        private SeeSharpTools.JY.GUI.EasyChart easyChart2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
    }
}

