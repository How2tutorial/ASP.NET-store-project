﻿using System.ComponentModel.DataAnnotations;

namespace ASP.NET_store_project.Server.Data
{
    public class OrderStatus
    {
        [Key]
        public int OrderId { get; set; }

        public Order Order { get; set; } = null!;

        public string Status { get; set; }

        public DateTime DateOfStatusChange { get; set; }

    }
}