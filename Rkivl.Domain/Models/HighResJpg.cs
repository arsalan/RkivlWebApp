using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rkivl.Domain.Models
{
    public class HighResJpg : Document
    {
        public override DocumentType TypeOfDocument
        {
            get { return DocumentType.ImageJpg; }
        }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}
