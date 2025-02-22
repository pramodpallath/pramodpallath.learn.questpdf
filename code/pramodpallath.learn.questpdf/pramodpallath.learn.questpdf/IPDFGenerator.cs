using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pramodpallath.learn.questpdf
{
    public interface IPDFGenerator
    {
        string GeneratorName { get; }

        string Generate();
    }
}
