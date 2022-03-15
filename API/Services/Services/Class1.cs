using System;
using Newtonsoft.Json;
using RestSharp;
using Services.Models;
using Services.Services;

namespace Services
{
    public class Class1 : IClass1
    {

        public dynamic AccountSuspensionMethod(UserResource UserLoginResource)
        {
            try
            {
                dynamic result = null;
                var client = new RestClient("https://localhost:44362/api/Values/SignUp");
                var restRequest = new RestRequest(Method.POST);
                restRequest.AddJsonBody(UserLoginResource);

                IRestResponse restResponse = client.Execute(restRequest);


                if (restResponse.StatusCode != System.Net.HttpStatusCode.Created)
                {
                     result = JsonConvert.DeserializeObject<ExceptionService>(restResponse.Content);
                    throw new InvalidOperationException(result.ExceptionMessage);
                }

                result = JsonConvert.DeserializeObject<UserResource>(restResponse.Content);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public dynamic AccountSuspensionMethod2(ResourceLogin ResourceLogin)
        {
            try
            {
                dynamic result = null;
                var client = new RestClient("https://localhost:44362/api/Values/SignIn");
                var restRequest = new RestRequest(Method.POST);
                restRequest.AddJsonBody(ResourceLogin);

                IRestResponse restResponse = client.Execute(restRequest);


                if (restResponse.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    result = restResponse.StatusCode;
                    return result;
                }
              
                result = JsonConvert.DeserializeObject<ResponseLogin>(restResponse.Content);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
