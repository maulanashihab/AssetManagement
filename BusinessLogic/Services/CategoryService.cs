using BusineesLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class CategoryService : ICategoryService
    {
        bool status = false;
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public CategoryService() { }
        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _categoryRepository.Delete(id);
                return result;
            }
        }

        public List<Category> Get()
        {
            var result = _categoryRepository.Get();
            return result;
        }

        public Category Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _categoryRepository.Get(id);
                return result;
            }
        }

        public bool Insert(CategoryVM categoryVM)
        {
            if (string.IsNullOrWhiteSpace(categoryVM.Name))
            {
                return status;
            }
            else
            {
                var result = _categoryRepository.Insert(categoryVM);
                return result;
            }
        }

        public bool Update(int id, CategoryVM categoryVM)
        {
            if (string.IsNullOrWhiteSpace(categoryVM.Name))
            {
                return status;
            }
            else
            {
                var result = _categoryRepository.Update(id, categoryVM);
                return result;
            }
        }
    }
}
