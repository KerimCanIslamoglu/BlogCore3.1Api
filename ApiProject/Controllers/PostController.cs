using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ApiProject.Business.Abstract;
using ApiProject.Entities.Entities;
using ApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        [Route("api/[controller]/GetAllPosts")]
        public IEnumerable<PostModel> GetAllPosts()
        {
            return _postService.GetAllPosts().Select(x => new PostModel
            {
                Id = x.Id,
               BlogBody=x.BlogBody,
               BlogHeader=x.BlogHeader,
               CreatedAt=x.CreatedAt,
               CreatedBy=x.CreatedBy,
               CreatedDay=x.CreatedAt.Day,
               CreatedMonth=CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(x.CreatedAt.Month)
        });
        }

        [HttpGet]
        [Route("api/[controller]/GetPostById")]
        public PostModel GetPostById(int id)
        {
            var post = _postService.GetPostById(id);
            return new PostModel
            {
                Id = post.Id,
                BlogBody = post.BlogBody,
                BlogHeader = post.BlogHeader,
                CreatedAt = post.CreatedAt,
                CreatedBy = post.CreatedBy
            };
        }

        [HttpPost]
        [Route("api/[controller]/CreatePost")]
        public void CreatePost(PostModel postModel)
        {
            var post = new Post
            {
                BlogBody = postModel.BlogBody,
                BlogHeader = postModel.BlogHeader,
                CreatedAt = postModel.CreatedAt,
                CreatedBy = postModel.CreatedBy
            };
            _postService.CreateNewPost(post);
        }
    }
}