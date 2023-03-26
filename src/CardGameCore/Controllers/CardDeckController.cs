using Microsoft.AspNetCore.Mvc;

using Npgsql;

namespace CardDeckAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardDeckController : ControllerBase
    {
        private readonly ILogger<CardDeckController> _logger;

        public CardDeckController(ILogger<CardDeckController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetCard")]
        public IActionResult GetCard()
        {
            using (var connection = new NpgsqlConnection("YourConnectionString"))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM Deck ORDER BY RANDOM() LIMIT 1", connection))
                {
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return Ok(new
                        {
                            id = reader.GetInt32(0),
                            suit = reader.GetString(1),
                            rank = reader.GetString(2)
                        });
                    }

                    return NotFound();
                }
            }
        }

        [HttpGet("GetCards/{amount:int}")]
        public IActionResult GetCards(int amount)
        {
            using (var connection = new NpgsqlConnection("YourConnectionString"))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM Deck ORDER BY RANDOM() LIMIT @amount", connection))
                {
                    command.Parameters.AddWithValue("@amount", amount);
                    var reader = command.ExecuteReader();
                    var cards = new List<object>();
                    while (reader.Read())
                    {
                        cards.Add(new
                        {
                            id = reader.GetInt32(0),
                            suit = reader.GetString(1),
                            rank = reader.GetString(2)
                        });
                    }
                    return Ok(cards);
                }
            }
        }

        [HttpPut("PutCard/{id:int}")]
        public IActionResult PutCard(int id)
        {
            using (var connection = new NpgsqlConnection("YourConnectionString"))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("DELETE FROM Deck WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    var rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return NotFound();
                    }
                    else
                    {
                        return Ok();
                    }
                }
            }
        }
    }
}
