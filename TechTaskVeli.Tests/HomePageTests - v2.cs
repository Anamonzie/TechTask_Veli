using TechTaskVeli;

namespace PlaywrightTests;

public class HomePageTestsV2 : PageTest
{
    private HomePage homepage;

    [SetUp]
    public void SetUp()
    {
        homepage = new HomePage(Page);
    }

    [Test]
    public async Task HasTitle()
    {
        await homepage.GoToHomePageAsync();

        await Expect(Page).ToHaveTitleAsync(new Regex("Veli Store"));
    }
  
    [Test]
    public async Task GetStartedLink()
    {
        await homepage.GoToHomePageAsync();
        await homepage.ClickBackToSchoolLinkAsync();

        await Expect(Page).ToHaveURLAsync(new Regex(".*back-to-school.*"));
    }    
}
