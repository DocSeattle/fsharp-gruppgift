using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GruppUppgift.Shared;

public class GruppContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=mssql1.ilait.se;Initial Catalog=dbs126377;User Id=udmsbs459161;Password='=UW_,pV-n'");
    }
}







