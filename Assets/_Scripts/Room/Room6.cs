using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Room6 : MonoBehaviour
{

    public Sprite habPrincipio, habFinal;
    public bool isIntro = false;
    private GameObject ClickToStart, note;
    private Text clickToStartText;
    private bool isFading = false;
    private int delay = 6;


    // Use this for initialization
    void Start()
    {

        ClickToStart = GameObject.Find("ClickToStart");
        clickToStartText = ClickToStart.GetComponent<Text>();
        note = GameObject.Find("Note").gameObject;

        GameObject hab = GameObject.Find("hab");
        if (isIntro)
        {
            note.SetActive(false);
            ClickToStart.SetActive(true);
            hab.GetComponent<SpriteRenderer>().sprite = habPrincipio;
        }
        else
        {
            note.SetActive(true);
            ClickToStart.SetActive(false);
            hab.GetComponent<SpriteRenderer>().sprite = habFinal;
            clickToStartText.text = "Final... (" + delay + " para continuar)";
            loadMenu();
        }
        clickToStartText.CrossFadeAlpha(0f, 0f, false);
        isFading = true;
        crossFadeText();
        GameObject.Find("ClickButton").GetComponent<Button>().onClick.AddListener(() =>
        {
            if (isIntro)
            {
                isFading = false;
                Invoke("transition", 0.5f);
            }
        });

    }

    void transition()
    {
        SceneManager.LoadScene("transition");
    }

    void loadMenu()
    {
        delay--;
        if (delay == 0)
        {
            SceneManager.LoadScene("menu");
        } else
        {
            clickToStartText.text = "Final... (" + delay + " para continuar)";
        }
        Invoke("loadMenu", 1f);
    }

    void crossFadeText()
    {
        if (isFading)
        {
            clickToStartText.CrossFadeAlpha(1f, 1f, false);
        }
        else
        {
            clickToStartText.CrossFadeAlpha(0f, 1f, false);
        }
        isFading = !isFading;
        Invoke("crossFadeText", 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
