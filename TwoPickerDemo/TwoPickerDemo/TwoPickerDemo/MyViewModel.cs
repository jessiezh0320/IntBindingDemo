﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TwoPickerDemo
{
     public class MyViewModel :ViewModelBase
    {
        public MyViewModel()
        {
            // Sample to pre-load list of records from data server of KVP
            //PickerChoices = GetDataFromServerForDemo("select * from LookupTable where Category = 'demo'");
           PickerChoices = new ObservableCollection<TestModel>() {
                new TestModel{ MyID = 1,ShowValue="test1" }, new TestModel{ MyID = 2,ShowValue="test2" },
                new TestModel{ MyID = 3,ShowValue="test3" }, new TestModel{ MyID = 4,ShowValue="test4" }
            };

            ShowThisRecord = new TestModel();
            // for grins, I am setting the value that SHOULD be defaulted 
            // in picker.  In this case, ID = 12 = "Some Item" from above
            ShowThisRecord.MyID = 12;
        }

        // this is the record that has the "ID" column I am trying to bind to
        public TestModel ShowThisRecord { get; set; }

        //*****************************************

        TestModel selectedRecord; //selected item object
        public TestModel SelectedRecord
        {
            get { return selectedRecord; }
            set
            {
                if (selectedRecord != value)
                {
                    selectedRecord = value;
                    OnPropertyChanged();
                }
            }
        }

        //*****************************************

        // The picker is bound to this list of possible choices
        public ObservableCollection<TestModel> PickerChoices { get; set; }
    }
}
