using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData;
using NaturalArtData.Models;

using System.Linq;


using Microsoft.EntityFrameworkCore;
namespace NaturalArtServices
{
    public class ArtistDetailsService : IArtistDetails
    {

        private NaturalArtdbContext _context;
       
        public ArtistDetailsService(NaturalArtdbContext context)
        {
            _context = context;
        }
        public void delete(int id)
        {

            var artist = getDetailyByID(id);
            _context.Remove(artist);
            _context.SaveChanges();
        }

        public IEnumerable<ArtistDetails> GetAll()
        {
            return _context.Artist
                 .Include(x => x.UserRole);
        }

        public List<UserRole> GetAlluserRoles()
        {
            return _context.UserRole.ToList();
        }

        public ArtistDetails getDetailyByID(int ID)
        {
            return GetAll().FirstOrDefault(a => a.ArtistID == ID);
        }
        public ArtistDetails GetUserByUserName(string Username)
        {
            return GetAll().FirstOrDefault(a => a.UserName == Username);
        }
        public bool Insert(ArtistDetails prmArtistDetails)
        {

            _context.Add(prmArtistDetails);
            _context.SaveChanges();
            return true;

        }

        public bool update(ArtistDetails prmArtistDetails)
        {
            _context.Update(prmArtistDetails);
            _context.SaveChanges();
            return true;
        }

        public bool VerifyLoginUser(string prmUsername, string prmPwd)
        {
            int reccnt = _context.Artist.Where(x => x.UserName == prmUsername && x.Password == prmPwd).Count();
            if (reccnt == 1)
            {
                return true;
            }
            return false;
        }
        public bool VerifyUser(string prmUsername, string prmPwd)
        {
            int reccnt = _context.Artist.Where(x => x.UserName == prmUsername).Count();
            if (reccnt >0)
            {
                return false;
            }
            return true;
        }
        public bool VerifyEmail(string prmEmail)
        {
            int reccnt = _context.Artist.Where(x => x.EmailID == prmEmail).Count();
            if (reccnt > 0)
            {
                return false;
            }
            return true;
        }

       
    }
}