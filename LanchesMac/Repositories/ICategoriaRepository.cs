using LanchesMac.Models;
using System.Collections.Generic;

namespace LanchesMac.Repositories
{
    interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
