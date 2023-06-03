using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using HaberSistemi.Core.Repository;
using HaberSistemi.Core.Infrastructure;


namespace HaberSistemi.Admin.Class
{
    public class BootSrapper
    {
        //Boot aşamasında çalışacak 
        public static void RunConfig()
        {
            BuildAutoFac();
        }
        public static void BuildAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<HaberRepository>().As < IHaberRepository>();
            builder.RegisterType<ResimRepository>().As<IResimRepository>();
            builder.RegisterType<KullaniciRepository>().As<IKullaniciRepository>();
            builder.RegisterType<KategoriRepository>().As<IKategoriRepository>();
            builder.RegisterType<RolRepository>().As<IRolRepository>();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

    }
}