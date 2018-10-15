using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace AzureLiveValidationNetSamples
{
    class LiveValidation_Swagger_Sample_1
    {
        static void Main(string[] args)
        {
            var apiInstance = new LiveValidationApi();
            //var liveValidationParameter = new LiveValidationParameter();

            try
            {
                LiveValidationWhiteListResponse whiteListResponse = apiInstance.ToolsLiveValidationWhiteList();
                Console.WriteLine(whiteListResponse);

                //LiveValidationResponse result = apiInstance.ToolsLiveValidationProdValidate(liveValidationParameter);
                //Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiveValidationApi.ToolsLiveValidationProdValidate: " + e.Message);
            }
        }
    }
}
