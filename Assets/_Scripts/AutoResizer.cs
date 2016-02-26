using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoResizer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float height = 0f;
        foreach (Transform t in this.transform) {
            if (t.GetComponent<Text> () != null) {
                GUIStyle height_calculator = new GUIStyle();
                GUIContent guiTextContent = new GUIContent(this.GetComponent<Text>().text);

                float textWidth = this.GetComponent<Text>().preferredWidth;
                height = height_calculator.CalcHeight(guiTextContent , textWidth) + 20;
                break;
            }
        }
        this.GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
