using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sdet.Auto.AUTLayer;

namespace Sdet.Auto.WinAppDriverTests
{
    [TestClass]
    public class WinAppDriverTest : TestBaseClass
    {
        [TestMethod]
        public void TC0001_SmokeTest()
        {
            GuiHelper.LaunchNotepadApp();
            NotepadMain.VerifyDefaultState(TestAssert);
            GuiHelper.CloseNotepadApp();
        }
    }
}
