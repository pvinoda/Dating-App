using API.Data;
using Microsoft.AspNetCore.Mvc;

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
}