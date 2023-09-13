using System.Collections.ObjectModel;
using WirtualnyOgrod.Models;

namespace WirtualnyOgrod.ViewModels
{
    public class WateringScheduleViewModel : BaseViewModel
    {
        public ObservableCollection<WateringSchedule> Schedules { get; set; }

        public WateringScheduleViewModel()
        {
            Schedules = new ObservableCollection<WateringSchedule>();
        }
    }
}
