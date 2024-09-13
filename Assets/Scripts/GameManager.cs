using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Rendering.HighDefinition;
using Unity.VisualScripting;
public class GameManager : MonoBehaviour
{

    [SerializeField] private GameEvent falsePositives;
    [SerializeField] private GameEvent falseNegatives;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartTest(Component sender, object data)
    {
        Debug.Log("Test Starting");
        if (gameObject.TryGetComponent<RandomLigths>(out RandomLigths lista))
        {
            StartCoroutine(Active(lista._ligths));
            //lista._ligths[0].transform.parent.gameObject.SetActive(true);
            //for (int i = 0; i < 50; i++)
            //{
            //    var rand = Random.Range(1, lista._ligths.Count);
            //    Debug.Log(rand);
            //    lista._ligths[rand].gameObject.SetActive(true);
            //    //lista._ligths
            //    //Debug.Log(lista._ligths[rand].gameObject.name);
            //}
        }

    }

    private IEnumerator Active(List<GameObject> lista)
    {
        
        //Active the parent. It could be 30-2, 24-2, or 10-2
        lista[0].transform.parent.gameObject.SetActive(true);

        //Ligths randomly active
        for (int i = 0; i < lista.Count * 10; i++)
        {
            var rand = Random.Range(0, lista.Count);
            //Debug.Log(rand);
            if (lista[rand].TryGetComponent<Luminocity>(out Luminocity luminocity))
            {
                if (luminocity.dbChange < 1f) continue;
                luminocity.CalculateLuminocity();

                if (lista[rand].TryGetComponent<HDAdditionalLightData>(out HDAdditionalLightData light))
                {
                    light.intensity = luminocity.luminocity;
                }

            }


            lista[rand].gameObject.SetActive(true);
            StartCoroutine(Rest(lista[rand].gameObject));
            StartCoroutine(Register(lista[rand].gameObject));
            yield return new WaitForSecondsRealtime(1);


            //float timeOff = 0;s
            //while (timeOff < 100f)
            //{
            //    timeOff += Time.deltaTime;
            //}

            //lista[rand].gameObject.SetActive(false);
            //StartCoroutine(Rest(lista[rand].gameObject));
        }
    }

    private IEnumerator Rest(GameObject ligth)
    {
        
        yield return new WaitForSecondsRealtime(0.2f);
        ligth.SetActive(false);
    }

    private IEnumerator Register(GameObject stimuli)
    {
        float limit = 1f;
        float elapsed = 0f;
        //Debug.Log("Waiting Response");
        if (stimuli.TryGetComponent<Luminocity>(out Luminocity stimul))
        {
            while (elapsed < limit) 
            {
                if (OVRInput.GetDown(OVRInput.RawButton.A))
                {
                    //Debug.Log("Waiting Response 2");
                    Debug.Log(stimuli.activeSelf);
                    if (stimuli.activeSelf)
                    {
                        stimul.maxLumRegistered = stimul.luminocity;
                        Debug.Log("Stimuli Registered");
                    }
                    else
                    {
                        Debug.Log("Failed");
                        stimul.dbChange = stimul.dbChange / 2;
                        stimul.attenuating = !stimul.attenuating;
                    }
                    yield break;
                }
                elapsed += Time.deltaTime;
                yield return null;
            }
            yield break;
        }

        //yield return new WaitForSecondsRealtime(1f);
    }
}
