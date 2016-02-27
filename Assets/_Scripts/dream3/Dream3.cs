using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dream3 : MonoBehaviour
{

    public GameObject delButtonPrefab;
    private Graphic background;
    private float totalDreamTime, remainingDreamTime;

    private GameObject dream3;
    private int dupCount;

    // Use this for initialization
    void Start()
    {
        dupCount = 0;
        totalDreamTime = 15f;
        remainingDreamTime = totalDreamTime;
        dream3 = GameObject.Find("Dream3");
        background = dream3.transform.FindChild("D3 Background").GetComponent<Graphic>();
        background.CrossFadeColor(new Color(0f, 0f, 0f, 1f), totalDreamTime, false, false);
        initDeleteButton();
    }

    void Update()
    {
        remainingDreamTime -= Time.deltaTime;

        if (remainingDreamTime < 0f)
        {
            wakeUp();
        }
    }

    void instantiateDeleteButton()
    {
        GameObject paperBall = PrefabUtils.LoadPrefab(dream3.transform, delButtonPrefab);

        Delete paperballComp = paperBall.GetComponent<Delete>();
        paperballComp.onDuplicate = () =>
        {
            Shake camShake = dream3.GetComponent<Shake>();
            if (!camShake.Shaking)
            {
                camShake.DoShake();
            }

            dupCount++;

            if (dupCount == 10)
            {
                wakeUp();
                return;
            }
            initDeleteButton();
        };

        paperBall.transform.localPosition = new Vector3(-Screen.width * .3f + Random.value * Screen.width * .6f,
            -Screen.height * .3f + Random.value * Screen.height * .6f, 0f);

        Graphic graphic = paperBall.GetComponent<Graphic>();
        float rgb = remainingDreamTime / totalDreamTime;
        graphic.color = new Color(rgb, rgb, rgb, 1f);
        graphic.CrossFadeAlpha(0f, 0f, false);
        graphic.CrossFadeAlpha(1f, Random.value * 0.25f, false);
      
    }

    void initDeleteButton()
    {
        if (Random.value > 0.5f)
        {
            instantiateDeleteButton();
        }
        instantiateDeleteButton();
    }

    void wakeUp()
    {
        if (!PrefabUtils.IS_DREAM_5)
        {
            SceneManager.LoadScene("transition");
        }
    }
}
