using PizzaMizza.IServices;
using PizzaMizza.Moduls;
using PizzaMizza.Service;

namespace PizzaMizza.Contexts
{
    internal class Context
    {
        Iservice<Pizza> _pizza;
        Iservice<Ingredient> _ingredient;
        Iservice<Size> _size;

        public Iservice<Pizza> Pizza
        {
            get
            {
                if (_pizza == null)
                {
                    _pizza = new PizzaService();
                }
                return _pizza;
            }
        }

        public Iservice<Ingredient> Ingredient
        {
            get
            {
                if (_ingredient == null)
                {
                    _ingredient = new IngredientService();
                }
                return _ingredient;
            }
        }

        public Iservice<Size> Size
        {
            get
            {
                if (_size == null)
                {
                    _size = new SizeService();
                }
                return _size;
            }
        }
    }
}
