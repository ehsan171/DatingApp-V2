﻿﻿namespace DatingApp.API.Models
{
    public class BarnameGroup
    {
        public virtual Barname Barname { get; set; }
        public int BarnameId { get; set; }
        public virtual BasicData BasicData { get; set; }
        public int BasicDataId { get; set; }
    }
}