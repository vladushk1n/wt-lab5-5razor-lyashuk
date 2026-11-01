using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_lyashuk.Models;
using wt_lab5_5razor_lyashuk.Data;

namespace wt_lab5_5razor_lyashuk.Pages.Players
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Player Player { get; set; } = default!;

        public IActionResult OnGet(int id)
        {
            Player = PlayerStore.Players.FirstOrDefault(p => p.Id == id);

            if (Player == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var existingPlayer = PlayerStore.Players.FirstOrDefault(p => p.Id == Player.Id);
            if (existingPlayer != null)
            {
                existingPlayer.Nickname = Player.Nickname;
                existingPlayer.Role = Player.Role;
                existingPlayer.Rating = Player.Rating;
                existingPlayer.IsActive = Player.IsActive;
            }

            return RedirectToPage("./Index");
        }
    }
}