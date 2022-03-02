using System;
using System.Collections.Generic;
using System.Data.Entity;

using LeChiffreApp.Models;

namespace LeChiffreApp.Repositories;

public class DataContext: DbContext
{
    public DataContext() :base("DbConnection")
    { }
          
    public DbSet<ILogin> Logins { get; set; }
}