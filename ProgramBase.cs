using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Test.Algorithms
{
    public class ProgramBase
    {
        public IServiceCollection Service = new ServiceCollection();
        public ProgramBase()
        {
            Configure();
        }
        public IEnumerable<object> GetServices<T>()
        {
           return Service.BuildServiceProvider().GetServices(typeof(T));
        }
        public object GetService<T>(T type)  
        {
           var result= Service.BuildServiceProvider().GetService(typeof(T));
            return result;
        }
        public ServiceProvider Builder()
        {
           return Service.BuildServiceProvider()  ;
            
        }
        public void Configure()
        {
            Service.AddTransient<IAlgorithmResolver, ContainsDuplicate>();
            Service.AddTransient<IAlgorithmResolver, ValidAnagram>();
            Service.AddTransient<IAlgorithmResolver, TwoSum>();
            Service.AddTransient<IAlgorithmResolver, GroupAnagrams>();

        }
    }
}