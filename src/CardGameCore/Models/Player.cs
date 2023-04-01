using System.ComponentModel.DataAnnotations.Schema;

namespace Tesaurs.CardGameCore.Models
{
    public class Player
    {
        /// <summary>
        /// идентификатор игрока
        /// </summary>
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }

        public int? CurrentGameId { get; set; }

        public Game? CurrentGame { get; set; }

        public int? DeckId { get; set; }

        public Deck? Deck { get; set; }


        public virtual ICollection<Card> Hand { get; set; }

        /// <summary>
        /// Карты игрока на столе.
        /// </summary>
        public virtual ICollection<Card> CardsOnTable { get; set;}
    }
}
