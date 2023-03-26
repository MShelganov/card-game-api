namespace Tesaurs.CardGameCore.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string EmailConfirmed { get; set; }
        public virtual ICollection<Deck> Decks { get; set; }
        public DateTime LastVisit { get; set; }
    }
}
