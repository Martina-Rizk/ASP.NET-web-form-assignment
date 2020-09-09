using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marina.Data
{
    public class DocksManager
    {
        public IList GetAllAsListItems()
        {
            var db = new MarinaEntities();
            var docks = db.Docks.Select(d => new
            { ID = d.ID, Name = d.Name }).ToList();
            return docks;
        }

        public static List<Dock> GetAll()
        {
            var db = new MarinaEntities();
            var docks = db.Docks.ToList();
            return docks;
        }

        public static Dock Find(int id)
        {
            var db = new MarinaEntities();
            var dock = db.Docks.SingleOrDefault(d => d.ID == id);
            return dock;
        }
    }
}
