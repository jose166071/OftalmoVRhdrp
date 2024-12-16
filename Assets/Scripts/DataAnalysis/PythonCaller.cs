using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Python.Runtime;
using System;
using System.Threading;
using System.Diagnostics;
using UnityEngine.SceneManagement;
public class PythonCaller : MonoBehaviour
{

    [SerializeField] GameEvent OnAnalysisDone;
    static public void RunScript()
    {
        var p = new Process()
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "python",
                WorkingDirectory = @"C:\Users\biomedica\Documents\Jose Rosales\OftalmoVR\Assets\Scripts\DataAnalysis",
                Arguments = "DAP.py"
            }
        };

        p.Start();
        
        /*Runtime.PythonDLL = @"C:\Users\biomedica\AppData\Local\Programs\Python\Python39\python39.dll";
        PythonEngine.Initialize();


        Thread pythonThread = new Thread(() =>
        {
            try
            {
                using (Py.GIL())
                {
                    dynamic sys = Py.Import("sys");
                    sys.path.append(@"C:\Users\biomedica\Documents\Jose Rosales\OftalmoVR\Assets\Scripts\DataAnalysis");

                    var pythonScript = Py.Import("DAP");
                    var result = pythonScript.InvokeMethod("RunScript");

                    Debug.Log(result);
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"Python error: {e.Message}");
            }
            finally
            {
                PythonEngine.Shutdown();
            }
        });

        pythonThread.Start();*/
        /*if (!PythonEngine.IsInitialized)
        {
            PythonEngine.Initialize();
        }
        */

        /*
        Thread pythonThread = new Thread(() =>
        {
            try
            {
                using (Py.GIL())
                {
                    dynamic sys = Py.Import("sys");
                    sys.path.append(@"C:\Users\biomedica\Documents\Jose Rosales\OftalmoVR\Assets\Scripts\DataAnalysis");

                    var pythonScript = Py.Import("DAP");
                    var result = pythonScript.InvokeMethod("RunScript");

                    Debug.Log(result);
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"Python error: {e.Message}");
            }
            finally
            {
                PythonEngine.Shutdown();
            }
        });

        pythonThread.Start();

        /*Runtime.PythonDLL = @"C:\Users\biomedica\AppData\Local\Programs\Python\Python39\python39.dll";
        PythonEngine.Initialize();
        

        using (Py.GIL())
        {
            dynamic sys = Py.Import("sys");
            sys.path.append(@"C:\Users\biomedica\Documents\Jose Rosales\OftalmoVR\Assets\Scripts\DataAnalysis");
            var pythonScript = Py.Import("DAP");

            var result = pythonScript.InvokeMethod("RunScript");
                    
            Debug.Log(result);
        }*/
    }

    public void ChangeScene(Component sender, object data)
    {
        OnAnalysisDone.Raise(sender, data); 
        SceneManager.LoadScene(0);
    }
}