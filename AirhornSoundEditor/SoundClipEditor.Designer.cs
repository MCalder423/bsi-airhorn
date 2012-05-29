namespace AirhornSoundEditor
{
    partial class SoundClipEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSoundFile = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxLoopRandom = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxLoopInterval = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonLoopRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonLoopContinuous = new System.Windows.Forms.RadioButton();
            this.checkBoxEnableLoop = new System.Windows.Forms.CheckBox();
            this.buttonTestSound = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSoundLabel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAssignedKey = new System.Windows.Forms.TextBox();
            this.buttonAssignKey = new System.Windows.Forms.Button();
            this.soundClipPlacement1 = new AirhornSoundEditor.SoundClipPlacement();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Sound File:";
            // 
            // textBoxSoundFile
            // 
            this.textBoxSoundFile.Location = new System.Drawing.Point(116, 75);
            this.textBoxSoundFile.Name = "textBoxSoundFile";
            this.textBoxSoundFile.Size = new System.Drawing.Size(269, 20);
            this.textBoxSoundFile.TabIndex = 2;
            this.textBoxSoundFile.Text = "C:\\Windows\\Media\\Quirky\\Windows Ding.wav";
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(391, 73);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(26, 23);
            this.buttonSelectFile.TabIndex = 3;
            this.buttonSelectFile.Text = "...";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Set Sound Placement:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Set Volume:";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(87, 345);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(333, 45);
            this.trackBarVolume.TabIndex = 6;
            this.trackBarVolume.TickFrequency = 5;
            this.trackBarVolume.Value = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxLoopRandom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maskedTextBoxLoopInterval);
            this.groupBox1.Controls.Add(this.radioButtonLoopRandom);
            this.groupBox1.Controls.Add(this.radioButtonLoopContinuous);
            this.groupBox1.Controls.Add(this.checkBoxEnableLoop);
            this.groupBox1.Location = new System.Drawing.Point(17, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 87);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxLoopRandom
            // 
            this.checkBoxLoopRandom.AutoSize = true;
            this.checkBoxLoopRandom.Location = new System.Drawing.Point(268, 47);
            this.checkBoxLoopRandom.Name = "checkBoxLoopRandom";
            this.checkBoxLoopRandom.Size = new System.Drawing.Size(68, 17);
            this.checkBoxLoopRandom.TabIndex = 13;
            this.checkBoxLoopRandom.Text = "randomly";
            this.checkBoxLoopRandom.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "seconds";
            // 
            // maskedTextBoxLoopInterval
            // 
            this.maskedTextBoxLoopInterval.Location = new System.Drawing.Point(174, 45);
            this.maskedTextBoxLoopInterval.Mask = "000";
            this.maskedTextBoxLoopInterval.Name = "maskedTextBoxLoopInterval";
            this.maskedTextBoxLoopInterval.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBoxLoopInterval.TabIndex = 11;
            // 
            // radioButtonLoopRandom
            // 
            this.radioButtonLoopRandom.AutoSize = true;
            this.radioButtonLoopRandom.Location = new System.Drawing.Point(67, 46);
            this.radioButtonLoopRandom.Name = "radioButtonLoopRandom";
            this.radioButtonLoopRandom.Size = new System.Drawing.Size(101, 17);
            this.radioButtonLoopRandom.TabIndex = 10;
            this.radioButtonLoopRandom.TabStop = true;
            this.radioButtonLoopRandom.Text = "Play once every";
            this.radioButtonLoopRandom.UseVisualStyleBackColor = true;
            // 
            // radioButtonLoopContinuous
            // 
            this.radioButtonLoopContinuous.AutoSize = true;
            this.radioButtonLoopContinuous.Location = new System.Drawing.Point(67, 23);
            this.radioButtonLoopContinuous.Name = "radioButtonLoopContinuous";
            this.radioButtonLoopContinuous.Size = new System.Drawing.Size(108, 17);
            this.radioButtonLoopContinuous.TabIndex = 9;
            this.radioButtonLoopContinuous.TabStop = true;
            this.radioButtonLoopContinuous.Text = "Play Continuously";
            this.radioButtonLoopContinuous.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableLoop
            // 
            this.checkBoxEnableLoop.AutoSize = true;
            this.checkBoxEnableLoop.Location = new System.Drawing.Point(20, 0);
            this.checkBoxEnableLoop.Name = "checkBoxEnableLoop";
            this.checkBoxEnableLoop.Size = new System.Drawing.Size(100, 17);
            this.checkBoxEnableLoop.TabIndex = 8;
            this.checkBoxEnableLoop.Text = "Enable Looping";
            this.checkBoxEnableLoop.UseVisualStyleBackColor = true;
            this.checkBoxEnableLoop.CheckedChanged += new System.EventHandler(this.checkBoxEnableLoop_CheckedChanged);
            // 
            // buttonTestSound
            // 
            this.buttonTestSound.Location = new System.Drawing.Point(20, 483);
            this.buttonTestSound.Name = "buttonTestSound";
            this.buttonTestSound.Size = new System.Drawing.Size(110, 23);
            this.buttonTestSound.TabIndex = 8;
            this.buttonTestSound.Text = "Test Sound Now";
            this.buttonTestSound.UseVisualStyleBackColor = true;
            this.buttonTestSound.Click += new System.EventHandler(this.buttonTestSound_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(200, 483);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(345, 483);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter Sound Label:";
            // 
            // textBoxSoundLabel
            // 
            this.textBoxSoundLabel.Location = new System.Drawing.Point(116, 12);
            this.textBoxSoundLabel.MaxLength = 20;
            this.textBoxSoundLabel.Name = "textBoxSoundLabel";
            this.textBoxSoundLabel.Size = new System.Drawing.Size(138, 20);
            this.textBoxSoundLabel.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Assign a Key:";
            // 
            // textBoxAssignedKey
            // 
            this.textBoxAssignedKey.Enabled = false;
            this.textBoxAssignedKey.Location = new System.Drawing.Point(116, 41);
            this.textBoxAssignedKey.Name = "textBoxAssignedKey";
            this.textBoxAssignedKey.Size = new System.Drawing.Size(237, 20);
            this.textBoxAssignedKey.TabIndex = 15;
            // 
            // buttonAssignKey
            // 
            this.buttonAssignKey.Location = new System.Drawing.Point(369, 39);
            this.buttonAssignKey.Name = "buttonAssignKey";
            this.buttonAssignKey.Size = new System.Drawing.Size(51, 23);
            this.buttonAssignKey.TabIndex = 16;
            this.buttonAssignKey.Text = "Set";
            this.buttonAssignKey.UseVisualStyleBackColor = true;
            this.buttonAssignKey.Click += new System.EventHandler(this.buttonAssignKey_Click);
            // 
            // soundClipPlacement1
            // 
            this.soundClipPlacement1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soundClipPlacement1.Location = new System.Drawing.Point(20, 126);
            this.soundClipPlacement1.Name = "soundClipPlacement1";
            this.soundClipPlacement1.Size = new System.Drawing.Size(400, 200);
            this.soundClipPlacement1.TabIndex = 0;
            // 
            // SoundClipEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(432, 525);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAssignKey);
            this.Controls.Add(this.textBoxAssignedKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSoundLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonTestSound);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.textBoxSoundFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soundClipPlacement1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SoundClipEditor";
            this.Text = "Sound Clip Editor";
            this.Load += new System.EventHandler(this.SoundClipEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoundClipPlacement soundClipPlacement1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSoundFile;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLoopInterval;
        private System.Windows.Forms.RadioButton radioButtonLoopRandom;
        private System.Windows.Forms.RadioButton radioButtonLoopContinuous;
        private System.Windows.Forms.CheckBox checkBoxEnableLoop;
        private System.Windows.Forms.Button buttonTestSound;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxLoopRandom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSoundLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAssignedKey;
        private System.Windows.Forms.Button buttonAssignKey;
    }
}