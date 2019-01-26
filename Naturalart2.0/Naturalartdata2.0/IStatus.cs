using NaturalArtData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaturalArtData {

  public  interface IStatus
    {
    IEnumerable<Status> GetAll();
    Status GetStatusbyID(int ID);
    Status GetStatusbyIDandType(int ID, string Type);
    void AddStatus(Status  dsStatus);
    void DeleteStatus(int ID);
    void UpdateStatusbyIDandType(int ID, string Type);
    void UpdateStatusbyID(Status ID);
        bool FindUniqueStatus(string Type,string Status);
        string GetStatusValue(int ID, string Type);
    List<String> GetStatusTypes();
    List<String> GetStatusNames(string Types);

    }
}
