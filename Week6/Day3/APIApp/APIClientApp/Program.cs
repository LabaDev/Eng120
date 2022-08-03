using RestSharp;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace APIClientApp
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //Encapsulate the info we need to make the api call
            //We can make autheneticated HTTP requests
            var restClient = new RestClient("https://api.postcodes.io/");
            
            //Set up the request. Create a request object
            var restRequest = new RestRequest();
            //Default value
            restRequest.Method = Method.Get;
            restRequest.AddHeader("Content-Type", "application/json");

            var postCode = "EC2Y 5AS";
            //Setting up request
            restRequest.Resource = $"postcodes/{postCode.ToLower().Replace(" ", "")}/";

            //Execute our request
            var singlePostcodeResponse = await restClient.ExecuteAsync(restRequest);
            //Console.WriteLine("Response content (string)");
            //Console.WriteLine(singlePostCodeResponse.Content);
            //Console.WriteLine("Response code");
            //Console.WriteLine((int)singlePostCodeResponse.StatusCode + " - " + singlePostCodeResponse.StatusCode);
            //Console.WriteLine("Headers");
            //foreach (var item in singlePostCodeResponse.Headers)
            //    Console.WriteLine(item);


            var responseContentType = singlePostcodeResponse.Headers.Where(x => x.Name == "Date")
                .Select(h => h.Value.ToString()).FirstOrDefault();
            Console.WriteLine(responseContentType);

            var client = new RestClient();
            var request = new RestRequest("https://api.postcodes.io/postcodes", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody("{\r\n\"postcodes\" : [\"OX49 5NU\", \"M32 0JG\", \"NE30 1DP\"]\r\n}\r\n", DataFormat.Json);
            var postCodes = new
            {
                Postcodes = new string[] {"SA1 8EP", "SA2 8PP", "PR3 0SG", "M45 6GN", "EX16 5BL"}
            };
            request.AddJsonBody(postCodes);
            RestResponse bulkPostcodeResponse = client.Execute(request);
            //Console.WriteLine(bulkPostcodeResponse.Content);

            var singlePostcodeJsonResponse = JObject.Parse(singlePostcodeResponse.Content);
            //Console.WriteLine(singlePostCodeResponse);
            //var adminDistrict = singlePostcodeJsonResponse["result"]["admin_district"];
            //Console.WriteLine(adminDistrict);

            //Repeat with bulk postcode response
            //Get info out JObject 

            //var bulkPostcodeJsonResponse = JObject.Parse(bulkPostcodeResponse.Content);
            ////Console.WriteLine(bulkPostcodeJsonResponse);
            //var bulkResponseResult = bulkPostcodeJsonResponse["result"];
            //foreach (var el in bulkResponseResult)
            //{
            //    Console.WriteLine(el["result"]["admin_district"]);
            //}

            //Console.WriteLine(bulkPostcodeJsonResponse["result"][1]["result"]["codes"]["admin_county"]);

            var singlePostcodeObjectResponse = JsonConvert.DeserializeObject<SinglePostcodeResponse>(singlePostcodeResponse.Content);
            var bulkPostcodeObjectResponse = JsonConvert.DeserializeObject<BulkPostcodeResponse>(bulkPostcodeResponse.Content);

            Console.WriteLine("Bulk postcode response:\n");
            foreach(var p in bulkPostcodeObjectResponse.result)
            {
                Console.WriteLine(p.query);
                Console.WriteLine($"{p.result.admin_ward}\n");
            }
            //var selectedAdminCounty = bulkPostcodeObjectResponse.result.Where(q => q.query == "PR3 0SG")
            //    .FirstOrDefault().result.codes.admin_county;

            var selectedAdminCountyAlt = bulkPostcodeObjectResponse.result[0].result.codes.admin_county;
        }
    }
}