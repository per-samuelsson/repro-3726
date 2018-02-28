using System;
using ClassLib;
using Microsoft.Extensions.DependencyModel;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var classLibAssembly = typeof(Class1).Assembly;
            var deps = DependencyContext.Load(classLibAssembly);

            foreach (var library in deps.CompileLibraries)
            {
                Console.WriteLine(string.Join(" ", library.ResolveReferencePaths()));
            }
        }
    }
}
