using Application.DTOs.Lookup;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Application.DTOs;

public class UserDTO
{
    public Guid UserId { get; set; }
    public Person Person { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public List<Guid> Roles { get; set; } = new();
    public List<long> Areas { get; set; } = new();
    public List<long> Organizations { get; set; } = new();
    public TokenDTO UserToken { get; set; }
    public List<ApplicationPageDTO> AccessablePages { get; set; } = new List<ApplicationPageDTO>();
} 