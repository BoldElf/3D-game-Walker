using UnityEngine;

public class SoundRun : MonoBehaviour
{
    public AudioSource moveSound;

    [SerializeField] private PlayerMove playerMove;

    /*
    private void Start()
    {
        playerMove.jumpOn += jumpOn;
        playerMove.jumpOff += jumpOff;
    }
    

    private void jumpOn()
    {
        enabled = false;
        Debug.Log("On");
    }

    private void jumpOff()
    {
        enabled = true;
        Debug.Log("off");
    }
    */

    void Update()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.35f || Mathf.Abs(Input.GetAxis("Vertical")) > 0.35f)
        {
            if (moveSound.isActiveAndEnabled == false) return;
            if (moveSound.isPlaying) return;
            moveSound.Play();
        }
        else
        {
            if (moveSound.isActiveAndEnabled == false) return;
            moveSound.Stop();
        }
    }
}
