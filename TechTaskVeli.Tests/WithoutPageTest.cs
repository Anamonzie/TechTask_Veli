
//  **** not revised yet **** //

//using Microsoft.Playwright;
//using TechTaskVeli;

//namespace PlaywrightTests;

//[Parallelizable(ParallelScope.Self)]
//[TestFixture]
//public class NavigationTests
//{
//    private IPlaywright _playwright;
//    private IBrowser _browser;
//    private IPage _page;

//    [SetUp]
//    public async Task Setup()
//    {
//        _playwright = await Playwright.CreateAsync();
//        _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
//        _page = await _browser.NewPageAsync();
//    }

//    [TearDown]
//    public async Task TearDown()
//    {
//        await _browser.CloseAsync();
//    }

    //[Test]
    //public async Task HasTitle()
    //{
    //    await Page.GotoAsync("https://veli.store/");

    //    // Expect a title "to contain" a substring.
    //    await Expect(Page).ToHaveTitleAsync(new Regex("Veli Store"));
    //}

    //[Test]
    //public async Task GetStartedLink()
    //{
    //    await Page.GotoAsync("https://veli.store/");

    //    // Click the get started link.
    //    await Page
    //        .GetByRole(AriaRole.Link)
    //        .Filter(new() { HasTextRegex = new Regex("Back to School") }).Nth(1)
    //        .ClickAsync();

    //    // Expects page to have a heading with the name of Installation.
    //    await Expect(Page).ToHaveURLAsync(new Regex(".*back-to-school.*"));
    //}
//}