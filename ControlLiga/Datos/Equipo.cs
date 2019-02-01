using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ControlLiga.Datos
{
    public class Equipo
    {
        public string nombreEquipo { get; set; }
        public int puntos { get; set; }  
        public int puesto { get; set; }
        public BitmapImage escudo { get; set; }

    }

    public class GestorEquipos
    {
        public static ObservableCollection<Equipo> getEquipos()
        {
            var Equipos = new ObservableCollection<Equipo>();

            Equipos.Add(new Equipo { nombreEquipo = "CD ALAVES", puntos = 32, puesto = 5, escudo = new BitmapImage(new Uri("ms-appx:///Assets/ALAVES-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "ATH BILBAO", puntos = 26, puesto = 11, escudo = new BitmapImage(new Uri("ms-appx:///Assets/ATHLETIC-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "AT MADRID", puntos = 44, puesto = 2, escudo = new BitmapImage(new Uri("ms-appx:///Assets/ATLETICO-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "FC BARCELONA", puntos = 49, puesto = 1, escudo = new BitmapImage(new Uri("ms-appx:///Assets/BARCELONA-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "CELTA", puntos = 21, puesto = 18, escudo = new BitmapImage(new Uri("ms-appx:///Assets/CELTA-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "EIBAR", puntos = 26, puesto = 10, escudo = new BitmapImage(new Uri("ms-appx:///Assets/EIBAR-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "SPANYOL", puntos = 24, puesto = 15, escudo = new BitmapImage(new Uri("ms-appx:///Assets/ESPANYOL-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "GETAFE", puntos = 31, puesto = 6, escudo = new BitmapImage(new Uri("ms-appx:///Assets/GETAFE-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "GIRONA", puntos = 24, puesto = 14, escudo = new BitmapImage(new Uri("ms-appx:///Assets/GIRONA-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "HUESCA", puntos = 12, puesto = 20, escudo = new BitmapImage(new Uri("ms-appx:///Assets/HUESCA-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "LEGANES", puntos = 23, puesto = 16, escudo = new BitmapImage(new Uri("ms-appx:///Assets/LEGANES-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "LEVANTE", puntos = 26, puesto = 12, escudo = new BitmapImage(new Uri("ms-appx:///Assets/LEVANTE-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "RAYO", puntos = 23, puesto = 17, escudo = new BitmapImage(new Uri("ms-appx:///Assets/RAYO-VALLECANO-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "BETIS", puntos = 29, puesto = 8, escudo = new BitmapImage(new Uri("ms-appx:///Assets/REAL-BETIS-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "MADRID", puntos = 39, puesto = 3, escudo = new BitmapImage(new Uri("ms-appx:///Assets/REAL-MADRID-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "REAL SOCIEDAD", puntos = 27, puesto = 9, escudo = new BitmapImage(new Uri("ms-appx:///Assets/REAL-SOCIEDAD-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "VALLADOLID", puntos = 25, puesto = 13, escudo = new BitmapImage(new Uri("ms-appx:///Assets/REAL-VALLADOLID-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "SEVILLA", puntos = 36, puesto = 4, escudo = new BitmapImage(new Uri("ms-appx:///Assets/SEVILLA-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "VALENCIA", puntos = 29, puesto = 7, escudo = new BitmapImage(new Uri("ms-appx:///Assets/VALENCIA-150x150.jpg")) });
            Equipos.Add(new Equipo { nombreEquipo = "VILLAREAL", puntos = 18, puesto = 19, escudo = new BitmapImage(new Uri("ms-appx:///Assets/VILLARREAL-150x150.jpg")) });
            return Equipos;
        }
    }
}