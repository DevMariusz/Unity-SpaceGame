//shows freeze ray icon
if(pLevel==3)
{
	freezeLogo.transform.position = new Vector3 (freezeLogo.transform.position.x + 7F, freezeLogo.transform.position.y, freezeLogo.transform.position.z);
}

//Shoot freeze ray
if(GameController.pLevel >2)
{
	if(fireon==2)
	{
		if (Input.GetButton ("Fire2") && Time.time > nextFire2) {
			nextFire2 = Time.time + missilefireRate;
			Instantiate (freeze, shotSpawn.position, shotSpawn.rotation);
			shotsFired = shotsFired + 0.5F;
			freezeSound.GetComponent<AudioSource>().Play ();
		}
	}
}

if (other.tag == "Freeze")
{
	if (gameObject.tag == "Enemy")
	{
		enemyfreeze.GetComponent<AudioSource>().Play ();
		gameObject.GetComponent<EvasiveManeuver>().enabled = false;
	}
	gameObject.GetComponent<Rigidbody>().velocity = transform.forward * 0;
	Destroy(other.gameObject);
}
