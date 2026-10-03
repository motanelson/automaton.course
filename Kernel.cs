using Cosmos.Core.IOGroup;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace Cosmosvirtual
{


    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        
        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth = (uint)1020;
            Sys.MouseManager.ScreenHeight = (uint)798;



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0; static int y = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {
                graf.starts();
                
                tests.mainLoop();
                while (true)
                {
                    Thread.Sleep(1000);
                    tests.mainLoop();




                    ;

                }
            }


        }
    }





    class tests



    {


        public static void mainLoop()
        {
            //


            double[] dcos = { 1.0000, 0.9945, 0.9781, 0.9510, 0.9135, 0.8660, 0.8090, 0.7431, 0.6691, 0.5877, 0.5000, 0.4067, 0.3090, 0.2079, 0.1045, 0.0000, -0.104, -0.207, -0.309, -0.406, -0.500, -0.587, -0.669, -0.743, -0.809, -0.866, -0.913, -0.951, -0.978, -0.994, -1.000, -0.994, -0.978, -0.951, -0.913, -0.866, -0.809, -0.743, -0.669, -0.587, -0.500, -0.406, -0.309, -0.207, -0.104, -0.000, 0.1045, 0.2079, 0.3090, 0.4067, 0.5000, 0.5877, 0.6691, 0.7431, 0.8090, 0.8660, 0.9135, 0.9510, 0.9781, 0.9945, 1.0000, 0.00 };

            double[] dsin = { 0.0000, 0.1045, 0.2079, 0.3090, 0.4067, 0.5000, 0.5877, 0.6691, 0.7431, 0.8090, 0.8660, 0.9135, 0.9510, 0.9781, 0.9945, 1.0000, 0.9945, 0.9781, 0.9510, 0.9135, 0.8660, 0.8090, 0.7431, 0.6691, 0.5877, 0.5000, 0.4067, 0.3090, 0.2079, 0.1045, 0.0000, -0.104, -0.207, -0.309, -0.406, -0.500, -0.587, -0.669, -0.743, -0.809, -0.866, -0.913, -0.951, -0.978, -0.994, -1.000, -0.994, -0.978, -0.951, -0.913, -0.866, -0.809, -0.743, -0.669, -0.587, -0.500, -0.406, -0.309, -0.207, -0.104, 0.0000, 0.00 };

            Pen ppp = new Pen(Color.FromArgb(0, 0, 0));
            DateTime dat = new DateTime();
            dat=DateTime.Now;
            int s = dat.Second;
            int m = dat.Minute;
            int h = dat.Hour;
            if (s > 59) s = 0;
            if (m > 59) m = 0;
            if (h > 12) h = h - 12;
            Font ff = PCScreenFont.Default;
            graf.cls(Color.White);
            for (int a = 5; a < 65; a=a+5) graf.canvas.DrawString((a/5).ToString(),ff,ppp,512+((int)(dsin[a] * 300.00)),400 - (int)(dcos[a] * 300.00));
            graf.canvas.DrawLine(ppp,512,400 ,512 + ((int)(dsin[s] * 260.00)), 400 - (int)(dcos[s] * 260.00));
            graf.canvas.DrawLine(ppp, 512, 400, 512 + ((int)(dsin[m] * 200.00)), 400 - (int)(dcos[m] * 200.00));
            graf.canvas.DrawLine(ppp, 512, 400, 512 + ((int)(dsin[h] * 150.00)), 400 - (int)(dcos[h] * 150.00));
            graf.displays();
        }

    }





}
