﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PhamVanLeBao_2001170836_AppSmart_BT2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3());
        }
    }
}
