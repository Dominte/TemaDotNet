using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class TodoRepository : ITodoRepository
    {
        private readonly DataContext context;
        public void Create(Todo todo)
        {
            this.context.Add(todo);
            this.context.SaveChanges();
        }

        public IEnumerable<Todo> GetActive()
        {
            return this.context.Todos.Where(todo => todo.IsDone ==false).ToList();
        }

        public IEnumerable<Todo> GetAll()
        {
            return this.context.Todos.ToList();
        }

        public Todo GetById(int id)
        {
            return this.context.Todos.Find(id);
        }

        public void Remove(Todo todo)
        {
            this.context.Remove(todo);
            this.context.SaveChanges();
        }

        public void Update(Todo todo)
        {
            this.context.Update(todo);
            this.context.SaveChanges();
        }
    }
}
