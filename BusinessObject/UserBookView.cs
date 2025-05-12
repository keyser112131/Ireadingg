﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class UserBookView
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string? ChapterId { get; set; }
        public BookTypeStatus BookTypeStatus { get; set; }
        public string? CreateBy { get; set; }
        public string? UserId { get; set; }
        public Account? User { get; set; }
        public Book? Book { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    public enum BookTypeStatus
    {
        Read = 0,
        Voice = 1,
    }
}
