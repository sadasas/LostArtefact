using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCatchTrigger : MonoBehaviour
{
    public bool isTriggered;
    public GameObject pintu;
    public int a;
    private string liftableTag = "Liftable";
    public AudioSource playaudio;

    public GameObject camera5;
    public GameObject main;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(liftableTag)) // jika ini box
        {
            MoveObject box = other.gameObject.GetComponent<MoveObject>();
            if (box.isLifted == false)
            {
                other.transform.position = this.transform.position;
                other.transform.rotation = this.transform.rotation;
                Debug.Log($"Disentuh {other.gameObject.name}");
                isTriggered = true;

                membukaPintu(box);
            }
        }
    }

    private void membukaPintu(MoveObject box)
    {
        if (a == 1)
        {
            StartCoroutine(BUKA(box));
        }
        else
        {
            doorCatcher terbuka = pintu.gameObject.GetComponent<doorCatcher>();

            // disable box
            box.isPintuStillMoving = true;
            // membuka pintu
            playaudio.Play();
            LeanTween.move(pintu, terbuka.posTerbuka, 1f).setOnComplete(() =>
            {
                // kalo udah nyampe baru

                //enable box is lefted
                box.isPintuStillMoving = false;
            });
        }
    }

    private IEnumerator BUKA(MoveObject box)
    {
        main.SetActive(false);
        camera5.SetActive(true);
        yield return new WaitForSeconds(1);
        doorCatcher terbuka = pintu.gameObject.GetComponent<doorCatcher>();

        // disable box
        box.isPintuStillMoving = true;
        // membuka pintu
        playaudio.Play();
        LeanTween.move(pintu, terbuka.posTerbuka, 1f).setOnComplete(() =>
        {
            // kalo udah nyampe baru

            //enable box is lefted
            box.isPintuStillMoving = false;
        });
        yield return new WaitForSeconds(1.5F);
        camera5.SetActive(false);
        main.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        doorCatcher tertutup = pintu.gameObject.GetComponent<doorCatcher>();
        if (!LeanTween.isTweening(pintu))
        {
            if (isTriggered == true)
            {
                isTriggered = false;
                playaudio.Play();

                Vector3 turun = new Vector3(0, -5, 0);
                LeanTween.move(pintu, tertutup.posTertutup, 1f);
            }
            // gausah ngapa ngapain
        }
    }
}