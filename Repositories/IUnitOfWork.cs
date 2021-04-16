using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiGresol.Model;
using WebApiGresol.Service;

namespace WebApiGresol.Repositories
{
    public interface IUnitOfWork
    {
        
        IGenericRepository<Expense> ExpenseRepository { get; }

        IGenericRepository<ExpenseCategories> ExpenseCategoriesRepository { get; }

        IGenericRepository<Invoice> InvoiceRepository { get; }

        
        IGenericRepository<ThirdParty> ThirdPartyRepository { get; }

        IGenericRepository<Todo> TodoRepository { get; }

        IGenericRepository<TravelExpense> TravelExpenseRepository { get; }

        IGenericRepository<Users> UsersRepository { get; }

        IGenericRepository<Visit> VisitRepository { get; }
        Task<int> Commit();
    }
}
