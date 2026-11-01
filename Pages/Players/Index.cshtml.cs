using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_lyashuk.Data;
using wt_lab5_5razor_lyashuk.Models;

namespace wt_lab5_5razor_lyashuk.Pages.Players
{
    public class IndexModel : PageModel
    {
        public List<Player> Players { get; set; } = new();

        public void OnGet()
        {
            Players = PlayerStore.Players;
        }
    }
}