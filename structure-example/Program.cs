using System;

namespace structure_example
{
    class Program
    {
        public struct Color 
        {
            public int Red;
            public int Green;
            public int Blue;
            
        }
        static void Main(string[] args)
        {
            #region 颜色练习

            Color mc;
            mc.Red = 255;
            mc.Green = 0;
            mc.Blue = 0;

            #endregion


        }
    }
}
