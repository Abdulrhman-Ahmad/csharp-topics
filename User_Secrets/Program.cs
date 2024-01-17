/*
 * - What is the purpose of using user-secrets
 *          - is to kep sensitive informatino, suah as API keys, connection strings, or other private configuration settings
 *          - Seperate from your source code and project files 
 *          - this is particularly important when workingon a team or sharing code in a version-controlled environment
 * 
 * Install these two packages to use configuration also to access secrets list 
 *          - Include="Microsoft.Extensions.Configuration" Version="5
 *          - Include="Microsoft.Extensions.Configuration.UserSecrets 
 *          
 * - To Start
 *      - Set Secret
 *          - dotnet user-secrets set "
 *   [ init, set, clear, list, remove ] 
 * - dotnet user-secrets init                               // will generate UserSecretsId => ff538252-b285-47a0-a006-466ee4e16984
 * - dotnet user-secrets set "SecretName" "SecretValue"     // will save the secret with the specified name in the project file
 * - dotnet user-secrets list                               // Show all the secrets
 */
using Microsoft.Extensions.Configuration;

namespace User_Secrets
{
    class Program
    {
        static void Main()
        {
            var builder = new ConfigurationBuilder().AddUserSecrets<Program>();

            IConfigurationRoot configuration = builder.Build();

            // I've created a user secret and named id 'MySecret'
            string secretKey = configuration["MySecret"];

            Console.WriteLine(secretKey);
        }
    }
}