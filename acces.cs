using System;
using System.Runtime.InteropServices;

namespace second_lab
{
    public class acces
    {
        public byte r, g, b;
 
        public void getColor(int x,int y)
        {
            IntPtr hDC = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hDC, x, y);
            ReleaseDC(IntPtr.Zero, hDC);
 
            r = (byte)(pixel & 0x000000FF);
            g = (byte)((pixel & 0x0000FF00) >> 8);
            b = (byte)((pixel & 0x00FF0000) >> 16);
        }
 
        #region DLLImport
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
 
        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hDC);
 
        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hDC, int x, int y);
        #endregion
    }
}