using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoParaExamenQuintoSemestre
{
    public partial class AgregarPresentacion : System.Web.UI.Page
    {
        protected string titulo = "";
        protected string descripcion = "";
        List<Presentacion> lstPresentacion = new List<Presentacion>();
        List<Conexiones> lstConexiones = new List<Conexiones>();
        protected string html = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                html = "";
                LlenarPresentacion();
                MostrarHtmlPresentacion();
            }

        }
        protected void MostrarHtmlPresentacion()
        {
            int mayor=0, menor=1000;
            
            foreach (Presentacion p in lstPresentacion.ToList())
            {
                if (mayor<p.index)
                {
                    mayor = p.index;
                }
                if (menor>p.index)
                {
                    menor = p.index;
                }
            }
            foreach (Presentacion p in lstPresentacion.ToList())
            {
                string titulo, desc;
                int index;
                titulo = p.title;
                desc = p.desc;
                index = p.index;

                html += GenerarDiv(titulo, desc, index,mayor,menor);

            }
            pnlGenerar.Controls.Add(new LiteralControl(html));
        }
        protected string GenerarDiv(string tit, string des, int ind,int mayor,int menor)
        {
            string divHTML = "<div class='contenedor-divs' id='S" + ind.ToString() + "'>" +
            "<div class='Presentacion'>"+
                "<div> Diapositiva No. " + ind.ToString() + "</div>" +
                "<div class='titulo'><h1>" + tit + "</h1></div>" +
                "<div class='Desc'><p>" + des + "</p></div></div><div class='links'>";

            int contador = 0;
            foreach (Conexiones cn in lstConexiones.ToList())
            {
                int numero1, numero2;
                numero1 = cn.conexion;
                numero2 = cn.conexion2;
                if (numero1 == ind && numero2 != ind)
                {
                    if (numero2 == numero1 - 1)
                    {
                        divHTML += @"<div class='link' actual='" + ind.ToString() + "' siguiente='" + numero2.ToString() + "'><i class='fas fa-arrow-left'> </i> Anterior</div>";
                    }
                    else if (numero2 == numero1 + 1)
                    {
                        divHTML += @"<div class='link' actual='" + ind.ToString() + "' siguiente='" + numero2.ToString() + "'><i class='fas fa-arrow-right'> </i> Siguiente</div>";
                    }
                    else if (numero2==mayor)
                    {
                        divHTML += @"<div class='link' actual='" + ind.ToString() + "' siguiente='" + numero2.ToString() + "'><i class='fas fa-fast-forward'></i> Ir al Final</div>";
                    }
                    else if (numero2==menor)
                    {
                        divHTML += @"<div class='link' actual='" + ind.ToString() + "' siguiente='" + numero2.ToString() + "'><i class='fas fa-home'></i> Ir al Inicio</div>";
                    }
                    else
                    {
                        divHTML += @"<div class='link' actual='" + ind.ToString() + "' siguiente='" + numero2.ToString() + "'><i class='fas fa-arrow-up'> </i> Diapositiva No." + numero2 + "</div>";
                    }

                    contador++;
                }
                else if (numero2 == ind && numero1 != ind)
                {
                    if (numero1 == numero2 - 1)
                    {
                        divHTML += "<div class='link' actual='" + ind.ToString() + "' siguiente='" + numero1.ToString() + "'><i class='fas fa-arrow-left'> </i> Anterior</div>";
                    }
                    else if (numero1 == numero2 + 1)
                    {
                        divHTML += "<div class='link' actual='" + ind.ToString() + "' siguiente='" + numero1.ToString() + "'><i class='fas fa-arrow-right'> </i> Siguiente</div>";
                    }
                    else if (numero1 == mayor)
                    {
                        divHTML += @"<div class='link' actual='" + ind.ToString() + "' siguiente='" + numero1.ToString() + "'><i class='fas fa-fast-forward'></i> Ir al Final</div>";
                    }
                    else if (numero1 == menor)
                    {
                        divHTML += @"<div class='link' actual='" + ind.ToString() + "' siguiente='" + numero1.ToString() + "'><i class='fas fa-home'></i> Ir al Inicio</div>";
                    }
                    else
                    {
                        divHTML += "<div class='link' actual='" + ind.ToString() + "' siguiente='" + numero1.ToString() + "'><i class='fas fa-arrow-up'> </i> Diapositiva No." + numero1 + "</div>";
                    }
                    contador++;
                }
            }
            if (contador == 0)
            {
                divHTML += "<div> No tiene Conexiones</div>";
            }
            divHTML += "</div></div>";
            return divHTML;
        }
        protected void LlenarPresentacion()
        {
            titulo = "Titulo 1";
            descripcion = "descripcion 1";
            lstPresentacion.Add(new Presentacion(1, titulo, descripcion));
            titulo = "Titulo 2";
            descripcion = "descripcion 2";
            lstPresentacion.Add(new Presentacion(2, titulo, descripcion));
            titulo = "Titulo 3";
            descripcion = "descripcion 3";
            lstPresentacion.Add(new Presentacion(3, titulo, descripcion));
            titulo = "Titulo 4";
            descripcion = "descripcion 4";
            lstPresentacion.Add(new Presentacion(4, titulo, descripcion));
            titulo = "Titulo 5";
            descripcion = "descripcion 5";
            lstPresentacion.Add(new Presentacion(5, titulo, descripcion));
            titulo = "Titulo 6";
            descripcion = "descripcion 6";
            lstPresentacion.Add(new Presentacion(6, titulo, descripcion));

            lstConexiones.Add(new Conexiones(1, 2));
            lstConexiones.Add(new Conexiones(2, 3));
            lstConexiones.Add(new Conexiones(3, 4));
            lstConexiones.Add(new Conexiones(4, 5));
            lstConexiones.Add(new Conexiones(5, 6));
            lstConexiones.Add(new Conexiones(6, 1));
            lstConexiones.Add(new Conexiones(6, 2));
            lstConexiones.Add(new Conexiones(6, 3));
        }
    }
}