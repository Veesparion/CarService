﻿using System.ComponentModel.DataAnnotations;

namespace CarService.Models
{
    public class ServiceType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}