using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace GarantsBack.Service
{
    public class SaveFileService : ISaveFileService
    {
        private readonly string _path;
        private readonly IWebHostEnvironment _appEnvironment;

            
        public SaveFileService(IConfiguration iConfig, IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
            _path = iConfig.GetSection("FilePath").Value;
        }
        public async Task<List<FileModel>> SaveFile(IFormCollection files)
        {
            if (files == null) return null;
            var list = new List<FileModel>();
            
            foreach (var formFile in files.Files)
            {
                
                var orderId = formFile.FileName[..formFile.FileName.IndexOf("order", StringComparison.Ordinal)];
                var name = formFile.FileName[(formFile.FileName.IndexOf("order", StringComparison.Ordinal)+5)..];
                
                // путь к папке с айди заявки
                var path = _appEnvironment.WebRootPath + _path + orderId;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                // сохраняем файл в папку с айди заявки
                await using var fileStream = new FileStream(path + '/' + name, FileMode.Create);
                await formFile.CopyToAsync(fileStream);
                
                list.Add(new FileModel
                {
                    Name = name,
                    Path = path + '/' + name,
                    OrderId = orderId
                });
            }

            return list;
        }
    }
}