using System;
using System.Collections.Generic;

namespace GISA.Model;

public partial class Vwfichasappterritorio
{
    public long? CoSeqRecebLote { get; set; }

    public DateTime? DtRecebimento { get; set; }

    public long? NuLoteOriginadora { get; set; }

    public string? NoResponsavelEnvio { get; set; }

    public string? NuIdentificadorResponsavel { get; set; }

    public long? QtFichas { get; set; }
}
