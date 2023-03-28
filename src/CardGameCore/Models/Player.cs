namespace Tesaurs.CardGameCore.Models
{
    public class Player
    {
        /// <summary>
        /// идентификатор игрока
        /// </summary>
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int DeckId { get; set; }

        public Deck Deck { get; set; }


        public virtual ICollection<Card> Hand { get; set; }

        /// <summary>
        /// Карты игрока на столе.
        /// </summary>
        public virtual ICollection<Card> CardsOnTable { get; set;}
    }
}
