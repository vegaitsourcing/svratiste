using SafeHouse.Data.Enums;

namespace SafeHouse.Business.Contracts.Models
{
    public class WorkshopDto
    {
        public WorkshopType WorkshopType { get; set; }

        public int Number { get; set; }
    }
}
