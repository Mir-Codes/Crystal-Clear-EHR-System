﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using System.Data;

namespace Metodos
{
    public class MPacientes
    {

        //Metodo Insertar que llama al metodo Insertar de la clase DPaciente de la capa Datos

        public static string Insertar(string cedula, string nombre, DateTime fechanac, string sexo, string estcivil, string lugnac, string direccion, string ocupacion, string telefono, string correo, string estadovm, string imgpath, string peso, string talla, int estado)
        {
            DPacientes Obj = new DPacientes();
            Obj.Cedula = cedula;
            Obj.Nombre = nombre;
            Obj.Fechanac = fechanac;
            Obj.Sexo = sexo;
            Obj.Estcivil = estcivil;
            Obj.Lugarnac = lugnac;
            Obj.Direccion = direccion;
            Obj.Ocupacion = ocupacion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Estadovivomuerto = estadovm;
            Obj.Imagepath = imgpath;
            Obj.Peso = peso;
            Obj.Talla = talla;
            Obj.Estado = estado;

            return Obj.Insertar(Obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase DPaciente de la capa Datos

        public static string Editar(string cedula, string nombre, DateTime fechanac, string sexo, string estcivil, string lugnac, string direccion, string ocupacion, string telefono, string correo, string estadovm, string imgpath, string peso, string talla)
        {
            DPacientes Obj = new DPacientes();
            Obj.Cedula = cedula;
            Obj.Nombre = nombre;
            Obj.Fechanac = fechanac;
            Obj.Sexo = sexo;
            Obj.Estcivil = estcivil;
            Obj.Lugarnac = lugnac;
            Obj.Direccion = direccion;
            Obj.Ocupacion = ocupacion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Estadovivomuerto = estadovm;
            Obj.Imagepath = imgpath;
            Obj.Peso = peso;
            Obj.Talla = talla;

            return Obj.Editar(Obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase DPaciente de la capa Datos

        public static string Eliminar(string cedula)
        {
            DPacientes Obj = new DPacientes();
            Obj.Cedula = cedula;

            return Obj.Eliminar(Obj);
        }

     

        //public new static List<DPacientes> Mostrar(string TextoBuscar)
        //{
        //    DPacientes Objeto = new DPacientes();
        //    return Objeto.Mostrar(TextoBuscar);
        //}

        //Metodo BuscarNombre que llama al metodo BuscarNombre de la clase DPaciente de la capa Datos

        public static DataTable BuscarNombre(string textobuscar)
        {
            DPacientes Obj = new DPacientes();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }


        public static DataTable BuscarCedula(string textobuscar)
        {
            DPacientes Obj = new DPacientes();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCedula(Obj);
        }


        public static string Anular(string ci)
        {
            DPacientes Objeto = new DPacientes();
            Objeto.Cedula = ci;
            return Objeto.Anular(Objeto);
        }


        


    }
}
