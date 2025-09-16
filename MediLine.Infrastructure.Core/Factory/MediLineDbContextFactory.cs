﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediLine.Infrastructure.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MediLine.Infrastructure.Core.Factory
{
    public class MediLineDbContextFactory:IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args) 
        {
            var optionBuilder=new DbContextOptionsBuilder<ApplicationDbContext>();
            optionBuilder.UseSqlServer("Data Source=DESKTOP-1PCHEEU\\SQLEXPRESS;Initial Catalog=Mediline;Integrated Security=True;Trust Server Certificate=True");
            return new ApplicationDbContext(optionBuilder.Options);
        }
    }
}
