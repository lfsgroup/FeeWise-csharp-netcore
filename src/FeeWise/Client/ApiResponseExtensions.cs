using System;
using System.Collections.Generic;
using System.Text;

namespace FeeWise.Client
{
    public partial class ApiResponse<T>
    {
        /// <summary>
        /// Indicates whether this response is a success status code
        /// </summary>
        public bool IsSuccessStatusCode => (int)StatusCode >= 200 && (int)StatusCode <= 299;
    }
}
