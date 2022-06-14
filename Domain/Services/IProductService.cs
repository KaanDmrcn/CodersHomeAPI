﻿using CodersHomeAPI.Domain.Models;
using CodersHomeAPI.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodersHomeAPI.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
