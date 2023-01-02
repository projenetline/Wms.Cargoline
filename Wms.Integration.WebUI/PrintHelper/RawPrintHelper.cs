
using Spire.Pdf;
using System.Drawing.Printing;

namespace Wms.Integration.WebUI.PrintHelper
{
    public class RawPrintHelper
    {



        public void Print(byte[] file)
        {
            

            PdfDocument doc = new PdfDocument();
            //Load a PDF file
            doc.LoadFromBytes(file);
            //Print with default printer

            doc.PrintSettings.PrinterName = "TSC TTP-244CE";


            doc.Print();
        }


    }
}
