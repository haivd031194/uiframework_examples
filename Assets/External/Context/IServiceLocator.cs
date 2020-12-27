
using System;

namespace Zitga.Context
{
    public interface IServiceLocator
    {
        object Resolve(Type type);

        T Resolve<T>();

        object Resolve(string name);

        T Resolve<T>(string name);
    }
}