using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;
using UnityEngine.Events;

public class Delete : MonoBehaviour, IPointerEnterHandler
{
    public UnityAction onDuplicate;
    private Vector3 targetPosition;
    private float speed = 100.0f;
    private float threshold = 0.5f;
    private int pointerEnterCount;

    void Start()
    {
        pointerEnterCount = 0;
        GetComponent<Button>().onClick.AddListener(() =>
        {
            duplicate();
        });
    }

    void duplicate()
    {
        if(onDuplicate != null)
        {
            onDuplicate();
        }
    }

    void Update()
    {
        Vector3 direction = targetPosition - transform.localPosition;
        if (direction.magnitude > threshold)
        {
            transform.localPosition = transform.localPosition + direction * speed * Time.deltaTime;
        }
        else
        {
            // Without this game object jumps around target and never settles
            transform.localPosition = targetPosition;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        pointerEnterCount++;
        if (pointerEnterCount == 5)
        {
            pointerEnterCount = 0;
            duplicate();
        }
        targetPosition = new Vector3(-Screen.width * .45f + UnityEngine.Random.value * Screen.width * .9f,
            -Screen.height * .45f + UnityEngine.Random.value * Screen.height * .9f, 0f);
    }

}
