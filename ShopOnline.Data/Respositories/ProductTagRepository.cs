using ShopOnline.Data.Infrastructure;
using ShopOnline.Model.Models;

namespace ShopOnline.Data.Respositories
{
    public interface IProductTagRepository { }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}