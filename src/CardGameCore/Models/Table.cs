namespace Tesaurs.CardGameCore.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Card> Player1Cards { get; set; }
        public virtual ICollection<Card> Player2Cards { get; set; }
        public string Status { get; set; } // Todo: enum
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
