﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.DataAccessLayer.MySql
{
    public class RepositoryBase
    {
        protected static object context;
        private static object _lockSync = new object();

        protected RepositoryBase()//protected constractor, bu class newlenemez. Sadece miras alan newleyebilir demektir.
        {
            CreateContext();
        }

        private static void CreateContext()
        {
            if (context == null)
            {

                lock (_lockSync)//lock, bir kere çalışmayı sağlar
                {
                    if (context == null)
                    {
                        context = new object();
                    }
                }
            }
        }

    }
}