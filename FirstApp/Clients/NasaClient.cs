using System.Net.Http.Json;

using FirstApp.Models;

namespace FirstApp.Clients;
public class NasaClient{

private readonly HttpClient _client;

public NasaClient(HttpClient client){
    _client = client;
}

public async Task<NasaResponse> getNasa(string date){
    var url = "https://api.nasa.gov/planetary/apod?api_key=yUeGvLlZJcUwN89d0XVPWsnLVXJ2cby3D6cuUJhJ";
    if(date != null){
        url = url + "&date=" + date;
    }
    return await _client.GetFromJsonAsync<NasaResponse>(url);
}

}