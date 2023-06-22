using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.DataAccess
{
    public class StudentDataAccessService
    {
        private IRepo<Student> repo;

        public StudentDataAccessService(IRepo<Student> repo)
        {
            this.repo = repo;
        }

        public List<Student> GetRecords()
        {
            return repo.GetAll();
        }
    }
}
