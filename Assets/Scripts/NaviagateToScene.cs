using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NaviagateToScene : MonoBehaviour {

    [SerializeField]

    string SceneToNavigateTo;

    public void Navigate(){
        SceneManager.LoadScene(SceneToNavigateTo);

	}
}
