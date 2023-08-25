using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Models
{
    public class Book : BaseModel
    {
        
        public int PageCount { get; set; } = 0;
        public string? ISBN { get; set; }
        public bool IsDigital { get; set; }= false;
        public int CategoryId { get; set; }
        public virtual ICollection<Author> Authors { get;} = new List<Author>();
        public virtual ICollection<Publisher> Publishers { get;}= new List<Publisher>();
        // senaryo geregı bir kitabın sadece 1 kategorisi olma durumu varsayılmıstrı
        public virtual Category? Category { get; set; }
    }
}
