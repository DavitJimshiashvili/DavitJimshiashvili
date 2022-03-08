using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateW.Services.Abstractions
{
    public interface IJWTService
    {
        string GenerateJWTToken(string userName);

    }
}
