//using Microsoft.Playwright;

//namespace PlaywrightTests;

//public class HomePageTests : PageTest
//{
//    [Test]
//    public async Task HasTitle()
//    {
//        await Page.GotoAsync("https://veli.store/en");

//        await Expect(Page).ToHaveTitleAsync(new Regex("Veli Store"));
//    }

//    [Test]
//    public async Task GetStartedLink()
//    {
//        await Page.GotoAsync("https://veli.store/en");

//        await Page
//            .GetByRole(AriaRole.Link)
//            .Filter(new() { HasTextRegex = new Regex("Back to School") }).Nth(1)
//            .ClickAsync();

//        await Expect(Page).ToHaveURLAsync(new Regex(".*back-to-school.*"));
//    }
//}
