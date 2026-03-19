using VKFoodApp.Models;

namespace VKFoodApp.Services
{
    public interface IDataService
    {
        List<FoodLocation> GetFoodLocations();

        List<FoodLocation> GetNearbyLocations(double latitude, double longitude);

        AudioGuide GetAudioGuide(int locationId, int languageId);
    }
}