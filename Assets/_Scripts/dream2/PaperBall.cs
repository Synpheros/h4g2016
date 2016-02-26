using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class PaperBall : MonoBehaviour
{

    public UnityAction onHitPlayer;
    public UnityAction onClicked;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {

        RectTransform paperBall = GetComponent<RectTransform>();

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
            if (onHitPlayer != null)
            {
                onHitPlayer();
            }
            Destroy(this.gameObject);
        }
        else
        {
            paperBall.localScale = scale;
        }
    }


    void OnMouseDown()
    {
        if (onClicked != null)
        {
            onClicked();
        }
        Destroy(this.gameObject);
    }
}
