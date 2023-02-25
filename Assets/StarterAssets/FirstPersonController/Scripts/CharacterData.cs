using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData
{
    public string name;
    public int weight;
    public float speed;
    public int strength;
    public float frameData;
    public float jumpDistance;
    public float damange;

    public CharacterData()
    {

    }

    public CharacterData(string _name, int _weight, float _speed)
    {
        name = _name;
        weight = _weight;
        speed = _speed;
    }
}
