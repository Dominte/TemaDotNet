using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class DBInitializer
    {
        public static void Seed(DataContext context)
        {
            IList<Todo> todos = new List<Todo>();

            todos.Add(new Todo() { Description = "description1", Created = DateTime.Now, IsDone = true });
            todos.Add(new Todo() { Description = "description2", Created = DateTime.Now, IsDone = false });
            todos.Add(new Todo() { Description = "description3", Created = DateTime.Now, IsDone = true });
            todos.Add(new Todo() { Description = "description4", Created = DateTime.Now, IsDone = false });
            todos.Add(new Todo() { Description = "description5", Created = DateTime.Now, IsDone = true });

            foreach (Todo item in todos)
                context.Todos.Add(item);

        }
    }
}
