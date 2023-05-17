namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;


[ApiController] 
[Route("[controller]")] 
public class UsersController : IUserService
{ 
    public IUserService _userService; 
    public IMapper _mapper; 
 
    public UsersController( IUserService userService, IMapper mapper) 
    { 
        _userService = userService; 
        _mapper = mapper; 
    } 
 
    [HttpGet] 
    public new IActionResult GetAll() 
    { 
        var users = _userService.GetAll(); 
        return Ok(users); 
    } 
 
    [HttpGet("{id}")] 
    public new  IActionResult GetById(int id) 
    { 
        var user = _userService.GetById(id);
        return Ok(user); 
    } 
 
    [HttpPost] 
    public  IActionResult Create(CreateRequest model) 
    { 
        _userService.Create(model); 
        return Ok(new { message = "User created" }); 
    } 
 
    [HttpPut("{id}")] 
    public  IActionResult Update(int id, UpdateRequest model) 
    { 
        _userService.Update(id, model); 
        return Ok(new { message = "User updated" }); 
    } 
 
    [HttpDelete("{id}")] 
    public IActionResult Delete(int id) 
    { 
        _userService.Delete(id); 
        return Ok(new { message = "User deleted" }); 
    } 
}