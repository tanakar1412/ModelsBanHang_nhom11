﻿using API.Models.DTO;
using BlazorAdmin.Service.IService;
using System.Net.Http.Json;

namespace BlazorAdmin.Service
{
    public class ThongBaoService : IThongBaoService
    {
        private readonly HttpClient _http;

        public ThongBaoService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<ThongBaoDTO>> GetThongBaoMoiAsync()
        {
            return await _http.GetFromJsonAsync<List<ThongBaoDTO>>("api/ThongBao/moi");
        }
    }
}
