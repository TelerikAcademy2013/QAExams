namespace Demos.Telerik.Core.Pages.ComboBoxGrid
{
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core;

    public class ComboBoxGridValidator
    {
        private string exceptionMessage = "The number of rows do not match. Expected 3.";
        public ComboBoxGridMap Map
        {
            get
            {
                return new ComboBoxGridMap();
            }
        }

        public void AssertNumberOfRowsInGridIs3()
        {
            var numberOfRows = this.Map.VerifyNumberOfRowsInGrid();
            Assert.AreEqual<int>(numberOfRows, 3, exceptionMessage);
        }
    }
}
