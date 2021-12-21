using Newtonsoft.Json;
using ResfulApi.Models;
using ResfulAPI_Demo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace ResfulAPI_Demo.ViewModels
{
    public class UserPageViewModel
    {
        public User UserPost { get; set; }
        public ObservableCollection<Todo> Todos { get; set; }
        public ObservableCollection<Album> Albums  { get; set; }
        public UserPageViewModel(Page page, INavigation navigation, int userId)
        {
            UserPost = JsonConvert.DeserializeObject<User>(
                            new HttpClient()
                            .GetStringAsync("https://jsonplaceholder.typicode.com/users/" + userId)
                            .Result);
            Todos = new ObservableCollection<Todo>(JsonConvert.DeserializeObject<List<Todo>>(
                            new HttpClient()
                            .GetStringAsync("https://jsonplaceholder.typicode.com/todos/")
                            .Result).Where(p=> p.UserId ==UserPost.Id));
            Albums = new ObservableCollection<Album>(JsonConvert.DeserializeObject<List<Album>>(
                            new HttpClient()
                            .GetStringAsync("https://jsonplaceholder.typicode.com/albums/")
                            .Result).Where(p => p.UserId == UserPost.Id));
        }
    }
}
