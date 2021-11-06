using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /**
        if (Input.GetKey(KeyCode.Alpha1))
        {
            gameObject.transform.gameObject.SetActive(false);

            Vector3 gunPosition = new Vector3(
                gameObject.transform.position.x,
                gameObject.transform.position.y,
                gameObject.transform.position.z);

            GameObject gunType = GameObject.FindWithTag("Arm1");
            GameObject newGun  = Instantiate(gunType, gunPosition, gameObject.transform.rotation);
            gameObject.transform.SetParent(newGun.transform);

        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Destroy(myGun);

            Vector3 gunPosition = new Vector3(
                gameObject.transform.position.x,
                gameObject.transform.position.y,
                gameObject.transform.position.z);

            GameObject gunType = GameObject.FindWithTag("Arm2");
            myGun = Instantiate(gunType, gunPosition, Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Destroy(myGun);

            Vector3 gunPosition = new Vector3(
                gameObject.transform.position.x,
                gameObject.transform.position.y,
                gameObject.transform.position.z);

            GameObject gunType = GameObject.FindWithTag("ArmArmy");
            myGun = Instantiate(gunType, gunPosition, Quaternion.identity);
        }
        **/

        if (Input.GetKey(KeyCode.Alpha1))
        {
            GameObject ChildGameObjeto1 = gameObject.transform.GetChild(0).gameObject;
            ChildGameObjeto1.transform.gameObject.SetActive(false);

            GameObject ChildGameObjeto2 = gameObject.transform.GetChild(1).gameObject;
            ChildGameObjeto2.transform.gameObject.SetActive(false);

            GameObject ChildGameObjeto3 = gameObject.transform.GetChild(2).gameObject;
            ChildGameObjeto3.transform.gameObject.SetActive(false);

            GameObject ChildGameObjeto4 = gameObject.transform.GetChild(0).gameObject;
            ChildGameObjeto4.transform.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            GameObject ChildGameObjeto1 = gameObject.transform.GetChild(0).gameObject;
            ChildGameObjeto1.transform.gameObject.SetActive(false);

            GameObject ChildGameObjeto2 = gameObject.transform.GetChild(1).gameObject;
            ChildGameObjeto2.transform.gameObject.SetActive(false);

            GameObject ChildGameObjeto3 = gameObject.transform.GetChild(2).gameObject;
            ChildGameObjeto3.transform.gameObject.SetActive(false);

            GameObject ChildGameObjeto4 = gameObject.transform.GetChild(1).gameObject;
            ChildGameObjeto4.transform.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            GameObject ChildGameObjeto1 = gameObject.transform.GetChild(0).gameObject;
            ChildGameObjeto1.transform.gameObject.SetActive(false);

            GameObject ChildGameObjeto2 = gameObject.transform.GetChild(1).gameObject;
            ChildGameObjeto2.transform.gameObject.SetActive(false);

            GameObject ChildGameObjeto3 = gameObject.transform.GetChild(2).gameObject;
            ChildGameObjeto3.transform.gameObject.SetActive(false);

            GameObject ChildGameObjeto4 = gameObject.transform.GetChild(2).gameObject;
            ChildGameObjeto4.transform.gameObject.SetActive(true);
        }
    }
}
