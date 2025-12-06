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
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}

