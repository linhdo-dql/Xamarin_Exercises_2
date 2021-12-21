using Newtonsoft.Json;
using ResfulApi.Models;
using ResfulAPI_Demo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace ResfulApi.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Post> Posts { get; set;}
        HttpClient client = new HttpClient();
        readonly string url = "https://jsonplaceholder.typicode.com/posts";
        public string Text { get; set; }
        public MainPageViewModel(Page page, INavigation navigation)
        {
            var content = client.GetStringAsync(url);
            Posts = SetUser(JsonConvert.DeserializeObject<List<Post>>(content.Result));
            PostTabbed = new Command((x) =>
            {
                var post = x as Post;
                navigation.PushAsync(new PostDetailPage(post));
            });
        }
        public ObservableCollection<Post> SetUser(List<Post> posts)
        {
            string urlUser = "https://jsonplaceholder.typicode.com/users";
            var users = JsonConvert.DeserializeObject<List<User>>(client.GetStringAsync(urlUser).Result);
            foreach(var post in posts)
            {
                post.NameUser = users.Where(u => u.Id == post.UserId).First().UserName;
            }
            return new ObservableCollection<Post>(posts);
        }
        public Command PostTabbed { get; }
        public Command Upload { get; }
    }
}
