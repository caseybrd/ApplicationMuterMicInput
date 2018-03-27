namespace ApplicationMuterMicInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.refreshList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.processNameBox = new System.Windows.Forms.Label();
            this.recordButton = new System.Windows.Forms.Button();
            this.recordOrNaw = new System.Windows.Forms.Label();
            this.micLevel = new System.Windows.Forms.ProgressBar();
            this.micMuteThreshhold = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProcessList = new ApplicationMuterMicInput.CustomItemSelector3();
            ((System.ComponentModel.ISupportInitialize)(this.micMuteThreshhold)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshList
            // 
            this.refreshList.Location = new System.Drawing.Point(299, 23);
            this.refreshList.Name = "refreshList";
            this.refreshList.Size = new System.Drawing.Size(75, 27);
            this.refreshList.TabIndex = 1;
            this.refreshList.Text = "Refresh List";
            this.refreshList.UseVisualStyleBackColor = true;
            this.refreshList.Click += new System.EventHandler(this.refreshList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Process Name:";
            // 
            // processNameBox
            // 
            this.processNameBox.AutoSize = true;
            this.processNameBox.Location = new System.Drawing.Point(97, 54);
            this.processNameBox.MaximumSize = new System.Drawing.Size(0, 100);
            this.processNameBox.Name = "processNameBox";
            this.processNameBox.Size = new System.Drawing.Size(53, 13);
            this.processNameBox.TabIndex = 3;
            this.processNameBox.Text = "dasfadsfa";
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(12, 174);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(102, 23);
            this.recordButton.TabIndex = 4;
            this.recordButton.Text = "Begin Recording";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // recordOrNaw
            // 
            this.recordOrNaw.AutoSize = true;
            this.recordOrNaw.Location = new System.Drawing.Point(132, 179);
            this.recordOrNaw.Name = "recordOrNaw";
            this.recordOrNaw.Size = new System.Drawing.Size(69, 13);
            this.recordOrNaw.TabIndex = 5;
            this.recordOrNaw.Text = "not recording";
            // 
            // micLevel
            // 
            this.micLevel.Location = new System.Drawing.Point(12, 203);
            this.micLevel.Name = "micLevel";
            this.micLevel.Size = new System.Drawing.Size(281, 23);
            this.micLevel.TabIndex = 6;
            // 
            // micMuteThreshhold
            // 
            this.micMuteThreshhold.Location = new System.Drawing.Point(12, 232);
            this.micMuteThreshhold.Maximum = 100;
            this.micMuteThreshhold.Name = "micMuteThreshhold";
            this.micMuteThreshhold.Size = new System.Drawing.Size(291, 45);
            this.micMuteThreshhold.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Any Application";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Specific Process By ProcessID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Get From Application";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "How to find Twitch Alerts?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Get From ProcessID";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProcessList
            // 
            this.ProcessList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProcessList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.ItemHeight = 20;
            this.ProcessList.Location = new System.Drawing.Point(12, 24);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(281, 26);
            this.ProcessList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 280);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.micMuteThreshhold);
            this.Controls.Add(this.micLevel);
            this.Controls.Add(this.recordOrNaw);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.processNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshList);
            this.Controls.Add(this.ProcessList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Application Muter";
            ((System.ComponentModel.ISupportInitialize)(this.micMuteThreshhold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomItemSelector3 ProcessList;
        private System.Windows.Forms.Button refreshList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label processNameBox;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Label recordOrNaw;
        private System.Windows.Forms.ProgressBar micLevel;
        private System.Windows.Forms.TrackBar micMuteThreshhold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

