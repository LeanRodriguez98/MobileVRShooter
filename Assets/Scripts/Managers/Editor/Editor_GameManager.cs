﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameManager))]

public class Editor_GameManager : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GameManager gameManager = (GameManager)target;

        if (GUILayout.Button("Find Cowboys"))
        {
            gameManager.FindCowboys();
        }
    }
}