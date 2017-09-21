using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Telephone.Parts
{
    abstract class PartFactory
    {
        protected List<Type> GetSupportedTypesList<T>() => Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && t.GetInterfaces().Contains(typeof(T))).ToList();
    }
}
