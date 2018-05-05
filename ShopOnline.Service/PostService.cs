using ShopOnline.Data.Infrastructure;
using ShopOnline.Data.Respositories;
using ShopOnline.Model.Models;
using System.Collections.Generic;

namespace ShopOnline.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Post> GetAllByCategoryPaging(int categoryId,int page, int pageSize, out int totalRow);

        Post GetById(int id);

        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChange();
    }

    public class PostService : IPostService
    {
        private IPostRepository _postReponsitory;
        private IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postReponsitory = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postReponsitory.Add(post);
        }

        public void Delete(int id)
        {
            _postReponsitory.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            //có thể lấy ra cả post và category tương ứng
            return _postReponsitory.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postReponsitory.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalRow, page, pageSize,new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //Lấy tất cả danh sách Post bằng Tag 
            return _postReponsitory.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postReponsitory.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postReponsitory.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postReponsitory.Update(post);
        }
    }
}