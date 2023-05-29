using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipCutscene : MonoBehaviour
{
    public GameObject cutsceneObject;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            Skip();
        }
    }

    // Method to skip the cutscene
    private void Skip()
    {
        if (cutsceneObject != null)
        {
            cutsceneObject.SetActive(false);
        }
    }
}