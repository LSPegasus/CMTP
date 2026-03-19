namespace VKFoodApp.Models
{
    public class AudioGuide
    {
        public int Id { get; set; }

        public int FoodLocationId { get; set; }

        public int LanguageId { get; set; }

        public string AudioFilePath { get; set; }
    }
}