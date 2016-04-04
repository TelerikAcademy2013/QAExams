namespace Demos.Telerik.Core.Pages.ComboBoxGrid
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Contracts;

    public class ComboBoxGridMap : BaseElementMap
    {

        public HtmlAnchor FilterDropdown
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("ctl00_ContentPlaceHolder1_NamesDDL_Arrow");
            }
        }

        public HtmlListItem ListNameReginaMurphy
        {
            get
            {
                var namesContainer = this.Find.ById<HtmlDiv>("ctl00_ContentPlaceHolder1_NamesDDL_DropDown");
                return namesContainer.Find.ByContent<HtmlListItem>("Regina Murphy");
            }
        }

        public int VerifyNumberOfRowsInGrid()
        {
            var gridContainer = this.Find.ById<HtmlTable>("ctl00_ContentPlaceHolder1_OrdersGrid_ctl00");
            var rowsCountInGrid = gridContainer.Find.AllByTagName("tr");
            var result = rowsCountInGrid.Count;
            return result;
        }
    }
}
