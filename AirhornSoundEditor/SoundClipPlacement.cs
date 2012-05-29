using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirhornSoundEditor
{
    public partial class SoundClipPlacement : UserControl
    {
        public SoundClipPlacement()
        {
            InitializeComponent();
        }

        public float CurrentPosX = 0;
        public float CurrentPosY = 0;
        public double Balance = 0;
        public double Fade = 0;

        private void SoundClipPlacement_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics gr = this.CreateGraphics())
            {
                Rectangle clientRect = this.ClientRectangle;
                // Draw a vertical axis down the center of the form
                gr.DrawLine(Pens.Red, clientRect.Width / 2, 0, clientRect.Width / 2, clientRect.Height);
                // Draw a horizontal axis across the center of the form
                gr.DrawLine(Pens.Red, 0, clientRect.Height / 2, clientRect.Width, clientRect.Height / 2);
                // Draw Layout guides
                gr.DrawString("Back of Layout", SystemFonts.SmallCaptionFont, Brushes.Blue, (clientRect.Width / 2) - 44, 3);
                gr.DrawString("Front of Layout", SystemFonts.SmallCaptionFont, Brushes.Blue, (clientRect.Width / 2) - 44, clientRect.Height - 18);

                // Draw speaker indicators
                gr.DrawString("RL", SystemFonts.CaptionFont, Brushes.Black, 20, 20);
                gr.DrawString("CENTER", SystemFonts.CaptionFont, Brushes.Black, (clientRect.Width / 2) - 23, clientRect.Height / 2);
                gr.DrawString("RR", SystemFonts.CaptionFont, Brushes.Black, clientRect.Width - 40, 20);
                gr.DrawString("FL", SystemFonts.CaptionFont, Brushes.Black, 20, clientRect.Height - 20);
                //gr.DrawString("(SUB)", SystemFonts.CaptionFont, Brushes.DarkSlateGray, (clientRect.Width / 2) - 11, clientRect.Height / 2);
                gr.DrawString("FR", SystemFonts.CaptionFont, Brushes.Black, clientRect.Width - 40, clientRect.Height - 20);
            }

        }

        private void SoundClipPlacement_MouseDown(object sender, MouseEventArgs e)
        {
            DrawCircle(e);
        }

        private void SoundClipPlacement_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DrawCircle(e);
            }
        }

        private void DrawCircle(MouseEventArgs e)
        {
            // Repaint the form to erase other circles
            this.Refresh();

            // Draw a cirlce under the mouse cursor
            using (Graphics gr = this.CreateGraphics())
            {
                gr.FillEllipse(Brushes.LightGreen, e.X - 5, e.Y - 5, 10, 10);
                gr.DrawEllipse(Pens.Green, e.X - 5, e.Y - 5, 10, 10);


                // Calculate cursor position relative to center of form
                Rectangle clientRect = this.ClientRectangle;
                CurrentPosX = e.X - (clientRect.Width / 2);
                CurrentPosY = (clientRect.Height / 2) - e.Y;
                // Calculate Balance value
                int BalTotal = clientRect.Width / 2;
                Balance = (CurrentPosX / BalTotal);
                // Calculate Fade value
                int FadeTotal = clientRect.Height / 2;
                Fade = (CurrentPosY / FadeTotal);
                gr.DrawString(string.Format("Current Pos: ({0}, {1})", Balance, Fade), SystemFonts.CaptionFont, Brushes.Red, 3, 3);
            }
        }
    }
}
