//Pause game
if (Input.GetKeyDown (KeyCode.P))
{
	if(Time.timeScale == 0)
	{
		Time.timeScale = 1;
		pauseText.text = "Press 'P' to pause!";
	}
	else
	{
		Time.timeScale = 0;
		pauseText.text = "";
	}
}

//saves new high score
if (GameController.score > PlayerPrefs.GetInt ("topScore"))
{
	GameController.oldScore=PlayerPrefs.GetInt ("topScore");
	PlayerPrefs.SetInt("topScore", GameController.score);
	gameController.bScore.text = "Best Score: " + GameController.score;
	gameController.inputField.transform.Translate(-10,0,0);
}
gameController.gameOverText.text = "Game Over!";
gameController.tryAgain.transform.Translate(-10f,0f,0f);
GameController.gameOver = true;
