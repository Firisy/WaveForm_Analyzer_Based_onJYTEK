using JYUSB61902;
using SeeSharpTools.JY.DSP.FilteringMCR;
using SeeSharpTools.JY.DSP.Fundamental;
using SeeSharpTools.JY.DSP.Utility;
using SeeSharpTools.JY.GUI;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace test2
{
    public partial class Form1 : Form
    {
        private JYUSB61902AITask aitask;
        public static EasyChartX EasyChart2;
        double[,] readvalue = new double[5000, 5];
        double[] FFT_Showvol = new double[10000];
        double[] FFT_Showcur = new double[10000];
        double df2 = 0;
        int periodLength;
        public Form1()
        {
            MessageBox.Show("请耐心等待程序启动。。。");
            IIRFilter.Initialize();
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            led1.Value = true;
            aitask = new JYUSB61902AITask(0);
            aitask.AddChannel(0, -10, 10, AITerminal.RSE);
            aitask.AddChannel(1, -10, 10, AITerminal.RSE);
            aitask.AddChannel(2, -10, 10, AITerminal.RSE);
            aitask.AddChannel(3, -10, 10, AITerminal.RSE);
            aitask.Mode = AIMode.Continuous;
            aitask.SampleRate = 10000;
            //aitask.SamplesToAcquire = 1000;

            aitask.Start();
            timer1.Enabled = true;

        }
        double[] vol = new double[5000];
        double[] cur = new double[5000];
        double[] vol2 = new double[5000];
        double[] cur2 = new double[5000];
        double[] vol3 = new double[5000];
        double[] cur3 = new double[5000];
        double fs;
        private void timer1_Tick(object sender, EventArgs e)
        {

            aitask.ReadData(ref readvalue);
            for (int i = 0; i < readvalue.GetLength(0); i++)
            {
                vol[i] = readvalue[i, 0]*100;
                cur[i] = readvalue[i, 1];
                vol2[i] = readvalue[i, 2]*100;
                //cur2[i] = readvalue[i, 3];
                vol3[i] = readvalue[i, 3] * 100;
                //cur3[i] = readvalue[i, 5];
            }
            //IIRFilter.ProcessLowpass(cur, 0.1, 100);
            double[,] displayvol = new double[3, 5000];
            displayval(vol,vol2,vol3,ref displayvol);
            easyChartX1.Plot(displayvol);
            double[,] displaycur = new double[3, 5000];
            displayval(cur,cur2,cur3, ref displaycur);
            easyChartX2.Plot(displaycur);
            if (led1.Value) led1.Value = false;
            else led1.Value = true;
        }
        void displayval(double[] val1,double[] val2,double[] val3, ref double[,] displayvalues)
        {
            for(int i=0;i<5000;i++)
            {
                displayvalues[0, i] = val1[i];
                displayvalues[1, i] = val2[i];
                displayvalues[2, i] = val3[i];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            aitask.Stop();
            timer1.Stop();
            timer1.Enabled = false;
            led1.Value = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filename="保存文件";
            //打开文件对话框，选择文件保存路径
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv文件|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
            }
            //将数据存入csv文件
            using (StreamWriter file = new StreamWriter(filename, true))
            {
                file.Write("vol\n");
                for (int j = 0; j < 5000; j++)
                {
                    file.Write(vol[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
                file.Write("cur\n");
                for (int j = 0; j < 5000; j++)
                {
                    file.Write(cur[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
                file.Write("FFT_vol\n");
                for (int j = 0; j < FFT_Showvol.Length; j++)
                {
                    file.Write(FFT_Showvol[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
                file.Write("FFT_cur\n");
                for (int j = 0; j < FFT_Showcur.Length; j++)
                {
                    file.Write(FFT_Showcur[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
               
                file.Write("vol2\n");
                for (int j = 0; j < 5000; j++)
                {
                    file.Write(vol2[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
                file.Write("cur2\n");
                for (int j = 0; j < 5000; j++)
                {
                    file.Write(cur2[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
                file.Write("FFT_vol2\n");
                for (int j = 0; j < FFT_Showvol2.Length; j++)
                {
                    file.Write(FFT_Showvol2[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
                file.Write("FFT_cur2\n");
                for (int j = 0; j < FFT_Showcur2.Length; j++)
                {
                    file.Write(FFT_Showcur2[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
                file.Write("vol3\n");
                for (int j = 0; j < 5000; j++)
                {
                    file.Write(vol3[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
                file.Write("cur3\n");
                for (int j = 0; j < 5000; j++)
                {
                    file.Write(cur3[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
                file.Write("FFT_vol3\n");
                for (int j = 0; j < FFT_Showvol3.Length; j++)
                {
                    file.Write(FFT_Showvol3[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
                file.Write("FFT_cur3\n");
                for (int j = 0; j < FFT_Showcur3.Length; j++)
                {
                    file.Write(FFT_Showcur3[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxfs.Text == "")
            {
                MessageBox.Show("请输入采样频率");
                return;
            }
            double fs = double.Parse(textBoxfs.Text);
            //CalculatorVI.CalT(vol, out periodLength,fs);
            if(vol.Length==0)
            {
                MessageBox.Show("请先采集数据");
                return;
            }
            double phi;
            textBox4.Text = Phase.CalPhaseShift(vol, vol2).ToString("0.###");
            textBox5.Text = Phase.CalPhaseShift(vol, vol3).ToString("0.###");
            phi = Phase.CalPhaseShift(vol, cur);
            textBoxphi.Text = phi.ToString("0.###");
            textBoxpp.Text = Math.Cos(phi / 180 * 3.1415926).ToString();
            ToneInfo volinfo;

            volinfo = ToneAnalyzer.SingleToneAnalysis(vol, fs);
            textBoxT.Text = ((1.0 / volinfo.Frequency) * 1000).ToString("0.###"); // 保留三位小数
                                                                                  // 
            periodLength = (int)((1.0 / volinfo.Frequency) * fs);

            textBox1.Text = (volinfo.Amplitude).ToString("0.###");
            textBoxV.Text = CalculatorVI.CalVrms(vol, periodLength).ToString("0.###");
            textBoxI.Text = CalculatorVI.CalIrms(cur, periodLength).ToString("0.###"); // 保留三位小数  
            textBoxP.Text = CalculatorVI.CalP(vol, cur, periodLength).ToString("0.###"); // 保留三位小数  
            textBoxVA.Text = CalculatorVI.CalVA1().ToString("0.###"); // 保留三位小数  
            textBoxQ2.Text = CalculatorVI.CalQ2(vol, cur, periodLength).ToString("0.###"); // 保留三位小数  
            textBoxQ.Text = CalculatorVI.CalQ1().ToString("0.###"); // 保留三位小数

                //phi = Phase.CalPhaseShift(vol2, cur2);
                if (vol2[0] == 0) return;
                volinfo = ToneAnalyzer.SingleToneAnalysis(vol2, fs);
                textBoxT2.Text = ((1.0 / volinfo.Frequency) * 1000).ToString("0.###"); // 保留三位小数
                textBox2.Text = (volinfo.Amplitude).ToString("0.###");
                //textBoxang_2.Text = phi.ToString("0.###");
                //textBoxpp_2.Text = Math.Cos(phi / 180 * 3.1415926).ToString();
                textBox13.Text = CalculatorVI.CalVrms(vol2, periodLength).ToString("0.###");
               // textBox12.Text = CalculatorVI.CalIrms(cur2, periodLength).ToString("0.###"); // 保留三位小数  
                //textBoxP2.Text = CalculatorVI.CalP(vol2, cur2, periodLength).ToString("0.###"); // 保留三位小数  
                //textBoxS2.Text = CalculatorVI.CalVA1().ToString("0.###"); // 保留三位小数  
                //textBoxQ2_2.Text = CalculatorVI.CalQ2(vol2, cur2, periodLength).ToString("0.###"); // 保留三位小数  
                //textBoxQ_2.Text = CalculatorVI.CalQ1().ToString("0.###"); // 保留三位小数


                if (vol3[0] == 0) return;
                //phi = Phase.CalPhaseShift(vol3, cur3);
                volinfo = ToneAnalyzer.SingleToneAnalysis(vol3, fs);
                textBoxT_3.Text = ((1.0 / volinfo.Frequency) * 1000).ToString("0.###"); // 保留三位小数
                textBox3.Text = (volinfo.Amplitude).ToString("0.###");
                //textBoxang_3.Text = phi.ToString("0.###");
                //textBoxpp3.Text = Math.Cos(phi / 180 * 3.1415926).ToString();
                textBoxV3.Text = CalculatorVI.CalVrms(vol3, periodLength).ToString("0.###");
                //textBoxI3.Text = CalculatorVI.CalIrms(cur3, periodLength).ToString("0.###"); // 保留三位小数  
                //textBoxP3.Text = CalculatorVI.CalP(vol3, cur3, periodLength).ToString("0.###"); // 保留三位小数  
                //textBoxS_3.Text = CalculatorVI.CalVA1().ToString("0.###"); // 保留三位小数  
                //textBoxQ2_3.Text = CalculatorVI.CalQ2(vol3, cur3, periodLength).ToString("0.###"); // 保留三位小数  
                //textBoxQ_3.Text = CalculatorVI.CalQ1().ToString("0.###"); // 保留三位小数

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                string[] lines = System.IO.File.ReadAllLines(filename);
                /*int cal = 0;
                for (int i = 12; i < 5012; i++)
                {
                    string[] values = lines[i].Split(',');
                    vol[cal] = Convert.ToDouble(values[1]) * 100;
                    cur[cal] = Convert.ToDouble(values[2]);
                    cal++;
                }*/
                //读取csv文件，将数据存入vol和cur数组中，数据的格式为：第二行为电压，第四行为电流
                string[] values = lines[1].Split(',');//Split方法将字符串分割成字符串数组
                int maxLength = Math.Min(5000, Math.Min(vol.Length, cur.Length));
                for (int i = 0; i < maxLength; i++)
                {
                    vol[i] = Convert.ToDouble(values[i])*100;
                }
                values = lines[3].Split(',');
                for (int i = 0; i < maxLength; i++)
                {
                    cur[i] = Convert.ToDouble(values[i]);
                }
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                string[] lines = System.IO.File.ReadAllLines(filename);
                /*int cal = 0;
                for (int i = 12; i < 5012; i++)
                {
                    string[] values = lines[i].Split(',');
                    vol[cal] = Convert.ToDouble(values[1]) * 100;
                    cur[cal] = Convert.ToDouble(values[2]);
                    cal++;
                }*/
                //读取csv文件，将数据存入vol和cur数组中，数据的格式为：第二行为电压，第四行为电流
                string[] values = lines[1].Split(',');//Split方法将字符串分割成字符串数组
                int maxLength = Math.Min(5000, Math.Min(vol.Length, cur.Length));
                for (int i = 0; i < maxLength; i++)
                {
                    vol2[i] = Convert.ToDouble(values[i]) * 100;
                }
                values = lines[3].Split(',');
                for (int i = 0; i < maxLength; i++)
                {
                    cur2[i] = Convert.ToDouble(values[i]);
                }
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                string[] lines = System.IO.File.ReadAllLines(filename);
                /*int cal = 0;
                for (int i = 12; i < 5012; i++)
                {
                    string[] values = lines[i].Split(',');
                    vol[cal] = Convert.ToDouble(values[1]) * 100;
                    cur[cal] = Convert.ToDouble(values[2]);
                    cal++;
                }*/
                //读取csv文件，将数据存入vol和cur数组中，数据的格式为：第二行为电压，第四行为电流
                string[] values = lines[1].Split(',');//Split方法将字符串分割成字符串数组
                int maxLength = Math.Min(5000, Math.Min(vol.Length, cur.Length));
                for (int i = 0; i < maxLength; i++)
                {
                    vol3[i] = Convert.ToDouble(values[i]) * 100;
                }
                values = lines[3].Split(',');
                for (int i = 0; i < maxLength; i++)
                {
                    cur3[i] = Convert.ToDouble(values[i]);
                }
            }
            double[,] displayvol = new double[3, 5000];
            displayval(vol, vol2, vol3, ref displayvol);
            easyChartX1.Plot(displayvol);
            double[,] displaycur = new double[3, 5000];
            displayval(cur, cur2, cur3, ref displaycur);
            easyChartX2.Plot(displaycur);
        }
        private void button8_Click(object sender, EventArgs e)
        {

            if (textlow.Text == "")
            {
                MessageBox.Show("请输入fPass");
                return;
            }

            double fpass = double.Parse(textlow.Text);
            if (textfh.Text == "")
            {
                MessageBox.Show("请输入fStop");
                return;
            }
            double fstop = double.Parse(textfh.Text);
            if (textBoxfs.Text == "")
            {
                MessageBox.Show("请输入采样频率");
                return;
            }
            fs = double.Parse(textBoxfs.Text);

            CalculatorVI.filter_input(vol, fpass, fstop, fs, out vol);
            CalculatorVI.filter_input(cur, fpass, fstop, fs, out cur);
            this.Update();
            easyChartX1.Plot(vol);
            easyChartX2.Plot(cur);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxfs.Text == "")
            {
                MessageBox.Show("请输入采样频率");
                return;
            }
            fs = double.Parse(textBoxfs.Text);
            CalculatorVI.FFT_showing(vol, fs, ref df2, out FFT_Showvol);
            this.Update();
            easyChart2.Plot(FFT_Showvol, 0, df2);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxfs.Text == "")
            {
                MessageBox.Show("请输入采样频率");
                return;
            }
            fs = double.Parse(textBoxfs.Text);
            CalculatorVI.FFT_showing(cur, fs, ref df2, out FFT_Showcur);
            easyChart2.Plot(FFT_Showcur, 0, df2);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int i = 0;
            timer1.Enabled = false;
            double[] waveform1 = new double[10000];
            double[] waveform2 = new double[10000];
            Generation.SineWave(ref waveform1,10, 0, 50, 1000);  //软件产生正弦波形1
            Generation.SineWave(ref waveform2, 100, -45, 50, 1000);  //软件产生正弦波形2
            for (i = 0; i < 5000; i++)
            {
                vol[i] = waveform1[i];
                cur[i] = waveform2[i];
            }
            easyChartX1.Plot(vol);
            easyChartX2.Plot(cur);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBoxfl2.Text == "")
            {
                MessageBox.Show("请输入fPass");
                return;
            }

            double fpass = double.Parse(textBoxfl2.Text);
            if (textBoxfh2.Text == "")
            { 
                MessageBox.Show("请输入fStop");
                return;
            }
            double fstop = double.Parse(textBoxfh2.Text);
            if (textBoxfs.Text == "")
            {
                MessageBox.Show("请输入采样频率");
                return;
            }
            fs = double.Parse(textBoxfs.Text);

            CalculatorVI.filter_input(vol2, fpass, fstop, fs, out vol);
            CalculatorVI.filter_input(cur2, fpass, fstop, fs, out cur);
            this.Update();
            easyChartX1.Plot(vol2);
            easyChartX2.Plot(cur2);
        }
        double[] FFT_Showcur2 = new double[10000];
        double[] FFT_Showvol2 = new double[10000];
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBoxfs.Text == "")
            {
                MessageBox.Show("请输入采样频率");
                return;
            }
            fs = double.Parse(textBoxfs.Text);
            CalculatorVI.FFT_showing(cur2, fs, ref df2, out FFT_Showcur2);
            easyChart2.Plot(FFT_Showcur2, 0, df2);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBoxfs.Text == "")
            {
                MessageBox.Show("请输入采样频率");
                return;
            }
            fs = double.Parse(textBoxfs.Text);
            CalculatorVI.FFT_showing(vol2, fs, ref df2, out FFT_Showvol2);
            this.Update();
            easyChart2.Plot(FFT_Showvol2, 0, df2);
        }
        double[] FFT_Showcur3 = new double[10000];
        double[] FFT_Showvol3 = new double[10000];
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBoxfs.Text == "")
            {
                MessageBox.Show("请输入采样频率");
                return;
            }
            fs = double.Parse(textBoxfs.Text);
            CalculatorVI.FFT_showing(cur3, fs, ref df2, out FFT_Showcur3);
            easyChart2.Plot(FFT_Showcur3, 0, df2);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBoxfs.Text == "")
            {
                MessageBox.Show("请输入采样频率");
                return;
            }
            fs = double.Parse(textBoxfs.Text);
            CalculatorVI.FFT_showing(vol3, fs, ref df2, out FFT_Showvol3);
            this.Update();
            easyChart2.Plot(FFT_Showvol3, 0, df2);
        }

        private void easyChartX2_AxisViewChanged(object sender, SeeSharpTools.JY.GUI.EasyChartXViewEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBoxfl3.Text == "")
            {
                MessageBox.Show("请输入fPass");
                return;
            }

            double fpass = double.Parse(textBoxfl3.Text);
            if (textBoxfh3.Text == "")
            {
                MessageBox.Show("请输入fStop");
                return;
            }
            double fstop = double.Parse(textBoxfh3.Text);
            if (textBoxfs.Text == "")
            {
                MessageBox.Show("请输入采样频率");
                return;
            }
            fs = double.Parse(textBoxfs.Text);

            CalculatorVI.filter_input(vol3, fpass, fstop, fs, out vol);
            CalculatorVI.filter_input(cur3, fpass, fstop, fs, out cur);
            this.Update();
            easyChartX1.Plot(vol3);
            easyChartX2.Plot(cur3);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void textBoxQ_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class CalculatorVI
    {
        static double Vrms;
        static double Irms;
        static double S, P;
        public static double CalVrms(double[] voltage, int periodlength)
        {
            double vsum = 0;
            for (int i = 0; i < periodlength; i++)
            {
                vsum += Math.Pow(voltage[i], 2);
            }
            Vrms = Math.Sqrt(vsum / periodlength);
            return Vrms;
        }
        public static double CalIrms(double[] currency, int periodlength)
        {
            double isum = 0;
            for (int i = 0; i < periodlength; i++)
            {
                isum += Math.Pow(currency[i], 2);
            }
            Irms = Math.Sqrt(isum / periodlength);
            return Irms;
        }
        public static double CalP(double[] vol, double[] cur, int periodlength)
        {
            double psum = 0;
            for (int i = 0; i < periodlength; i++)
            {
                psum += vol[i] * cur[i];
            }
            P = psum / periodlength;
            return P;
        }
        public static double CalVA1()
        {
            S = Vrms * Irms;
            return S;
        }
        public static double CalQ2(double[] vol, double[] cur, int periodlength)
        {
            double q2;
            double sum = 0;
            for (int i = 0; i < periodlength; i++)
            {
                sum += vol[i] * cur[i + periodlength / 4];
            }
            q2 = sum / periodlength;
            return q2;
        }
        public static double CalQ1()
        {
            double Q = Math.Sqrt(Math.Pow(S, 2) - Math.Pow(P, 2));
            return Q;
        }
        public static void filter_input(double[] input, double fPass, double fStop, double fs, out double[] output)
        {
            output = IIRFilter.ProcessLowpass(input, fPass, fStop, fs);

        }
        public static void FFT_showing(double[] input, double fs, ref double df2, out double[] output)
        {
            output = JYSpectrum.FFTSpectrum(input, (int)fs, ref df2, JYSpectrum.DataUnit.DBV);
        }
    }

}
