using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public Canvas nextCanvas;
    public void LoadNextCanvas()
    {
        nextCanvas.GetComponent<Canvas>().enabled = true;
    }
}
