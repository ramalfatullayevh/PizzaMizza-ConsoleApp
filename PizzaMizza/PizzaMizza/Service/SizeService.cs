using PizzaMizza.Helper;
using PizzaMizza.IServices;
using PizzaMizza.Moduls;
using System.Data;

namespace PizzaMizza.Service
{
    internal class SizeService : Iservice<Size>
    {
        public void Add(Size model)
        {
            Sql.ExecCommand($"Insert into Sizes (Size) values (N'{model.SizeName}')");
        }

        public void Delete(int id)
        {
            Sql.ExecCommand($"Delete Sizes Where Id = {id}");
        }

        public List<Size> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Sizes");
            List<Size> pizza = new List<Size>();
            foreach (DataRow dr in dt.Rows)
            {
                pizza.Add(new Size { Id = Convert.ToInt32(dr["Id"]), SizeName = dr["Size"].ToString(),});
            }
            return pizza;
        }

        public void Update(Size model)
        {
            Sql.ExecCommand($"Update Sizes Set Size = N'{model.SizeName}' Where Id = {model.Id} ");
        }
    }
}
