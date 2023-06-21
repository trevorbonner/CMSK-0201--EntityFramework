using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Repo<T> where T : Entity
    {
        private DataContext context;

        public Repo()
        {
            context = new DataContext();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Create(T newItem)
        {
            context.Set<T>().Add(newItem);
            context.SaveChanges();
        }

        public T Read(int id)
        {
            var item = context.Set<T>().Where(x => x.Id == id).First();
            //Select * from Students where Id = 1
            return item;
        }

        public void Update(T item)
        {
            var foundItem = context.Set<T>().Where(x => x.Id == item.Id).First();
            //Select * from Students where Id = 1
            if (foundItem == null)
                return; //no record for the id

            foreach(var property in foundItem.GetType().GetProperties())
            {
                var value = property.GetValue(item);
                property.SetValue(foundItem, value);
            }

            foundItem = item;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = context.Set<T>().Where(x => x.Id == id).First();
            if (item == null)
                return; //no record for the id

            context.Set<T>().Remove(item);
            context.SaveChanges();
        }
    }
}
