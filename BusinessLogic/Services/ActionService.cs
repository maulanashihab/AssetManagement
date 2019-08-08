using BusineesLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class ActionService : IActionService
    {
        bool status = false;
        private readonly IActionRepository _actionRepository;
        public ActionService(IActionRepository actionRepository)
        {
            _actionRepository = actionRepository;
        }
        public ActionService() { }
        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _actionRepository.Delete(id);
                return result;
            }
        }
        public List<DataAccess.Models.Action> Get()
        {
            var result = _actionRepository.Get();
            return result;
        }

        public DataAccess.Models.Action Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _actionRepository.Get(id);
                return result;
            }
        }

        public bool Insert(ActionVM actionVM)
        {
            if (string.IsNullOrWhiteSpace(actionVM.Name))
            {
                return status;
            }
            else
            {
                var result = _actionRepository.Insert(actionVM);
                return result;
            }
        }

        public bool Update(int id, ActionVM actionVM)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(actionVM.Name))
            {
                return status;
            }
            else
            {
                var result = _actionRepository.Update(id, actionVM);
                return result;
            }
        }
    }
}
