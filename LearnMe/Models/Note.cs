﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearnMe.Models
{
    [Table("Note")]
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("Text")]
        public string Text { get; set; }

        [Column("CardId")]
        public int CardId { get; set; }
    }
}
