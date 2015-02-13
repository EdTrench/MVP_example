using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_example.Presenter.Garden
{
    interface IGarden
    {
        View.Garden.IGarden GardenView { get; set; }
        Model.Garden.Garden GardenModel { get; }
        void Show();
        void BuildActionPanel();
        void RefreshAwardLists();
        void Save();
    }
}