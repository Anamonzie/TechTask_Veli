//using Microsoft.Playwright;
//using TechTaskVeli;

//namespace PlaywrightTests;

//public class HomePageTestsV2 : PageTest
//{
//    private HomePage homepage;

//    [SetUp]
//    public async Task SetUp()
//    {
//        homepage = new HomePage(Page);

//        await homepage.GoToHomePageAsync();
//    }

//    // Cat collar search in URL
//    [Test]
//    public async Task GetStartedLink()
//    {
//        await homepage.ClickBackToSchoolLinkAsync();

//        //var frameLocator = Page.FrameLocator("#hs-overlay-cta-111766127085");

//        //if (frameLocator is not null)
//        //{
//        //    var buttonLocator = frameLocator.GetByRole(AriaRole.Button);
//        //    if (buttonLocator is not null)
//        //    {
//        //        await buttonLocator.ClickAsync();
//        //    }
//        //}

//        await homepage.ClickOnBackpack();

//        await Expect(Page).ToHaveURLAsync(new Regex(".*zurgchantebi.*"));

//        //await Expect(Page).ToHaveURLAsync(new Regex(".*back-to-school.*"));

//        await Page.PauseAsync();
//    }

//   // //add to cart button - notification added in cart
//   //[Test]
//   // public async Task HasTitle()
//   // {
//   //     await Expect(Page).ToHaveTitleAsync(new Regex("Veli Store"));
//   // }
//}
