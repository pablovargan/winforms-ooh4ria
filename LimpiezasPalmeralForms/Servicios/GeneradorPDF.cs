using System;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using PalmeralGenNHibernate.EN.Default_;

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
            PdfPCell cell = new PdfPCell(new Phrase("Informe de Producto"));
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.AddCell(cell);
            table.AddCell("ID: " + producto.Id);
            table.AddCell("Nombre: " + producto.Nombre);
            table.AddCell("Col 1 Row 2");
            table.AddCell("Col 2 Row 2");
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
