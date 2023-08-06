using BitMiracle.Docotic.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace SearchablePDF
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            BitMiracle.Docotic.LicenseManager.AddLicenseData("4N7N9-JTDT7-GII7F-HJ62K-FHL85");

            var docuentFileName = FilePathLabel.Text;
            PageConfidenceListBox.Items.Clear();
            if (Path.GetExtension(docuentFileName).ToLower().Equals(".pdf"))
            {
                using (var pdf = new PdfDocument(docuentFileName))
                {
                    using (var engine = new TesseractEngine($@"{AppDomain.CurrentDomain.BaseDirectory}\tessdata\", "ara", EngineMode.Default))
                    {
                        Parallel.For(0, pdf.PageCount,
                   i =>
                   {
                       lock (pdf)
                       {
                           lock (engine)
                           {
                               PdfPage page = pdf.Pages[i];
                               string searchableText = page.GetText();

                               // Simple check if the page contains searchable text.
                               // We do not need to perform OCR in that case.
                               if (!string.IsNullOrEmpty(searchableText.Trim()))
                               {
                                   return;
                               }

                               // This page is not searchable.
                               // Save the page as a high-resolution image
                               PdfDrawOptions options = PdfDrawOptions.Create();
                               options.BackgroundColor = new PdfRgbColor(255, 255, 255);
                               options.HorizontalResolution = 300;
                               options.VerticalResolution = 300;

                               string pageImage = $"page_{i}.png";
                               page.Save(pageImage, options);

                               // Perform OCR
                               using (Pix img = Pix.LoadFromFile(pageImage))
                               {
                                   using (Page recognizedPage = engine.Process(img))
                                   {
                                       string recognizedText = recognizedPage.GetText();
                                       using (var writer = new StreamWriter($@"{Path.GetDirectoryName(docuentFileName)}\page_{i}.txt"))
                                           writer.Write(recognizedText.ToString());

                                   }
                               }

                               File.Delete(pageImage);


                           }
                       }
                   });
                    }
                }
            }

        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (SelectPdfFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = SelectPdfFileDialog.FileName;
                FilePathLabel.Text = filePath;
            }
            else
            {
                FilePathLabel.Text = string.Empty;
            }

        }


    }
}


/*
  //for (int i = 0; i < pdf.PageCount; ++i)
                        //{
                        //    if (documentText.Length > 0)
                        //        documentText.Append("\r\n\r\n");

                        //    PdfPage page = pdf.Pages[i];
                        //    string searchableText = page.GetText();

                        //    // Simple check if the page contains searchable text.
                        //    // We do not need to perform OCR in that case.
                        //    if (!string.IsNullOrEmpty(searchableText.Trim()))
                        //    {
                        //        documentText.Append(searchableText);
                        //        PageConfidenceListBox.Items.Add($"Text Page #{i}");
                        //        continue;
                        //    }

                        //    // This page is not searchable.
                        //    // Save the page as a high-resolution image
                        //    PdfDrawOptions options = PdfDrawOptions.Create();
                        //    options.BackgroundColor = new PdfRgbColor(255, 255, 255);
                        //    options.HorizontalResolution = 300;
                        //    options.VerticalResolution = 300;

                        //    string pageImage = $"page_{i}.png";
                        //    page.Save(pageImage, options);

                        //    // Perform OCR
                        //    using (Pix img = Pix.LoadFromFile(pageImage))
                        //    {
                        //        using (Page recognizedPage = engine.Process(img))
                        //        {

                        //            PageConfidenceListBox.Items.Add($"Mean confidence for page #{i}: {recognizedPage.GetMeanConfidence():P}");
                        //            string recognizedText = recognizedPage.GetText();
                        //            documentText.Append(recognizedText);
                        //        }
                        //    }

                        //    File.Delete(pageImage);

                        //    using (var writer = new StreamWriter($@"{Path.GetDirectoryName(docuentFileName)}\page_{i}.txt"))
                        //        writer.Write(documentText.ToString());
                        //}
 */