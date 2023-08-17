using PizzaMizza.Helper;
using PizzaMizza.IServices;
using PizzaMizza.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Service
{
    internal class PizzaIngredientService : Iservice<PizzaIngredient>
    {
        public void Add(PizzaIngredient model)
        {
            Sql.ExecCommand($"Insert into PizzaIngredients (PizzaId,IngredientId) values ({model.PizzaId} ,{model.IngredientId})");
        }

        public void Delete(int id)
        {
            
        }

        public List<PizzaIngredient> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(PizzaIngredient model)
        {
            throw new NotImplementedException();
        }
    }
}
