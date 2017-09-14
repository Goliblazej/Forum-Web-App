using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using Forum.Domain.Abstract;
using Forum.Domain.Entities;
using Forum.Domain.Concrete;

namespace Forum.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IPostRepository>().To<EFPostRepository>();
            kernel.Bind<ITopicRepository>().To<EFTopicRepository>();
            kernel.Bind<IUserRepository>().To<EFUserRepository>();
        }
    }
}