using PequenosEncantos.Core.Entities;

namespace PequenosEncantos.API.Model
{
    public class CreateANewJobModel : BaseEntity
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }

    }
}
