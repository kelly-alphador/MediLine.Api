using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediLine.Domaine.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MediLine.Infrastructure.Core.Context
{
    //on utilise identity pour la gestion de l'utilisateur lorsu'on migre il va creer 
    //AspnetUser , aspNetRoles etc
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    }
}
