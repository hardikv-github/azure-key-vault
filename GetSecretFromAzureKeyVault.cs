using System;
using System.Threading.Tasks;
using Azure.Security.KeyVault.Secrets;
using Azure.Identity;

namespace ConsoleAppTrueBlue
{
    static class Program
    {
        static void Main(string[] args)
        {
            SecretResponse secretVal = GetValue().ConfigureAwait(false).GetAwaiter().GetResult();
            Console.WriteLine();
        }

        public static async Task<SecretResponse> GetValue()
        {
            SecretResponse res = new SecretResponse();

            //Vault URI from Key Vault
            string keyVaultUrl = "https://retrieve-demo-key-vault.vault.azure.net/";
            string secretName = "MyFirstSecret";

            // Specify your Azure Active Directory tenant ID, client ID, and client secret
            string tenantId = "890c15f5-67bd-4448-938e-53fb233b359d"; //Directory (tenant) ID
            string clientId = "3d334072-12dd-4da6-b404-836a1d8cc08c"; //Application (client) ID
            string clientSecret = "Mj***~****_B1PIs******Fp******."; //Client secret

            // Create a new secret client using the ClientSecretCredential for authentication
            var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            var secretClient = new SecretClient(new Uri(keyVaultUrl), credential);

            try
            {
                var secret = await secretClient.GetSecretAsync(secretName);
                string secretValue = secret.Value.Value;

                res.IsSuccess = true;
                res.SecretValue = secretValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving secret: {ex.Message}");
                res.IsSuccess = false;
                res.ErrorMessage = ex.Message;
            }
            return res;
        }
    }

    public class SecretResponse
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string SecretValue { get; set; }
    }
}
