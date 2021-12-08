using PosTrack.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosTrack.Services
{
    interface ITrolleyService
    {
        // Create
        Trolley AddTrolley(Trolley Trolley);
        //Get (Read)
        Trolley GetTrolleyById(int id);
        //List
        //???  IEnumerable<>
        List<Trolley> AllTrolleys { get; }
        //List<Trolley> AllTrolleysWitRfid { get; }
        //public string GetLeftRfid(int Id);
        //Update
        Trolley UpdateTrolleyById(Trolley Trolley);
        //Delete
        void DeleteTrolleyById(int id);
    }
}
