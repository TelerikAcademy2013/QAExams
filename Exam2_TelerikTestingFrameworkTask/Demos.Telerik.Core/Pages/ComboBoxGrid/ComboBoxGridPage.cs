namespace Demos.Telerik.Core.Pages.ComboBoxGrid
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core;

    public class ComboBoxGridPage
    {
        public ComboBoxGridMap Map
        {
            get
            {
                return new ComboBoxGridMap();
            }
        }

        public ComboBoxGridValidator Validator
        {
            get
            {
                return new ComboBoxGridValidator();
            }
        }

        public void ClickFilterDropdown()
        {
            this.Map.FilterDropdown.MouseClick();
        }

        public void SelectListNameReginaMurphy()
        {
            this.Map.ListNameReginaMurphy.MouseClick();
        }
    }
}
