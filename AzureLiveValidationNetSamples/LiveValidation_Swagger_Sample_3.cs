using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.IO;
using System.Reflection;

namespace AzureLiveValidationNetSamples
{
    class LiveValidation_Swagger_Sample_3
    {
        static void Main(string[] args)
        {
            string live_request_headers_text = System.IO.File.ReadAllText(@".\Resources\live_request_headers.txt");
            object live_request_headers = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(live_request_headers_text);
            string live_request_body_text = System.IO.File.ReadAllText(@".\Resources\live_request_body.txt");
            object live_request_body = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(live_request_body_text);

            string live_response_headers_text = System.IO.File.ReadAllText(@".\Resources\live_response_headers.txt");
            object live_response_headers = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(live_response_headers_text);
            string live_response_body_text = System.IO.File.ReadAllText(@".\Resources\live_response_body.txt");
            object live_response_body = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(live_response_body_text);

            LiveRequest liveRequest = new LiveRequest(
                "PUT",
                "/subscriptions/4d368445-cbb1-42a7-97a6-6850ab99f48e/resourceGroups/pslibtest9279/providers/Microsoft.Compute/virtualMachines/vm1827?api-version=2017-12-01",
                live_request_body,
                live_request_headers
            );

            LiveResponse liveResponse = new LiveResponse(
                "403",
                live_response_headers,
                live_response_body
            );

            LiveValidationParameter liveValidationParameter = new LiveValidationParameter(
                liveRequest,
                liveResponse
            );

            var apiInstance = new LiveValidationApi();

            try
            {
                LiveValidationResponse liveValidationResponse = apiInstance.ToolsLiveValidationValidate(liveValidationParameter);
                Console.WriteLine(liveValidationResponse);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiveValidationApi.ToolsLiveValidationProdValidate: " + e.Message);
            }
        }
    }
}
