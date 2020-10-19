﻿using Microsoft.OpenApi.Models;

namespace WideWorldImporters.API
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}