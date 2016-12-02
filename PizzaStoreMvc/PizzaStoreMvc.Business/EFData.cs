using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreMvc.Business
{
  public class EFData
  {
    private PizzaDBEntities db = new PizzaDBEntities();

    public List<Sauce> GetSauces()
    {
      return db.Sauces.ToList();
    }

  }
}
