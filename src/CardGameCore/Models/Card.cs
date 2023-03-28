namespace Tesaurs.CardGameCore.Models
{
    public class Card
    {
        /// <summary>
        /// Идентификатор карты.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название карты.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание карты.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Значение атаки карты.
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// Значение здоровья карты.
        /// </summary>
        public int Health { get; set; }
    }
}
