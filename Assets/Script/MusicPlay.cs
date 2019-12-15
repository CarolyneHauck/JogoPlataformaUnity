using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour {

    private static MusicPlay mp;

	// Use this for initialization
	void Awake ()
    {
        if(mp == null)
        {
            mp = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
