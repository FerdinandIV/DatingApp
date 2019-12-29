using Microsoft.AspNetCore.Http;

namespace DatingApp.API.helpers
{
    /* static means that we dont want to create a new instance of extensions when we 
    want to use one of its methods*/
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse respons, string message)
        {
            /* in event of exception a new header will be created -> Application-Error 
            with the error message as its value*/
            respons.Headers.Add("Application-Error", message);
            //below headers is to allow above message to be dispalyed
            respons.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            respons.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}