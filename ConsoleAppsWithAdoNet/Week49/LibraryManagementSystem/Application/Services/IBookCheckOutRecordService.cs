using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Services
{
    internal interface IBookCheckOutRecordService
    {
        void Add(BookCheckOutRecord bookCheckOutRecord);

        void Update(BookCheckOutRecord bookCheckOutRecord);

        void Delete(int id);

        BookCheckOutRecord? GetById(int id);

        List<BookCheckOutRecord> GetAll();
    }
}
