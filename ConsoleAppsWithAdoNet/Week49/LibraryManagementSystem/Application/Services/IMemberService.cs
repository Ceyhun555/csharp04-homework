using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Services
{
    internal interface IMemberService
    {
        void Add(Member member);

        void Update(Member member);

        void Delete(int id);

        Member? GetById(int id);

        List<Member> GetAll();
    }
}
