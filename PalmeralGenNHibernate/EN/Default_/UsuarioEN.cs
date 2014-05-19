
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class UsuarioEN                  :                           PalmeralGenNHibernate.EN.Default_.TrabajadorEN


{
/**
 *
 */

private string usuario;

/**
 *
 */

private string contrasenya;





public virtual string Usuario {
        get { return usuario; } set { usuario = value;  }
}


public virtual string Contrasenya {
        get { return contrasenya; } set { contrasenya = value;  }
}





public UsuarioEN() : base ()
{
}



public UsuarioEN(string nif, string usuario, string contrasenya, string nombre, string apellidos, string direccion, string telefono, string codigoPostal, string pais, string localidad, string provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum tipo, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> nominas, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> jornadas)
{
        this.init (nif, usuario, contrasenya, nombre, apellidos, direccion, telefono, codigoPostal, pais, localidad, provincia, tipo, nominas, jornadas);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.Nif, usuario.Usuario, usuario.Contrasenya, usuario.Nombre, usuario.Apellidos, usuario.Direccion, usuario.Telefono, usuario.CodigoPostal, usuario.Pais, usuario.Localidad, usuario.Provincia, usuario.Tipo, usuario.Nominas, usuario.Jornadas);
}

private void init (string nif, string usuario, string contrasenya, string nombre, string apellidos, string direccion, string telefono, string codigoPostal, string pais, string localidad, string provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum tipo, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> nominas, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> jornadas)
{
        this.Nif = nif;


        this.Usuario = usuario;

        this.Contrasenya = contrasenya;

        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Direccion = direccion;

        this.Telefono = telefono;

        this.CodigoPostal = codigoPostal;

        this.Pais = pais;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Tipo = tipo;

        this.Nominas = nominas;

        this.Jornadas = jornadas;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Nif.Equals (t.Nif))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nif.GetHashCode ();
        return hash;
}
}
}
