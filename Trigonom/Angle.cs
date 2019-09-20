using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trigonom
{
    class Angle
    {
        private double degree;
        private double radian;

        public Angle()
        {
            this.degree = 0;
            this.radian = 0;
        }

        public void setDegree(double degree)
        {
            this.degree = degree;
            convDegToRad();
        }
        public void setRadian(double radian)
        {
            this.radian = radian;
            convRadToDeg();
        }

        public double getDegree()
        {
            return this.degree;
        }
        public double getRadians()
        {
            return this.radian;
        }

        private void convDegToRad()
        {
            this.radian = this.degree * Math.PI / 180;
        }
        private void convRadToDeg()
        {
            this.degree = this.radian * 180 / Math.PI;
        }

    }
}
