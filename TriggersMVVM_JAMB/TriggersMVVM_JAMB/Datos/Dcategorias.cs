using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TriggersMVVM_JAMB.Modelo;

namespace TriggersMVVM_JAMB.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias ()
                {
                    descripcion = "Cena",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/TqHZYRQ/cena-romantica.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Hotel",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/FmKPQLJ/hotel.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Fiesta",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/j34m9PD/papel-picado.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Flores",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/GF6TVwc/flor.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                }
            };
        }
    }
}
