using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookWiki.Domain.Models;

namespace BookWiki.Domain.Abstractions
{
    interface IDomain<T>
    {
        Task Add(T obj);
        IQueryable<T> Get();
    }
}