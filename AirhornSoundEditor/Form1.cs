using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirhornSoundEditor
{
    public partial class Form1 : Form
    {
        public float CurrentPosX = 0;
        public float CurrentPosY = 0;
        public double Balance = 0;
        public double Fade = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics gr = this.CreateGraphics())
            {
                Rectangle clientRect = this.ClientRectangle;
                // Draw a vertical axis down the center of the form
                gr.DrawLine(Pens.Black, clientRect.Width / 2, 0, clientRect.Width / 2, clientRect.Height);
                // Draw a horizontal axis across the center of the form
                gr.DrawLine(Pens.Black, 0, clientRect.Height / 2, clientRect.Width, clientRect.Height / 2);
                // Draw speaker indicators
                gr.DrawString("FL", SystemFonts.CaptionFont, Brushes.Black, 20, 20);
                gr.DrawString("CENTER", SystemFonts.CaptionFont, Brushes.Black, (clientRect.Width / 2) - 23, clientRect.Height / 4);
                gr.DrawString("FR", SystemFonts.CaptionFont, Brushes.Black, clientRect.Width - 40, 20);
                gr.DrawString("RL", SystemFonts.CaptionFont, Brushes.Black, 20, clientRect.Height - 20);
                gr.DrawString("SUB", SystemFonts.CaptionFont, Brushes.Black, (clientRect.Width / 2) - 11, clientRect.Height / 2);
                gr.DrawString("RR", SystemFonts.CaptionFont, Brushes.Black, clientRect.Width - 40, clientRect.Height - 20);
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            DrawCircle(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
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
            }

            // Calculate cursor position relative to center of form
            Rectangle clientRect = this.ClientRectangle;
            CurrentPosX = e.X - (clientRect.Width / 2);
            CurrentPosY = (clientRect.Height / 2) - e.Y;
            // Calculate Balance value
            int BalTotal = clientRect.Width / 2;
            Balance = Math.Round((CurrentPosX / BalTotal) * 100, 0);
            // Calculate Fade value
            int FadeTotal = clientRect.Height / 2;
            Fade = Math.Round((CurrentPosY / FadeTotal) * 100, 0);
            this.Text = string.Format("Current Pos: ({0}%, {1}%)", Balance > 0 ? "R" + Balance.ToString() : "L" + Math.Abs(Balance).ToString(), Fade > 0 ? "F" + Fade.ToString() : "R" + Math.Abs(Fade).ToString());
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
