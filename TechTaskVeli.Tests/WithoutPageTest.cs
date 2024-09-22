
////  **** not revised yet **** //

//using Microsoft.Playwright;

//namespace PlaywrightTests;

//public class NavigationTests
//{
//    private IPlaywright playwright;
//    private IBrowser browser;
//    private IPage page;

//    [SetUp]
//    public async Task Setup()
//    {
//        playwright = await Playwright.CreateAsync();
//        browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
//        page = await browser.NewPageAsync();
//        await page.GotoAsync("https://veli.store/");
//    }

//    [TearDown]
//    public async Task TearDown()
//    {
//        await browser.CloseAsync();
//    }

//    [Test]
//    public async Task HasTitle()
//    {
//        Assert.That(await page.TitleAsync(), Does.Contain("Veli Store"));
//    }

//    [Test]
//    public async Task GetStartedLink()
//    {
//        // Click the get started link.
//        await page
//            .GetByRole(AriaRole.Link)
//            .Filter(new() { HasTextRegex = new Regex("Back to School") }).Nth(1)
//            .ClickAsync();

//        // Expects page to have a heading with the name of Installation.
//        Assert.That(page.Url, Does.Contain("back-to-school"));
//    }
//}
