﻿using System;

 class MyLine : System.Windows.Forms.Control
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(this.ForeColor, this.Width);
            e.Graphics.DrawRectangle(pen, 0, 0, this.Width, this.Height);
            base.OnPaint(e);
        }
    }

