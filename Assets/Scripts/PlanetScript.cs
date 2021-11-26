using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// classe qui gere les planetes qui scrollent dans le fond
/// </summary>
public class PlanetScript : MonoBehaviour
{
    [SerializeField]
    float speed;
    void Update()
    {
        Transform planet = this.gameObject.transform;
    }
}
