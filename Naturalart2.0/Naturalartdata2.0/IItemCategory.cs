using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData.Models;

namespace NaturalArtData {
  public  interface IItemCategory
    {

        IEnumerable<ItemCategory> GetAll();
        ItemCategory GetAllbyCatID(int ID);
        bool FindUniqueCat(string cat);
        void DeleteItemCategory(int  id);
        void UpdateItemCategory(ItemCategory recCategory);
        void InsertItemCategory(ItemCategory recCategory);
        List<string> getCategoryTypelist();
    }
}
