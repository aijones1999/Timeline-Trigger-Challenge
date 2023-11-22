using UnityEngine;
using UnityEngine.Playables;
 
public class PlaySequence : MonoBehaviour
{
    public PlayableDirector timeline;
 
    
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }
 
 
    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            timeline.Stop();
        }
    }
 
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            timeline.Play();
        }
    }
}