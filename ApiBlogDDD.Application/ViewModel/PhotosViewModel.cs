using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.ViewModels
{
    public class PhotosViewModel
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnaiilUrl { get; set; }
    }
}
