using Starcounter;

namespace ThePrimeBaby.Database
{
    [Database]
    public class Concept
    {
        public int ID;

        public string NAME;
        public string ObId { get { return DbHelper.GetObjectID(this); } }
    }
}