using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ILocateServices
    {
        object GetDependency(Type type);

        T GetDependency<T>();

        T GetDependency<T>(KeyValuePair<string, object> constructorArgument);

        object GetNamed(Type type, string name);

        T GetNamed<T>(string name);

        T GetNamed<T>(string name, KeyValuePair<string, object> constructorArgument);

        T GetNamed<T>(string name, IDictionary<string, object> constructorArgument);

        T TryGetNamed<T>(string name);

        IEnumerable<T> GetAll<T>();

        IEnumerable<T> GetAll<T>(IDictionary<string, object> constructorArgument);

        string What();
    }
}