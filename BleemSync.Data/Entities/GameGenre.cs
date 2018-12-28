﻿using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BleemSync.Data.Entities
{
    public class GameGenre : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
