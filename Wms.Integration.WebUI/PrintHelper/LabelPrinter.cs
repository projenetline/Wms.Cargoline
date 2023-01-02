using DinkToPdf;
using DinkToPdf.Contracts;
using Newtonsoft.Json.Linq;
using Spire.Barcode;
using System.Drawing;
using System.Drawing.Imaging;
using Wms.Integration.Entities.Dtos.Shipments;
using ColorMode = DinkToPdf.ColorMode;

namespace Wms.Integration.WebUI.PrintHelper
{
    public class LabelPrinter
    {
        private const double V = 5.8;
        private IConverter _converter;
        public LabelPrinter(IConverter converter)
        {
            _converter = converter;
        }
        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {



                //Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                //Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        public byte[] print(LabelInfoModel label, int labelNr)
        {

            string path = GetBaseUrl() + "/PrintDesigns/LabelDesign.html";

            HttpClient httpClient = new HttpClient();

            string body = httpClient.GetStringAsync(path).Result;


            byte[] logoImage = httpClient.GetByteArrayAsync(GetBaseUrl() + "/img/FirmImages/native.jpg").Result;

            string netline_logoBase64String = Convert.ToBase64String(logoImage);
            body = body.Replace("{firmLogo}", "data:image/jpeg;base64," + netline_logoBase64String + "\" ");

            BarcodeSettings settings = new BarcodeSettings();
            settings.Type = BarCodeType.Code128;
            settings.Data = label.OrderNr;
            settings.BarHeight = 20;
            settings.ImageWidth = 400;
            settings.ShowBottomText = false;
            settings.ShowText = false;
            settings.ShowTopText = false;
            //settings.X = 5.08f;

            //settings.Data2D = "NAT2022000001524";
            //settings.X = 5.08f;

            settings.AutoResize = true;
            settings.Code128SetMode = Code128SetMode.Auto;
            BarCodeGenerator generator = new BarCodeGenerator(settings);
            var image = generator.GenerateImage();
            body = body.Replace("{barcode}", "data:image/jpeg;base64," + ImageToBase64(image, ImageFormat.Jpeg) + "\" ");
            body = body.Replace("{koli}", label.BoxCount);
            body = body.Replace("{desi}", label.Desi);
            body = body.Replace("{belgeno}", label.OrderNr);
            string transporter = "";
            switch (label.Transporter)
            {
                case "1":
                    transporter = "Yurt İçi Kargo"; break;
                case "2":
                    transporter = "Aras Kargo"; break;
                case "3":
                    transporter = "Kargolin"; break;
                case "4":
                    transporter = "Elden Teslimat"; break;
                case "5":
                    transporter = "Özel Servis"; break;
                default:
                    break;
            }
            body = body.Replace("{transporter}", transporter);
            body = body.Replace("{adres1}", label.Address1);
            body = body.Replace("{adres2}", label.Address2);
            body = body.Replace("{client}", label.ClDefintion);
            body = body.Replace("{city}", label.City);
            body = body.Replace("{town}", label.Town);
            body = body.Replace("{boxCount}", labelNr+ "/"+ label.BoxCount);
            body = body.Replace("{paletNr}", "P :" +label.PaletNr);
            return CreatePDF(body);

        }
        private string GetBaseUrl()
        {


            return $"https://localhost:7233";
        }
        public byte[] CreatePDF(string html)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,

                // Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "Cargoline Label",
                PaperSize = new PechkinPaperSize("152.4mm", "101.6mm"),

            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = html,
                WebSettings = { DefaultEncoding = "utf-8", LoadImages = true }


            };
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            return _converter.Convert(pdf);

        }



    }
}
