using Microsoft.EntityFrameworkCore;
using RandomizerAPI.Models.Context;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace RandomizerAPI.Models
{
    public class RandomizerSession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string SessionID { get; set; }
        public string Password { get; set; }

        public Game Game { get; set; }
        public string  SpoilerLog { get; set; }
    }

    public enum Game
    {
        OcarinaOfTime = 0,
        MajorasMask = 1
    }

    public enum View
    {
        Player = 0,
        Spectator = 1
    }
}
