using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace BlogProject.Models
{
    public class BlogModel
    {
        public int Id { get; set; }

        public string Baslik { get; set; }

        public string Aciklama { get; set; }

        public string Resim { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }
        public int CategoryId { get; set; }
        public DateTime EklenmeTarihi { get; set; }
    }
}