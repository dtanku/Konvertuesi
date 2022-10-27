using ESCPOS_NET;
using ESCPOS_NET.Emitters;
using System;
using System.Drawing;

namespace Converter
{
    class Print
    {
        public static EPSON printer = new EPSON();
        public static SerialPrinter printerConn = new SerialPrinter(portName: "COM2", baudRate: 9600);
        public static byte[] ImgtoByteArr(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
        public static byte[][] Receipt(ICommandEmitter printeri, string koha, string currencyfrom, string currencyto, decimal input, decimal converted, string paddednumber) => new byte[][]
        {
            printeri.LeftAlign(),
			//printeri.PrintImage(ImgtoByteArr(Properties.Resources.kompanilogo), true, true),
			printeri.LeftAlign(),
            printeri.PrintLine(Properties.Settings.Default.company),
            printeri.PrintLine(Properties.Settings.Default.row2),
            printeri.PrintLine(Properties.Settings.Default.row3),
            printeri.SetStyles(PrintStyle.Underline),
            printeri.PrintLine("Konvertimi i monedhes"),
            printeri.SetStyles(PrintStyle.None),
            printeri.PrintLine(""),
            printeri.LeftAlign(),
            printeri.PrintLine("Fatura Nr.: " + paddednumber +"       " + koha),
            printeri.SetStyles(PrintStyle.FontB),
            printeri.PrintLine("----------------------------------------------------------------"),
            printeri.Print2DCode(TwoDimensionCodeType.PDF417, "Fatura " + paddednumber + ": " + koha + ", " + input + " " + currencyfrom + " = " + converted + " " + currencyto, Size2DCode.SMALL),
            printeri.PrintLine("----------------------------------------------------------------"),
            printeri.SetStyles(PrintStyle.None),
            printeri.LeftAlign(),
            printeri.PrintLine("JU KENI KONVERTUAR " + input + " " + currencyfrom),
            printeri.PrintLine("KENI MARRE         " + converted + " " + currencyto),
            printeri.PrintLine("KURSI ESHTE: 1 " + currencyfrom + " = " + Math.Round(Convert.ToDecimal(converted) / input, 3) + " " + currencyto),
            printeri.PrintLine(""),
            printeri.FullCutAfterFeed(5),
        };
        public static byte[][] Reprint(ICommandEmitter printeri, string koha, string currencyfrom, string currencyto, decimal input, decimal converted, string paddednumber) => new byte[][]
{
            printeri.LeftAlign(),
			//printeri.PrintImage(ImgtoByteArr(Properties.Resources.kompanilogo), true, true),
            printeri.CenterAlign(),
            printeri.SetStyles(PrintStyle.Bold | PrintStyle.FontB | PrintStyle.DoubleHeight | PrintStyle.DoubleWidth),
            printeri.PrintLine("KOPJE DYTESORE"),
            printeri.SetStyles(PrintStyle.None),
            printeri.LeftAlign(),
            printeri.PrintLine(Properties.Settings.Default.company),
            printeri.PrintLine(Properties.Settings.Default.row2),
            printeri.PrintLine(Properties.Settings.Default.row3),
            printeri.SetStyles(PrintStyle.Underline),
            printeri.PrintLine("Konvertimi i monedhes"),
            printeri.SetStyles(PrintStyle.None),
            printeri.PrintLine(""),
            printeri.LeftAlign(),
            printeri.PrintLine("Fatura Nr.: " + paddednumber +"       " + koha),
            printeri.SetStyles(PrintStyle.FontB),
            printeri.PrintLine("----------------------------------------------------------------"),
            printeri.Print2DCode(TwoDimensionCodeType.PDF417, "Fatura " + paddednumber + ": " + koha + ", " + input + " " + currencyfrom + " = " + converted + " " + currencyto, Size2DCode.SMALL),
            printeri.PrintLine("----------------------------------------------------------------"),
            printeri.SetStyles(PrintStyle.None),
            printeri.LeftAlign(),
            printeri.PrintLine("JU KENI KONVERTUAR " + input + " " + currencyfrom),
            printeri.PrintLine("KENI MARRE         " + converted + " " + currencyto),
            printeri.PrintLine("KURSI ESHTE: 1 " + currencyfrom + " = " + Math.Round(Convert.ToDecimal(converted) / input, 3) + " " + currencyto),
            printeri.PrintLine(""),
            printeri.FullCutAfterFeed(5),
};
    }
}
