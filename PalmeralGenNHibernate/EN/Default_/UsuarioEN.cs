
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class UsuarioEN                  :                           PalmeralGenNHibernate.EN.Default_.TrabajadorEN


{
/**
 *
 */

private string user;

/**
 *
 */

private String password;





public virtual string User {
        get { return user; } set { user = value;  }
}


public virtual String Password {
        get { return password; } set { password = value;  }
}





public UsuarioEN() : base ()
{
}



public UsuarioEN(string nif, string user, String password, string nombre, string apellidos, string direccion, string telefono, string codigoPostal, string pais, string localidad, string provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum tipo, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> nominas, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> jornadas)
{
        this.init (nif, user, password, nombre, apellidos, direccion, telefono, codigoPostal, pais, localidad, provincia, tipo, nominas, jornadas);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.Nif, usuario.User, usuario.Password, usuario.Nombre, usuario.Apellidos, usuario.Direccion, usuario.Telefono, usuario.CodigoPostal, usuario.Pais, usuario.Localidad, usuario.Provincia, usuario.Tipo, usuario.Nominas, usuario.Jornadas);
}

private void init (string nif, string user, String password, string nombre, string apellidos, string direccion, string telefono, string codigoPostal, string pais, string localidad, string provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum tipo, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> nominas, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> jornadas)
{
        this.Nif = nif;


        this.User = user;

        this.Password = password;

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
