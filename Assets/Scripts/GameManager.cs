using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
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
        lista[0].transform.parent.gameObject.SetActive(true);
        for (int i = 0; i < lista.Count; i++)
        {
            var rand = Random.Range(1, lista.Count);
            //Debug.Log(rand);
            lista[rand].gameObject.SetActive(true);
            StartCoroutine(Rest(lista[rand].gameObject));
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
}
