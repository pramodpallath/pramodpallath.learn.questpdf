
using pramodpallath.learn.questpdf.samples;

namespace pramodpallath.learn.questpdf.ui.winforms
{
    public partial class frmPDFGenerator : Form
    {
        List<IPDFGenerator> pdfGenerators = new List<IPDFGenerator>();

        public frmPDFGenerator()
        {
            InitializeComponent();
            registerPDFGenerators();
            lstBxActions.SelectedValueChanged += LstBxActions_SelectedValueChanged;
            lstBxActions.DataSource = pdfGenerators;
        }

        private async void LstBxActions_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (lstBxActions.SelectedItem != null)
            {
                IPDFGenerator selectedGenerator = (IPDFGenerator)lstBxActions.SelectedItem;
                lblSelectedGeneratorName.Text = selectedGenerator.GeneratorName;
                try
                {
                    string fileName = selectedGenerator.Generate();
                    string pdfFilePath = Path.Combine(Application.StartupPath, fileName);
                    await webView21.EnsureCoreWebView2Async();
                    webView21.Source = new Uri(pdfFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblSelectedGeneratorName.Text = string.Empty;
            }
        }

        private void registerPDFGenerators()
        {
            pdfGenerators.Add(new HelloWorldPDFGenerator());
            pdfGenerators.Add(new HeaderFooterPDFGenerator());
            pdfGenerators.Add(new MultipleOrientationPDFGenerator());
        }
    }
}
