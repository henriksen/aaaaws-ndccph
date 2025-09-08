using Microsoft.Identity.Client;

var app = PublicClientApplicationBuilder.Create("ef3a0a7a-5e7a-403a-bdef-f07b98a74ae9")
    .WithAuthority(AzureCloudInstance.AzurePublic, "a1c5bee8-9e19-44cb-9f07-b94b279890ab")
    .Build();

var result = await app.AcquireTokenWithDeviceCode(new[] { "User.Read.All" }, deviceCodeResult =>
    {
        Console.WriteLine(deviceCodeResult.Message);
        return Task.CompletedTask;
    }).ExecuteAsync();

Console.WriteLine("Access Token: " + result.AccessToken);