using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using Tesseract;

namespace WebDemo.Views
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        #region PageEvents

        protected void SubmitFile_Click(object sender, EventArgs e)
        {
            if (ImageFile.PostedFile != null && ImageFile.PostedFile.ContentLength > 0)
            {
                //
                //Image.FromStream(ImageFile.PostedFile.InputStream);
                //Bitmap.FromStream(ImageFile.PostedFile.InputStream);
                using (var engine = new TesseractEngine(Server.MapPath(@"~/tessdata"), "ara", EngineMode.Default))
                {
                    using (var image = new Bitmap(ImageFile.PostedFile.InputStream))
                    {
                        using (var pix = PixConverter.ToPix(image))
                        {
                            using (var page = engine.Process(pix))
                            {
                                // GetOcrText ....
                                //ResultText.Text = page.GetText();
                                ResultText.InnerText = page.GetText();
                                // Confidence `%`.
                                ConfidenceLabel.Text = string.Format("{0:P}", page.GetMeanConfidence());

                            }// Dispose


                        } // Dispose


                    } // Dispose


                }// Dispose

                inputPanel.Visible = false;
                resultPanel.Visible = true;
            }
        }

        #endregion

        protected void ReSubmitFile_Click(object sender, EventArgs e)
        {
            inputPanel.Visible = true;
            resultPanel.Visible = false;
        }
    }
}