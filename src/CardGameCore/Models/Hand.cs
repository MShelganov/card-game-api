namespace Tesaurs.CardGameCore.Models
{
    /// <summary>
    /// Хранит в себе указание за каким столом сидит игрок и какой
    /// набор карт он вытянул из колоды.
    /// </summary>
    public class Hand
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
    }
}
