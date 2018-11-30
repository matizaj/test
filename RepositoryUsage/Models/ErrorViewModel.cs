using System;

namespace RepositoryUsage.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string TestProp2 { get; set; }
    }
}