using PizzaMizza.Helper;
using PizzaMizza.IServices;
using PizzaMizza.Moduls;
using System.Data;

namespace PizzaMizza.Service
{
    internal class PizzaService : Iservice<Pizza>
    {
        public void Add(Pizza model)
        {
            Sql.ExecCommand($"Insert into Pizzas (Name,Image) values (N'{model.Name}' ,N'{model.Image}')");
        }

        public void Delete(int id)
        {
            Sql.ExecCommand($"Delete Pizzas Where Id = {id}");
        }

        public List<Pizza> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Pizzas");
            List<Pizza> pizza = new List<Pizza>();
            foreach (DataRow dr in dt.Rows)
            {
                pizza.Add(new Pizza { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString(), Image = dr["Image"].ToString()});
            }
            return pizza;
        }

        public void Update(Pizza model)
        {
            Sql.ExecCommand($"Update Pizzas Set Name = {model.Name}, Image = {model.Image} Where Id = {model.Id} ");
        }
    }
}
