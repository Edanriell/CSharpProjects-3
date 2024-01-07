using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasuryFlightDataAnalysis
{
    internal enum FilterCriteriaType
    {
        Class,
        Origin,
        Destination
    }

    internal record FilterCriteria(FilterCriteriaType Filter, string Operand);
}
