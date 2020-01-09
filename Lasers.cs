//Shoot regular lasers
if (Input.GetButtonDown ("Fire1") && Time.time > nextFire)
{
	nextFire = Time.time + fireRate;
	Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
	shotsFired = shotsFired + 1;
	boltSound.GetComponent<AudioSource>().Play();
}
