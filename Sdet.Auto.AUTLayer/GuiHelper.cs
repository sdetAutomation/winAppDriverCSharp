using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sdet.Auto.AUTLayer
{
    public class GuiHelper
    {
        protected const string WinDriverUri = "http://127.0.0.1:4723";
        protected const string NotepadPath = @"C:\Windows\System32\notepad.exe";
        public static WindowsDriver<WindowsElement> Driver;

        public static void LaunchNotepadApp()
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", NotepadPath);
            Driver = new WindowsDriver<WindowsElement>(new Uri(WinDriverUri), appCapabilities);
        }

        public static void CloseNotepadApp()
        {
            Driver.Close();
        }
    }
}
