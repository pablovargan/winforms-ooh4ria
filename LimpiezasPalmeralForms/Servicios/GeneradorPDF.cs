using System;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using PalmeralGenNHibernate.EN.Default_;
using System.Collections.Generic;
using PalmeralGenNHibernate.CEN.Default_;
using System.Windows.Forms;

namespace LimpiezasPalmeralForms.Servicios
{
    class GeneradorPDF
    {
        public GeneradorPDF()
        {
        
        }

        public void pdfProducto(ProductoEN producto)
        {
            Document document;
            document = new Document(PageSize.A4, 25, 25, 30, 30);
            string path = @"" + "Producto " + producto.Id + ".pdf";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);


            // Create an instance to the PDF file by creating an instance of the PDF 
            // Writer class using the document and the filestrem in the constructor.
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Open the document to enable you to write to the document
            document.Open();

            // Creo cabecera del informe
            PdfPTable tableTitulo = new PdfPTable(2);
            tableTitulo.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            PdfPCell cell = new PdfPCell(new Phrase("Informe de Producto"));
            cell.BorderWidth = 0;
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableTitulo.AddCell(cell);
            document.Add(tableTitulo);

            PdfPTable tableCabecera = new PdfPTable(2);

            //Tabla sin bordes
            tableCabecera.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;


            //Cargamos la imagen de resources.
            System.Drawing.Image logores = Properties.Resources.logo;
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logores, System.Drawing.Imaging.ImageFormat.Jpeg);

            //Añado imagen a la cabecera y fecha.
            logo.ScaleAbsolute(100f, 100f);
            PdfPCell cellLogo = new PdfPCell(logo);
            cellLogo.BorderWidth = 0;
            tableCabecera.AddCell(cellLogo);
            tableCabecera.AddCell("\n\n\n\n\nEmpresa: " + Constantes._NOMBREEMPRESA + "\nLocalidad: " + Constantes._CIUDADEMPRESA + "\nFecha: " + DateTime.Now.ToString() + "\n");

            //Inserto tabla de cabecera
            document.Add(tableCabecera);

            Paragraph salto = new Paragraph(" ");
            document.Add(salto);
            document.Add(salto);

            //Añadimos una tabla
            PdfPTable table = new PdfPTable(2);
            PdfPCell header = new PdfPCell(new Phrase("Datos del producto"));
            header.Colspan = 2;
            table.TotalWidth = 400f;
            table.LockedWidth = true;
            header.HorizontalAlignment = 1;
            table.AddCell(header);
            PdfPTable nested = new PdfPTable(1);
            nested.AddCell("ID: " + producto.Id);
            nested.AddCell("Nombre: " + producto.Nombre);
            nested.AddCell("Descripción: " + producto.Descripcion);
            nested.AddCell("Stock Actual: " + producto.Stock);
            PdfPCell nesthousing = new PdfPCell(nested);
            nesthousing.Padding = 0f;
            table.AddCell(nesthousing);
            iTextSharp.text.Image foto = iTextSharp.text.Image.GetInstance(producto.Foto);
            foto.ScaleAbsolute(100f, 100f);
            PdfPCell cellfoto = new PdfPCell(foto);
            cellfoto.HorizontalAlignment = 1;
            //bottom.Colspan = 1;
            table.AddCell(cellfoto);
            document.Add(table);

            //Cerramos todo
            document.Close();
            writer.Close();
            fs.Close();
            MessageBox.Show("Se ha generado un informe en PDF con el nombre \"" + path + "\"");
        }


        public void pdfCliente(ClienteEN cliente)
        {
            Document document;
            document = new Document(PageSize.A4, 25, 25, 30, 30);
            string path = @"" + "Cliente " + cliente.Nif + ".pdf";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);


            // Create an instance to the PDF file by creating an instance of the PDF 
            // Writer class using the document and the filestrem in the constructor.
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Open the document to enable you to write to the document
            document.Open();

            // Creo cabecera del informe
            PdfPTable tableTitulo = new PdfPTable(2);
            tableTitulo.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            PdfPCell cell = new PdfPCell(new Phrase("Informe de Cliente"));
            cell.BorderWidth = 0;
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableTitulo.AddCell(cell);
            document.Add(tableTitulo);

            //Tabla sin bordes
            PdfPTable tableCabecera = new PdfPTable(2);
            tableCabecera.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;


            //Cargamos la imagen de resources.
            System.Drawing.Image logores = Properties.Resources.logo;
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logores, System.Drawing.Imaging.ImageFormat.Jpeg);

            //Añado imagen a la cabecera y fecha.
            logo.ScaleAbsolute(100f, 100f);
            PdfPCell cellLogo = new PdfPCell(logo);
            cellLogo.BorderWidth = 0;
            tableCabecera.AddCell(cellLogo);
            tableCabecera.AddCell("\n\n\n\n\nEmpresa: " + Constantes._NOMBREEMPRESA + "\nLocalidad: " + Constantes._CIUDADEMPRESA + "\nFecha: " + DateTime.Now.ToString() + "\n");

            //Inserto tabla de cabecera
            document.Add(tableCabecera);

            Paragraph salto = new Paragraph(" ");
            document.Add(salto);
            document.Add(salto);

            //Añadimos una tabla con los datos del cliente
            PdfPTable tableCliente = new PdfPTable(2);
            PdfPCell cell2 = new PdfPCell(new Phrase("Datos del Cliente"));
            cell2.Colspan = 2;
            cell2.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableCliente.AddCell(cell2);
            tableCliente.AddCell("NIF");
            tableCliente.AddCell(cliente.Nif);
            tableCliente.AddCell("Nombre");
            tableCliente.AddCell(cliente.Nombre);
            tableCliente.AddCell("Email");
            tableCliente.AddCell(cliente.Email);
            tableCliente.AddCell("Dirección");
            tableCliente.AddCell(cliente.Direccion);
            tableCliente.AddCell("Localidad");
            tableCliente.AddCell(cliente.Localidad);
            tableCliente.AddCell("Provincia");
            tableCliente.AddCell(cliente.Provincia);
            tableCliente.AddCell("CP");
            tableCliente.AddCell(cliente.CodigoPostal);
            tableCliente.AddCell("País");
            tableCliente.AddCell(cliente.Pais);
            tableCliente.AddCell("Teléfono");
            tableCliente.AddCell(cliente.Telefono);
            tableCliente.AddCell("Descripción");
            tableCliente.AddCell(cliente.Descripcion);
            document.Add(tableCliente);
         
            document.Add(salto);
            document.Add(salto);

            //Añadimos una tabla con los datos del cliente
            PdfPTable tableInstalaciones = new PdfPTable(7);
            tableInstalaciones.TotalWidth = 500f;
            tableInstalaciones.LockedWidth = true;
            PdfPCell cell3 = new PdfPCell(new Phrase("Instalaciones del Cliente"));
            cell3.Colspan = 7;
            cell3.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableInstalaciones.AddCell(cell3);
            tableInstalaciones.AddCell("Nombre");
            tableInstalaciones.AddCell("Dirección");
            tableInstalaciones.AddCell("Localidad");
            tableInstalaciones.AddCell("Provincia");
            tableInstalaciones.AddCell("CP");
            tableInstalaciones.AddCell("País");
            tableInstalaciones.AddCell("Teléfono");
            InstalacionCEN instalacionCEN = new InstalacionCEN();
            IList<InstalacionEN> instalacionesCliente = new List<InstalacionEN>();
            instalacionesCliente = instalacionCEN.BuscarInstalacionesCliente(cliente.Nif);

            foreach (InstalacionEN ins in instalacionesCliente)
            {
                tableInstalaciones.AddCell(ins.Nombre);
                tableInstalaciones.AddCell(ins.Direccion);
                tableInstalaciones.AddCell(ins.Localidad);
                tableInstalaciones.AddCell(ins.Provincia);
                tableInstalaciones.AddCell(ins.CodigoPostal);
                tableInstalaciones.AddCell(ins.Pais);
                tableInstalaciones.AddCell(ins.Telefono);
            }
            document.Add(tableInstalaciones);

            //Cerramos todo
            document.Close();
            writer.Close();
            fs.Close();

            MessageBox.Show("Se ha generado un informe en PDF con el nombre \"" + path + "\"" );
        }

        public void pdfTrabajador(TrabajadorEN trabajador)
        {
            Document document;
            document = new Document(PageSize.A4, 25, 25, 30, 30);
            string path = @"" + "Trabajador " + trabajador.Nif + ".pdf";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);


            // Create an instance to the PDF file by creating an instance of the PDF 
            // Writer class using the document and the filestrem in the constructor.
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Open the document to enable you to write to the document
            document.Open();

            // Creo cabecera del informe
            PdfPTable tableTitulo = new PdfPTable(2);
            tableTitulo.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            PdfPCell cell = new PdfPCell(new Phrase("Informe de Trabajador"));
            cell.BorderWidth = 0;
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableTitulo.AddCell(cell);
            document.Add(tableTitulo);

            //Tabla sin bordes
            PdfPTable tableCabecera = new PdfPTable(2);
            tableCabecera.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;


            //Cargamos la imagen de resources.
            System.Drawing.Image logores = Properties.Resources.logo;
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logores, System.Drawing.Imaging.ImageFormat.Jpeg);

            //Añado imagen a la cabecera y fecha.
            logo.ScaleAbsolute(100f, 100f);
            PdfPCell cellLogo = new PdfPCell(logo);
            cellLogo.BorderWidth = 0;
            tableCabecera.AddCell(cellLogo);
            tableCabecera.AddCell("\n\n\n\n\nEmpresa: " + Constantes._NOMBREEMPRESA + "\nLocalidad: " + Constantes._CIUDADEMPRESA + "\nFecha: " + DateTime.Now.ToString() + "\n");

            //Inserto tabla de cabecera
            document.Add(tableCabecera);

            Paragraph salto = new Paragraph(" ");
            document.Add(salto);
            document.Add(salto);

            //Añadimos una tabla con los datos del trabajador
            PdfPTable tableTrabajador = new PdfPTable(2);
            PdfPCell cell2 = new PdfPCell(new Phrase("Datos del Trabajador"));
            cell2.Colspan = 2;
            cell2.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableTrabajador.AddCell(cell2);
            tableTrabajador.AddCell("NIF");
            tableTrabajador.AddCell(trabajador.Nif);
            tableTrabajador.AddCell("Nombre");
            tableTrabajador.AddCell(trabajador.Nombre);
            tableTrabajador.AddCell("Apellidos");
            tableTrabajador.AddCell(trabajador.Apellidos);
            tableTrabajador.AddCell("Dirección");
            tableTrabajador.AddCell(trabajador.Direccion);
            tableTrabajador.AddCell("Localidad");
            tableTrabajador.AddCell(trabajador.Localidad);
            tableTrabajador.AddCell("Provincia");
            tableTrabajador.AddCell(trabajador.Provincia);
            tableTrabajador.AddCell("CP");
            tableTrabajador.AddCell(trabajador.CodigoPostal);
            tableTrabajador.AddCell("País");
            tableTrabajador.AddCell(trabajador.Pais);
            tableTrabajador.AddCell("Teléfono");
            tableTrabajador.AddCell(trabajador.Telefono);
            tableTrabajador.AddCell("Tipo de Empleo");
            tableTrabajador.AddCell(trabajador.Tipo.ToString());
            document.Add(tableTrabajador);

            document.Add(salto);
            document.Add(salto);

         

            if (trabajador.Tipo.ToString().Equals("Cooperativista"))
            {
                //Añadimos una tabla con los datos del cliente
                PdfPTable tableNominas = new PdfPTable(5);
                tableNominas.TotalWidth = 500f;
                tableNominas.LockedWidth = true;
                PdfPCell cell3 = new PdfPCell(new Phrase("Nominas del Trabajador"));
                cell3.Colspan = 5;
                cell3.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                tableNominas.AddCell(cell3);
                tableNominas.AddCell("Horas Trabajadas");
                tableNominas.AddCell("Parte Fija");
                tableNominas.AddCell("Parte Variable");
                tableNominas.AddCell("Total");
                tableNominas.AddCell("Fecha");
                NominaCEN nomina = new NominaCEN();
                IList<NominaEN> lista = new List<NominaEN>();
                lista = nomina.ObtenerTodas(0, 0);
                IList<NominaEN> listabuena = new List<NominaEN>();
                foreach (NominaEN n in lista)
                {
                    if (n.Trabajador.Nif.Equals(trabajador.Nif))
                    {
                        tableNominas.AddCell(n.Horas.ToString());
                        tableNominas.AddCell(n.ParteFija.ToString());
                        tableNominas.AddCell(n.ParteVariable.ToString());
                        tableNominas.AddCell(n.Total.ToString());
                        tableNominas.AddCell(n.Fecha.ToString());
                    }
                }
                document.Add(tableNominas);
            }
            else
            {
                //Añadimos una tabla con los datos del cliente
                PdfPTable tableNominas = new PdfPTable(4);
                tableNominas.TotalWidth = 500f;
                tableNominas.LockedWidth = true;
                PdfPCell cell3 = new PdfPCell(new Phrase("Nominas del Trabajador"));
                cell3.Colspan = 4;
                cell3.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                tableNominas.AddCell(cell3);
                tableNominas.AddCell("Horas Trabajadas");
                tableNominas.AddCell("Parte Fija");
                tableNominas.AddCell("Total");
                tableNominas.AddCell("Fecha");
                NominaCEN nomina = new NominaCEN();
                IList<NominaEN> lista = new List<NominaEN>();
                lista = nomina.ObtenerTodas(0, 0);
                IList<NominaEN> listabuena = new List<NominaEN>();
                foreach (NominaEN n in lista)
                {
                    if (n.Trabajador.Nif.Equals(trabajador.Nif))
                    {
                        tableNominas.AddCell(n.Horas.ToString());
                        tableNominas.AddCell(n.ParteFija.ToString());
                        tableNominas.AddCell(n.Total.ToString());
                        tableNominas.AddCell(n.Fecha.ToString());
                    }
                }
                document.Add(tableNominas);
            }

            //Cerramos todo
            document.Close();
            writer.Close();
            fs.Close();

            MessageBox.Show("Se ha generado un informe en PDF con el nombre \"" + path + "\"");
        }

        public void pdfTrabajadorListado(IList<TrabajadorEN> trabajadores)
        {
            Document document;
            document = new Document(PageSize.A4, 25, 25, 30, 30);
            string path = @"" + "Listado de trabajadores" + ".pdf";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);


            // Create an instance to the PDF file by creating an instance of the PDF 
            // Writer class using the document and the filestrem in the constructor.
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Open the document to enable you to write to the document
            document.Open();

            // Creo cabecera del informe
            PdfPTable tableTitulo = new PdfPTable(2);
            tableTitulo.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            PdfPCell cell = new PdfPCell(new Phrase("Informe de Trabajador"));
            cell.BorderWidth = 0;
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableTitulo.AddCell(cell);
            document.Add(tableTitulo);

            //Tabla sin bordes
            PdfPTable tableCabecera = new PdfPTable(2);
            tableCabecera.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;


            //Cargamos la imagen de resources.
            System.Drawing.Image logores = Properties.Resources.logo;
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logores, System.Drawing.Imaging.ImageFormat.Jpeg);

            //Añado imagen a la cabecera y fecha.
            logo.ScaleAbsolute(100f, 100f);
            PdfPCell cellLogo = new PdfPCell(logo);
            cellLogo.BorderWidth = 0;
            tableCabecera.AddCell(cellLogo);
            tableCabecera.AddCell("\n\n\n\n\nEmpresa: " + Constantes._NOMBREEMPRESA + "\nLocalidad: " + Constantes._CIUDADEMPRESA + "\nFecha: " + DateTime.Now.ToString() + "\n");

            //Inserto tabla de cabecera
            document.Add(tableCabecera);

            Paragraph salto = new Paragraph(" ");
            document.Add(salto);
            document.Add(salto);

            PdfPTable tableTrabajador = new PdfPTable(2);

            foreach (TrabajadorEN tra in trabajadores)
            {
                PdfPCell cell2 = new PdfPCell(new Phrase("Trabajador: " + tra.Nombre));
                cell2.Colspan = 2;
                cell2.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                tableTrabajador.AddCell(cell2);
                tableTrabajador.AddCell("NIF");
                tableTrabajador.AddCell(tra.Nif);
                tableTrabajador.AddCell("Apellidos");
                tableTrabajador.AddCell(tra.Apellidos);
                tableTrabajador.AddCell("Dirección");
                tableTrabajador.AddCell(tra.Direccion);
                tableTrabajador.AddCell("Localidad");
                tableTrabajador.AddCell(tra.Localidad);
                tableTrabajador.AddCell("Provincia");
                tableTrabajador.AddCell(tra.Provincia);
                tableTrabajador.AddCell("CP");
                tableTrabajador.AddCell(tra.CodigoPostal);
                tableTrabajador.AddCell("País");
                tableTrabajador.AddCell(tra.Pais);
                tableTrabajador.AddCell("Teléfono");
                tableTrabajador.AddCell(tra.Telefono);
                tableTrabajador.AddCell("Tipo de Empleo");
                tableTrabajador.AddCell(tra.Tipo.ToString());
            }
            document.Add(tableTrabajador);
            //Cerramos todo
            document.Close();
            writer.Close();
            fs.Close();

            MessageBox.Show("Se ha generado un informe en PDF con el nombre \"" + path + "\"");
        }

        public void pdfInstalacion(InstalacionEN instalacion)
        {
            Document document;
            document = new Document(PageSize.A4, 25, 25, 30, 30);
            string path = @"" + "Instalación " + instalacion.Id + ".pdf";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);


            // Create an instance to the PDF file by creating an instance of the PDF 
            // Writer class using the document and the filestrem in the constructor.
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Open the document to enable you to write to the document
            document.Open();

            // Creo cabecera del informe
            PdfPTable tableTitulo = new PdfPTable(2);
            tableTitulo.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            PdfPCell cell = new PdfPCell(new Phrase("Informe de Instalación"));
            cell.BorderWidth = 0;
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableTitulo.AddCell(cell);
            document.Add(tableTitulo);

            //Tabla sin bordes
            PdfPTable tableCabecera = new PdfPTable(2);
            tableCabecera.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

            //Cargamos la imagen de resources.
            System.Drawing.Image logores = Properties.Resources.logo;
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logores, System.Drawing.Imaging.ImageFormat.Jpeg);

            //Añado imagen a la cabecera y fecha.
            logo.ScaleAbsolute(100f, 100f);
            PdfPCell cellLogo = new PdfPCell(logo);
            cellLogo.BorderWidth = 0;
            tableCabecera.AddCell(cellLogo);
            tableCabecera.AddCell("\n\n\n\n\nEmpresa: " + Constantes._NOMBREEMPRESA + "\nLocalidad: " 
                + Constantes._CIUDADEMPRESA + "\nFecha: " + DateTime.Now.ToString() + "\n");

            //Inserto tabla de cabecera
            document.Add(tableCabecera);

            Paragraph salto = new Paragraph(" ");
            document.Add(salto);
            document.Add(salto);

            //Añadimos una tabla con los datos de la instalacion
            PdfPTable tableInstalacion = new PdfPTable(2);
            PdfPCell cell2 = new PdfPCell(new Phrase("Datos de la instalación"));
            cell2.Colspan = 2;
            cell2.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableInstalacion.AddCell(cell2);
            tableInstalacion.AddCell("ID");
            tableInstalacion.AddCell(instalacion.Id);
            tableInstalacion.AddCell("Nombre");
            tableInstalacion.AddCell(instalacion.Nombre);
            tableInstalacion.AddCell("Descripción");
            tableInstalacion.AddCell(instalacion.Descripcion);
            tableInstalacion.AddCell("Dirección");
            tableInstalacion.AddCell(instalacion.Direccion);
            tableInstalacion.AddCell("Localidad");
            tableInstalacion.AddCell(instalacion.Localidad);
            tableInstalacion.AddCell("Provincia");
            tableInstalacion.AddCell(instalacion.Provincia);
            tableInstalacion.AddCell("País");
            tableInstalacion.AddCell(instalacion.Pais);
            tableInstalacion.AddCell("CP");
            tableInstalacion.AddCell(instalacion.CodigoPostal);
            tableInstalacion.AddCell("Teléfono");
            tableInstalacion.AddCell(instalacion.Telefono);
            tableInstalacion.AddCell("Metros cuadrados");
            tableInstalacion.AddCell(instalacion.MetrosCuadrados.ToString());
            tableInstalacion.AddCell("NIF Cliente");
            tableInstalacion.AddCell(instalacion.Cliente.Nif);
            document.Add(tableInstalacion);

            document.Add(salto);
            document.Add(salto);

            //Añadimos una tabla con los datos delos trabajadores
            PdfPTable tableTrabajadores = new PdfPTable(7);
            tableTrabajadores.TotalWidth = 500f;
            tableTrabajadores.LockedWidth = true;
            PdfPCell cell3 = new PdfPCell(new Phrase("Trabajadores de la instalación"));
            cell3.Colspan = 9;
            cell3.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableTrabajadores.AddCell(cell3);
            tableTrabajadores.AddCell("NIF");
            tableTrabajadores.AddCell("Nombre");
            tableTrabajadores.AddCell("Apellidos");
            tableTrabajadores.AddCell("Dirección");
            tableTrabajadores.AddCell("Localidad");
            tableTrabajadores.AddCell("Teléfono");
            tableTrabajadores.AddCell("Tipo");
            TrabajadorCEN trabajadorCEN = new TrabajadorCEN();
            IList<TrabajadorEN> trabajadoresInst = trabajadorCEN.ObtenerTodos(0, 0);

            foreach (TrabajadorEN trab in trabajadoresInst)
            {
                tableTrabajadores.AddCell(trab.Nif);
                tableTrabajadores.AddCell(trab.Nombre);
                tableTrabajadores.AddCell(trab.Apellidos);
                tableTrabajadores.AddCell(trab.Direccion);
                tableTrabajadores.AddCell(trab.Localidad);
                tableTrabajadores.AddCell(trab.Telefono);
                tableTrabajadores.AddCell(trab.Tipo.ToString());
            }

            document.Add(tableTrabajadores);

            //Cerramos todo
            document.Close();
            writer.Close();
            fs.Close();

            MessageBox.Show("Se ha generado un informe en PDF con el nombre \"" + path + "\"");
        }

        public void pdfProveedor(ProveedorEN proveedor)
        {
            Document document;
            document = new Document(PageSize.A4, 25, 25, 30, 30);
            string path = @"" + "Proveedor " + proveedor.Id + ".pdf";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);


            // Create an instance to the PDF file by creating an instance of the PDF 
            // Writer class using the document and the filestrem in the constructor.
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Open the document to enable you to write to the document
            document.Open();

            // Creo cabecera del informe
            PdfPTable tableTitulo = new PdfPTable(2);
            tableTitulo.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            PdfPCell cell = new PdfPCell(new Phrase("Informe de Proveedor"));
            cell.BorderWidth = 0;
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableTitulo.AddCell(cell);
            document.Add(tableTitulo);

            //Tabla sin bordes
            PdfPTable tableCabecera = new PdfPTable(2);
            tableCabecera.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;


            //Cargamos la imagen de resources.
            System.Drawing.Image logores = Properties.Resources.logo;
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logores, System.Drawing.Imaging.ImageFormat.Jpeg);

            //Añado imagen a la cabecera y fecha.
            logo.ScaleAbsolute(100f, 100f);
            PdfPCell cellLogo = new PdfPCell(logo);
            cellLogo.BorderWidth = 0;
            tableCabecera.AddCell(cellLogo);
            tableCabecera.AddCell("\n\n\n\n\nEmpresa: " + Constantes._NOMBREEMPRESA + "\nLocalidad: " + Constantes._CIUDADEMPRESA + "\nFecha: " + DateTime.Now.ToString() + "\n");

            //Inserto tabla de cabecera
            document.Add(tableCabecera);

            Paragraph salto = new Paragraph(" ");
            document.Add(salto);
            document.Add(salto);

            //Añadimos una tabla con los datos del Proveedor
            PdfPTable tableProveedor = new PdfPTable(2);
            PdfPCell cell2 = new PdfPCell(new Phrase("Datos del Proveedor"));
            cell2.Colspan = 2;
            cell2.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tableProveedor.AddCell(cell2);
            tableProveedor.AddCell("Id");
            tableProveedor.AddCell(proveedor.Id);
            tableProveedor.AddCell("Nombre");
            tableProveedor.AddCell(proveedor.Nombre);
            tableProveedor.AddCell("Email");
            tableProveedor.AddCell(proveedor.Email);
            tableProveedor.AddCell("Dirección");
            tableProveedor.AddCell(proveedor.Direccion);
            tableProveedor.AddCell("Localidad");
            tableProveedor.AddCell(proveedor.Localidad);
            tableProveedor.AddCell("Provincia");
            tableProveedor.AddCell(proveedor.Provincia);
            tableProveedor.AddCell("CP");
            tableProveedor.AddCell(proveedor.CodigoPostal);
            tableProveedor.AddCell("País");
            tableProveedor.AddCell(proveedor.Pais);
            tableProveedor.AddCell("Teléfono");
            tableProveedor.AddCell(proveedor.Telefono);
            tableProveedor.AddCell("Descripción");
            tableProveedor.AddCell(proveedor.Descripcion);
            document.Add(tableProveedor);

            document.Add(salto);
            document.Add(salto);

            // Añadimos una tabla con los datos de los pedidos
            PdfPTable tablePedidos = new PdfPTable(4);
            tablePedidos.TotalWidth = 500f;
            tablePedidos.LockedWidth = true;
            PdfPCell cell3 = new PdfPCell(new Phrase("Pedidos al Proveedor"));
            cell3.Colspan = 4;
            cell3.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            tablePedidos.AddCell(cell3);
            tablePedidos.AddCell("Id");
            tablePedidos.AddCell("Fecha");
            tablePedidos.AddCell("Estado");
            tablePedidos.AddCell("Tipo de pago");

            PedidoCEN pedidoCEN = new PedidoCEN();
            ProveedorCEN proveedorCEN = new ProveedorCEN();
            foreach (var pedido in pedidoCEN.ObtenerTodos(0, 0))
            {
                if (proveedor.Equals(pedido.Proveedor))
                {
                    tablePedidos.AddCell(pedido.Id);
                    tablePedidos.AddCell(pedido.Fecha.ToString());
                    tablePedidos.AddCell(pedido.Estado.ToString());
                    tablePedidos.AddCell(pedido.TipoPago.ToString());
                }
            }
            document.Add(tablePedidos);

            //Cerramos todo
            document.Close();
            writer.Close();
            fs.Close();

            MessageBox.Show("Se ha generado un informe en PDF con el nombre \"" + path + "\"");
        }


        private Document pdfInstalacion(Document document)
        {

            return document;
        }



    }
}
