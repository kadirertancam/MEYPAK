using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Interfaces.Stok;
using Ninject;
using Ninject.Activation;
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
        private readonly IKernel ninjectKernel;

        public NinjectFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBllBindings();
        }
        private void AddBllBindings()
        {
            StandardKernel _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());

            MEYPAKContext context = _kernel.Get<MEYPAKContext>();
            ninjectKernel.Bind<IStokServis>()
                .To<StokManager>()
                .WithConstructorArgument("stokDal",
                new EFStokRepo(context));

            
        }

        //protected override Context GetControllerInstance(Context requestContext, Type controllerType)
        //{
        //    return controllerType == null ? null : (Context)ninjectKernel.Get(controllerType);
        //}
    }
}
