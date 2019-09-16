using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TwoPickerDemo
{
    public partial class MainPage : ContentPage
    {

        ObservableCollection<TestModel> items = new ObservableCollection<TestModel>();
        MyViewModel testModel;
        public MainPage()
        {
            InitializeComponent();

            //items = new ObservableCollection<TestModel>() {
            //    new TestModel{ MyID = 1,ShowValue="test1" }, new TestModel{ MyID = 2,ShowValue="test2" },
            //    new TestModel{ MyID = 3,ShowValue="test3" }, new TestModel{ MyID = 4,ShowValue="test4" }
            //};

            //mypicker.ItemsSource = items;


            testModel = new MyViewModel();
            BindingContext = testModel;

        }


        // to show the selected item
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "selected Item  MyID : " + testModel.SelectedRecord.MyID + "<--> ShowValue: " + testModel.SelectedRecord.ShowValue, "OK");
        }

    }
}
