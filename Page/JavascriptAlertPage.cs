using OpenQA.Selenium;

namespace Test.Page
{
    public class JavascriptAlertPage : BasePage
    {
        private readonly By _resultText = By.Id("result");
        private readonly By _jsAlertButton = By.CssSelector("button[onclick*='jsAlert']");
        private readonly By _jsConfirmButton = By.CssSelector("button[onclick*='jsConfirm']");
        private readonly By _jsPromptButton = By.CssSelector("button[onclick*='jsPrompt']");

        public JavascriptAlertPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetResultText()
        {
            return GetElement(_resultText).Text;
        }

        public void ClickJsAlertButton()
        {
            Click(_jsAlertButton);
        }

        public void ClickJsConfirmButton()
        {
            Click(_jsConfirmButton);
        }

        public void ClickJsPromptButton()
        {
            Click(_jsPromptButton);
        }

        public void ClickJsAlertButtonAndAccept()
        {
            ClickJsAlertButton();
            AcceptAlert();
        }

        public void ClickJsConfirmButtonAndAccept()
        {
            ClickJsConfirmButton();
            AcceptAlert();
        }

        public void ClickJsConfirmButtonAndDismiss()
        {
            ClickJsConfirmButton();
            DismissAlert();
        }

        public void ClickJsPromptButtonAndDismiss()
        {
            ClickJsPromptButton();
            DismissAlert();
        }

        public void ClickJsPromptButtonThenSendTextAndAccept(string text)
        {
            ClickJsPromptButton();
            SendTextToAlertThenAccept(text);
        }
    }
}