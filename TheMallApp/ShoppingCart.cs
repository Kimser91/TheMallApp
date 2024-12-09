using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMallApp
{
    internal class ShoppingCart
    {
        List<IItem> items = new List<IItem>();

      public void getList(CarPart part, Food food, List <Tool> tools)
        {
            items.Add(part);
            items.Add(food);

            foreach (var tool in tools)
            {
                items.Add(tool);
            }
            

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
