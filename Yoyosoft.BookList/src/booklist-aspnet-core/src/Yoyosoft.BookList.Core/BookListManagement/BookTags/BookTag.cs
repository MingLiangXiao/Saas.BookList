﻿using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;
using Yoyosoft.BookList.BookListManagement.Relationships;

namespace Yoyosoft.BookList.BookListManagement.BookTags
{
    public class BookTag : CreationAuditedEntity<long>
    {
        public string TagName { get; set; }

        public ICollection<BookAndBookTag> BookAndBookTags { get; set; }
    }
}