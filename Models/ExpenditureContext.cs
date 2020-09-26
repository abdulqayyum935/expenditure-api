using Microsoft.EntityFrameworkCore;

namespace ExpenditureApi.Models
{
    public class ExpenditureContext:DbContext
    {
       public ExpenditureContext(DbContextOptions options):base(options){
       }
      public  DbSet<Income> Income {get;set;}
       public DbSet<ExpenditureType> ExpenditureType {get;set;}

    }
}