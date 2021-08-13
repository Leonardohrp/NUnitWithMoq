using Models.Interfaces;
using NUnitWithMoq.Demo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Classes
{
    public class VerifierProductPrice : IVerifierProductPrice
    {
        public string VerifyProductPrice(Product product)
        {
            if (product.Price > 100)
                return "Expensive product!";
            else if (product.Price <= 100 && product.Price > 40)
                return "Product at average price!";
            else
                return "Cheap product!";
        }
    }
}
