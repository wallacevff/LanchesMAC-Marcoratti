using LanchesMac.Models;
using System.Collections.Generic;

namespace LanchesMac.Repositories
{
    interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheByID(int lancheId);
    }
}
