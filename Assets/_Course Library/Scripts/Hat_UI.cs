using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat_UI : MonoBehaviour
{
    public GameObject myCamera;
    public GameObject target;
    public GameObject UI;
    public GameObject pickedUpUI;
    public float distance = 0;
    public float minDist = 5f;
    public static bool RunOnce;

    private void Update()
    {
        CheckDistance();
    }

    private void CheckDistance()
    {
        distance = (myCamera.transform.position - target.transform.position).sqrMagnitude;

        if (distance < minDist && !RunOnce)
        {
            UI.SetActive(true);
            RunOnce = true;
        }
    }

    public void DestroyUI()
    {
        Destroy(pickedUpUI.gameObject);
        Destroy(UI.gameObject);
    }
}
