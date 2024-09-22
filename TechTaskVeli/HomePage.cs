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

        //private ILocator BackpackButton => page
        //    .Locator("a.title[href*='/zurgchantebi/']");


        //private ILocator PopupCloseButton => page.Locator("interactive-close-button");

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
        //public ILocator GetPopupCloseButton()
        //{            
        //    return PopupCloseButton;
        //}

        //public async Task ClickOnBackpack()
        //{
        //    await BackpackButton.ClickAsync();
        //}

        //public async Task ClosePopup()
        //{
        //    await PopupCloseButton.ClickAsync();
        //}

        public string GetPageUrl()
        {
            return page.Url;
        }
    }
}
