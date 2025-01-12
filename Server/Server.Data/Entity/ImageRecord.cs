﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phoenix.Server.Data.Entity
{
    [Table("ImageRecords")]
    public class ImageRecord
    {
        [Key]
        public int Id { get; set; }
        public string FileName { get; set; }
        public string RelativePath { get; set; }
        public string AbsolutePath { get; set; }
        public bool IsExternal { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public bool IsUsed { get; set; }
        public bool Deleted { get; set; }
    }
}
