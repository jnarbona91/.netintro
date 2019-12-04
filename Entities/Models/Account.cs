﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("account")]
    public class Account
    {
        public Guid AccountID { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Account type is required")]
        public string AccountType { get; set; }

        [Required(ErrorMessage = "Owner Id is required")]
        public Guid OwnerId { get; set; }

        [ForeignKey(nameof(Owner))]
         public Guid OwnerId { get; set; }
         public Owner Owner { get; set; }
    }
}
