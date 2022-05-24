﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelSave : MonoBehaviour
{
    private GameObject input;
    Button btn;

    // Start is called before the first frame update
    void Start()
    {
        input = GameObject.Find("SavePanel(Clone)");
        btn = this.GetComponent<Button>();
        btn.onClick.AddListener(Cancel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Cancel()
    {
        GameObject.Find("SaveButton").GetComponent<Button>().interactable = true;
        Destroy(input);
    }
}
