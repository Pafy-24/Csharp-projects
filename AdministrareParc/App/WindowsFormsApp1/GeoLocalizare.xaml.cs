// Copyright 2018 Esri.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific 
// language governing permissions and limitations under the License.

using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.UI;
using System;
using System.Windows;

namespace WindowsFormsApp1
{
    [ArcGISRuntime.Samples.Shared.Attributes.Sample(
        name: "Display device location",
        category: "Location",
        description: "Display your current position on the map, as well as switch between different types of auto pan Modes.",
        instructions: "Select an autopan mode, then use the buttons to start and stop location display.",
        tags: new[] { "GPS", "compass", "location", "map", "mobile", "navigation" })]
    public partial class GeoLocalizare
    {
        private string[] _navigationTypes = Enum.GetNames(typeof(LocationDisplayAutoPanMode));

        public GeoLocalizare()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Unloaded += SampleUnloaded;

            Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ApiKey = "AAPK9fd0a7a2edd34c80aa1d7853401466938hYE8gIsrRd49UeKGWZh1RmPO0PT5Vwu6exk9f6CW4cOYZn0Nt2D3CfG2CKuN1lY";

            Map myMap = new Map(BasemapStyle.ArcGISImageryStandard);

            MyMapView.Map = myMap;

        }


        private void OnModeChooserSelectionChanged(object sender, RoutedEventArgs e)
        {
            int selectedIndex = 1;

            switch (selectedIndex)
            {
                case 1:
                    MyMapView.LocationDisplay.AutoPanMode = LocationDisplayAutoPanMode.Recenter;
                    MyMapView.LocationDisplay.IsEnabled = true;
                    break;

            }
        }

        private void SampleUnloaded(object sender, RoutedEventArgs e)
        {
            MyMapView.LocationDisplay?.DataSource?.StopAsync();
        }
    }
}

