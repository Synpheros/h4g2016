using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dream6 : MonoBehaviour {

    private float totalDreamTime, remainingDreamTime;
	public GameObject paperBallPrefab;
	public GameObject textPrefab;
	public GameObject deleteButtonPrefab;

	private GameObject dream;
	private Graphic background;
	private int hitCount;

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

	private int dupCount;

	// Use this for initialization
	void Start ()
    {
		dupCount = 0;

		totalDreamTime = 15f;
        remainingDreamTime = totalDreamTime;
        PrefabUtils.IS_DREAM_5 = true;
		dream = GameObject.Find("Dream");
		background = GameObject.Find("Background").GetComponent<Graphic>();
		background.CrossFadeColor(new Color(0f, 0f, 0f, 1f), totalDreamTime, false, false);

		hitCount = 0;
		instantiateBall();
		iniTextMessageButton();
		initDeleteButton();
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


	void instantiateBall()
	{
		GameObject paperBall = PrefabUtils.LoadPrefab(dream.transform, paperBallPrefab);

		PaperBall paperballComp = paperBall.GetComponent<PaperBall>();
		paperballComp.onHitPlayer = () =>
		{
			Shake camShake = dream.GetComponent<Shake>();
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

	void initPaperBalls()
	{
		if (Random.value > 0.5f)
		{
			instantiateBall();
		}
		instantiateBall();
	}

	void iniTextMessageButton()
	{
		if (Random.value > 0.5f)
		{
			instantiateTextMessage();
		}
		instantiateTextMessage();
	}

	void instantiateTextMessage()
	{
		GameObject paperBall = PrefabUtils.LoadPrefab(dream.transform, textPrefab);

		D4text paperballComp = paperBall.GetComponent<D4text>();
		paperballComp.onDuplicate = () =>
		{

			dupCount++;

			if (dupCount == 20)
			{
				wakeUp();
				return;
			}
			iniTextMessageButton();
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

	void instantiateDeleteButton()
	{
		GameObject paperBall = PrefabUtils.LoadPrefab(dream.transform, deleteButtonPrefab);

		Delete paperballComp = paperBall.GetComponent<Delete>();
		paperballComp.onDuplicate = () =>
		{
			Shake camShake = dream.GetComponent<Shake>();
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
}


