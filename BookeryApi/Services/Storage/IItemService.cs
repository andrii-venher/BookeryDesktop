﻿using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.Models;

namespace BookeryApi.Services.Storage
{
    public interface IItemService
    {
        Task<List<Item>> GetSubItems(string path);
        Task<Item> CreateDirectory(string path);
        Task<Item> UploadFile(string path, MultipartFormDataContent content);
        Task<Stream> DownloadFile(string path);
        void SetBearerToken(string accessToken);
    }
}