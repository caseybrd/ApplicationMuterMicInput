using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ApplicationMuterMicInput
{
    class AudioRecord
    {

        public List<float> levels = new List<float>();
        public WaveInEvent waveSource = new WaveInEvent();
        public int sampleCount = 0;
        public float maxValue;
        public float minValue;
        public int processID;
        public System.Timers.Timer timer = new System.Timers.Timer(250);
        public int notTalkCount;
        public static float sampleTime;
        ProgressBar micLeveler;
        Form1 theForm;
       
        public AudioRecord(int processID2, ProgressBar micLevel, Form1 form)
        {
            processID = processID2;
            timer.Elapsed += MicCheckInterval;
            micLeveler = micLevel;
            theForm = form;
        }

        public void StartRecording()
        {

            //int waveInDevices = WaveIn.DeviceCount;
            /*
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                Console.WriteLine("Device {0}: {1}, {2} channels",
                    waveInDevice, deviceInfo.ProductName, deviceInfo.Channels);
            }
            Console.WriteLine("Choose Recording Device Number: ");
            string num = Console.ReadLine();
            int deviceNumberer;*/
            //int.TryParse(num, out deviceNumberer);
            timer.Start();
            waveSource.WaveFormat = new WaveFormat(44100, 1);
            waveSource.DeviceNumber = 0;
            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);

            
            waveSource.StartRecording();
            Console.WriteLine("Running...(Press Enter to Terminate)");
            Console.ReadLine();
            //waveSource.StopRecording();
            //Console.WriteLine("Max: " + maxValue + " Min: " + minValue + " Level: " + levels[0]);
            //VolumeMixer.SetApplicationMute(processID, false);
            
            

        }

        public void StopRecording()
        {

        }

        public void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            for (int index = 0; index < e.BytesRecorded; index += 2)
            {
                short sample = (short)((e.Buffer[index + 1] << 8) |
                                        e.Buffer[index + 0]);
                float sample32 = sample / 32768f;
                
                
                levels.Add(sample32);
                ProcessSample(sample32);
            }
        }

        void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.Dispose();
                waveSource = null;
            }

        }
        public void ProcessSample(float sample)
        {
            sampleCount++;
            
            sample = Math.Abs(sample);
            sampleTime = sample;
            
            
            if(sample > maxValue)
            {
                maxValue = sample;
            }
            if(sample < minValue)
            {
                minValue = sample;
            }

            if (sampleCount % 800 == 0)
            {
                int value = ((int)(maxValue * 100));
                theForm.progBarUpdater(value);
                maxValue = 0;
                minValue = 0;
            }


        }

        

        private void MicCheckInterval(Object source, ElapsedEventArgs e)
        {
            float threshold = theForm.recordThreshhold / 100.0f;
            if (maxValue > threshold)
            {
                
                VolumeMixer.SetApplicationMute(processID, true);
                notTalkCount = 0;
            }
            else
            {
                notTalkCount++;
                if (notTalkCount > 13)
                {
                    VolumeMixer.SetApplicationMute(processID, false);
                }
            }
        }

        

    }
}
