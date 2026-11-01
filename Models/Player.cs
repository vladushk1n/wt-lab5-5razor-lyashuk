using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_lyashuk.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите никнейм игрока")]
        [StringLength(50, ErrorMessage = "Никнейм не должен превышать 50 символов")]
        public string Nickname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Укажите игровую роль")]
        public string Role { get; set; } = string.Empty;

        [Range(1, 10000, ErrorMessage = "Рейтинг MMR должен быть от 1 до 10000")]
        public int Rating { get; set; }

        public bool IsActive { get; set; }
    }
}