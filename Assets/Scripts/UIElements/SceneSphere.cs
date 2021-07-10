using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSphere : MonoBehaviour
{
    public void GoTo360()
    {
        FindObjectOfType<SceneManagement>().ChangeScene("360Video");
    }
}
