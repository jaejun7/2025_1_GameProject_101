using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    public float GameTimer = 0.0f;
    public GameObject MonsterGo;

    // Update is called once per frame
    void Update()
    { 
        GameTimer -= Time.deltaTime;

        if (GameTimer <= 0)
        {
            GameTimer = 3.0f;

            GameObject Temp = Instantiate(MonsterGo);
            Temp.transform.position = new Vector3(Random.Range(-10,10),Random.Range(-4, 4), 0.0f);
        }
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider != null)
                    {
                        hit.collider.gameObject.GetComponent<Monster>().CharacterHit(10);
                    }
                }
            }
        }

    }
}
