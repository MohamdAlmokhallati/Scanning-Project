using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;
using WIA;


namespace Scanning_Project
{
    internal class ScannerHelper
    {

        public static Task<List<string>> GetAllScanners()
        {
            List<string> devices = new List<string>();

            try
            {
                DeviceManager deviceManager = new DeviceManager();

                foreach (DeviceInfo deviceInfo in deviceManager.DeviceInfos)
                {
                    if (deviceInfo.Type == WiaDeviceType.ScannerDeviceType)
                    {
                        devices.Add(deviceInfo.Properties["Name"].get_Value().ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                //Log
            }

            return Task.FromResult(devices);
        }


        public static async Task<System.Drawing.Image> ScanAsImageAsycn(string scannerName, int colorMode = 1, int dpi = 200,
            string paperSize = "A4"
            )
        {
            return await Task.Run(() =>

            {
                DeviceManager deviceManager = new DeviceManager();
                DeviceInfo selectedDevice = null;

                foreach (DeviceInfo deviceInfo in deviceManager.DeviceInfos)
                {
                    if (deviceInfo.Type == WiaDeviceType.ScannerDeviceType &&
                    (string)deviceInfo.Properties["Name"].get_Value() == scannerName)
                    {

                        selectedDevice = deviceInfo;

                        break;
                    }
                }

                if (selectedDevice == null)
                    throw new Exception("Das ausgewählte Gerät existiert nicht!");


                Device device = selectedDevice.Connect();

                Item scannerItem = device.Items[1];

                SetScannerSettings(scannerItem, dpi, colorMode, paperSize);


                ImageFile imageFile = null;

                try
                {
                    string wiaFormatJPEG = "{B96B3CAF-0728-11D3-9D7B-0000F81EF32E}";
                    imageFile = (ImageFile)scannerItem.Transfer(wiaFormatJPEG);


                }
                catch (Exception ex)
                {

                }

                byte[] imageByte = (byte[])imageFile.FileData.get_BinaryData();

                using (MemoryStream ma = new MemoryStream(imageByte))
                {
                    return System.Drawing.Image.FromStream(ma);
                }


            });

        }

        private static void SetScannerSettings(Item scannerItem, int dpi, int colorMode, string paperSize)

        {
            //The default settings for a normal scanning
            const string WIA_HORIZONTAL_DPI = "6147";
            const string WIA_VERTICAL_DPI = "6148";
            const string WIA_HORIZONTAL_EXTENT = "6151";
            const string WIA_VERTICAL_EXTENT = "6152";
            const string WIA_COLOR_MODE = "6146";


            SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_DPI, dpi);
            SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_DPI, dpi);
            SetWIAProperty(scannerItem.Properties, WIA_COLOR_MODE, colorMode);


            int width = 0;
            int height = 0;

            switch (paperSize.ToUpper())
            {
                case "A4":
                    width = (int)(8.27 * dpi);
                    height = (int)(11.69 * dpi);
                    break;

                case "A5":
                    width = (int)(5.83 * dpi);
                    height = (int)(8.27 * dpi);
                    break;

                case "Letter":
                    width = (int)(8.5 * dpi);
                    height = (int)(11 * dpi);
                    break;

                default:
                    throw new Exception("Das Papierformat ist unbekannt");
            }

            SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_EXTENT, width);
            SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_EXTENT, height);



        }


        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        public static bool SaveImagesAsPdf(List<System.Drawing.Image> images, string outputPdfPath)
        {
            if (images == null || images.Count == 0)
            {
                throw new ArgumentException("The image list cannot be null or empty.", nameof(images));
            }

            try
            {
                using (PdfWriter writer = new PdfWriter(outputPdfPath))
                using (PdfDocument pdfDoc = new PdfDocument(writer))
                {
                    Document document = new Document(pdfDoc);

                    foreach (var image in images)
                    {
                        using (var ms = new MemoryStream())
                        {
                            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Save in PNG format
                            byte[] imageBytes = ms.ToArray();

                            ImageData imageData = ImageDataFactory.Create(imageBytes);
                            iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(imageData);
                            document.Add(pdfImage);
                        }
                    }

                    document.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while saving images to PDF: " + ex.Message);
                return false;
            }
        }


    }

    

}
