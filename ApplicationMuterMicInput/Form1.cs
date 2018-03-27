using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationMuterMicInput
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr h, uint dwVolume);


        Process[] processes = Process.GetProcesses();
        List<string> processesNames = new List<string>();
        List<Process> namedProcess = new List<Process>();
        List<DropDownItem> processItems = new List<DropDownItem>();
        public Bitmap allAccessImage = new Bitmap((Image.FromFile("C:\\Users\\Bernard\\Downloads\\Help-and-Support.png")));

        Process selectedProcess;

        int micLevelValue = 0;

        public int recordThreshhold = 0;

        bool recording = false;




        public Form1()
        {
            InitializeComponent();
            PopulateProcessList();

            ProcessList.DropDownClosed += new System.EventHandler(ProcessList_DropDown);
            micMuteThreshhold.ValueChanged += new System.EventHandler(TrackBar_ValueChange);
            
            
            
        }

        private void ProcessList_DropDown(object sender, System.EventArgs e)
        {
            selectedProcess = namedProcess[ProcessList.SelectedIndex];
            processNameBox.Text = selectedProcess.MainWindowTitle;
            
        }

        private void TrackBar_ValueChange(object sender, System.EventArgs e)
        {
            recordThreshhold = micMuteThreshhold.Value;
        }

        public void PopulateProcessList()
        {
            foreach (Process proc in processes)
            {
                if (!(proc.MainWindowTitle.Equals("")))
                {
                    processesNames.Add(proc.MainWindowTitle);
                    namedProcess.Add(proc);
                    Bitmap image;
                    try
                    {
                        image = Icon.ExtractAssociatedIcon(proc.MainModule.FileName).ToBitmap();
                        //allAccessImage = image;
                        string name = proc.MainWindowTitle;
                        DropDownItem item = new DropDownItem(name, image);
                        processItems.Add(item);
                    }
                    catch (Win32Exception ex)
                    {
                        
                            Console.WriteLine(proc.MainWindowTitle + " is 64 bit");
                            string name = proc.MainWindowTitle;
                            DropDownItem item = new DropDownItem(name, allAccessImage);
                            processItems.Add(item);
                        
                    }


                }

            }


            ProcessList.Items.AddRange(processItems.ToArray());
        }

        private void refreshList_Click(object sender, EventArgs e)
        {
            processesNames.Clear();
            namedProcess.Clear();
            processItems.Clear();
            ProcessList.Items.Clear();
            PopulateProcessList();
        }


        //record button
        private void button1_Click(object sender, EventArgs e)
        {
            int pID2 = selectedProcess.Id;
            textBox1.Text = pID2.ToString();
            AudioRecord audioRecorder = new AudioRecord(pID2, micLevel, this);
            if (!recording)
            {
               
                recordOrNaw.Text = "Recording";
                audioRecorder.StartRecording();
            }
            else
            {
                recordOrNaw.Text = "Not Recording";
                audioRecorder.StopRecording();
            }
           
        }

        private void UpdateProgressBar()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(UpdateProgressBar);
                Invoke(method);
                return;
            }
            micLevel.Value = micLevelValue;
            
            
        }

        public void progBarUpdater(int value)
        {
            micLevelValue = value;
            UpdateProgressBar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string processIDstring = textBox1.Text;
            int processID = 0;
            bool didPass = int.TryParse( processIDstring , out processID);
            selectedProcess = Process.GetProcessById(processID);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int pID2 = selectedProcess.Id;
            textBox1.Text = pID2.ToString();
        }
    }


}
