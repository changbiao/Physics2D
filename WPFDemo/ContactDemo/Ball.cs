﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using Physics2D.Collision;
using Physics2D;
using Physics2D.Object;
using Physics2D.Factories;

using WPFDemo.Graphic;

namespace WPFDemo.ContactDemo
{
    class Ball : IDrawable
    {
        public Particle fixedParticle;
        public Particle particle;
        public int r;

        public void Draw(WriteableBitmap bitmap)
        {
            bitmap.DrawLineAa
            (
                ConvertUnits.ToDisplayUnits(fixedParticle.Position.X),
                ConvertUnits.ToDisplayUnits(fixedParticle.Position.Y),
                ConvertUnits.ToDisplayUnits(particle.Position.X),
                ConvertUnits.ToDisplayUnits(particle.Position.Y),
                Colors.DarkGray
            );
            bitmap.FillEllipseCentered
            (
                ConvertUnits.ToDisplayUnits(particle.Position.X),
                ConvertUnits.ToDisplayUnits(particle.Position.Y), r, r, Colors.DarkRed
            );
        }
    }
}
