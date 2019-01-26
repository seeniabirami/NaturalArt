using NaturalArtData;
using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NaturalArtServices
{
    public class ArtItemService : IArtItem

    {
        private NaturalArtdbContext _context;
        public ArtItemService(NaturalArtdbContext context)
        {
            _context = context;
        }
        public bool AddArtItem(ArtItem dsArtitem)
        {
            _context.Add(dsArtitem);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateArtItem(ArtItem dsArtitem)
        {
            _context.Update(dsArtitem);
            _context.SaveChanges();
             return true;
        }
        public void DeleteArtItem(int ID)
        {

            var ArtItem = GetArtItem(ID);
            if (ArtItem.imageurl.Length > 0)// Find and delete the old File
            {
                if (System.IO.File.Exists(ArtItem.imageurl))
                {
                    System.IO.File.Delete(ArtItem.imageurl);
                }

            }
            _context.Remove(ArtItem);
            _context.SaveChanges();
         
        }
        public IEnumerable<ArtItem> GetAll()
        {
            //  _context = new NaturalArtdbContext();
            return _context.ArtItem
                .Include(x => x.ArtistDetail)
                .Include(x => x.Statusrec);
         
        }
        public ArtItem GetArtItem(int ID)
        {
            return GetAll()
        .FirstOrDefault(x => x.ItemID == ID);

        }
        public List<ItemCategory>  GetAllCategoryType()
        {

            return _context.ItemCatagory.OrderBy(x => x.CategoryType).ToList();

           

        }
        public List<Status> GetALLStatusbyType(string prmStatustype) {


            
            return _context.Status.Where(x => x.StatusType==prmStatustype).OrderBy(x=>x.StatusName).ToList();

        }
        public String GetStatusbyItemid(int prmID)
        {
            return _context.Status.FirstOrDefault(x => x.Statusid==prmID).StatusName;
              
        }
        public String GetCategoryByItemid(int prmID) {
            return _context.ItemCatagory.FirstOrDefault(x => x.CategoryID== prmID).CategoryType;

        }
        public List<ArtistDetails> GetAllArtist()
        {
            return _context.Artist.OrderBy(x => x.Name).Distinct().ToList();

        }
    }
}
