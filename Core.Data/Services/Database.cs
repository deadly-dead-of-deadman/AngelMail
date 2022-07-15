using Core.Data.Models;

namespace Core.Data.Services;

public class Database
{
    public IEnumerable<Message> GetMessages() => new[]
    {
        new Message { Id = 0, Reciever = "You", Sender = "mail@mail.ru", SendTime = DateTime.Now, Text = "Hello!" },
        new Message { Id = 1, Reciever = "You", Sender = "pochta@mail.ru", SendTime = DateTime.Now, Text = "Posilo4ka priшla!" },
        new Message { Id = 2, Reciever = "You", Sender = "gosuslugi@mail.ru", SendTime = DateTime.Now, Text = "Plati nalogi" },
        new Message { Id = 3, Reciever = "You", Sender = "sam@mail.ru", SendTime = DateTime.Now, Text = "where are u at tonight?" },

    };
}