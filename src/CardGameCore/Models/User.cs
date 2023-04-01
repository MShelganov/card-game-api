using System.ComponentModel.DataAnnotations.Schema;

namespace Tesaurs.CardGameCore.Models
{
    public class User
    {
        /// <summary>
        /// идентификатор пользователя
        /// </summary>
        public int Id { get; set; }

        [ForeignKey("Player")]
        public int? PlayerId { get; set; }
        public Player? Player { get; set; }

        /// <summary>
        /// имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Электронный адрес.
        /// </summary>
        public string Email { get; set; }
        public string Password { get; set; }
        public string EmailConfirmed { get; set; }
        public virtual ICollection<Deck> Decks { get; set; }
        public DateTime LastVisit { get; set; }

    }
}
