using wt_lab5_5razor_lyashuk.Models;

namespace wt_lab5_5razor_lyashuk.Data
{
    public static class PlayerStore
    {
        public static List<Player> Players { get; set; } = new()
        {
            new Player { Id = 1, Nickname = "s1mple", Role = "AWPer", Rating = 3200, IsActive = true },
            new Player { Id = 2, Nickname = "ZywOo", Role = "AWPer", Rating = 3150, IsActive = true },
            new Player { Id = 3, Nickname = "b1t", Role = "Rifler", Rating = 2800, IsActive = true },
            new Player { Id = 4, Nickname = "m0NESY", Role = "AWPer", Rating = 2950, IsActive = true },
            new Player { Id = 5, Nickname = "electroNic", Role = "IGL", Rating = 2700, IsActive = true }
        };
    }
}