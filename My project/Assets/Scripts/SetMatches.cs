using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class SetMatches : MonoBehaviour
{
    public List<GameObject> matches;

    public void LightAllMatches()
    {
        foreach (GameObject match in matches)
        {
            if (match != null)
            {
                match.SetActive(true);
            }
        }
    }
}
