using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Interfaces.Stok;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class NinjectFactory
    {
        public class DependencyModule : NinjectModule
        {

            public override void Load()
            {

            }
        }
        public class CompositionRoot
        {
            public static IKernel ninjectKernel;

            public static void Initialize(INinjectModule module)
            {
                ninjectKernel = new StandardKernel(module);

                ninjectKernel.Bind<IStokServis>()
                    .To<StokManager>()
                    .WithConstructorArgument("stokDal",
                    new EFStokRepo(ninjectKernel.Get<MEYPAKContext>()));
            }

            public static T Resolve<T>()
            {
                return ninjectKernel.Get<T>();
            }

            public static IEnumerable<T> ResolveAll<T>()
            {
                return ninjectKernel.GetAll<T>();
            }
        }
    }
}
