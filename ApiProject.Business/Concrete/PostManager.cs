using ApiProject.Business.Abstract;
using ApiProject.DataAccess.Abstract;
using ApiProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiProject.Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;
        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }
        public void CreateNewPost(Post post)
        {
            _postDal.Create(post);
        }

        public List<Post> GetAllPosts()
        {
            return _postDal.GetAll();
        }

        public Post GetPostById(int id)
        {
            return _postDal.GetById(id);
        }
    }
}
