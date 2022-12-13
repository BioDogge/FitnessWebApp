﻿using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.Models
{
    public class Eating
    {
        public int EatingId { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        [Column(TypeName = "date")]
        public DateTime MealDate { get; set; }

        [Column(TypeName = "time(0)")]
        public DateTime MealTime { get; set; }
    }
}