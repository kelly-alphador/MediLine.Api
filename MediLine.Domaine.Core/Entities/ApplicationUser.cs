using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MediLine.Domaine.Core.Entities
{
    //si IdentityUser le id sera de type string GUID mais pour specifier IdentityUser<int> 
    public class ApplicationUser:IdentityUser<int>
    {
        [MaxLength(100)]
        public string ImageProfil {  get; set; }
        //DateTime.Now:c'est pour date local de l'ordinateur
        [MaxLength(25)]
        public string LastName {  get; set; }
        [MaxLength(25)]
        public string? Specialite { get; set; }
        public DateTime DateInscriptions { get; set; }= DateTime.Now;
    }
}
