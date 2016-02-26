using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class BullyLogic : MonoBehaviour
{

    public GameObject paperBallPrefab;

    private GameObject dream2;
    private List<RectTransform> paperBalls;
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


        paperBalls = new List<RectTransform>();
        hitCount = 0;
        instantiateBall();
    }

    void instantiateBall()
    {
        GameObject paperBall = PrefabUtils.LoadPrefab(dream2.transform, paperBallPrefab);

        paperBall.transform.localPosition = new Vector3(-Screen.width * .3f + Random.value * Screen.width * .6f,
            -Screen.height * .3f + Random.value * Screen.height * .6f, 0f);

        Graphic graphic = paperBall.GetComponent<Graphic>();
        float rgb = remainingDreamTime / totalDreamTime;
        graphic.color = new Color(rgb, rgb, rgb, 1f);
        graphic.CrossFadeAlpha(0f, 0f, false);
        graphic.CrossFadeAlpha(1f, Random.value * 0.25f, false);
        paperBalls.Add(paperBall.GetComponent<RectTransform>());

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

    void FixedUpdate()
    {

        for (int i = 0; i < paperBalls.Count; ++i)
        {
            RectTransform paperBall = paperBalls[i];
            if (paperBall == null)
            {
                paperBalls.RemoveAt(i);
                initPaperBalls();
                return;
            }

            // Rotation interpolation
            float rotationSpeed = 2f;
            float rotation = paperBall.localRotation.eulerAngles.z;
            rotation += rotation > 0 ? rotationSpeed : -rotationSpeed;
            paperBall.localRotation = Quaternion.Euler(0, 0, rotation);

            // Scale interpolation
            float scaleSpeed = 0.025f;
            Vector3 scale = paperBall.localScale;
            scale.x += scaleSpeed;
            scale.y = scale.x;
            if (scale.x > 5f)
            {
                Destroy(paperBall.gameObject);
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

                paperBalls.Remove(paperBall);
                initPaperBalls();
            }
            else
            {
                paperBall.localScale = scale;
            }

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
        // TODO Wake up and go to Day 3

    }
}
