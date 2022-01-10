﻿using Microsoft.Maui.Graphics;
using System;

namespace GraphicsViewDemos.Drawables
{
    internal class SolidPaintDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            SolidPaint solidPaint = new SolidPaint(Colors.Silver);

            //SolidPaint solidPaint = new SolidPaint
            //{
            //    Color = Colors.Silver
            //};

            RectangleF solidRectangle = new RectangleF(100, 100, 200, 100);
            canvas.SetFillPaint(solidPaint, solidRectangle);
            canvas.SetShadow(new SizeF(10, 10), 10, Colors.Grey);
            canvas.FillRoundedRectangle(solidRectangle, 12);
        }
    }
}
