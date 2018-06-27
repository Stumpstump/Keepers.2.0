using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTriggerPathFollow : MonoBehaviour {

    public Transform[] path;
    public float speed = 5.0f;
    public float reachDistance = 1.0f;
    public int currentPoint = 0;
    bool CheckForBark = false;

    private void OnTriggerEnter(Collider Player)
    {
        CheckForBark = true;
    }
    private void OnTriggerExit(Collider Player)
    {
        CheckForBark = false;
    }
 

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown("joystick button 1") && CheckForBark)

            {
                float dist = Vector3.Distance(path[currentPoint].position, transform.position);
                transform.position = Vector3.MoveTowards(transform.position, path[currentPoint].position, Time.deltaTime * speed);

                if (dist <= reachDistance)
                {
                    currentPoint++;
                }
            }

        }

        private void OnDrawGizmos()
        {
            if (path.Length > 0)
            {
                for (int i = 0; i < path.Length; i++)
                {
                    if (path[i] != null)
                    {
                        Gizmos.DrawSphere(path[i].position, reachDistance);
                    }
                }
            }
        }
    }
