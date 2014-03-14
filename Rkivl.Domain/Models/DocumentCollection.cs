using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rkivl.Domain.Models
{
    public class DocumentCollection 
    {
        public IEnumerable<Document> Documents { get;  private set; }
    }
}
