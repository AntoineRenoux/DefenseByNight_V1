using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefenseByNight.IoC
{
    public class AutofacContainer
    {
        private static IContainer _instance;
        public static IContainer Instance
        {
            get {
                if (_instance == null)
                    throw new ArgumentNullException("Autofac Container Is Null");
                return _instance;
            }
        }

        public AutofacContainer(IContainer container)
        {
            _instance = container;
        }
    }
}