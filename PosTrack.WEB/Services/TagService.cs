using PosTrack.Data;
using PosTrack.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosTrack.Services
{
    public class TagService: ITagService
    {
        private readonly AppDbContext _context;
        public TagService(AppDbContext context)
        {
            _context = context;
        }

        public Tag AddTag(Tag tag)
        {
            throw new NotImplementedException();
        }
        //public void AddTag(TagVM tag)
        //{
        //    var _tag = new Tag()
        //    {
        //        TagNumber = tag.TagNumber,
        //        Rfid = tag.Rfid
        //    };

        //    _context.Tags.Add(_tag);
        //    _context.SaveChanges();
        //}
        public Tag GetTagById(int tagid) => _context.Tags.FirstOrDefault(n => n.Id == tagid);

        public List<Tag> AllTags => _context.Tags.ToList();
        //{
        //    return _context.Tags.ToList();
        //}

        //public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        //{
        //    var rng = new Random();
        //    return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = startDate.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    }).ToArray());
        //}
        public Tag UpdateTagById(Tag tag)
        {
            throw new NotImplementedException();
        }
        //public Tag UpdateTagById(int tagid, TagVM tag)
        //{
        //    var _tag = _context.Tags.FirstOrDefault(n => n.Id == tagid);
        //    if (_tag != null)
        //    {
        //        _tag.TagNumber = tag.TagNumber;
        //        _tag.Rfid = tag.Rfid;
        //        _context.SaveChanges();
        //    }
        //    return _tag;
        //}


        public void DeleteTagById(int tagid)
        {
            var _tag = _context.Tags.FirstOrDefault(n => n.Id == tagid);
            if (_tag != null)
            {
                _context.Tags.Remove(_tag);
                _context.SaveChanges();
            }
        }

    }

}

