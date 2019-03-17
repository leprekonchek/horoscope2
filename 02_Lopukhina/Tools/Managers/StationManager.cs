using System;
using System.Windows;
using _02_Lopukhina.Models;

namespace _02_Lopukhina.Tools.Managers
{
    class StationManager
    {

        internal static Person CurrentPerson { get; set; }

        internal static void CloseApp()
        {
            MessageBox.Show("Closing the app...");
            Environment.Exit(1);
        }
    }
}
