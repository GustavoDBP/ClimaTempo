using System.Collections.Generic;

namespace ClimaTempo.Models.ViewModels
{
    public class RankingPrevisao
    {
        public IEnumerable<PrevisaoDoTempo> TopQuentes{ get; set; }
        public IEnumerable<PrevisaoDoTempo> TopFrias{ get; set; }
    }
}
