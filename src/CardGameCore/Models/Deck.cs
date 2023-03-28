namespace Tesaurs.CardGameCore.Models
{
    public class Deck
    {
        /// <summary>
        /// Идентификатор колоды.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название колоды.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Связь один ко многим с моделью Card, показывающая,
        /// какие карты входят в колоду.
        /// </summary>
        public virtual ICollection<Card> Cards { get; set; }

        /// <summary>
        /// Дата создания колоды.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Дата обновления колоды.
        /// </summary>
        public DateTime UpdatedDate { get; set; }
    }
}
