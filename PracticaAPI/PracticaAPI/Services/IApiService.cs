using PracticaAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAPI.Services
{
    interface IApiService
    {
        Task<Place> GetLocation(string cedula);
    }
}
