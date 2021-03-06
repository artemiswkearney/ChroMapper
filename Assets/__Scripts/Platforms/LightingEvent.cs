﻿using UnityEngine;

public class LightingEvent : MonoBehaviour {

    private static readonly int LightingEventRenderQueue = 2925;

    [HideInInspector] public Material LightMaterial;

	// Use this for initialization
	void Start () {
        LightMaterial = GetComponentInChildren<Renderer>().material;
        LightMaterial.renderQueue = LightingEventRenderQueue;
	}
}
