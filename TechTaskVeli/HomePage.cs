using Microsoft.Playwright;
using System.Text.RegularExpressions;

namespace TechTaskVeli
{
    public class HomePage
    {
        private readonly IPage page;

        public HomePage(IPage page)
        {
            this.page = page;
        }
        
        private ILocator BackToSchoolLink => page
            .GetByRole(AriaRole.Link)
            .Filter(new() { HasTextRegex = new Regex("Back to School") });

        public async Task GoToHomePageAsync()
        {
            await page.GotoAsync("https://veli.store/en");
        }

        public async Task<string> GetPageTitleAsync()
        {
            string title = await page.TitleAsync();

            return title;
        }

        public async Task ClickBackToSchoolLinkAsync()
        {
            await BackToSchoolLink.Nth(1).ClickAsync();
        }

        public string GetPageUrl()
        {
            return page.Url;
        }

    }
}
