using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CrudOperationUsingWebFormAndDapper
{
  public  class DataAccess
    {
        public List<Person> GetPeople(string Name)
        {
            using(IDbConnection  connection = new System.Data.SqlClient.SqlConnection(Helper.Vcs("TestDB")))
            {
        //      var output =  connection.Query<Person>($"Select * From Test Where Name = '{ lastname }'").ToList();
             var output =  connection.Query<Person>("spGetData @name", new { name = Name}).ToList();
                return output;
            }
        }

        public void InsertDetail(string name, int age)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Vcs("TestDB")))
            {
                Person person = new Person { Name = name, Age = age };
                List<Person> people = new List<Person>();
                people.Add(person);
                connection.Execute("spInsertData @Name, @Age", people);
            }
        }

        internal void UpdateDetails(int id, string name, int age)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Vcs("TestDB")))
            {
                Person person = new Person { Id = id, Name = name, Age = age };
                List<Person> people = new List<Person>();
                people.Add(person);
                connection.Execute("spUpdateData @id, @Name, @Age", people);
            }
        }

        internal void DeleteDetails(int id, string name, int age)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Vcs("TestDB")))
            {
                Person person = new Person { Id = id, Name = name, Age = age };
                List<Person> people = new List<Person>();
                people.Add(person);
                connection.Execute("spDeleteData @id, @Name, @Age", people);
            }
        }
    }
}
