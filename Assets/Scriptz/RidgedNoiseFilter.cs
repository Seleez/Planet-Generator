using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidgedNoiseFilter : INoiseFilter
{
    NoiseSettings settings;
    Noise noise = new Noise();

    public RidgedNoiseFilter(NoiseSettings settings){
        this.settings = settings;
    }
    
    public float Evaluate(Vector3 point){
        
        float noiseValues = 0;
        float frequency = settings.baseRoughness;
        float amplitude = 1;
        float weight = 1;
        for(int i = 0; i < settings.octaves; i++){
            float v = 1 - Mathf.Abs(noise.Evaluate(point * frequency + settings.centre));
            v *= v;
            v *= weight;
            weight = Mathf.Clamp01(v * settings.weightMulti);

            noiseValues += v * amplitude;
            frequency *= settings.roughness;
            amplitude *= settings.persistance;
        }
        noiseValues = noiseValues - settings.minValue;
        return noiseValues * settings.strength;
    }
}
