using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassthroughPlaneScript : MonoBehaviour
{
   void Start()
   {
#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN || UNITY_ANDROID
      OVRManager.eyeFovPremultipliedAlphaModeEnabled = false;
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
