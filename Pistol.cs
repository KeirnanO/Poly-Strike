using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{

    override public void Shoot()
    {
        ammo--;

        FindObjectOfType<AudioManager>().Play("Gunshot");

        RaycastHit hit;

        float spreadX = Random.Range(-1f, 1f);
        float spreadY = Random.Range(-1f, 1f);

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        {
            Transform newBullet = Instantiate(bullet, transform.position, transform.rotation).transform;
            newBullet.LookAt(hit.point);
            newBullet.Rotate(new Vector3(spreadX, spreadY, 0));

        }
        else
        {
            Instantiate(bullet, transform.position, Camera.main.transform.rotation);
        }



    }
}
