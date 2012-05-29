using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using IrrKlang;


namespace AirhornSoundEditor
{
    public partial class SoundClipEditor : Form
    {
        public SoundClipEditor()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxEnableLoop_CheckedChanged(object sender, EventArgs e)
        {
            setLoopControlsState();
        }

        private void SoundClipEditor_Load(object sender, EventArgs e)
        {
            setLoopControlsState();
        }

        private void setLoopControlsState()
        {
            radioButtonLoopContinuous.Enabled = checkBoxEnableLoop.Checked;
            radioButtonLoopRandom.Enabled = checkBoxEnableLoop.Checked;
            maskedTextBoxLoopInterval.Enabled = checkBoxEnableLoop.Checked;
            checkBoxLoopRandom.Enabled = checkBoxEnableLoop.Checked;
            label4.Enabled = checkBoxEnableLoop.Checked;
        }

        private void buttonAssignKey_Click(object sender, EventArgs e)
        {
            Keys AssignedKey = new Keys();
            dlgAssignKey form = new dlgAssignKey();
            form.ShowDialog();
            if (form.AssignedKey != null)
            {
                AssignedKey = form.AssignedKey;
                textBoxAssignedKey.Text = AssignedKey.ToString();
            }
            form.Dispose();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Sound files (*.wav)|*.wav|Sound files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Brinston Sound Images\Airhorn\Library";
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                textBoxSoundFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonTestSound_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSoundFile.Text))
            {
                MessageBox.Show("Please select a sound clip","No Sound Clip",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                textBoxSoundFile.Focus();
                return;
            }
            ISoundEngine engine = new ISoundEngine();
            engine.Default3DSoundMinDistance = 0;
            engine.Default3DSoundMaxDistance = 1;
            engine.SetListenerPosition(0, 0, 0, 0, 0, 1);
            engine.SoundVolume = ((float)trackBarVolume.Value) / 100;
            Vector3D vector = new Vector3D();
            ISound music = engine.Play3D(textBoxSoundFile.Text, (float)soundClipPlacement1.Balance,0, (float)soundClipPlacement1.Fade, false);

        }
    }
}
