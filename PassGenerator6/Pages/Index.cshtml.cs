using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PassGenerator._3_Services.Interface;

namespace PassGenerator6.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPasswordGenService _passwordGenService;

        public IndexModel(IPasswordGenService passwordGenService)
        {
            _passwordGenService = passwordGenService;
        }

        public void OnGet()
        {

        }

        public IActionResult OnGetGenerateRandomPassword(int passLength)
        {
            List<string> randomPasswords = _passwordGenService.GenerateRandomPasswords(passLength, 5);

            string passwordsAsString = string.Join(Environment.NewLine, randomPasswords);

            return Content(passwordsAsString);
        }


    }
}
