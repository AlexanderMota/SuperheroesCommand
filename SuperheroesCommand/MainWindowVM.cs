using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesCommand
{
    class MainWindowVM : ObservableObject
    {
        private List<Superheroe> heroes;

        private Superheroe heroeActual;
        public RelayCommand SiguienteCommand { get; }
        public RelayCommand VolverCommand { get; }

        public Superheroe HeroeActual
        {
            get => heroeActual; 
            set => SetProperty(ref heroeActual, value);
        }

        private int total;

        public int Total
        {
            get => total; 
            set => SetProperty(ref total, value);
        }

        private int actual;

        public int Actual
        {
            get => actual; 
            set => SetProperty(ref actual, value);
        }


        public MainWindowVM()
        {
            heroes = Utiles.GetSamples();
            HeroeActual = heroes[0];
            Total = heroes.Count;
            Actual = 1;

            SiguienteCommand = new RelayCommand(Siguiente);
            VolverCommand = new RelayCommand(Anterior);
        }

        public void Siguiente()
        {
            if (Actual < Total)
            {
                Actual++;
                HeroeActual = heroes[Actual - 1];
            }
        }

        public void Anterior()
        {
            if (Actual > 1)
            {
                Actual--;
                HeroeActual = heroes[Actual - 1];
            }
        }
    
    }
}
