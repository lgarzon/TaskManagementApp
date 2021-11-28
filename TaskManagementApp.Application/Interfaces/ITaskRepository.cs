using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManagementApp.Core.Entities;

namespace TaskManagementApp.Application.Interfaces
{
    public interface ITaskRepository : IGenericRepository<Task>
    {
    }
}
