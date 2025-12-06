using Library.Domain.Entities;
using Library.Domain.SecondaryPorts;
using Library.Persistence.EFContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.EFConcrete
{
    public class BookTagRepository : BaseRepository<BookTag>, IBookTagRepository
    {
        public BookTagRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}

