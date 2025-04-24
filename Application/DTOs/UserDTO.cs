using System;
using System.Collections.Generic;

namespace Application.DTOs;

public class UserDTO
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }

    public string FullName
    {
        get
        {
            return string.Format("{0} {1} {2}", FirstName, MiddleName, LastName).Trim();
        }
        private set { }
    }
    public string UserCode { get; set; }
    public string Email { get; set; }
    public List<RoleDTO> Roles { get; set; } = new List<RoleDTO>();
    public TokenDTO UserToken { get; set; }
    public List<ApplicationPageDTO> AccessablePages { get; set; } = new List<ApplicationPageDTO>();
} 