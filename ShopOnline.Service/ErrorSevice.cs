using ShopOnline.Data.Infrastructure;
using ShopOnline.Data.Respositories;
using ShopOnline.Model.Models;
namespace ShopOnline.Service
{
    public interface IErrorService
    {
        Error Create(Error error);

        void Save();
    }

    public class ErrorSevice : IErrorService
    {
        private IErrorRepository _errorRepository;
        private IUnitOfWork _unitOfWork;

        public ErrorSevice(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}