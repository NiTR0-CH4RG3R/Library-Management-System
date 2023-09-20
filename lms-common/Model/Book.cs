using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms_common.Model
{
    public class Book
    {
        [PrimaryKey] private string? isbn = "";
        private string? title = null;
        private string? author = null;
        private int? qty = 0;

        public string? ISBN { get => isbn; set => isbn = value; }
        public string? Title { get => title; set => title = value; }
        public string? Author { get => author; set => author = value; }
        public int? Qty { get => qty; set => qty = value; }
    }
}
