﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInjection
{
    public class Kernel
    {
        private static IKernel _kernel;

        public static IKernel Instance
        {
            get
            {
                if (_kernel == null)
                {
                    _kernel = new StandardKernel(new CustomInjections());
                }

                return _kernel;
            }
        }
    }
}
