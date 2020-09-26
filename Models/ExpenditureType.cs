using System;

namespace ExpenditureApi.Models
{
    public class ExpenditureType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate {get;set;}
        public bool IsActive { get; set; }
    }
}