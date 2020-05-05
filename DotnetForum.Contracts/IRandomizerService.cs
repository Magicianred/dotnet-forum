using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetForum.Contracts
{
    public interface IRandomizerService
    {
        int GetNextNumber(int? min = null, int? max = null);
    }
}
