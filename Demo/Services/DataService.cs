using System.Linq;
using VKFoodApp.Models;

namespace VKFoodApp.Services
{
    public class DataService : IDataService
    {
        private List<FoodLocation> _locations;

        public DataService()
        {
            _locations = new List<FoodLocation>
            {
                new FoodLocation
                {
                    Id = 1,
                    Name = "Ốc Oanh",
                    Description = "Quán ốc nổi tiếng tại phố ẩm thực Vĩnh Khánh",
                    Latitude = 10.7555,
                    Longitude = 106.7044,
                    AudioGuides = new List<AudioGuide>
                    {
                        new AudioGuide
                        {
                            Id = 1,
                            FoodLocationId = 1,
                            LanguageId = 1,
                            AudioFilePath = "audio/oc_oanh_vi.mp3"
                        },
                        new AudioGuide
                        {
                            Id = 2,
                            FoodLocationId = 1,
                            LanguageId = 2,
                            AudioFilePath = "audio/oc_oanh_en.mp3"
                        }
                    }
                },

                new FoodLocation
                {
                    Id = 2,
                    Name = "Bánh Tráng Trộn Chú Viên",
                    Description = "Bánh tráng trộn đặc trưng Sài Gòn",
                    Latitude = 10.7558,
                    Longitude = 106.7047
                }
            };
        }

        public List<FoodLocation> GetFoodLocations()
        {
            return _locations;
        }

        public List<FoodLocation> GetNearbyLocations(double latitude, double longitude)
        {
            return _locations;
        }

        public AudioGuide GetAudioGuide(int locationId, int languageId)
        {
            var location = _locations.FirstOrDefault(x => x.Id == locationId);

            return location?.AudioGuides?
                .FirstOrDefault(x => x.LanguageId == languageId);
        }
    }
}