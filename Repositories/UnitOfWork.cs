using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiGresol.Model;

namespace WebApiGresol.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext appDbContext;


        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.appDbContext = dbContext;
        }

        private IGenericRepository<Expense> expenseRepository;
        public IGenericRepository<Expense> ExpenseRepository
        { 
        
            get
            {
                if (expenseRepository == null)
                    expenseRepository = new GenericRepository<Expense>(appDbContext);
                return expenseRepository;
            }
           
        }

        private IGenericRepository<ExpenseCategories> expenseCategoriesRepository;
        public IGenericRepository<ExpenseCategories> ExpenseCategoriesRepository
        {
            get
            {
                if (expenseCategoriesRepository == null)
                    expenseCategoriesRepository = new GenericRepository<ExpenseCategories>(appDbContext);
                return expenseCategoriesRepository;
            }

        }

        private IGenericRepository<Invoice> invoiceRepository;

        public  IGenericRepository<Invoice> InvoiceRepository
        {
            get
            {
                if (invoiceRepository == null)
                    invoiceRepository = new GenericRepository<Invoice>(appDbContext);
                return invoiceRepository;
            }
        }


        private IGenericRepository<ThirdParty> thirdPartyRepository;

        public IGenericRepository<ThirdParty> ThirdPartyRepository
        {
            get
            {
                if (thirdPartyRepository == null)
                    thirdPartyRepository = new GenericRepository<ThirdParty>(appDbContext);
                return thirdPartyRepository;
            }
        }

        private IGenericRepository<Todo> todoRepository;

        public IGenericRepository<Todo> TodoRepository
        {
            get
            {
                if (todoRepository == null)
                    todoRepository = new GenericRepository<Todo>(appDbContext);
                return todoRepository;
            }
        }



        private IGenericRepository<TravelExpense> travelExpenseRepository;

        public IGenericRepository<TravelExpense> TravelExpenseRepository
        {
            get
            {
                if (travelExpenseRepository == null)
                    travelExpenseRepository = new GenericRepository<TravelExpense>(appDbContext);
                return travelExpenseRepository;
            }
        }

        private IGenericRepository<Users> usersRepository;

        public IGenericRepository<Users> UsersRepository
        {
            get
            {
                if (usersRepository == null)
                    usersRepository = new GenericRepository<Users>(appDbContext);
                return usersRepository;
            }
        }

        private IGenericRepository<Visit> visitRepository;

        public IGenericRepository<Visit> VisitRepository
        {
            get
            {
                if (visitRepository == null)
                    visitRepository = new GenericRepository<Visit>(appDbContext);
                return visitRepository;
            }
        }

        



        // Want to achieve this 

        //private IGenericRepository<TEntity> genericRepository;

        //public IGenericRepository<TEntity> GenericRepository
        //{
        //    get
        //    {
        //        if (genericRepository == null)
        //            genericRepository = new GenericRepository<TEntity>(appDbContext);

        //        return genericRepository;
        //    }
        //}


        public async Task<int> Commit()
        {

            return await this.appDbContext.SaveChangesAsync();
        }

    }
}
