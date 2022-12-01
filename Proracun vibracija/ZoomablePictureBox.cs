using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proracun_vibracija
{
    public partial class ZoomablePictureBox : PictureBox
    {
        public ZoomablePictureBox()
        {
            InitializeComponent();
        }

        public void Zoom(PictureBox TargetPictureBox, Button TargetButton, Panel TargetPanel, Form TargetForm)
        {
            TargetForm.ActiveControl = this;

            TargetPictureBox.Image   = Image;
            TargetPictureBox.Visible = TargetButton.Visible = true;
            TargetPanel.Enabled = false;

            Int32   panelH = TargetPanel.Height,
                    panelW = TargetPanel.Width,
                    slikaH = Image.Height,
                    slikaW = Image.Width,
                    centarX = panelW / 2 + TargetPanel.Location.X,
                    centarY = panelH / 2 + TargetPanel.Location.Y;
            Double ratioH = 0, ratioW = 0;

            for (Double i = 0; slikaH * i <= panelH; i += 0.01) ratioH = i;
            for (Double i = 0; ((slikaW * i) + TargetButton.Width) <= panelW; i += 0.01) ratioW = i;

            if (ratioH < ratioW)
            {
                TargetPictureBox.Height = Convert.ToInt32(slikaH * ratioH);
                TargetPictureBox.Width  = Convert.ToInt32(slikaW * ratioH);
            }
            else
            {
                TargetPictureBox.Height = Convert.ToInt32(slikaH * ratioW);
                TargetPictureBox.Width  = Convert.ToInt32(slikaW * ratioW);
            }

            TargetPictureBox.Location = new Point((centarX - TargetPictureBox.Width / 2), (centarY - TargetPictureBox.Height / 2));
            TargetButton.Location     = new Point(TargetPictureBox.Right, TargetPictureBox.Top);
        }
    }
}
