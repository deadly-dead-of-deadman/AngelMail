using AngelMail.Core.Data;
using Core.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngelMail.Core.Controllers;

[Route("message")]
[Controller]
public class MessageController : ControllerBase
{
    private readonly CoreDbContext _context;
    public MessageController(CoreDbContext context) => _context = context;

    [HttpGet]
    public async Task<IEnumerable<Message>> Get()
    {
        return await _context.Messages.ToListAsync();
        // return 
    } 
    
}