using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class D4text : MonoBehaviour, IPointerDownHandler
{

    public UnityAction onDuplicate;

    void Start()
    {
    }

    void duplicate()
    {
        if (onDuplicate != null)
        {
            onDuplicate();
        }
    }

    void Update()
    {
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        if (onDuplicate != null)
        {
            onDuplicate();
        }
    }
}

