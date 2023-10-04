using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkDotNet
{
    public class ComparacaoStringBenchmark
    {
        public string nome1 = "Teste Performance";
        public string nome2 = "tESTE PeRFoRMANCe";

        [Benchmark]
        public bool IgualdadeComToLower()
        {
            return nome1.ToLower() == nome2.ToLower();
        }

        [Benchmark]
        public bool IgualdadeComToUpper()
        {
            return nome1.ToUpper() == nome2.ToUpper();
        }
        
        [Benchmark]
        public bool CompareComIgnoreCase()
        {
            return string.Compare(nome1, nome2, StringComparison.OrdinalIgnoreCase) == 0;
        }

        [Benchmark]
        public bool EqualsIgnoreCase()
        {
            return nome1.Equals(nome2, StringComparison.OrdinalIgnoreCase);
        }


    }
}
