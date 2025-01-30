using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using System.IO;
using System.Threading;

public class UploadTest : MonoBehaviour
{
    
private static string[] Scopes = { DriveService.Scope.DriveFile };
    private static string ApplicationName = "Unity Google Drive API";

    private DriveService service;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Authenticate();
        }
    }

    public void Authenticate()
    {
        UserCredential credential;

        // Ruta al archivo credentials.json descargado desde Google Cloud Console.
        string credentialsPath = Path.Combine(Application.dataPath, "credentials.json");

        using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
        {
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.FromStream(stream).Secrets,
                Scopes,
                "user",
                CancellationToken.None).Result;
        }

        // Crear el servicio de Google Drive.
        service = new DriveService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = ApplicationName,
        });

        Debug.Log("Autenticación completada.");

        UploadTestFile();
    }

    void UploadTestFile()
    {
        if (service == null)
        {
            Debug.LogError("El servicio de Google Drive no está autenticado.");
            return;
        }

        string filePath = Application.dataPath + "/Scripts/DataAnalysis/Report21 ene 2025.pdf";
        //string filePath = Path.Combine(Application.dataPath, "test.txt");
        //File.WriteAllText(filePath, "Este es un archivo de prueba.");
        var fileMetadata = new Google.Apis.Drive.v3.Data.File()
        {
            Name = "report21ENE.pdf"
            
        };
        using (var stream = new FileStream(filePath, FileMode.Open))
        {
            var request = service.Files.Create(fileMetadata, stream, "text/pdf");
            request.Fields = "id";
            request.Upload();

            Debug.Log($"Archivo subido con éxito. ID: {request.ResponseBody.Id}");
        }
    }
}
