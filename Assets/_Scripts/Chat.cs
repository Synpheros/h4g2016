using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class Chat : MonoBehaviour {

    static public Chat S;

    public GameObject receiveBubble;
    public GameObject sendBubble;

    private GameObject content;

    private GameObject textchat;

    private List<GameObject> bubbles;

    public List<Sprite> characters;
    public Sprite transparente;

	// Use this for initialization
	void Start () {
        S = this;

        this.bubbles = new List<GameObject> ();

        this.content = GameObject.Find ("content");

        textchat = GameObject.Find ("textochat");
        fade_out_instant(this.content);
	}
	
	// Update is called once per frame
    private float msg_time = 1f;
    private float time_since_last_msg = 0;
    bool a = false;
	void Update () {
       /* time_since_last_msg += Time.deltaTime;
        if (time_since_last_msg > msg_time) {
            time_since_last_msg = 0;
            a = !a;
            if (a) 
                sendMessage ("hola, que tal estas");
            else
                receiveMessage ("bien y tu?");
        }   */
	}

    public void sendMessage(string text){
        GameObject bubble = GameObject.Instantiate (sendBubble);
        bubble.transform.SetParent (content.transform);


        bubble.transform.localScale = new Vector3 (1, 1, 1);

        bubble.GetComponent<Bubble> ().text = text;
        bubble.GetComponent<Bubble> ().resize ();

        bubble.transform.localPosition = new Vector3 (300 - (bubble.GetComponent<RectTransform> ().rect.width/2), 0, 0);

        this.bubbles.Add (bubble);

        this.pushBubbles (0f);
    }

    public void receiveMessage(string text){
        GameObject bubble = GameObject.Instantiate (receiveBubble);
        bubble.transform.SetParent (content.transform);


        bubble.transform.localScale = new Vector3 (1, 1, 1);

        bubble.GetComponent<Bubble> ().text = text;
        bubble.GetComponent<Bubble> ().resize ();

        bubble.transform.localPosition = new Vector3 (100  + (bubble.GetComponent<RectTransform> ().rect.width/2), 0, 0);

        this.bubbles.Add (bubble);

        this.pushBubbles (0f);
    }

    private int[] talkers = null;
    public void talk(int[] chars, string text){
        if (chars == null) {
            this.talkers = null;
            fade_out (this.content);
        }{
            if (this.talkers != chars) {
                if (this.talkers == null)
                    fade_in (this.content);
                
                this.talkers = chars;
                for(int i = 0; i<3; i++){
                    if(talkers[i] == -1)
                        GameObject.Find("char_" + i).GetComponent<Image> ().sprite = this.transparente;
                    else
                        GameObject.Find("char_" + i).GetComponent<Image> ().sprite = this.characters [talkers[i]]; 

                }
            }

            GameObject.Find ("texto_textochat").GetComponent<Text> ().text = text;
        }
    }

    public void pushBubbles(float height){
        foreach (GameObject go in bubbles) {
            go.GetComponent<Bubble>().moveTo(new Vector3 (go.transform.localPosition.x, go.transform.localPosition.y + height + 35, go.transform.localPosition.z));
        }
    }

    public void fade_in(GameObject go){
        Graphic[] graphics = go.GetComponentsInChildren<Graphic>();

        for (int i = 0; i < graphics.Length; ++i)
        {
            //graphics[i].CrossFadeAlpha(0f, 0f, false);
            Debug.Log (i);
            graphics[i].CrossFadeAlpha(1f, 1.5f, false);
        }
    }

    public void fade_out(GameObject go){
        Graphic[] graphics = go.GetComponentsInChildren<Graphic>();

        for (int i = 0; i < graphics.Length; ++i)
        {
            graphics[i].CrossFadeAlpha(0f, 1.5f, false);
        }
    }

    public void fade_out_instant(GameObject go){
        Graphic[] graphics = go.GetComponentsInChildren<Graphic>();

        for (int i = 0; i < graphics.Length; ++i)
        {
            graphics[i].CrossFadeAlpha(0f, 0f, false);
        }
    }
}
