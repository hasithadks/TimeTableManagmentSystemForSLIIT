using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayers.Tag
{
    public class TagData
    {
        public void InsertTagsToDatabase(TagModel tag)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                //insert
                DataLayer.Tag tag1 = new DataLayer.Tag()
                {
                    id = tag.tagId,
                    TagName = tag.tagName,
                    ShortName = tag.shortName
                };

                
                //Tag newTag = new Tag()
                //{
                //    id = tag.tagId,
                //    TagName = tag.tagName,
                //    ShortName = tag.shortName
                //};

                context.Tags.Add(tag1);
                context.SaveChanges();

                MessageBox.Show("Successfull Added");
            }

        }

        public List<DataLayer.Tag> GetAllTags()
        {
            using (var context = new TimetableManagementSystemEntities2())
            {
                List<DataLayer.Tag> multiple = context.Tags.ToList();

                return multiple;
            }


        }

        public void UpdateTagsInDatabase(TagModel tag)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {

                var updatingTag = context.Tags.Where(p => p.id == tag.tagId).FirstOrDefault();

                if (updatingTag != null)
                {
                    updatingTag.TagName = tag.tagName;
                    updatingTag.ShortName = tag.shortName;
                    context.SaveChanges();
                }
                MessageBox.Show("Successfull Updated");
            }
        }

        public void DeleteTagsInDatabase(TagModel tag)
        {
            using (var context = new TimetableManagementSystemEntities2())
            {

                var DeleteTag = context.Tags.Where(p => p.id == tag.tagId).FirstOrDefault();

                if (DeleteTag != null)
                {
                    context.Tags.Remove(DeleteTag);
                    context.SaveChanges();
                }
                MessageBox.Show("Successfull Deleted");
            }
        }
    }
}
