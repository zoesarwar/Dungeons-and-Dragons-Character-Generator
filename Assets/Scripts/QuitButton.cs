using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    
    public void QuitGame()
    {

#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = (false);
#else
        Application.Quit();
#endif

}

}
