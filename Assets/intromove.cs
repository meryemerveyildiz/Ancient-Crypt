using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intromove : MonoBehaviour
{
    public float wait_time = 74f;

    void Start()
    {
        StartCoroutine(Wait_for_intro());
    }

    IEnumerator Wait_for_intro()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(2);
    }

}
