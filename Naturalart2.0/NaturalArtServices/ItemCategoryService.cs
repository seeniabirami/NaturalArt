using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData;
using NaturalArtData.Models;

using System.Linq;


namespace NaturalArtServices
{
    public class ItemCategoryService : IItemCategory {

      private  NaturalArtdbContext _context;
        public ItemCategoryService(NaturalArtdbContext context) {
            _context = context;
        }

        public void DeleteItemCategory(int id) {
            var recExist = _context.ArtItem.Where(x => x.CategoryID == id).Count();

            if (recExist > 0)
                {
                throw new ArgumentException("Category Already exist in relational tables");
             

            } else {
                var cat = GetAllbyCatID(id);
                _context.Remove(cat);
                _context.SaveChanges();
            }

            
        }
       public  bool FindUniqueCat(string cat)
        {
            if( GetAll().Where(x => x.CategoryType==cat).Count()>0)
            {
                return true;
            }
            return false;
        }
        public IEnumerable<ItemCategory> GetAll() {
            return _context.ItemCatagory;
        }

        public ItemCategory GetAllbyCatID(int ID) {
            return GetAll()
                .FirstOrDefault(x => x.CategoryID == ID);

        }

        public List<String> getCategoryTypelist() {
            return GetAll().Select(x => x.CategoryType).Distinct().ToList();
        }

        public void InsertItemCategory(ItemCategory recCategory) {
            _context.Add(recCategory);
            _context.SaveChanges();

        }

        public void UpdateItemCategory(ItemCategory recCategory) {
            _context.Update(recCategory);
            _context.SaveChanges();
        }

     
    }
}
