using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goodwingroup_app
{
    internal class SeriesClass
    {
        public int ID { get; set; }
        public String series_title { get; set; }

        public int year { get; set; }

        public String image_name { get; set; }

        public String description { get; set; }

        public String series_genre { get; set; }

        public List<Seasons> seasons { get; set; }
    }
}
