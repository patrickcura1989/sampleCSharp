using NUnit.Framework;
using OpenQA.Selenium;
using System;
using Test.Page;

namespace Test.UnitTest
{
    class JavascriptAlertPageTest : BaseTest
    {
        private JavascriptAlertPage _javascriptAlertPage;

        [SetUp]
        public void Before()
        {
            _javascriptAlertPage = new JavascriptAlertPage(Driver);
        }

        [Test(Description = "Verify that a User can Click on JS Alert then click Ok in the Alert")]
        public void ClickJSAlertThenAccept()
        {
            String expectedResultText = "You successfully clicked an alert";

            _javascriptAlertPage.ClickJsAlertButtonAndAccept();

            Assert.AreEqual(expectedResultText, _javascriptAlertPage.GetResultText());
        }


        [Test(Description = "Verify that a User can Click on JS Confirm then click Ok in the Alert")]
        public void ClickJSConfirmThenAccept()
        {
            String expectedResultText = "You clicked: Ok";

            _javascriptAlertPage.ClickJsConfirmButtonAndAccept();

            Assert.AreEqual(expectedResultText, _javascriptAlertPage.GetResultText());
        }

        [Test(Description = "Verify that a User can Click on JS Confirm then click Cancel in the Alert")]
        public void ClickJSConfirmThenCancel()
        {
            String expectedResultText = "You clicked: Cancel";

            _javascriptAlertPage.ClickJsConfirmButtonAndDismiss();

            Assert.AreEqual(expectedResultText, _javascriptAlertPage.GetResultText());
        }

        [Test(Description = "Verify that a User can Click on JS Prompt then click Cancel in the Alert")]
        public void ClickJSPromptThenCancel()
        {
            String expectedResultText = "You entered: null";

            _javascriptAlertPage.ClickJsPromptButtonAndDismiss();

            Assert.AreEqual(expectedResultText, _javascriptAlertPage.GetResultText());
        }

        [Test(Description = "Verify that a User can Click on JS Prompt then Input Text in the Alert and Click Ok")]
        public void ClickJSPromptThenInputTextAndAccept()
        {
            String text = "hello";
            String expectedResultText = string.Format("You entered: {0}", text);

            _javascriptAlertPage.ClickJsPromptButtonThenSendTextAndAccept(text);

            Assert.AreEqual(expectedResultText, _javascriptAlertPage.GetResultText());
        }

    }
}