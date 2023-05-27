using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleNoiseFilter : INoiseFilter {
    
    NoiseSettings settings;
    Noise noise = new Noise();

    public SimpleNoiseFilter(NoiseSettings settings){
        this.settings = settings;
    }
    
    public float Evaluate(Vector3 point){
        float noiseValues = 0;
        float frequency = settings.baseRoughness;
        float amplitude = 1;
        for(int i = 0; i < settings.octaves; i++){
            float v = noise.Evaluate(point * frequency + settings.centre);
            noiseValues += (v + 1) * .5f * amplitude;
            frequency *= settings.roughness;
            amplitude *= settings.persistance;
        }
        noiseValues = noiseValues - settings.minValue;
        return noiseValues * settings.strength;
    }
}
