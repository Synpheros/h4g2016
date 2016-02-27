using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dream4 : MonoBehaviour
{
    private static string[] TEXT_MSGS =
    {
        "-Ventu ha comentado en tu foto-\n¡Jajaj, eso eso, etiquetadle en todas!",

        "-Ventu ha comentado en tu foto-\n...Te lo advertí Alicia.",

        "-Valentín ha comentado en tu foto-\nAdemás de Fea, tonta.",

        "-Teresa ha comentado en tu foto-\nQue pasa ¿Es tu novio?",

        "-Raúl ha comentado en tu foto-\nEres tan inútil como el.",

        "-Miguel ha comentado en tu foto-\nEs que con esa cara jjaja",

        "-Nerea ha comentado en tu foto-\nMoriros ya.",

        "-Ventu ha comentado en tu foto-\nExactamente..."
    };
    public GameObject textPrefab;
    private Shake alice;
    private float totalDreamTime, remainingDreamTime;

    private GameObject dream4;
    private int dupCount;

    // Use this for initialization
    void Start()
    {
        dupCount = 0;
        totalDreamTime = 15f;
        remainingDreamTime = totalDreamTime;
        dream4 = GameObject.Find("Dream4");
        dream4.transform.FindChild("D4 Background").GetComponent<Graphic>().CrossFadeColor(new Color(0f, 0f, 0f, 1f), totalDreamTime, false, false);
        alice = dream4.transform.FindChild("D4 Alicia").GetComponent<Shake>();
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
        GameObject paperBall = PrefabUtils.LoadPrefab(dream4.transform, textPrefab);

        D4text paperballComp = paperBall.GetComponent<D4text>();
        paperballComp.onDuplicate = () =>
        {
            if (!alice.Shaking)
            {
                alice.DoShake();
            }

            dupCount++;

            if (dupCount == 20)
            {
                wakeUp();
                return;
            }
            initDeleteButton();
        };

        paperBall.transform.localPosition = new Vector3(-Screen.width * .35f + Random.value * Screen.width * .7f,
            -Screen.height * .35f + Random.value * Screen.height * .7f, 0f);

        Graphic[] graphics = paperBall.GetComponentsInChildren<Graphic>();
        float fadeTime = Random.value * 0.25f;
        float rgb = remainingDreamTime / totalDreamTime;
        for (int i = 1; i < graphics.Length; ++i)
        {
            Graphic graphic = graphics[i];
            graphic.color = new Color(graphic.color.r * rgb, graphic.color.g * rgb, graphic.color.b * rgb, 1f);
            graphic.CrossFadeAlpha(0f, 0f, false);
            graphic.CrossFadeAlpha(1f, fadeTime, false);
        }

        Text[] texts = paperBall.GetComponentsInChildren<Text>();

        string newText = TEXT_MSGS[(int)Random.Range(0, (float)TEXT_MSGS.Length)];
        for (int i = 0; i < texts.Length; ++i)
        {
            texts[i].text = newText;
        }

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
        // TODO Wake up and go to Day 5
        if (!PrefabUtils.IS_DAY_5)
        {

        }
    }
}
