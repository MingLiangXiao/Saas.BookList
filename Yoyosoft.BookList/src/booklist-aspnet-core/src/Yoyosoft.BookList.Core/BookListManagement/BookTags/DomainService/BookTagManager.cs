

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Linq;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

using Yoyosoft.BookList;
using Yoyosoft.BookList.BookListManagement.BookTags;


namespace Yoyosoft.BookList.BookListManagement.BookTags.DomainService
{
    /// <summary>
    /// BookTag领域层的业务管理
    ///</summary>
    public class BookTagManager :BookListDomainServiceBase, IBookTagManager
    {
		
		private readonly IRepository<BookTag,long> _repository;

		/// <summary>
		/// BookTag的构造方法
		///</summary>
		public BookTagManager(
			IRepository<BookTag, long> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitBookTag()
		{
			throw new NotImplementedException();
		}

        public async Task<List<BookTag>> GetAll()
        {
            return await _repository.GetAll().AsNoTracking().ToListAsync();
        }

        // TODO:编写领域业务代码



		 
		  
		 

	}
}
