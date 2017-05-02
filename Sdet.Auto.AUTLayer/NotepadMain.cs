using OpenQA.Selenium.Interactions;
using Sdet.Auto.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sdet.Auto.AUTLayer
{
    public class NotepadMain : WinAppDriverBase
    {
        public static void VerifyDefaultState(TestAssert testAssert)
        {
            IoLibrary.WriteLine("Verifying Application Default State, and Menu Items.");
            Actions action = new Actions(Driver);    
            var notePadTitle = Driver.Title;
            testAssert.Pass = LoggingLibrary.CompareResult(notePadTitle, "Untitled - Notepad");
            // verifying File Menu Items   
            IoLibrary.WriteLine("Verifying Following File Menu Displayed: New, Open, Save, Save As..., Page Setup..., Print, Exit.");
            Driver.FindElementByName("File").Click();
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("New").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Open...").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Save").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Save As...").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Page Setup...").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Print...").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Exit").Displayed, true);

            IoLibrary.WriteLine("Verifying Following Edit Menu Displayed: Undo, Cut..., Copy, Paste, Delete, Find..., Find Next, Replace..., Go To..., Select All, Time/Date.");
            action.MoveToElement(Driver.FindElementByName("Edit")).Perform();
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Undo").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Cut").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Copy").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Paste").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Delete").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Find...").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Find Next").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Replace...").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Go To...").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Select All").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Time/Date").Displayed, true);

            IoLibrary.WriteLine("Verifying Following Format Menu Displayed: Word Wrap, Font...");
            action.MoveToElement(Driver.FindElementByName("Format")).Perform();
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Word Wrap").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Font...").Displayed, true);

            IoLibrary.WriteLine("Verifying Following View Menu Displayed: Status Bar");
            action.MoveToElement(Driver.FindElementByName("View")).Perform();
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("Status Bar").Displayed, true);

            IoLibrary.WriteLine("Verifying Following Help Menu Displayed: View Help, About Notepad");
            action.MoveToElement(Driver.FindElementByName("Help")).Perform();
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("View Help").Displayed, true);
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElementByName("About Notepad").Displayed, true);
        }
    }
}
