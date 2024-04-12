# azure-key-vault

Step1: Create App Registration

![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/b9f70370-3d7e-4fc2-8609-5afe9c7a8d91)

Step2: Go to API Permission, Click on "+ Add a permission", Select Azure Key Vault

![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/8ef052ca-57ec-47fc-99a3-92c09e2fe856)

Step3: Select Delegated permissions and check user_impersonation

![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/faf29bf6-fdd4-435b-8110-bcef11412c4a)

Step4: Click on "Grant admin consent for Default Directory"

![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/415ad038-0ba6-4292-9207-a7a373d166e9)

![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/eee7c253-a519-49c3-af4e-0799c82d12ac)

Step5: Create Client Secret

![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/0d5ebd74-79c4-45de-993b-b8e022a5d437)

This Secret will be used in C# for retrieve Key Vault Value
![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/36916480-57a7-48c0-9567-9a768904cdb7)

Step6: Create Key Vault

![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/69c2de2a-b932-47cb-8e95-500c4c0bccdd)

Select "Vault Access Policy" as Permission Model
![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/5e6e01c5-3d6d-4179-9b6a-7695f668c920)

Click next, next and Create. Once deployment is completed click on "Go to Resource"
![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/ecbdd7e3-5baa-4403-b402-e180eb378c2c)

Step7: Click on Access Policies and Create
![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/a327ed12-5181-49e2-a232-12760aaf410b)

Select "Key & Secret Management"
![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/c24dba93-887c-40b1-9f5d-d4c6c0cb4b7a)

Select App Registration(AppRegistration for Key Vault) which is created in Step1
![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/32bfa783-0f92-4710-9755-b5348f064f01)

Click Next and Create Key Vault
![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/8d0ee588-e15c-4121-8b39-6e6f35f72dd9)

Step8: Create Secret for Key Vault
![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/90acfe78-d343-468c-8727-e424d9fac604)

![image](https://github.com/hardikv-github/azure-key-vault/assets/56589683/b15a10d4-6a9b-4aef-91cb-5fda83b46347)










