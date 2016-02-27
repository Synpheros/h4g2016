using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Room6 : MonoBehaviour {

    public Sprite habPrincipio, habFinal;
    public bool isIntro = false;
    private GameObject ClickToStart, note;
    private Text clickToStartText;
    private bool isFading = false;


    // Use this for initialization
    void Start () {

        ClickToStart = GameObject.Find("ClickToStart");
        clickToStartText = ClickToStart.GetComponent<Text>();
        note = GameObject.Find("Note").gameObject;

        GameObject hab = GameObject.Find("hab");
        if (isIntro)
        {
            note.SetActive(false);
            ClickToStart.SetActive(true);
            hab.GetComponent<SpriteRenderer>().sprite = habPrincipio;
        } else
        {
            note.SetActive(true);
            ClickToStart.SetActive(true);
            hab.GetComponent<SpriteRenderer>().sprite = habFinal;
            clickToStartText.text = "Final... (click para continuar)";

        }
        clickToStartText.CrossFadeAlpha(0f, 0f, false);
        isFading = true;
        crossFadeText();
        this.gameObject.transform.Find("ClickButton").GetComponent<Button>().onClick.AddListener(() =>
        {
            if(isIntro)
            {
                isFading = false;
                Invoke("transition", 2f);
            } else
            {
                note.GetComponent<Image>().CrossFadeAlpha(0f, 1.5f, false);
                Invoke("loadMenu", 2f);
            }
        });

    }

    void loadMenu()
    {
        SceneManager.LoadScene("menu");
    }

    void crossFadeText()
    {
        if (isFading)
        {
            clickToStartText.CrossFadeAlpha(1f, 1f, false);
        } else
        {
            clickToStartText.CrossFadeAlpha(0f, 1f, false);
        }
        isFading = !isFading;
        Invoke("crossFadeText", 1f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
