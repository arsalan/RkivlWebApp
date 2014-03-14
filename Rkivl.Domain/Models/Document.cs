using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rkivl.Domain.Models
{
    public abstract class Document
    {
        public int Id { get; set; }
        public abstract DocumentType TypeOfDocument { get; }
    }
}
