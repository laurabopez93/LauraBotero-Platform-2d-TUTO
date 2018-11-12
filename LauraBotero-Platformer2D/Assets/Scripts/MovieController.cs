using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovieController : MonoBehaviour {

    private VideoPlayer m_VideoPlayer;

	// Use this for initialization
    void Awake () {

        // Cargamos el componente VideoPlayer
        m_VideoPlayer = GetComponent<VideoPlayer>();

        // loopPointReached es el evento para el fin del video
        m_VideoPlayer.loopPointReached += OnMovieFinished;
	}

    void OnMovieFinished(VideoPlayer player)
    {
        Debug.Log("Event for movie end called");
        player.Stop();

        // Cargan el prefab del nivel 1
        GameObject newLevel = GameObject.Instantiate(Resources.Load("Levels/Level1") as GameObject);

    }
	    
	// Update is called once per frame
	void Update () {
		
	}
}
