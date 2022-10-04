﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {
        private int length, width;

        public Rectangle(int width, int height)
        {
            this.length = height;
            this.width = width;

        }
        public int GetCurrentLength()
        {
            return length;
        }
        public int SetNewLength(int length)
        {
            this.length = length;
            return length;
        }
        public int GetCurrentWidth()
        {
            return width;
        }
        public int SetNewWidth(int width)
        {
            this.width = width;
            return width;
        }
        public int GetPerimeter()
        {
            return (2 * (length + width));
        }
        public int GetArea()
        {
            return (length * width);
        }


    }
}