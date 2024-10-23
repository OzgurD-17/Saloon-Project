/****************************************************************************
**					      SAKARYA ÜNÝVERSÝTESÝ
**				 BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				      BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					     2023-2024 BAHAR DÖNEMÝ
**
**
**
**		  ÖDEV NUMARASI.........:  Proje              Tarih..: 19.05.2024
**		  ÖÐRENCÝ ADI...........:  Özgür Demir
**		  ÖÐRENCÝ NUMARASI......:  B221210017
**        DERSÝN ALINDIÐI GRUP..:  C
**
**
**
*****************************************************************************/


namespace C_ProjeDeneme1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}