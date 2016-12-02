using PizzaStoreMvc.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzaStoreMvc.Tests
{
  public class EFDataTests
  {
    [Fact]
    public void Test_GetSauces()
    {
      var data = new EFData();
      var actual = data.GetSauces();

      Assert.Empty(actual);

    }
    
  }
}
