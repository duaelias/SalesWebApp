using System;
namespace SalesWebMvc.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestID => !string.IsNullOrEmpty(RequestId);
    }
}
