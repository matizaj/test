using System;

namespace RepositoryUsage.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string TestProp1 { get; set; }
        public string AppModelClassBranch { get; set; }
        public string Master { get; set; }
        public int AnotjeAoo { get; set; }
        public int AppProp { get; set; }

    }
}