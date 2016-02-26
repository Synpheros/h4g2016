using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bubble : MonoBehaviour {

    private enum BubbleState {STOP,MOVING};
    private BubbleState state = BubbleState.STOP;

    public string text;

    private Vector2 finalPosition;

	// Use this for initialization
	void Start () {
        resize ();

        Debug.Log (this.GetComponent<RectTransform> ().rect.width);
	}
	
	// Update is called once per frame
	void Update () {
        resize ();
	}


    public void moveTo(Vector2 position){
        this.finalPosition = position;
    }

    public void resize(){
        this.GetComponent<Text> ().text = this.text;
        foreach (Transform t in transform) {
            if (t.GetComponent<Text> () != null) {
                t.GetComponent<Text> ().text = this.text;
                break;
            }
        }
    }



    public float easing = 0.05f;
    public Vector2 minXY;
    public bool _____________________________;
    // fields set dynamically
    public float camZ; // The desired Z pos of the camera
    void Awake() {
        camZ = this.transform.position.z;
    }

    void FixedUpdate () {
        Vector3 destination;
        // If there is no poi, return to P:[0,0,0]
        if (finalPosition == null) {
            destination = Vector3.zero;
        } else {
            destination = finalPosition;
        }
        // Limit the X & Y to minimum values
        destination.y = Mathf.Max( minXY.y, destination.y );
        // Interpolate from the current Camera position toward destination
        destination = Vector3.Lerp(transform.localPosition, destination, easing);
        // Retain a destination.z of camZ
        destination.z = camZ;
        // Set the camera to the destination
        transform.localPosition = destination;
    }
}
