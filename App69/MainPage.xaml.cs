using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App69
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private WebView x;
        public MainPage()
        {
            this.InitializeComponent();

        }


        private void bookmarkBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MyListView.SelectedItems.Count > 0)
            {
                Items.RemoveAt(MyListView.SelectedIndex);

            }
            else
            {

            }
        }
        private ObservableCollection<string> Items = new ObservableCollection<string>();

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            Items = new ObservableCollection<string>() { "HEE", "DDD", "EEE", "ASDFA" };

            MyListView.ItemsSource = Items;


        }
    }

    public static class DeviceTool
    {
        public static async Task<T> GetDevice<T>() where T : class
        {
            DeviceWatcher watcher = DeviceInformation.CreateWatcher("");
            watcher.Added += (DeviceWatcher sender, DeviceInformation info) =>
            {

            };

            return null;
        }
    }
    public struct Books
    {
        public void Get()
        {

        }
    }
}
