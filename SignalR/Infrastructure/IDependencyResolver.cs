using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace SignalR
{
    [InheritedExport]
    public interface IDependencyResolver
    {
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
        void Register(Type serviceType, Func<object> activator);
        void Register(Type serviceType, IEnumerable<Func<object>> activators);
    }
}