
using Abp.Runtime.Validation;
using Yoyosoft.BookList.Dtos;
using Yoyosoft.BookList.BookListManagement;

namespace Yoyosoft.BookList.BookListManagement.Dtos
{
    public class GetBooksInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
