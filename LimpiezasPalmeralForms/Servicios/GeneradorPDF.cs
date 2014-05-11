using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection;

namespace LimpiezasPalmeralForms.Servicios
{
    class GeneradorPDF
    {
        private string id;
        private string tipo;
        Document document;


        public GeneradorPDF(string tipo_pdf, string id_pdf)
        {
            document = new Document(PageSize.A4, 25, 25, 30, 30);
            tipo = tipo_pdf;
            id = id_pdf;      
        }



        private void pdfCliente(Document document)
        {
            string path = @"" + tipo + " " + id + ".pdf";
            FileStream fs = new FileStream(path, FileMode.Create);


            document.AddAuthor("Limpiezas el Palmeral");
            document.AddCreator("Limpiezas el Palmeral Cooperativa");
            document.AddKeywords("Informe de Clientes");
            document.AddSubject("Informe de un determinado cliente");
            document.AddTitle("Informe del " + tipo + " : " + id);

            // Create an instance to the PDF file by creating an instance of the PDF 
            // Writer class using the document and the filestrem in the constructor.
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Open the document to enable you to write to the document
            document.Open();
            // Add a simple and wellknown phrase to the document in a flow layout manner
            document.Add(new Paragraph("Informe"));

            Paragraph salto = new Paragraph(" ");
            document.Add(salto);
            document.Add(salto);

            //Añadimos una tabla
            PdfPTable table = new PdfPTable(3);
            PdfPCell cell = new PdfPCell(new Phrase("Header spanning 3 columns"));
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.AddCell(cell);
            table.AddCell("Col 1 Row 1");
            table.AddCell("Col 2 Row 1");
            table.AddCell("Col 3 Row 1");
            table.AddCell("Col 1 Row 2");
            table.AddCell("Col 2 Row 2");
            table.AddCell("Col 3 Row 2");
            document.Add(table);


            // Close the document
            document.Close();
            // Close the writer instance
            writer.Close();
            // Always close open filehandles explicity


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
