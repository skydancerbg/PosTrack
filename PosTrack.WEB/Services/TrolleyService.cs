using PosTrack.Data;
using PosTrack.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosTrack.Services
{
    public class TrolleyService :ITrolleyService
    {
        private readonly AppDbContext _context;
        public TrolleyService(AppDbContext context)
        {
            _context = context;
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



        public Trolley AddTrolley(Trolley Trolley)
        {
            throw new NotImplementedException();
        }

        public Trolley GetTrolleyById(int trolleyId) => _context.Trolleys.FirstOrDefault(n => n.Id == trolleyId);
        //public string GetLeftRfid(int trolleyId) //=> _context.Trolleys.Select(tr => tr.LeftTag.Rfid).Where(n => n.Id == trolleyId); //.FirstOrDefault(n => n.Id == trolleyId);
        //{ 
        //}
        
        //public List<Trolley> AllTrolleys()
        //{
        //    var trolleys = _context.Trolleys;

        //    var leftRfidQuery = from trolley in trolleys
        //                        //where trolley.Id == trolleyId
        //                        select new
        //                        {
        //                          Id = trolley.Id,
        //                          Label = trolley.Label,
        //                          LeftTagID = trolley.LeftTag.Rfid,
        //                          RightTagID = trolley.RightTag.Rfid
        //                            //Total = contact.SalesOrderHeaders.Sum(o => o.TotalDue)
        //                        };

        //    return null;
        //}
        public List<Trolley> AllTrolleys => _context.Trolleys.ToList();
        public Trolley UpdateTrolleyById(Trolley Trolley)
        {
            throw new NotImplementedException();
        }

        public void DeleteTrolleyById(int trolleyId)
        {
            var _trolley = _context.Trolleys.FirstOrDefault(n => n.Id == trolleyId);
            if (_trolley != null)
            {
                _context.Trolleys.Remove(_trolley);
                _context.SaveChanges();
            }
        }
    }
}
