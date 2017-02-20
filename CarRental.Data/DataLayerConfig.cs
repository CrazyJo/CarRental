using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Data.Initializer;

namespace CarRental.Data
{
    public static class DataLayerConfig
    {
        public static void Configure()
        {
            SetDbRelativePath();
            Database.SetInitializer(new DbInitializer());
        }

        private static void SetDbRelativePath()
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", root);
        }
    }
}
