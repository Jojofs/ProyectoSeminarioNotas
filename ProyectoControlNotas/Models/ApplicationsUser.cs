using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProyectoControlNotas.Models
{
    public class ApplicationsUser : IdentityUser
    {
        [StringLength(200)]
        public string? Direccion { get; set; }
    }
}