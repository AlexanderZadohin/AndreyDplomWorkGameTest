using AndreyDplomWorkGameTest.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AndreyDplomWorkGameTest
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static NiDboForDiplomAppWorkEntities context = new NiDboForDiplomAppWorkEntities();
    }
}
