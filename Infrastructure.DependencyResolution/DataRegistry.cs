using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DependencyResolution
{
    public class DataRegistry : Registry
    {
        public DataRegistry()
        {
            For<IEmployeeRepository>().Use<EmployeeRepository>();
            For<IContextProvider>().Use<ContextProvider>();
        }
    }
}
