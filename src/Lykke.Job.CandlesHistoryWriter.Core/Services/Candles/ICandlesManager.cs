﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Job.CandlesHistoryWriter.Core.Domain.Candles;

namespace Lykke.Job.CandlesHistoryWriter.Core.Services.Candles
{
    public interface ICandlesManager
    {
        Task ProcessCandlesAsync(IReadOnlyList<ICandle> candles);
    }
}
