using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment02;
using NUnit.Framework;

namespace Assignment02.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        // 1st case
        [Test]
        public void rectLength()
        {
            int leng = 10;
            Rectangle rect = new Rectangle(leng, 20);
            int expextedVal = leng;
            int result = rect.GetCurrentLength();
            Assert.AreEqual(leng, result);

        }

        //2nd case
        [Test]
        public void lenghtNull()
        {
            int leng = 30;
            Rectangle rect = new Rectangle(leng, 20);
            var result = rect.GetCurrentLength();
            Assert.IsNotNull(result);
        }

        // 3rd case
        [Test]
        public void lenghtEqual()
        {
            int leng = 25;
            Rectangle rect = new Rectangle(leng, 20);
            var result = rect.GetCurrentLength();
            Assert.AreNotEqual(result,1);
        }
        //4th case
        [Test]
        public void newRectLength()
        {
            int leng = 15;
            Rectangle rect = new Rectangle(67, 25);
            int expextedVal = leng;
            int result = rect.SetNewLength(leng);
            Assert.AreEqual(leng, result);

        }

        // 5th case
        [Test]
        public void newLenghtNull()
        {
            int leng = 45;
            Rectangle rect = new Rectangle(16, 24);
            var result = rect.SetNewLength(leng);
            Assert.IsNotNull(result);
        }
        // 6th case
        [Test]
        public void newLenghtEqual()
        {
            int leng = 37;
            Rectangle rect = new Rectangle(67, 56);
            var result = rect.SetNewLength(leng);
            Assert.AreNotEqual(result, 1);
        }

        // 7th case
        [Test]
        public void rectWidth()
        {
            int wid = 22;
            Rectangle rect = new Rectangle(13, wid);
            int expextedVal = wid;
            int result = rect.GetCurrentWidth();
            Assert.AreEqual(wid, result);

        }

        // 8th case
        [Test]
        public void widthNull()
        {
            int wid = 13;
            Rectangle rect = new Rectangle(15, wid);
            int expextedVal = wid;
            int result = rect.GetCurrentWidth();
            Assert.IsNotNull(result);
        }

        //9th case
        [Test]
        public void widthEqual()
        {
            int leng = 18;
            Rectangle rect = new Rectangle(leng, 56);
            var result = rect.GetCurrentWidth();
            Assert.AreNotEqual(result, leng);
        }

        //10th case
        [Test]
        public void newRectWidth()
        {
            int width = 35;
            Rectangle rect = new Rectangle(78, 12);
            int expextedVal = width;
            int result = rect.SetNewWidth(width);
            Assert.AreEqual(width, result);

        }

        // 11th case
        [Test]
        public void newWidthNull()
        {
            int width = 25;
            Rectangle rect = new Rectangle(7, 24);
            int expextedVal = width;
            var result = rect.SetNewWidth(width);
            Assert.IsNotNull(result);
        }
        
        // 12th case
        [Test]
        public void newWidthEqual()
        {
            int width = 28;
            Rectangle rect = new Rectangle(17, 12);
            int expextedVal = width;
            var result = rect.SetNewWidth(width);
            Assert.AreNotEqual(result, 0);
        }

        //13th case
        [Test]
        public void rectPerimeter()
        {
            Rectangle rect = new Rectangle(78, 12);
            int expextedVal = 180;
            int result = rect.GetPerimeter();
            Assert.AreEqual(result, expextedVal);

        }

        // 14th case
        [Test]
        public void PerimeterNull()
        {
            Rectangle rect = new Rectangle(16, 18);
            int expextedVal = 68;
            int result = rect.GetPerimeter();
            Assert.IsNotNull(result);
        }

        // 15th case
        [Test]
        public void PerimeterEqual()
        {
            Rectangle rect = new Rectangle(45, 19);
            int expextedVal = 128;
            var result = rect.GetPerimeter();
            Assert.AreNotEqual(result, 0);
        }

        //16th case
        [Test]
        public void rectgetArea()
        {
            Rectangle rect = new Rectangle(9, 13);
            int expextedVal = 117;
            int result = rect.GetArea();
            Assert.AreEqual(result, expextedVal);

        }

        // 14th case
        [Test]
        public void AreaNull()
        {
            Rectangle rect = new Rectangle(17, 10);
            int expextedVal = 170;
            int result = rect.GetArea();
            Assert.IsNotNull(result);
        }

        // 15th case
        [Test]
        public void AreaEqual()
        {
            Rectangle rect = new Rectangle(75, 25);
            int expextedVal = 1875;
            var result = rect.GetArea();
            Assert.AreNotEqual(result, 0);
        }


    }
}
