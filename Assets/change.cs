using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    // Start is called before the first frame update
    public void changeScene(string SceneChanging)
    {
        Application.LoadLevel(SceneChanging);
    }
}
