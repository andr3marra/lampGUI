using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lampGUI
{
    public static class LedStrip
    {
        public static byte[] MoveU(byte[] dots, byte step = 1)
        {
            var newDots = new byte[dots.Length];
            for (byte i = 0; i < step; i++)
            {
                newDots[i] = dots[dots.Length - step + i];
            }
            for (byte i = 0; i < dots.Length - step; i++)
            {
                newDots[i + step] = dots[i];
            }
            return newDots;
        }
        public static byte[] MoveD(byte[] dots, byte step = 4)
        {
            var newDots = new byte[dots.Length];
            for (byte i = 0; i < step; i++)
            {
                newDots[dots.Length - step + i] = dots[i];
            }
            for (byte i = 0; i < dots.Length - step; i++)
            {
                newDots[i] = dots[i + step];
            }
            return newDots;
        }
    }
}
