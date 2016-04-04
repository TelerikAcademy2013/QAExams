namespace Demos.Telerik.Core.Pages.MainPage
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Contracts;

    public class MainPage
    {
        public const string navigationUrl = @"http://demos.telerik.com/aspnet-ajax/";

        public MainPageMap Map
        {
            get
            {
                return new MainPageMap();
            }
        }

        public MainPageValidator Validator
        {
            get
            {
                return new MainPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(navigationUrl);
        }

        public void SearchForGridFilteredByCombo()
        {
            this.Map.SearchBox.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("Grid Filtered by Combo");
        }

        public void SelectGridFilteredByCombo()
        {
            this.Map.GridFilteredByCombo.MouseClick();
        }
    }
}
