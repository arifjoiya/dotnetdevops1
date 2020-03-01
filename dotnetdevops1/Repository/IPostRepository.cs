using dotnetdevops1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetdevops1.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> getPost();
    }
}
