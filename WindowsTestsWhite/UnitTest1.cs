using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using System.Collections.Generic;
using TestStack.White.Factory;
using TestStack.White.UIItems.ListBoxItems;
using System.Threading;

namespace WindowsTestsWhite
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SignupTesting()
        {
            Application application = null;
            Window window = null;
            application = Application.Launch(@"D:\WindowsAppControls\WindowsAppControls\bin\Debug\WindowsAppControls.exe");
            //  window = application.GetWindow("Form1");
          //  Window window = application.GetWindow( SearchCriteria.ByAutomationId("Form1"), InitializeOption.NoCache);
             var windows = application.GetWindows();
       //     window = windows[0];
           window= windows.Find(x => x.Id == "Form1");
            TextBox enteremail = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox1"));
            Thread.Sleep(3000);
            enteremail.SetValue("Khaja.moizuddin@gmail.com");
            TextBox firstname = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox2"));
            firstname.SetValue("Khaja");
            Thread.Sleep(3000);
            TextBox lastname = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox3"));
            lastname.SetValue("Moizuddin");
            Thread.Sleep(3000);
            TextBox enterPassword = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox4"));
            enterPassword.SetValue("1234567890!@#$");
            TextBox confirmpassword = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox5"));
            confirmpassword.SetValue("1234567890!@#$");
            ComboBox dropCountry = window.Get<ComboBox>(SearchCriteria.ByAutomationId("comboBox1"));
            dropCountry.Select("India");
            TextBox zipcode = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox6"));
            zipcode.SetValue("500076");
            TextBox city = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox7"));
            city.SetValue("Hyderabad");
            ComboBox dropSecurityQuestion = window.Get<ComboBox>(SearchCriteria.ByAutomationId("comboBox2"));
            dropSecurityQuestion.Select("What is the name of the company of your first job?");
            TextBox securityAnswer = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox8"));
            securityAnswer.SetValue("XYZ Technologies");

            Button registerclick = window.Get<Button>(SearchCriteria.ByAutomationId("button1"));
            registerclick.Click();

          
        }

        //[TestMethod]
        //public void CalculatorTesting()
        //{
        //    Application application = null;
        //    Window window = null;
        //    application = Application.Launch(@"C:\Windows\system32\calc.exe");
        //    //  window = application.GetWindow("Form1");
        //      Window windowx = application.GetWindow("Calculator");
            
        //    var windows = application.GetWindows();
        //    //     window = windows[0];
        //    window = windows.Find(x => x.Name == "Calculator");
            
        //    // Identifying Calculator Controls
        //    Button minimizeBtn = window.Get<Button>(SearchCriteria.ByAutomationId("Minimize"));//
        //    Button maximizeBtn = window.Get<Button>(SearchCriteria.ByAutomationId("Maximize"));//
        //    Button closeBtn = window.Get<Button>(SearchCriteria.ByAutomationId("Close"));
        //}
    }
}
