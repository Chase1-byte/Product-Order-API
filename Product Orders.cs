var client = new RestClient("https://adac.leading2lean.com/api/1.0/productorders/sync_order/?auth=S69ZoQRFyVrlRHW7b410KSRlZ8ZFqD7W");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AlwaysMultipartFormData = true;
request.AddParameter("site", "2");
request.AddParameter("productcode", "4603-5000.101");
request.AddParameter("name", "8028151");
request.AddParameter("description", "U55x LH Paak");
request.AddParameter("status", "scheduled");
request.AddParameter("order_quantity", "4752");
request.AddParameter("product_order_group_id", "30");
request.AddParameter("planned_ratio", "2");
request.AddParameter("actual_ratio", "2");
request.AddParameter("externalid", "8028151");
request.AddParameter("linecode", "10215");
IRestResponse response = client.Execute(request);
object p = Console.WriteLine(response.Content);

private interface IRestResponse
{
}