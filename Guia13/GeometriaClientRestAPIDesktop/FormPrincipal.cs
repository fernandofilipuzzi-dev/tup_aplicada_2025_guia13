using GeometriaRestAPIWeb.DTOs;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace GeometriaClientRestAPIDesktop;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }

    async private void btnConsulta_Click(object sender, EventArgs e)
    {
        try
        {
            string url = "https://localhost:7257/api/Geometrias2";

            using var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };

            var response = await client.SendAsync(request);

            listBox1.Items.Clear();
            if (response.IsSuccessStatusCode)
            {
                var lista = response.Content.ReadFromJsonAsync<List<FiguraDTO>>();
                listBox1.DataSource = lista.Result;
            }
        } 
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
