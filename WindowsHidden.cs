using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Phisten.WindowsHidden
{


    class WindowsHidden
    {
        static void Main(string[] args)
        {
            Process p;
            //autorun File
            for (int i = 0,length = args.Length; i < length; i++)
            {
                string appPath = args[i];
                p = openApp(appPath);
            }
        }

        private static Process openApp(string appPath)
        {
            Process app = new Process();
            app.StartInfo.FileName = appPath;
            app.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            app.Start();
            return app;
        }

    }
}
