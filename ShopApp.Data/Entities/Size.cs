﻿using ShopApp.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopApp.Data.Entities
{
    [Table("Sizes")]
    public class Size : DomainEntity<int>
    {
        [StringLength(250)]
        public string Name
        {
            get; set;
        }
    }
}