using ShopOnline.Data.Infrastructure;
using ShopOnline.Model.Models;
using System;
namespace ShopOnline.Data.Respositories
{
    public interface IPostRepository:IRepository<Post> {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}