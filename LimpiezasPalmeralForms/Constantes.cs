﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimpiezasPalmeralForms
{
    class Constantes
    {
        public static string _ERRORCREAR = "El NIF introducido ya existe";
        public static string _ERRORNIFFORMATO = "El formato del NIF introducido no es correcto";
        public static string _ERRORNIF = "El NIF no puede estar vacio";
        public static string _ERRORINSTALACION = "Ya existe una instalación con ese ID";
        public static string _ERRORIDINST = "El ID no puede estar vacío";
        public static string _ERRORCREARPRODUCTO = "El ID introducido ya existe";
        public static string _ERRORIDPRODUCTO = "El ID no puede estar vacio";
        public static string _ERRORREDUCIRSTOCK = "No existen tantas unidades de stock";
        public static string _ERRORREDUCIRSTOCKNEGATIVO = "El dato introducido es incorrecto";
        public static string _ERRORLOGINPASS = "La contraseña es incorrecta";
        public static string _ERRORLOGINUSER = "El usuario no existe";
        public static string _ERRORCAMPOSVACIOS = "Existen campos sin rellenar";
        public static string _ERRORTRABAJADOR = "El trabajador no se pudo crear";
        public static string _ERRORNOMINAEXISTE = "La nomina ya existe";
        public static string _ERRORNOMINA = "La nomina no se pudo crear";

        public static string _CIUDADEMPRESA = "Elche";
        public static string _NOMBREEMPRESA = "Limpiezas el Palmeral";

        

        public static string _ERRORID { get; set; }
    }
}
