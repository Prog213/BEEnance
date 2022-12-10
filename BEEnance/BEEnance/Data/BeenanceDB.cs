using SQLite;
using BEEnance.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BEEnance.Data
{
    public class BeenanceDB
    {
        private readonly SQLiteAsyncConnection db;

        public BeenanceDB(string connectionString) // це якийсь гівнокод
        {                                          // в ідеалі потім це все розбити на файли і взагалі переробити
                                                   // але вже як є
            db = new SQLiteAsyncConnection(connectionString);

            db.CreateTableAsync<Expenses>().Wait();
            db.CreateTableAsync<Incomes>().Wait();
            //db.CreateTableAsync<Category>().Wait();
        }

        public Task<List<Expenses>> GetExpenses() // отримати список зі всіма витратами
        {
            return db.Table<Expenses>().ToListAsync(); 
        }

        public Task<Expenses> GetExpense(int id) // отримати конкретну витрату по айді
        {
            return db.Table<Expenses>()
                .Where(e => e.Id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveExpense(Expenses expense) // дозволяє додавати і редагувати вже існуючі витрати
        {
            if (expense.Id != 0) 
            {
                return db.UpdateAsync(expense); // зміна запису витрати
            }
            else
            {
                return db.InsertAsync(expense); // збереження витрати
            }
        }

        public Task<int> DeleteExpense(Expenses expense) // видалити витрату
        {
            return db.DeleteAsync(expense);
        }

        //                              а тут все тупо те саме, тільки для Incomes

        public Task<List<Incomes>> GetIncomes()
        {
            return db.Table<Incomes>().ToListAsync();
        }

        public Task<Incomes> GetIncome(int id)
        {
            return db.Table<Incomes>()
                .Where(e => e.Id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveIncome(Incomes income) // дозволяє додавати і редагувати вже існуючі надходження
        {
            if (income.Id != 0)
            {
                return db.UpdateAsync(income); // зміна запису надходжень
            }
            else
            {
                return db.InsertAsync(income); // збереження надходжень
            }
        }

        public Task<int> DeleteIncome(Incomes income)
        {
            return db.DeleteAsync(income);
        }
    }
}
