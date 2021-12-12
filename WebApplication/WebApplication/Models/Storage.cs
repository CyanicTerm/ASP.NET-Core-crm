using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Storage
    {
        [Key]
        public int StorageId { get; set; }
        public int StorageNum { get; set; }
        [Required]
        public string PlateNum { get; set; }
        [Required]
        public string TireDescription { get; set; }
        public int TireNum { get; set; }
        public string RimDescription { get; set; }
        public int? RimNum { get; set; }
        public string OverallDescription { get; set; }

        //Foreign key for Client
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
