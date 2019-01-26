using NaturalArtData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Naturalartdata
{
  public  interface IAddress
    {
    
    Address GetbyUserID(int ID);
    void DeleteOrder(int id);
    void UpdateOrder(Address recOrder);
    void InsertOrder(Address recOrder);
}
}
