using ConsoleApp1.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region entity framework core

            /*
             * features :-
             *      - object relational mapper (ORM) => fully ORM
             *      - auto tracker
             *      - support linq
             *      - support migrations
             *      - support multiple database
             *      - cross platform
             * 
             * disadvantages :-
             * - performance (auto tracker)
             * - complexity
             * 
             */

            #endregion

            #region ADO.NET

            /*
             * features :-
             *      - low level framework
             *      - no tracking
             *      - manual connection
             *      - direct access to SQL
             * 
             */

            #endregion

            #region Dapper

            /*
             * features :-
             *      - lightweight for simple , small projects
             *      - no tracker
             *      - no migrations
             *      - simple API (dapper)
             *      - faster
             *      - easy to use
             *      - micro ORM
             *          limited features
             * 
             */

            #endregion

            #region DbContext

            //CompanyDbContext db = new CompanyDbContext();
            //// open connection with database

            //// close connection
            //try
            //{

            //}
            //finally
            //{
            //    db.Dispose();
            //    // close connection => Dispose()
            //}

            using CompanyDbContext db = new CompanyDbContext();

            //db.Database.Migrate();

            // to applay migrations
            // you must download this package Microsoft.EntityFrameworkCore.Tools

            // to applay database in 

            #endregion

            #region migrations

            /*
             * to remove migration
             * 1. you must revert this migration
             *      update-database 0
             * 2. remove-migration
             * 
             */

            #endregion

        } // Dispose()
    }
}
