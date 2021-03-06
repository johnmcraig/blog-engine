﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CoreBlogDataLibrary.Entities
{
    public class Post
    {
        public string Title { get; set; }
        public string Permalink { get; set; }
        public Author PostAuthor { get; set; }
        public string PostContent { get; set; }
        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EditDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public int PostId { get; set; }
       
        // Navigation Properties
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        //public int PostCategoryId { get; set; }
        //public PostCategory PostCategory { get; set; }
    }
}
