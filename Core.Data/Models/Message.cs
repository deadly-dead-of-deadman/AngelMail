using System.ComponentModel.DataAnnotations;

namespace Core.Data.Models;

public class Message
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string Sender { get; set; }
    public string Reciever { get; set; }
    public DateTime SendTime { get; set; }
}