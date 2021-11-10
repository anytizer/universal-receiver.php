public string upload(string html_name, string local_guid, string filename)
{
	string remote = new Config().ReceiverGateway();

	RestClient cient = new RestClient(remote);
	RestRequest request = new RestRequest("/receive.php");
	request.RequestFormat = DataFormat.Json;
	request.Method = Method.POST;
	request.AddHeader("Authorization", "Authorization");
	request.AddHeader("Content-Type", "multipart/form-data");
	request.AddFile(html_name, filename);
	request.AddParameter("guid", local_guid);
	request.AddParameter("type", html_name);

	IRestResponse response = cient.Execute(request);

	string remote_guid = "error";
	if(response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		remote_guid = response.Content;
	}

	return remote_guid; // remote guid
}
