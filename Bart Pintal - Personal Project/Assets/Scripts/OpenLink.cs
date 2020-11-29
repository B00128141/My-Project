using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenChannel()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=qqOqLNqAdDo&feature=youtu.be&ab_channel=Blackthornprod%22");
    }
}