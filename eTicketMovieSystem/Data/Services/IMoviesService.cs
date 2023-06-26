using eTicketMovieSystem.Data.Base;
using eTicketMovieSystem.Data.ViewModels;
using eTicketMovieSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketMovieSystem.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMoiveAsync(NewMovieVM data);
        Task UpdateMoiveAsync (NewMovieVM data);
    }
}
