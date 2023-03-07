using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float delay = 10.0f;
    

    public void invokeVideo()
    {
        Debug.Log("test1");
        //Invoke("autoScene", 1.0f);
        StartCoroutine(autoScene());
    
        Debug.Log("test2");
    }

    IEnumerator autoScene()
    {
        Debug.Log("test3");
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("EndScene");
    }
    
              
    
}
