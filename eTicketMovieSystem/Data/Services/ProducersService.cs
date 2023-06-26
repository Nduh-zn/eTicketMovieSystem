using eTicketMovieSystem.Data.Base;
using eTicketMovieSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketMovieSystem.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        //Injecting AppDbContext from the EntityBaseRepository
        public ProducersService(AppDbContext context):base(context)
        {

        }
    }
}
