using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjZalSongs.Models
{
    public class Songs
    {
        [Key]
        public int SongID { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string SongTitle { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string SongPerformer { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string SongDuration { get; set; }

    }
}
