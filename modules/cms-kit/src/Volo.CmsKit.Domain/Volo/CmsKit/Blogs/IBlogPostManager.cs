﻿using System;
using System.Threading.Tasks;

namespace Volo.CmsKit.Domain.Volo.CmsKit.Blogs
{
    public interface IBlogPostManager
    {
        Task<BlogPost> CreateAsync(BlogPost blogPost);

        Task UpdateAsync(BlogPost blogPost);
    }
}
