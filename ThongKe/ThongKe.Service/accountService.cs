﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThongKe.Data.Infrastructure;
using ThongKe.Data.Models;
using ThongKe.Data.Repositories;

namespace ThongKe.Service
{
    public interface IaccountService
    {
        void Add(account acc);

        void Update(account acc);

        void Delete(string id);

        IEnumerable<account> GetAll();

        IEnumerable<account> Search(string keyword, int page, int pageSize, string status, out int totalRow);

        IEnumerable<account> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<account> GetAllBySearchPaging(string name, bool status, int page, int pageSize, out int totalRow);

        account GetById(string id);

        //string EncodeSHA1(string pass);

        //string GetNextId(string id);

        //string GetLastId();

        void Save();
    }
    public class accountService : IaccountService
    {
        private IaccountRepository _accountRepository;
        private IUnitOfWork _unitOfWork;

        public accountService(IaccountRepository accountRepository,IUnitOfWork unitOfWork)
        {
            _accountRepository = accountRepository;
            _unitOfWork = unitOfWork;
        }
        public void Add(account acc)
        {
            _accountRepository.Add(acc);
        }

        public void Delete(string id)
        {
            _accountRepository.Delete(id);
        }

        public IEnumerable<account> GetAll()
        {
            return _accountRepository.GetAll();
        }

        public IEnumerable<account> GetAllBySearchPaging(string name, bool status, int page, int pageSize, out int totalRow)
        {
            return _accountRepository.GetMultiPaging(x => x.trangthai == status && x.hoten == name, out totalRow, page, pageSize);
        }

        public IEnumerable<account> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _accountRepository.GetMultiPaging(x => x.trangthai == true, out totalRow, page, pageSize);
        }

        public account GetById(string id)
        {
            return _accountRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public IEnumerable<account> Search(string keyword, int page, int pageSize, string status, out int totalRow)
        {
            var query = _accountRepository.GetAll();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = _accountRepository.GetMulti(x => x.hoten.Contains(keyword) || x.username.Contains(keyword));
            }

            if (!string.IsNullOrEmpty(status))
            {
                var statusBool = bool.Parse(status);
                query = query.Where(x => x.trangthai == statusBool);
            }

            totalRow = query.Count();
            query = query.OrderByDescending(x => x.ngaytao).Skip((page - 1) * pageSize).Take(pageSize);

            return query;
        }

        public void Update(account acc)
        {
            _accountRepository.Update(acc);
        }
    }
}
