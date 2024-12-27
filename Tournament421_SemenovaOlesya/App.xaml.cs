using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tournament421_SemenovaOlesya.Bases;

namespace Tournament421_SemenovaOlesya
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TournamentDB_421_SemenovaEntities db = new TournamentDB_421_SemenovaEntities();

        public static Player totalPlayer;
        public static Organizer totalOrganizer;
    }
}
