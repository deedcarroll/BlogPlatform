using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repository
{
    public interface ISelectList
    {
        Post GetPostById(int id);
    }
}