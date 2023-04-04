using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcVetement.Models
{
    public class VetementGenreViewModel
    {
        public List<Vetement>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
