using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenditureApi.Models
{
    public class Income
    {
        //Auto increment & primary key in the table
        // test comment
        public int Id {get;set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
    }
}
