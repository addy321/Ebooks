using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Books
    {
        public int id { get; set; }
        public string title { get; set; }
        public string summary { get; set; }
        public string author { get; set; }
        public string addedTime { get; set; }
        public int collection { get; set; }
        public string imgUrl { get; set; }
        public int Types { get; set; }
        public int status { get; set; }
        public string txtUrl { get; set; }
    }
}
