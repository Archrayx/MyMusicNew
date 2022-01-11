using MyMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Services.Services
{
    public interface IArtistService
    {
        Task<IEnumerable<Artist>> GetAllArtists();
        Task<Artist> GetArtistById(int id);
        Task<Artist> CreateArtist(Artist newArtist);
        Task UpdateArtist(Artist artistToUpdate, Artist artist);
        Task DeleteArtist(Artist artist);
    }

    }
