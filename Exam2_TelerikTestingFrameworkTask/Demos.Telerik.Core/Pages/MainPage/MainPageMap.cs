namespace Demos.Telerik.Core.Pages.MainPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Contracts;

    public class MainPageMap : BaseElementMap
    {
        
        public HtmlInputText SearchBox
        {
            get
            {
                return this.Find.ById<HtmlInputText>("DemoSearchControl_SearchBox_Input");
            }
        }

        public HtmlSpan GridFilteredByCombo
        {
            get
            {
                //var container = this.Find.ByAttributes<HtmlUnorderedList>("class=rsbList");
                //var item = container.Find.AllByTagName<HtmlListItem>("li")[0];
                //this.Find.ByXPath<HtmlListItem>("//*[@id='form1']/div[1]/div/ul/li[1]/a");
                //
                //var item = this.Find.AllByAttributes<HtmlListItem>("class=rsbListItem rsbListItemTemplate")[0];
                //return item;
                //I give up!!!
                return this.Find.ByContent<HtmlSpan>("Grid Filtered by Combo");
            }
        }

        public HtmlSpan VerifyGridFilteredByCombo
        {
            get
            {
                return this.Find.ById<HtmlSpan>("ctl00_DemoName");
            }
        }
    }
}
