using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.controllers;


[ApiController]
[Route("api/[controller]")] //api/users
public class UsersController: ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
       var users = _context.Users.ToListAsync();

       return await users; 
    }

    [HttpGet("{Id}")] // api/users/2
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = _context.Users.FindAsync(id);
        return await user;
        // need to handle cases of when ID is invalid.
    }
}