using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarvajalJProgreso3.Models;


namespace CarvajalJProgreso3.Interfaces
{
    public interface ICarvajalPais
    {
        public Task<List<CarvajalPaisAPI>> Obtener();
    }
}
