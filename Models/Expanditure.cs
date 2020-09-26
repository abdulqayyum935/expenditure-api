using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenditureApi.Models
{
    public class Expanditure
    {
        public int Id { get; set; } 
        public int defsf { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public DateTime CreatedDate {get;set;}
        public bool IsActive {get;set;}
    }
}