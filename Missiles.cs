//shows missile icon
if(pLevel==2)
{
	missileLogo.transform.position = new Vector3 (missileLogo.transform.position.x + 6.5F, missileLogo.transform.position.y, missileLogo.transform.position.z);
	dirText.transform.position = new Vector3 (dirText.transform.position.x + 10F, dirText.transform.position.y, dirText.transform.position.z);
}

//Shoot missile
if(GameController.pLevel >1)
{
	if(fireon==1)
	{
		if (Input.GetButton ("Fire2") && Time.time > nextFire2)
		{
			nextFire2 = Time.time + missilefireRate;
			Instantiate (missile, shotSpawn.position, shotSpawn.rotation);
			shotsFired = shotsFired + 1;
			GetComponent<AudioSource>().Play ();
		}
	}
}
