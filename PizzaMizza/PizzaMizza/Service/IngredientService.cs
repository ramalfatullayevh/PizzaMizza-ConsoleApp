using PizzaMizza.Helper;
using PizzaMizza.IServices;
using PizzaMizza.Moduls;
using System.Data;

namespace PizzaMizza.Service
{
    internal class IngredientService : Iservice<Ingredient>
    {
        public void Add(Ingredient model)
        {
            Sql.ExecCommand($"Insert into Ingredients (Name) values (N'{model.Name}')");
        }

        public void Delete(int id)
        {
            Sql.ExecCommand($"Delete Ingredients Where Id = {id}");
        }

        public List<Ingredient> GetAll()
        {

            DataTable dt = Sql.ExecQuery("SELECT * FROM Ingredients");
            List<Ingredient> ingredient = new List<Ingredient>();
            foreach (DataRow dr in dt.Rows)
            {
                ingredient.Add(new Ingredient { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString()});
            }
            return ingredient;
        }

        public void Update(Ingredient model)
        {
            Sql.ExecCommand($"Update Ingredients Set Name = N'{model.Name}' Where Id = {model.Id} ");
        }
    }
}
