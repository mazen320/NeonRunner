using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    string gameId = "4759613";
    
    bool testMode = false;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }

    public void ShowAd()
    {
        Advertisement.Show();
    }
}
