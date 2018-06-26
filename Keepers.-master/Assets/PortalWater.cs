using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalWater : MonoBehaviour
{
    public GameObject character;
    public Animator anim;
    bool CheckForHowl = false;

    private IEnumerator PortalHowl ()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }

    private void OnTriggerEnter(Collider Player)
    {
        CheckForHowl = true;
    }
    private void OnTriggerExit(Collider Player)
    {
        CheckForHowl = false;
    }

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown("joystick button 3") && CheckForHowl)
        {
            anim.Play("FadeOut");
            StartCoroutine(PortalHowl());
        }
 
    }
}




