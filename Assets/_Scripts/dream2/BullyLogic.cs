using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BullyLogic : MonoBehaviour
{

    public GameObject paperBallPrefab;

    private GameObject dream2;
    private Graphic background;
    private int hitCount;
    private float totalDreamTime, remainingDreamTime;

    // Use this for initialization
    void Start()
    {
        totalDreamTime = 15f;
        remainingDreamTime = totalDreamTime;
        dream2 = GameObject.Find("Dream2");
        background = dream2.transform.FindChild("D2 Background").GetComponent<Graphic>();
        background.CrossFadeColor(new Color(0f, 0f, 0f, 1f), totalDreamTime, false, false);
        dream2.transform.FindChild("D2 Bully").GetComponent<Graphic>().CrossFadeColor(new Color(0f, 0f, 0f, 1f), totalDreamTime, false, false);

        
        hitCount = 0;
        instantiateBall();
    }

    void instantiateBall()
    {
        GameObject paperBall = PrefabUtils.LoadPrefab(dream2.transform, paperBallPrefab);

        PaperBall paperballComp = paperBall.GetComponent<PaperBall>();
        paperballComp.onHitPlayer = () =>
        {
            Shake camShake = dream2.GetComponent<Shake>();
            if (!camShake.Shaking)
            {
                camShake.DoShake();
            }

            hitCount++;

            if (hitCount == 10)
            {
                wakeUp();
                return;
            }
            initPaperBalls();
        };

        paperballComp.onClicked = () =>
        {
            initPaperBalls();
        };

        paperBall.transform.localPosition = new Vector3(-Screen.width * .3f + Random.value * Screen.width * .6f,
            -Screen.height * .3f + Random.value * Screen.height * .6f, 0f);

        Graphic graphic = paperBall.GetComponent<Graphic>();
        float rgb = remainingDreamTime / totalDreamTime;
        graphic.color = new Color(rgb, rgb, rgb, 1f);
        graphic.CrossFadeAlpha(0f, 0f, false);
        graphic.CrossFadeAlpha(1f, Random.value * 0.25f, false);

        paperBall.transform.localRotation = Quaternion.Euler(0, 0, Random.value > 0.5f ? -1f : 1f);
    }

    void Update()
    {
        remainingDreamTime -= Time.deltaTime;

        if (remainingDreamTime < 0f)
        {
            wakeUp();
        }
    }

    void initPaperBalls()
    {
        if (Random.value > 0.5f)
        {
            instantiateBall();
        }
        instantiateBall();
    }



    void wakeUp()
    {
        if (!PrefabUtils.IS_DREAM_5)
        {
            SceneManager.LoadScene("transition");
        }
    }
}
