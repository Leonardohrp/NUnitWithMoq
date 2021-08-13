using NUnitWithMoq.Demo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public interface IVerifierProductPrice
    {
        string VerifyProductPrice(Product product);
    }
}
