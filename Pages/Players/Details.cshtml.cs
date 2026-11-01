using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_lyashuk.Data;
using wt_lab5_5razor_lyashuk.Models;

namespace wt_lab5_5razor_lyashuk.Pages.Players
{
    public class DetailsModel : PageModel
    {
        public Player? Player { get; set; }

        public IActionResult OnGet(int id)
        {
            Player = PlayerStore.Players.FirstOrDefault(x => x.Id == id);
            if (Player == null) // замените name на null (или скопируйте код ниже)
            {
                return NotFound();
            }
            return Page();
        }
    }
}