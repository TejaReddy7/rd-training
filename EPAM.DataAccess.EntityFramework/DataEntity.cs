using EPAM.CoreModels;
using EPAM.InterfacesCollection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.DataAccess.EntityFramework
{
    public class DataEntity : IDataAccessLayer
    {
        readonly EPAMDBContext _context = new EPAMDBContext();
        
       
        public void Delete(int? id)
        {
            Employees obj = _context.EmployeesTable.Find(id);
            if (obj != null)
            {
                _context.EmployeesTable.Remove(obj);
                _context.SaveChanges();

            }
            
        }

        public DataSet GetDetails()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            DataColumn id = new DataColumn("Id", typeof(Int32));
            DataColumn firstName = new DataColumn("FirstName", typeof(string));
            DataColumn lastName = new DataColumn("LastName", typeof(string));
            DataColumn dob = new DataColumn("DOB", typeof(DateTime));
            DataColumn genderId = new DataColumn("GenderId", typeof(string));
            DataColumn batch = new DataColumn("Batch", typeof(string));
            DataColumn streamId = new DataColumn("StreamId", typeof(string));
            DataColumn quarterId = new DataColumn("QuarterId", typeof(string));
            
            dataTable.Columns.Add(id);
            dataTable.Columns.Add(firstName);
            dataTable.Columns.Add(lastName);
            dataTable.Columns.Add(dob);
            dataTable.Columns.Add(genderId);
            dataTable.Columns.Add(batch);
            dataTable.Columns.Add(streamId);
            dataTable.Columns.Add(quarterId);

            var employeeList = (from e in _context.EmployeesTable 
                                join g in _context.MasterGenders on e.GenderId equals g.Id
                                join q in _context.MasterQuarters on e.QuarterId equals q.Id
                                select new { e.Id, e.FirstName, e.LastName,  e.DOB, gValue = g.Value, e.Batch, e.StreamId, qValue = q.Value }).ToList();
            
            foreach (var item in employeeList)
            {
                dataTable.Rows.Add(item.Id, item.FirstName, item.LastName, item.DOB, item.gValue,  item.Batch, item.StreamId, item.qValue);
                
            }

            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        
    

        public DataSet GetGender()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            DataColumn id = new DataColumn("Id", typeof(Int32));
            DataColumn value = new DataColumn("Value", typeof(string));
            dataTable.Columns.Add(id);
            dataTable.Columns.Add(value);
            var genderList = _context.MasterGenders.ToList();
            foreach (var item in genderList)
            {
                dataTable.Rows.Add(item.Id, item.Value);

            }
            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        public DataSet GetQuarter()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            DataColumn id = new DataColumn("Id", typeof(Int32));
            DataColumn value = new DataColumn("Value", typeof(string));
            dataTable.Columns.Add(id);
            dataTable.Columns.Add(value);
            var quarterList = _context.MasterQuarters.ToList();
            foreach (var item in quarterList)
            {
                dataTable.Rows.Add(item.Id, item.Value);

            }
            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        public DataSet GetStream()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            DataColumn id = new DataColumn("Id", typeof(Int32));
            DataColumn value = new DataColumn("Value", typeof(string));
            dataTable.Columns.Add(id);
            dataTable.Columns.Add(value);
            var streamList = _context.MasterStreams.ToList();
            foreach (var item in streamList)
            {
                dataTable.Rows.Add(item.Id, item.Value);

            }
            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        public void InsertOrUpdate(EmployeesParameters employeesParameters)
        {
            Employees employees = new Employees
            {
                Id = employeesParameters.Id,
                FirstName = employeesParameters.FirstName,
                LastName = employeesParameters.LastName,
                DOB = employeesParameters.Dob,
                Batch = employeesParameters.Batch,
                GenderId = employeesParameters.GenderId,
                StreamId = employeesParameters.Stream,
                QuarterId = employeesParameters.QuarterId
            };

            if (employeesParameters.Id == null)
            {
                _context.EmployeesTable.Add(employees);
                _context.SaveChanges();
            }
            else
            {
                var result = _context.EmployeesTable.SingleOrDefault(e => e.Id == employeesParameters.Id);
                result.FirstName = employees.FirstName;
                result.LastName = employees.LastName;
                result.GenderId = employees.GenderId;
                result.DOB = employees.DOB;
                result.Batch = employees.Batch;
                result.QuarterId = employees.QuarterId;
                result.StreamId = employees.StreamId;
                _context.SaveChanges();
                                             
            }
        }

        public DataSet ViewById(int? id)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            DataColumn clId = new DataColumn("Id", typeof(Int32));
            DataColumn firstName = new DataColumn("FirstName", typeof(string));
            DataColumn lastName = new DataColumn("LastName", typeof(string));
            DataColumn dob = new DataColumn("DOB", typeof(DateTime));
            DataColumn genderId = new DataColumn("GenderId", typeof(Int32));
            DataColumn batch = new DataColumn("Batch", typeof(string));
            DataColumn streamId = new DataColumn("StreamId", typeof(string));
            DataColumn quarterId = new DataColumn("QuarterId", typeof(Int32));
            DataColumn gender = new DataColumn("Gender", typeof(string));
            DataColumn quarter = new DataColumn("Quarter", typeof(string));
            

            dataTable.Columns.Add(clId);
            dataTable.Columns.Add(firstName);
            dataTable.Columns.Add(lastName);
            dataTable.Columns.Add(dob);
            dataTable.Columns.Add(genderId);
            dataTable.Columns.Add(batch);
            dataTable.Columns.Add(streamId);
            dataTable.Columns.Add(quarterId);
            dataTable.Columns.Add(gender);
            dataTable.Columns.Add(quarter);

            var employeeList = (from e in _context.EmployeesTable
                join g in _context.MasterGenders on e.GenderId equals g.Id
                join q in _context.MasterQuarters on e.QuarterId equals q.Id
                where e.Id == id
                select new { e.Id, e.FirstName, e.LastName, e.DOB, e.GenderId, e.Batch, e.StreamId, e.QuarterId, qValue = q.Value, gValue = g.Value, }).ToList();

            foreach (var item in employeeList)
            {
                dataTable.Rows.Add(item.Id, item.FirstName, item.LastName, item.DOB, item.GenderId, item.Batch, item.StreamId, item.QuarterId, item.gValue, item.qValue);

            }

            dataSet.Tables.Add(dataTable);
            return dataSet;
        }
    }
}
