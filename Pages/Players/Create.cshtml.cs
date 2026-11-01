using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_lyashuk.Data;
using wt_lab5_5razor_lyashuk.Models;

namespace wt_lab5_5razor_lyashuk.Pages.Players
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Player Player { get; set; } = new();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Player.Id = PlayerStore.Players.Any() 
                ? PlayerStore.Players.Max(x => x.Id) + 1 
                : 1;

            PlayerStore.Players.Add(Player);
            return RedirectToPage("./Index");
        }
    }
}