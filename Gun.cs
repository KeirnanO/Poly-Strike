using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public bool attack;

    public Transform muzzle;

	protected int maxAmmo;
	protected int ammo;

    [SerializeField]
    protected Transform cam;

    [SerializeField]
    protected GameObject bullet;

    private void Update()
    {
        //cam = Camera.main.transform;

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    //Instantiate bullets based on gun type
    public virtual void Shoot(){}
    //Set ammo
    public virtual void SetAmmo(){}

	public int GetAmmo()
	{
		return ammo;
	}

	public int GetMaxAmmo()
	{
		return maxAmmo;
	}

	public void Reload()
	{
		ammo = maxAmmo;
	}
}
