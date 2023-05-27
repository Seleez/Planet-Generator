using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ShapeSettings : ScriptableObject {
    public float planetRadius = 1;
    public NoiseLayers[] noiseLayers;

    [System.Serializable]
    public class NoiseLayers{
        public string Name;
        public bool enabled = true;
        public bool useFirstLayerAsMask;
        public NoiseSettings noiseSettings;
    }
}
