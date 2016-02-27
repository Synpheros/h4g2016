using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Dream5 : MonoBehaviour {

    private float totalDreamTime, remainingDreamTime;
    // Use this for initialization
    void Start ()
    {
        totalDreamTime = 15f;
        remainingDreamTime = totalDreamTime;
        PrefabUtils.IS_DREAM_5 = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        remainingDreamTime -= Time.deltaTime;

        if (remainingDreamTime < 0f)
        {
            wakeUp();
        }
    }

    void wakeUp()
    {
        SceneManager.LoadScene("transition");
    }
}
