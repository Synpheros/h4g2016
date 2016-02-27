using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MiniGame1Logic : MonoBehaviour
{

    private Transform canvasTransform;

    void Start()
    {
        canvasTransform = GameObject.Find("Canvas").transform;

    }

    void Update()
    {
        if (canvasTransform.childCount == 1)
        {
            EndDream();
        }
    }

    private void EndDream()
    {
        if (!PrefabUtils.IS_DREAM_5)
        {
            SceneManager.LoadScene("transition");
        }
    }
}
