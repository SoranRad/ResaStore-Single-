using System.Collections.Generic;

namespace ShareLib.Models
{
    public class ImageDocument
    {
        public ImageDocument()
        {
            PeopleSign     = new HashSet<People>();
            PeoplePicture  = new HashSet<People>();
            PeopleWarranty = new HashSet<People>();
        }

        public long                 ID               { get; set; }
        public byte[]               Image            { get; set; }

        public ICollection<People>  PeopleSign       { get; set; }
        public ICollection<People>  PeoplePicture    { get; set; }
        public ICollection<People>  PeopleWarranty   { get; set; }


    }
}
