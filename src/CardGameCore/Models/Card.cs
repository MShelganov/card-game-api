namespace Tesaurs.CardGameCore.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AttackPoints { get; set; }
        public int HealthPoints { get; set; }
        public int? DeckId { get; set; }
        public virtual Deck? Deck { get; set; }
        public int? TableId { get; set; }
        public virtual Table Table { get; set; }
    }
}
