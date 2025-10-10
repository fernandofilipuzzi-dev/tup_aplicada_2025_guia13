using GeometriaAPIModels.Models;
using System.Net.Http.Json;

namespace GeometriaClientAPIWeb;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }


    async private void btnActualizar_Click(object sender, EventArgs e)
    {
        try
        {
            string url = "https://localhost:8082/api/Figuras";

            #region preparando el request
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            #endregion

            #region enviando el request y recibiendo el response
            using HttpClient client = new HttpClient();
            var response = await client.SendAsync(request);
            #endregion

            #region evaluando el response
            if (response.IsSuccessStatusCode)
            {
                var figuras = await response.Content.ReadFromJsonAsync<List<FiguraDTO>>();

                listBox1.Items.Clear();
                listBox1.Items.AddRange(figuras.ToArray());
            }
            #endregion
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
    }

    async private void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            #region captura de datos
            int tipo = 0;
        double ancho = 0;
        double largo = 0;
        double radio = 0;
        double area = 0;
        if (rbRectangulo.Checked)
        {
            tipo = 1;
            ancho = Convert.ToDouble(tbAncho.Text);
            largo = Convert.ToDouble(tbLargo.Text);
        }
        else if (rbCirculo.Checked)
        {
            tipo = 2;
            largo = Convert.ToDouble(tbRadio.Text);
        }
        
        var figura = new FiguraDTO
        {
            Tipo = tipo,
            Ancho = ancho,
            Largo = largo,
            Radio = radio,
            Area = area
        };
        #endregion

            string url = "https://localhost:8082/api/Figuras";

            #region preparando el request
            var request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = JsonContent.Create(figura)
            };
            #endregion

            #region enviando el request y recibiendo el response
            using HttpClient client = new HttpClient();
            var response = await client.SendAsync(request);
            #endregion

            #region evaluando el response
            if (response.IsSuccessStatusCode)
            {
                var dto=response.Content.ReadFromJsonAsync<FiguraDTO>();
                MessageBox.Show($"Figura creada: {dto.Id}");
            }
            #endregion

            btnActualizar.PerformClick();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
    }
}
