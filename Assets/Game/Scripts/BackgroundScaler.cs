﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour
{
    private Vector3 startScale;

    // Start is called before the first frame update
    void Start()
    {
        startScale = transform.localScale;

        float height = Camera.main.orthographicSize * 2;
        float width = height * Screen.width / Screen.height;

        transform.localScale = new Vector3(width, height, startScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
