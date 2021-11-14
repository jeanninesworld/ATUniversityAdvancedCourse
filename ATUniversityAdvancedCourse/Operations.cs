using System;

internal class Operations
{
    internal Lecture3.Multiplication<decimal, decimal> TaxCalculation;

    public Lecture3.Multiplication<decimal, decimal> GetTotal { get; internal set; }

    internal float GetTaxCalculation(decimal subTotal, decimal taxPercentage)
    {
        throw new NotImplementedException();
    }
}