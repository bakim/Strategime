using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformAttack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) /*|| Add touch input*/)
        {
            Vector3 mousePosition = new Vector3();
            Vector3 mouseScreenCoordinates = Input.mousePosition;

            mousePosition = Camera.main.ScreenToWorldPoint(mouseScreenCoordinates);
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            RaycastHit hit;

            if (Physics.Raycast (ray, out hit))
            {
                Debug.DrawLine(hit.point, mousePosition, Color.red);
            }
        }
	}

    void Attack ()
    {

    }
}
