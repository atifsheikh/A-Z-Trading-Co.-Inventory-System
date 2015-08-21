using Starcounter;

namespace ThePrimeBaby.Database
{
    [Database]
    public class Concept
    {
        public string Name;
        public string ObId { get { return DbHelper.GetObjectID(this); } }
    }
}