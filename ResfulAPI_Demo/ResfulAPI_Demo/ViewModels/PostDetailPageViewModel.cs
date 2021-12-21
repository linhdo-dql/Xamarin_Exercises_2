using Newtonsoft.Json;
using ResfulApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace ResfulAPI_Demo.ViewModels
{
    public class PostDetailPageViewModel
    {
        public ObservableCollection<Comment> Comments { get; set; }
        INavigation Navigation { get; set; }
        public Post Post { get; set; }
        string urlComment = "https://jsonplaceholder.typicode.com/comments";
        public PostDetailPageViewModel(Page page, INavigation navigation, Post post)
        {
            Navigation = navigation;
            Post = post;
            UserAnswer = new Command(() =>
            {
                navigation.PushAsync(new UserPage(Post.UserId));
            });
            Comments = GetComments(JsonConvert.DeserializeObject<List<Comment>>(
                new HttpClient()
                .GetStringAsync(urlComment)
                .Result
                ), post.Id);
        }
        public ObservableCollection<Comment> GetComments(List<Comment> comments, int postID)
        {
            return new ObservableCollection<Comment> (comments.Where(x => x.PostId == postID).ToList());
        }
        public Command UserAnswer { get; }
    }
}
