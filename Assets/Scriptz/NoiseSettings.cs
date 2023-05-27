using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NoiseSettings
{
    public enum FilterType{Simple, Ridged};
    public FilterType filterType;

    
    public int octaves = 1;
    public float strength = 1;
    public float baseRoughness = 1;
    public float roughness = 2;
    public float persistance = .5f;
    public float minValue;
    public Vector3 centre;

    public float weightMulti = .8f;
}
