namespace Demos.Telerik.Core.Pages.MainPage
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class MainPageValidator
    {
        public MainPageMap Map
        {
            get
            {
                return new MainPageMap();
            }
        }

        public void AssertAtGridFilteredByCombo()
        {
            this.Map.VerifyGridFilteredByCombo.AssertIsPresent();
        }
    }
}
