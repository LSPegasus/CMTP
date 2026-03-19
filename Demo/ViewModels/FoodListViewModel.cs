using System.Collections.ObjectModel;
using VKFoodApp.Models;
using VKFoodApp.Services;

namespace VKFoodApp.ViewModels;

public class FoodListViewModel
{
    private readonly IDataService _dataService;

    public ObservableCollection<FoodLocation> Foods { get; set; }

    public FoodListViewModel(IDataService dataService)
    {
        _dataService = dataService;

        var foods = _dataService.GetFoodLocations();

        Foods = new ObservableCollection<FoodLocation>(foods);
    }
}

//using System.Collections.ObjectModel;
//using VKFoodApp.Models;
//using VKFoodApp.Services;

//namespace VKFoodApp.ViewModels;

//public class FoodListViewModel
//{
//    public ObservableCollection<FoodLocation> Foods { get; set; }

//    public FoodListViewModel()
//    {
//        var dataService = new DataService();

//        Foods = new ObservableCollection<FoodLocation>(dataService.GetFoodLocations());
//    }
//}