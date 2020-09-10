using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.Tag
{
    public class TagModel
    {
        public int tagId { set; get; }

        public string tagName { set; get; }

        public string shortName { set; get; }


        public TagModel()
        {

            this.tagId = 0;
            this.tagName = string.Empty;
            this.shortName = string.Empty;
           
        }


        public TagModel(int id, string TagName, string ShortName)
        {

            this.tagId = id;
            this.tagName = TagName;
            this.shortName = ShortName;
        }
    }
}
