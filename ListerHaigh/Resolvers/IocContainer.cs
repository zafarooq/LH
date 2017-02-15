﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace ListerHaigh.Resolvers
{
    public class IocContainer
    {
        private static IWindsorContainer _container;
        public static void RegisterContainers()
        {
            _container = new WindsorContainer().Install(FromAssembly.This());
            ControllerFactory controllerFactory = new ControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}