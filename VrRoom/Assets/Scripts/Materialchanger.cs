using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Materialchanger : MonoBehaviour
{
    public float value,intensity;
    public Material material;
    bool ChangeScene=false;
    public Color col,NewCol,tempcolor;
    private void Start()
    {
       
        intensity = 1;
       
        col = material.GetColor("_LetterEmissionColor");
        tempcolor = col;
      //  StartCoroutine(changeScene());

    }
    private void Update()
    {
       intensity= Mathf.Lerp(intensity,100,Time.deltaTime*value/100);
        NewCol = NewCol * intensity;
        col = Color.Lerp(col, NewCol, Time.deltaTime * value);
        material.SetColor("_LetterEmissionColor",col );
        if(intensity>=1.09&&!ChangeScene)
        {
            ChangeScene = true;
            StartCoroutine(changeScene());
            
        }
        
    }
    IEnumerator changeScene()
    {
     //  yield return new WaitForSeconds(5);
        
        SceneManager.LoadScene("Room");
        //material.SetColor("_LetterEmissionColor", tempcolor);
        return null;
    }
}
