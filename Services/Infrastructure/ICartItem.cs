﻿using EcommerceApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Services.Infrastructure
{
   public interface ICartItem
    {
        IEnumerable<CartItem> GetAll();

        CartItem GetById(int id);

        void Insert(CartItem cart);

        void Update(CartItem cart);

        void Delete(int id);

        int Count();

        void Save();
    }
}
