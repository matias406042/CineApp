﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFrontEnd.Http
{
    class  Cliente
    {

        private static Cliente instancia;
        private HttpClient client;
        private Cliente()
        {
            client = new HttpClient();
        }
        public static Cliente GetInstance()
        {
            if (instancia == null)
                instancia = new Cliente();
            return instancia;
        }
        
        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                var errorDetails = await result.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {errorDetails}");
            }
            return content;
        }
        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await client.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                var errorDetails = await result.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {errorDetails}");
            }
            return response;
        }
        public async Task<string> PutAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PutAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                var errorDetails = await result.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {errorDetails}");
            }
            return response;
        }

        public async Task<string> DeleteAsync(string url)
        {
            var result = await client.DeleteAsync(url);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            if (!result.IsSuccessStatusCode)
            {
                var errorDetails = await result.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {errorDetails}");
            }
            return response;

        }
        public async Task<string> PostAsync(string urlPost)
        {
            //StringContent content = new StringContent(dataJson, Encoding.UTF8, "application/json");

            HttpResponseMessage responseHTTP = await client.PostAsync(urlPost, null);
            var response = "";
            if (responseHTTP.IsSuccessStatusCode)
            {
                response = await responseHTTP.Content.ReadAsStringAsync();
            }
            return response;
        }
    }
}

