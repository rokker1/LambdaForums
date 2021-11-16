﻿using LambdaForums.Models.Post;
using System.Collections;
using System.Collections.Generic;

namespace LambdaForums.Models.Forum
{
    public class ForumTopicModel
    {
        public ForumIndexModel Forum { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }
    }
}
