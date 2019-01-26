using NaturalArtData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaturalArtData 
{
    public interface IArtItem 
        {
            bool AddArtItem(ArtItem dsArtitem);
            bool UpdateArtItem(ArtItem dsArtitem);
            void DeleteArtItem(int ID);
            IEnumerable<ArtItem> GetAll();
            ArtItem GetArtItem(int ID);
            List<Status> GetALLStatusbyType(string prmStatustype);
            List<ItemCategory> GetAllCategoryType();
            List<ArtistDetails> GetAllArtist();
            String GetStatusbyItemid(int ID);
            String GetCategoryByItemid(int ID);
       }
}
