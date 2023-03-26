namespace Tesaurs.CardGameCore.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
