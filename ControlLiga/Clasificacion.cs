using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Shapes;
using ControlLiga.Datos;


// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace ControlLiga
{
    public sealed class Clasificacion : Control
    {
        Canvas CanvasClasificacion;
        String rectEquipo;
        



        public Clasificacion()
        {
            this.DefaultStyleKey = typeof(Clasificacion);

            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                var items = new ObservableCollection<Equipo>();
                items.Add(new Equipo { nombreEquipo = "CD ALAVES", puntos = 15, puesto = 1, escudo = new BitmapImage(new Uri("ms-appx:///Assets/ALAVES-150x150.jpg")) });               
                ItemsSource = items;
            }
        }
        

        public static readonly DependencyProperty ItemsSourceProperty =
           DependencyProperty.Register("ItemsSource", typeof(ObservableCollection<Clasificacion>), typeof(Clasificacion), new PropertyMetadata(null, PintarEquipos));

        private static void PintarEquipos(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PintarEquipos();
        }

        private static void PintarEquipos()
        {
            //throw new NotImplementedException();
            // this.onAppyTemplate();
        }

        public ObservableCollection<Equipo> ItemsSource
        {
            get { return (ObservableCollection<Equipo>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }



        private void AnimarGraficas(Canvas CanvasClasificacion, Rectangle grafica, Button equipo, Equipo eq )
        {

           
        }



        /*  private void Animation_Begin(object sender, RoutedEventArgs e)
             {
                 myStoryboard.Begin();
             } */
        

        protected override void OnApplyTemplate()
        {
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/campocanvas.jpg"));
            
            base.OnApplyTemplate();
           

            Canvas CanvasClasificacion = (Canvas)GetTemplateChild("CanvasClasificacion");
            CanvasClasificacion.Background = ib;
            CanvasClasificacion.Children.Clear();          

            int dib = 10;
            int dib1 = 10;
            foreach (Equipo item in ItemsSource)
            {
                ImageBrush Brocha = new ImageBrush();
                SolidColorBrush ChampionBrush = new SolidColorBrush(Colors.Blue);
                SolidColorBrush UefaBrush = new SolidColorBrush(Colors.Green);
                SolidColorBrush DescensoBrush = new SolidColorBrush(Colors.Red);
                SolidColorBrush NormalBrush = new SolidColorBrush(Colors.Yellow);
                Button equipo = new Button();
                equipo.Name = item.nombreEquipo;
                equipo.Height = 50;
                equipo.Width = 50;
                Rectangle grafica = new Rectangle();
                grafica.Name = item.nombreEquipo;
                grafica.Name = item.nombreEquipo;
                grafica.Height = item.puntos*15;
                grafica.Width = 50;
                grafica.Stroke = new SolidColorBrush(Colors.Purple);
                grafica.StrokeThickness = 1;
              
                Brocha.ImageSource = item.escudo;
                equipo.Background = Brocha;
                Storyboard storyboard = new Storyboard();
                DoubleAnimation GA = new DoubleAnimation()
                {
                    From = 0,
                    To = item.puntos*15,
                    Duration = new Duration(TimeSpan.FromSeconds(1.5)),
                    EnableDependentAnimation = true
                };
                Storyboard.SetTarget(GA, grafica);
                Storyboard.SetTargetProperty(GA, "grafica.Height");
                storyboard.Children.Add(GA);
                if (item.puesto <= 4)
                {
                    grafica.Fill = ChampionBrush;
                }
                if (item.puesto > 4 && item.puesto <= 7)
                {
                    grafica.Fill = UefaBrush;
                }
                if (item.puesto > 7 && item.puesto <= 17)
                {
                    grafica.Fill = NormalBrush;
                }
                if (item.puesto > 17)
                {
                    grafica.Fill = DescensoBrush;
                }


                CanvasClasificacion.Children.Add(equipo);
                Canvas.SetLeft(equipo, (dib));
                Canvas.SetTop(equipo, (800));
               // Canvas.SetZIndex(equipo, (dib));
               
                CanvasClasificacion.Children.Add(grafica);
                Canvas.SetLeft(grafica, (dib1));
                Canvas.SetZIndex(grafica, (1000));
                dib += 60;
                dib1 += 60;

                storyboard.Begin();
            }

        }
                }               
            }
      


      

