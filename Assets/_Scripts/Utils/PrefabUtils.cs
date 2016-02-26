using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class PrefabUtils
{

    /**
      Prefab Staitc Utilities
    */
    

    public static GameObject LoadPrefab(Transform transform, GameObject prefabObj)
    {
        
        GameObject prefab = GameObject.Instantiate(prefabObj);

        Vector3 localPos = prefab.transform.localPosition;
        localPos = new Vector3(localPos.x, localPos.y, localPos.z);

        prefab.transform.SetParent(transform);

        prefab.transform.localPosition = localPos;
        prefab.transform.localScale = new Vector3(1, 1, 1);
        return prefab;
    }
}
