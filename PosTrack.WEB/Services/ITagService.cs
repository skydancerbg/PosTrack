using PosTrack.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosTrack.Services
{
    public interface ITagService
    {
        // Create
        Tag AddTag(Tag tag);
        //Get (Read)
        Tag GetTagById(int id);
        //List
        //???  IEnumerable<>
        List<Tag> AllTags { get; }

        //Update
        Tag UpdateTagById(Tag tag);
        //Delete
        void DeleteTagById(int id);
    }
}
