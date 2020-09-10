using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayers.Tag
{
    public class TagController
    {
        private TagData tagData;

        public void InsertTag(TagModel tag)
        {
            tagData = new TagData();
            tagData.InsertTagsToDatabase(tag);
        }

        public List<DataLayer.Tag> SelectAllTags() {
            tagData = new TagData();

            return tagData.GetAllTags();
        }

        public void UpdateTag(TagModel tag)
        {
            tagData = new TagData();
            tagData.UpdateTagsInDatabase(tag);
        }

        public void DeleteTag(TagModel tag)
        {
            tagData = new TagData();
            tagData.DeleteTagsInDatabase(tag);
        }
    }
}
