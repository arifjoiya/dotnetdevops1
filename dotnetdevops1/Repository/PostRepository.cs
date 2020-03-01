using dotnetdevops1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetdevops1.Repository
{
    public class PostRepository:IPostRepository
    {
        public List<PostViewModel> getPost()
        {
            var posts = new List<PostViewModel>(){
                new PostViewModel(){ Id =101, Title ="ccx", Description="ds", Author="dsd"},
                new PostViewModel(){ Id =101, Title ="ccx1", Description="ds2", Author="dsd6"},
                new PostViewModel(){ Id =101, Title ="ccx2", Description="ds5", Author="dsd6"},
        };
            return posts;
        }
    }
}
