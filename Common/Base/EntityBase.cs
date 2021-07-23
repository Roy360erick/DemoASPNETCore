using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Base
{
    public class EntityBase
    {
        public int Id { get; set; }
        public bool Enabled { get; set; }
        public DateTime? CreateAt { get; set; }
    }
}
