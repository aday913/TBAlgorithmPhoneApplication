using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OkayButtonLinearCode : MonoBehaviour {
    public int TargetScene;
    public void NextSceneOnClick()
    {
        SceneManager.LoadScene(TargetScene);
    }
}
