using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaForums.Data;
using LambdaForums.Data.Models;
using LambdaForums.Models.Reply;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LambdaForums.Controllers
{
    public class ReplyController : Controller
    {
        private readonly IPost _postService;
        private readonly UserManager<ApplicationUser> _userManager;

        protected ReplyController(IPost postService)
        {
            _postService = postService;
        }

        public async Task<IActionResult> Create(int id)
        {
            var post = _postService.GetById(id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var forum = post.Forum;
            var model = new PostReplyModel {

                PostContent = post.Content,
                PostTitle = post.Title,
                PostId = post.Id,

                AuthorName = User.Identity.Name,
                AuthorImageUrl = user.ProfileImageUrl,
                AuthorId = user.Id,
                AuthorRating = user.Rating,
                IsAuthorAdmin = User.IsInRole("Admin"),

                Created = DateTime.Now,

                ForumName = forum.Title,
                ForumId = forum.Id,
                ForumImageUrl = forum.ImageUrl

            
            };
            return View(model);
        }
    }
}
