using Data.Context;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class PresentesRepo
    {
        public void Create(Presentes model)
        {
            using (var context = new PreContext())
            {
                context.Presentes.Add(model);
                context.SaveChanges();
            }
        }
        public List<Presentes> Read()
        {
            List<Presentes> list = new List<Presentes>();
            using (var context = new PreContext())
            {
                list = context.Presentes.ToList();
            }
            return list;
        }
        public Presentes Read(int id)
        {
            Presentes presentes = new Presentes();
            using (var context = new PreContext())
            {
                presentes = context.Presentes.Find(id);
            }
            return presentes;
        }
        public void Update(Presentes model)
        {
            using (var context = new PreContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new PreContext())
            {
                context.Entry<Presentes>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
