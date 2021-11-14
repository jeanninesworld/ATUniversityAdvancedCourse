using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Lecture3

{

    public delegate float Multiplication<in T1, in T2>(T1 subTotal, T2 taxPercentage);
        private float TaxCalculation(decimal subTotal, decimal taxPercentage)
        {
            return (float)(subTotal * taxPercentage);
        }
        private float GetTotal(decimal subTotal, decimal tax)
        {
            return (float)(float)(subTotal + tax);
        }
    public void DelegateTest()
        {
        /*  Multiplication<float> handler = TaxCalculation;
          Console.WriteLine(String.Format("The result is {0}", TaxCalculation(1, 2)));
          Console.WriteLine(String.Format("The result is {0}", GetTotal(1, 2)));
        */
        Operations myOperation = new Operations();
        Multiplication<decimal, decimal> TaxCalculation = myOperation.TaxCalculation;
        Multiplication<decimal, decimal> GetTotal = myOperation.GetTotal;
    }

    [Test]
    public void Collection()
    {
        Dictionary<int, decimal> result = new Dictionary<int, decimal>();
        result.Add(100, (decimal).15);
        result.Add(200, (decimal).17);
        result.Add(300, (decimal).19);
        result.Add(100, (decimal).15);
        result.Add(100, (decimal).15);

        

        foreach (KeyValuePair<int,decimal> row in result)
        {
            Console.WriteLine("TaxCalculation = " + TaxCalculation(row.Key, row.Value));
            Console.WriteLine("SubTotal = " + GetTotal(row.Key, row.Value));
        }
    }
}
    
