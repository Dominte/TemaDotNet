using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public interface ITodoRepository
    {
        void Create(Todo todo);
        IEnumerable<Todo> GetAll();
        Todo GetById(int id);
        IEnumerable<Todo> GetActive();
        void Remove(Todo todo);
        void Update(Todo todo);
    }
}
