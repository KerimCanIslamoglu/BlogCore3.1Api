using ApiProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiProject.Business.Abstract
{
    public interface IPostService
    {
        List<Post> GetAllPosts();
        void CreateNewPost(Post post);
        Post GetPostById(int id);
    }
}
