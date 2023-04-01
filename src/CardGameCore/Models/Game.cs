namespace Tesaurs.CardGameCore.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Status { get; set; } // Todo: enum
        public virtual ICollection<Player> Players { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
