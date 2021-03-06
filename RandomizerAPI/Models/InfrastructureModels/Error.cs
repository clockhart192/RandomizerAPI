﻿using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandomizerAPI.Models.InfrastructureModels
{
    public class Error
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }

        public Error() { }
        public Error(Exception ex)
        {
            Message = ex.Message;
            StackTrace = ex.StackTrace;
        }
    }
}
