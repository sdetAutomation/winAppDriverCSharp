using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.AUTLayer
{
    public class WinAppDriverBase
    {
        public static WindowsDriver<WindowsElement> Driver = GuiHelper.Driver;
    }
}
