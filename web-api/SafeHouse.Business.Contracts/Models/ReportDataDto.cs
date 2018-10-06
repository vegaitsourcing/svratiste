namespace SafeHouse.Business.Contracts.Models
{
    public class ReportDataDto
    {
        public int GuestsCount { get; set; }

        public int FemaleGuestsCount { get; set; }

        public int MaleGuestsCount { get; set; }

        public int VisitsCount { get; set; }

        public int MealCount { get; set; }

        public int BathsCount { get; set; }

        public int LiecesRemovedCount { get; set; }

        public int ClothingSumCount { get; set; }
    }
}
