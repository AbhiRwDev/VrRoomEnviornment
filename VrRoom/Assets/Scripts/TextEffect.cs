using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class TextEffect : MonoBehaviour
{
    public string TextToshow;
    public float typespeed = 5;
    bool writing = false;
    public GameObject NextActive;
    // Start is called before the first frame update
    void Start()
    {
        TextToshow = GetComponent<TextMeshProUGUI>().text;
        GetComponent<TextMeshProUGUI>().text = "";
        StartCoroutine(WriteText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator WriteText()
    {
        foreach (var item in TextToshow)
        {
            GetComponent<TextMeshProUGUI>().text += item;
            yield return new WaitForSeconds(typespeed);
            
            
        }
        yield return new WaitForSeconds(2);
        if (NextActive != null)
        {
            NextActive.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
