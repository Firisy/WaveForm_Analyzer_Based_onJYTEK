using JYUSB61902;
using SeeSharpTools.JY.DSP.FilteringMCR;
using SeeSharpTools.JY.DSP.Fundamental;
using SeeSharpTools.JY.DSP.Utility;
using DSPMatlab;
using System;
using System.IO;
using System.Windows.Forms;
using SeeSharpTools.JY.DSP.Measurements;


namespace test2
{
    public partial class Form1 : Form
    {
        private JYUSB61902AITask aitask;
        double[,] readvalue = new double[5000, 2];
        double[] volcycle = new double[5000];
        double[] curcycle = new double[5000];
        double[] FFT_Showvol = new double[10000];
        double[] FFT_Showcur = new double[10000];
        double df2 = 0;
        int periodLength, SlewupV, SlewupI;
        public Form1()
        {
            IIRFilter.Initialize();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            led1.Value = true;
            aitask = new JYUSB61902AITask(0);
            aitask.AddChannel(0, -10, 10, AITerminal.RSE);
            aitask.AddChannel(1, -10, 10, AITerminal.RSE);
            aitask.Mode = AIMode.Continuous;
            aitask.SampleRate = 10000;
            //aitask.SamplesToAcquire = 1000;

            aitask.Start();
            timer1.Enabled = true;

        }
        double[] vol = new double[5000];
        double[] cur = new double[5000];
        double fs;
        private void timer1_Tick(object sender, EventArgs e)
        {

            aitask.ReadData(ref readvalue);
            for (int i = 0; i < readvalue.GetLength(0); i++)
            {
                vol[i] = readvalue[i, 0];
                cur[i] = readvalue[i, 1];
            }
            //IIRFilter.ProcessLowpass(cur, 0.1, 100);
            easyChartX1.Plot(vol);
            easyChartX2.Plot(cur);
            if (led1.Value) led1.Value = false;
            else led1.Value = true;
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
            string filename = textBox1.Text;
            using (StreamWriter file = new StreamWriter("D:/"+filename+".csv", true))
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
                    file.Write(FFT_Showvol[j]);
                    if (j < 4999)
                        file.Write(",");
                }
                file.Write("\n");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            CalculatorVI.CalT(vol, cur, out periodLength, out SlewupV, out SlewupI, out volcycle, out curcycle);
            easyChartX1.Plot(volcycle);
            easyChartX2.Plot(curcycle);
            double phi;
            phi = Phase.CalPhaseShift(vol, cur);
            textBoxphi.Text = phi.ToString("0.###");
            textBoxpp.Text = Math.Cos(phi / 180 * 3.1415926).ToString();
            double T = periodLength;
            textBoxT.Text = T.ToString("0.###"); // 保留三位小数  

            textBoxV.Text = CalculatorVI.CalVrms(volcycle,periodLength).ToString("0.###");
            textBoxI.Text = CalculatorVI.CalIrms(curcycle, periodLength).ToString("0.###"); // 保留三位小数  
            textBoxP.Text = CalculatorVI.CalP(volcycle, curcycle, periodLength).ToString("0.###"); // 保留三位小数  
            textBoxVA.Text = CalculatorVI.CalVA1().ToString("0.###"); // 保留三位小数  
            textBoxQ2.Text = CalculatorVI.CalQ2(volcycle, curcycle, periodLength).ToString("0.###"); // 保留三位小数  
            textBoxQ.Text = CalculatorVI.CalQ1().ToString("0.###"); // 保留三位小数  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(filename);
                int cal = 0;
                for (int i = 12; i < 5012; i++)
                {
                    string[] values = lines[i].Split(',');
                    vol[cal] = Convert.ToDouble(values[1]) * 100;
                    cur[cal] = Convert.ToDouble(values[2]);
                    cal++;
                }
            }
            easyChartX1.Plot(vol);
            easyChartX2.Plot(cur);
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
            CalculatorVI.filter_input(cur, fpass, fstop, fs,out cur);
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
            Generation.SineWave(ref waveform1, 311, 0, 50, 10000);  //软件产生正弦波形1
            Generation.SineWave(ref waveform2, 1, -45, 50, 10000);  //软件产生正弦波形2
            for (i = 0; i < 5000; i++)
            {
                vol[i] = waveform1[i];
                cur[i] = waveform2[i];
            }
            easyChartX1.Plot(vol);
            easyChartX2.Plot(cur);
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
        public static double CalVrms2(double[] voltage)
        {
            LevelCrossings levelCrossings = new LevelCrossings();
            levelCrossings.CrossingLevel =20;
            double[] vrms= JitterAnalysis.Level.MeasureRMSVoltage(voltage,levelCrossings);
            return vrms[0];
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
        public static void CalT(double[] vol, double[] cur, out int periodLength, out int risePointV, out int risePointI, out double[] volcycle, out double[] curcycle)
        {
            risePointI = 0;
            risePointV = 0;
            int downpointV = 0;
            // 寻找周期  
            for (int i = 1; i < 5000; i++)
            {
                if (risePointV != 0 && vol[i - 1] < 0 && vol[i] >= 0 && i > risePointV + 5)
                {
                    downpointV = i;
                    break;
                }
                if (vol[i - 1] < 0 && vol[i] >= 0) risePointV = i;
                if (cur[i - 1] < 0 && cur[i] >= 0) risePointI = i;

            }
            periodLength = downpointV - risePointV;
            if (periodLength == 0) periodLength = 2500;
            // 赋值周期到数组a  
            int cal = 0;
            volcycle = new double[5000];
            curcycle = new double[5000];
            for (int i = risePointV; i < periodLength * 4 && i < 5000; i++)
            {
                volcycle[cal] = vol[i];
                curcycle[cal] = cur[i];
                cal++;
            }
        }
        public static void filter_input(double[] input, double fPass, double fStop,double fs, out double[] output)
        {
            output = IIRFilter.ProcessLowpass(input, fPass, fStop,fs);

        }
        public static void FFT_showing(double[] input,double fs,ref double df2, out double[] output)
        {
            //FFTSpectrum(double[] input, int fs, ref double df, DataUnit dataUnit),各个参数的意义如下：
            //input：输入数据
            //fs：采样率
            //df：频率分辨率
            //dataUnit：数据单
            output = JYSpectrum.FFTSpectrum(input, (int)fs, ref df2, JYSpectrum.DataUnit.DBV);
        }
    }

}
