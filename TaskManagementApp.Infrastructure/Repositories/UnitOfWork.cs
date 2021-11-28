using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.Application.Interfaces;

namespace TaskManagementApp.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ITaskRepository taskRepository)
        {
            Tasks = taskRepository;
        }

        public ITaskRepository Tasks { get; }
    }
}
