using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoParaExamenQuintoSemestre
{

    public class Presentacion
    {
        public int index;
        public string title;
        public string desc;

        public Presentacion(int indicador, string titulo, string descripcion)
        {
            index = indicador;
            title = titulo;
            desc = descripcion;
        }
    }
}