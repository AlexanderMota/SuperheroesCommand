using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesCommand
{
    class Superheroe : ObservableObject
    {
        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    SetProperty(ref _nombre, value);
                }
            }
        }
        private string _imagen;
        public string Imagen
        {
            get => _imagen;
            set => SetProperty(ref _imagen,  value);
        }

        private bool _vengador;
        public bool Vengador
        {
            get => _vengador;
            set
            {
                if (_vengador != value)
                {
                    SetProperty(ref _vengador, value);
                }
            }
        }

        private bool _xmen;
        public bool Xmen
        {
            get => _xmen;
            set
            {
                if (_xmen != value)
                {
                    SetProperty(ref _xmen, value);
                }
            }
        }

        private bool _heroe;
        public bool Heroe
        {
            get => _heroe;
            set
            {
                if (_heroe != value)
                {
                    SetProperty(ref _heroe, value);
                }
            }
        }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        
    
    }
}
