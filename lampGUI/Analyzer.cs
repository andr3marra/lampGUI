using System;
using System.Collections.Generic;
//using System.Windows;
using System.Windows.Forms;
using System.Windows.Threading;
using Un4seen.Bass;
using Un4seen.BassWasapi;

namespace lampGUI
{


    internal class Analyzer
    {
        private bool _enable;               //enabled status
        private DispatcherTimer _t;         //timer that refreshes the display
        public float[] _fft;               //buffer for fft data
        //private ProgressBar _l, _r;         //progressbars for left and right channel intensity
        private WASAPIPROC _process;        //callback function to obtain data
        private int _lastlevel;             //last output level
        private int _hanctr;                //last output level counter
        public List<byte> _spectrumdata;   //spectrum data buffer
        //private Spectrum _spectrum;         //spectrum dispay control
        private ComboBox _devicelist;       //device list
        private bool _initialized;          //initialized flag
        private int devindex;               //used device index
        private int var_teste = 0;
        //private Chart _chart;

        private int _lines = 10;            // number of spectrum lines
        Api led;

        //ctor
        public Analyzer(ComboBox devicelist, Api instancia)
        {

            _fft = new float[8192];
            _lastlevel = 0;
            _hanctr = 0;
            _t = new DispatcherTimer();
            _t.Tick += _t_Tick;
            _t.Interval = TimeSpan.FromMilliseconds(0); //40hz refresh rate//25
            _t.IsEnabled = false;
            /*_l = left;
            _r = right;
            _l.Minimum = 0;
            _r.Minimum = 0;
            _r.Maximum = (ushort.MaxValue);
            _l.Maximum = (ushort.MaxValue);*/
            _process = new WASAPIPROC(Process);
            _spectrumdata = new List<byte>();
            //_spectrum = spectrum;
            //_chart = chart;
            _devicelist = devicelist;
            _initialized = false;


            /*            chart.Series.Add("wave");
                        chart.Series["wave"].ChartType = SeriesChartType.FastLine;
                        chart.Series["wave"].ChartArea = "ChartArea1";

                        chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                        chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                        chart.ChartAreas["ChartArea1"].AxisY.Maximum = 255;
                        chart.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
                        chart.ChartAreas["ChartArea1"].AxisX.Maximum = 64;
                        chart.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
                        for (int i = 0; i < chart.ChartAreas["ChartArea1"].AxisX.Maximum; i++)
                        {
                            chart.Series["wave"].Points.Add(0);
                        }*/
            led = instancia;
            Init();
        }

        // Serial port for arduino output


        // flag for display enable
        public bool DisplayEnable { get; set; }

        //flag for enabling and disabling program functionality
        public bool Enable
        {
            get { return _enable; }
            set
            {
                _enable = value;
                if (value)
                {
                    if (!_initialized)
                    {
                        var array = (_devicelist.Items[_devicelist.SelectedIndex] as string).Split(' ');
                        devindex = Convert.ToInt32(array[0]);
                        bool result = BassWasapi.BASS_WASAPI_Init(devindex, 0, 0, BASSWASAPIInit.BASS_WASAPI_BUFFER, 1f, 0.05f, _process, IntPtr.Zero);
                        if (!result)
                        {
                            var error = Bass.BASS_ErrorGetCode();
                            MessageBox.Show(error.ToString());
                        }
                        else
                        {
                            _initialized = true;
                            _devicelist.Enabled = true;
                        }
                    }
                    BassWasapi.BASS_WASAPI_Start();
                }
                else BassWasapi.BASS_WASAPI_Stop(true);
                System.Threading.Thread.Sleep(500);
                _t.IsEnabled = value;
            }
        }

        // initialization
        private void Init()
        {
            bool result = false;

            for (int i = 0; i < BassWasapi.BASS_WASAPI_GetDeviceCount(); i++)
            {
                var device = BassWasapi.BASS_WASAPI_GetDeviceInfo(i);
                if (device.IsEnabled && device.IsLoopback)
                {
                    _devicelist.Items.Add(string.Format("{0} - {1}", i, device.name));
                }
            }
            _devicelist.SelectedIndex = 0;
            try
            {
                Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATETHREADS, false);
                result = Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                if (!result) throw new Exception("Init Error");
            }
            catch
            {

            }
        }

        //timer 

        private void _t_Tick(object sender, EventArgs e)
        {
            int ret = BassWasapi.BASS_WASAPI_GetData(_fft, (int)BASSData.BASS_DATA_FFT8192);  //get ch.annel fft data
            if (ret < -1) return;
            int x, y;
            int b0 = 0;

            //computes the spectrum data, the code is taken from a bass_wasapi sample.
            for (x = 0; x < _lines; x++)
            {
                float peak = 0;
                int b1 = (int)Math.Pow(2, x * 10.0 / (_lines - 1));
                if (b1 > 1023) b1 = 1023;
                if (b1 <= b0) b1 = b0 + 1;
                for (; b0 < b1; b0++)
                {
                    if (peak < _fft[1 + b0]) peak = _fft[1 + b0];
                }
                y = (int)(Math.Sqrt(peak) * 3 * 255 - 4);
                if (y > 255) y = 255;
                if (y < 0) y = 0;
                _spectrumdata.Add((byte)y);


                // switch (x)
                // {
                //     case 19:
                //         if (y < 100)
                //         {
                //              Form1.serialPort1.Write("500" + y.ToString() + "000000E");
                //             //Form1.serialPort1.Write("20255000000E");
                //         }
                //         else
                //         {
                //             /*Form1.serialPort1.Write("20000000000E");*/
                //             Form1.serialPort1.Write("50" + y.ToString() + "000000E");
                //         }
                //         break;
                // }

            }
            byte[] array = new byte[270];
            /*            for (int test = 0; test < _lines; test++) {
                            array[9 * test] = (byte)(_spectrumdata[test] * 5);          //r
                            array[9 * test +1] = _spectrumdata[test];                   //g
                            array[9 * test +2] = _spectrumdata[test];                   //b
                            array[9 * test + 3] = (byte)(_spectrumdata[test] * 5);      //r
                            array[9 * test +4] = _spectrumdata[test];                   //g
                            array[9 * test +5] = _spectrumdata[test];                   //b
                            array[9 * test + 6] = (byte)(_spectrumdata[test] * 5);      //r
                            array[9 * test +7] = _spectrumdata[test];                   //g
                            array[9 * test +8] = _spectrumdata[test];                   //b
                        }*/

            for (int i = 0; i < 270; i++)
            {
                array[i] = 0;
            }
            if (var_teste == 255)
                var_teste = 0;

            array[var_teste] = 0;
            array[var_teste + 1] = 254;
            var_teste++;

            led.PostAsync(array);

            /*            if (DisplayEnable) _spectrum.Set(_spectrumdata);
                        for (int i = 0; i < _spectrumdata.ToArray().Length; i++)
                        {
                            try
                            {
                                _chart.Series["wave"].Points.Add(_spectrumdata[i]);
                            }
                            catch (Exception)
                            {
                            }
                            try
                            {
                                _chart.Series["wave"].Points.RemoveAt(0);
                            }
                            catch (Exception)
                            {
                            }

                        }*/
            _spectrumdata.Clear();


            int level = BassWasapi.BASS_WASAPI_GetLevel();
            /*            _l.Value = (Utils.LowWord32(level));
                        _r.Value = (Utils.HighWord32(level));*/
            /*            int nLeds = _l.Value / 100*90;*/
            /*            for(int led = 0; led < 90; led++)
                        {
                            if (led < nLeds)
                            {
                                if (led < 10)
                                {
                                    Form1.serialPort1.Write("0" + led.ToString() + "255000000E");
                                }
                                else
                                {
                                    Form1.serialPort1.Write(led.ToString() + "255000000E");
                                }
                            }
                            else
                            {
                                if (led < 10)
                                {
                                    Form1.serialPort1.Write("0" + led.ToString() + "000000000E");
                                }
                                else
                                {
                                    Form1.serialPort1.Write(led.ToString() + "000000000E");
                                }
                            }
                        }*/
            /*            for (int led = 0; led < nLeds; led++)
                        {
                            if (led < 10)
                            {
                                Form1.serialPort1.Write("0" + led.ToString() + "255000000E");
                            }
                            else
                            {
                                Form1.serialPort1.Write(led.ToString() + "255000000E");
                            }

                        }*/
            // for (int led = nLeds; led < 90; led++)
            // {
            //     Form1.serialPort1.Write(led.ToString() + "000000000E");
            // }


            if (level == _lastlevel && level != 0) _hanctr++;
            _lastlevel = level;

            //Required, because some programs hang the output. If the output hangs for a 75ms
            //this piece of code re initializes the output so it doesn't make a gliched sound for long.
            if (_hanctr > 3)
            {
                _hanctr = 0;
                /*                _l.Value = (0);
                                _r.Value = (0);*/
                Free();
                Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                _initialized = false;
                Enable = true;
            }

        }

        // WASAPI callback, required for continuous recording
        private int Process(IntPtr buffer, int length, IntPtr user)
        {
            return length;
        }

        //cleanup
        public void Free()
        {
            BassWasapi.BASS_WASAPI_Free();
            Bass.BASS_Free();
        }
    }
}
