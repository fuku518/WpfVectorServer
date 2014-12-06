using Microsoft.AspNet.SignalR.Client;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Windows;

namespace WpfVectorClient
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string Server = "http://localhost:53178/";
        public IHubProxy HubProxy { get; set; }
        public HubConnection Connection { get; set; }

        public ObservableCollection<ShineLineVm> Lines { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            Lines = new ObservableCollection<ShineLineVm>();
            DataContext = this;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ConnectAsync();
        }

        private async void ConnectAsync()
        {
            Connection = new HubConnection(Server);
            HubProxy = Connection.CreateHubProxy("MyHub");

            HubProxy.On<string>("LoadInClient", LoadInClient);
            try
            {
                await Connection.Start();
                await HubProxy.Invoke("LoadInServer");
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void LoadInClient(string loadJson)
        {
            this.Dispatcher.Invoke(() =>
            {
                Lines.Clear();
                var lines1 = JsonConvert.DeserializeObject<List<ShineLineVm>>(loadJson);
                foreach (var line in lines1)
                {
                    Lines.Add(line);
                }
            });
        }
    }

    public class ShineLineVm
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
    }
}
