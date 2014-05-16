﻿using System;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using PalmeralGenNHibernate.EN.Default_;
using System.Collections.Generic;

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
            //PdfPTable table = new PdfPTable(2);
            //table.AddCell("ID: " + producto.Id + "\nNombre: " + producto.Nombre + "\nDescripción: " + producto.Descripcion + "\nStock Actual: " + producto.Stock);
            //Cargamos la imagen de resources.
            //iTextSharp.text.Image foto = iTextSharp.text.Image.GetInstance(producto.Foto);
            //foto.ScaleAbsolute(100f, 100f);
            //PdfPCell cellFoto = new PdfPCell(foto);
            //cellFoto.HorizontalAlignment = 1;
            //table.AddCell(cellFoto);
            //document.Add(table);

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
            tableCabecera.AddCell("Fecha: " + DateTime.Now.ToString());

            //Inserto tabla de cabecera
            document.Add(tableCabecera);

            Paragraph salto = new Paragraph(" ");
            document.Add(salto);
            document.Add(salto);

            //Añadimos una tabla
            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell(new Phrase("Informe de Cliente"));
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.AddCell(cell);
            table.AddCell("Nif: " + cliente.Nif);
            table.AddCell("Nombre: " + cliente.Nombre);
            table.AddCell("Col 1 Row 2");
            table.AddCell("Col 2 Row 2");
            document.Add(table);

            //Cerramos todo
            document.Close();
            writer.Close();
            fs.Close();
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
            tableCabecera.AddCell("Fecha: " + DateTime.Now.ToString());

            //Inserto tabla de cabecera
            document.Add(tableCabecera);

            Paragraph salto = new Paragraph(" ");
            document.Add(salto);
            document.Add(salto);

            //Añadimos una tabla
            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell(new Phrase("Informe de Cliente"));
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.AddCell(cell);
            table.AddCell("Nif: " + trabajador.Nif);
            table.AddCell("Nombre: " + trabajador.Nombre);
            table.AddCell("Col 1 Row 2");
            table.AddCell("Col 2 Row 2");
            document.Add(table);

            //Cerramos todo
            document.Close();
            writer.Close();
            fs.Close();
        }

        public void pdfTrabajadorListado(IList<TrabajadorEN> trabajadores)
        {

        }

        private Document pdfProveedor(Document document)
        {

            return document;
        }


        private Document pdfInstalacion(Document document)
        {

            return document;
        }



    }
}
