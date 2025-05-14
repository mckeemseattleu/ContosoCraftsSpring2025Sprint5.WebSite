


using NUnit.Framework;
using ContosoCrafts.WebSite.Pages.Product;


namespace UnitTests.Pages.Product.Read
{
    public class ReadTests
    {
        #region TestSetup
        public static ReadModel pageModel;
        /// <summary>
        /// Initialize of Test
        /// </summary>
        [SetUp]
        public void TestInitialize()
        {
            pageModel = new ReadModel(TestHelper.ProductService)
            {
            };
        }

        #endregion TestSetup

        #region OnGet

        // OnGet on Read should test functionality of a Read of a specific product
        // Tests should include making sure that Read returns the Product in its payload with a valid ID
        // Tests should include InvalidID's

        // OnPost is not handled.

        /// <summary>
        /// Return a Product with a given Id.
        /// We will create a Record, and then search for it
        /// 
        /// </summary>
        [Test]

        public void OnGet_Valid_Should_Return_Products()
        {
            // Arrange 

            // Act
            pageModel.OnGet("mike-cloud");

            // Assert
            Assert.AreEqual(true, pageModel.ModelState.IsValid);
            Assert.AreEqual("Cloud Costume", pageModel.Product.Title);

            // Reset

            return;
        }

        [Test]
        public void OnGet_InValid_Should_Return_InvalidState()
        {
            // Arrange

            // Act
            pageModel.OnGet("mike-cloud2"); // Does not exist

            // Assert
            // Store whether the ModelState is valid for later assert
            var stateIsValid = pageModel.ModelState.IsValid;
            Assert.AreEqual(false, stateIsValid);

            // Reset
            // This should remove the error we added
            pageModel.ModelState.Clear();

            return;
        }
        #endregion OnGet
    }
}