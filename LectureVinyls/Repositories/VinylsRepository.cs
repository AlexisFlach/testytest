using LectureVinyls.Entities;
using System.Collections.Generic;

namespace LectureVinyls.Repositories
{
    public class VinylsRepository
    {
        private readonly List<Vinyl> _vinylCollection = new()
        {
            new Vinyl() { Id = 1, Artist = "My artist", Title = "My title" },
            new Vinyl() { Id = 2, Artist = "My artist-2", Title = "My title-2" },
            new Vinyl() { Id = 3, Artist = "My artist-2", Title = "My title-2" },
        };

        public IEnumerable<Vinyl> GetVinyls()
        {
            return _vinylCollection;
        }
    }
}
