using System;
using System.Collections.Generic;
using System.Text;
using NaturalArtData;
using NaturalArtData.Models;

public interface IArtistDetails
{


    List<UserRole> GetAlluserRoles();
    IEnumerable<ArtistDetails> GetAll();
    ArtistDetails getDetailyByID(int ID);
    ArtistDetails GetUserByUserName(string Username);

    bool VerifyEmail(string prmEmail);
    bool VerifyUser(string prmUsername, string prmPwd);
    bool VerifyLoginUser(string prmUsername, string prmPwd);
    bool Insert(ArtistDetails prmArtistDetails);
    bool update(ArtistDetails prmArtistDetails);
    void delete(int Id);
}

