using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DetectionManager : MonoBehaviour
{
    public static DetectionManager instance;
    public GameObject dokument;

    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private string liftableTag = "Liftable";
    [SerializeField] private string Dokumen = "dokument";
    [SerializeField] private string lockerTag = "Locker";
    [SerializeField] private string keyTag = "Key";
    [SerializeField] private Material HightlightMaterial;
    [SerializeField] private Material defaultMaterial;

    [SerializeField] private Text middelText;
    [SerializeField] private GameObject bgTeks;
    [SerializeField] private TextMeshProUGUI StatusText;
    [SerializeField] private LayerMask hintLayer;
    [SerializeField] private TextMeshProUGUI InventoryText;
    private string namaKey;

    public List<BoxSlot> boxList = new List<BoxSlot>();
    public List<Checkpoint> CPList = new List<Checkpoint>();
    public List<keyController> keyList = new List<keyController>();
    private Transform _selection;
    private GameMaster gm;

    public AudioSource playaudio;

    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
        gm = GameMaster.instance;
        loadBoxPos();
        loadCheckpointState();
        loadKeyitem();
        loadInventory();
        if (instance == null)
        {
            instance = this;
        }
    }

    private void loadInventory()
    {
        foreach (var key in gm.lastItem)
        {
            namaKey += $"{key} \n";
        }
        InventoryText.text = "Inventory :\n" + namaKey;
    }

    private void loadKeyitem()
    {
        for (int i = 0; i < keyList.Count; i++)
        {
            keyList[i].isPickedUp = gm.keyPickedUp[i];
        }
    }

    private void loadCheckpointState()
    {
        for (int i = 0; i < CPList.Count; i++)
        {
            CPList[i].isUsed = gm.isCheckpointUsed[i];
        }
    }

    private void loadBoxPos()
    {
        for (int i = 0; i < boxList.Count; i++)
        {
            if (gm.boxLastpos[i] != Vector3.zero)
            {
                boxList[i].transform.position = gm.boxLastpos[i];
            }
        }
    }

    // Update is called once per frame
    private void Update()
    {
        hintDepan();
        if (Input.GetMouseButtonDown(0))
        {
            // diisi dengan ray (di sini pakai klik posisi mouse)
            // punyamu ganti pakai tengah dari layar
            Shot(Camera.main.ScreenPointToRay(Input.mousePosition));
        }
    }

    private void hintDepan()
    {
        RaycastHit deteksi;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out deteksi, 3f, hintLayer))
        {
            var selection = deteksi.transform.gameObject;

            if (selection.CompareTag(selectableTag))
            {
                bgTeks.gameObject.SetActive(true);
                setMiddleText("klik untuk dorong");
            }

            if (selection.CompareTag(Dokumen))
            {
                bgTeks.gameObject.SetActive(true);
                setMiddleText("lihat");
            }

            if (selection.CompareTag(liftableTag))
            {
                MoveObject box = selection.gameObject.GetComponent<MoveObject>();
                bgTeks.gameObject.SetActive(true);
                setMiddleText("tekan untuk ambil");
                if (box.isLifted == true)
                {
                    if (selection.gameObject.GetComponent<MoveObject>() != null || box.isPintuStillMoving == true)
                    {
                        bgTeks.gameObject.SetActive(false);
                        setMiddleText(" ");
                    }
                    if (selection.gameObject.GetComponent<MoveObject>() == null)
                    {
                    }
                }
            }

            if (selection.CompareTag(keyTag))
            {
                bgTeks.gameObject.SetActive(true);
                setMiddleText("Ambil kunci");
            }
            if (selection.CompareTag(lockerTag))
            {
                bgTeks.gameObject.SetActive(true);
                setMiddleText("Buka");
            }
        }
        else
        {
            bgTeks.gameObject.SetActive(false);
            setMiddleText(" ");
        }
    }

    private void Shot(Ray ray)
    {
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3f))
        {
            Debug.Log($"{hit.collider.name}");

            // nge set text pakai nama objeknya

            var selection = hit.transform.gameObject; // ini objeknya

            DeteksiObjek(selection);
        }
    }

    private void DeteksiObjek(GameObject selection)
    {
        if (selection.CompareTag(selectableTag))
        {
            Transform newTransform = selection.transform;
            Rigidbody newRigidbody = selection.GetComponent<Rigidbody>();
            //gantiWarna(selection);

            Vector3 arah = DeteksiArah(selection);

            newRigidbody.AddForce(arah * 100);

            playaudio.Play();

            //gulingObjek(selection);
        }
        if (selection.CompareTag(lockerTag))
        {
            selection.GetComponent<LockerControl>().Buka();
        }
        if (selection.CompareTag(Dokumen))
        {
            dokument.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }

        if (selection.CompareTag(keyTag))
        {
            setStatusText("Kunci diambil");
            this.GetComponent<PlayerInventory>().getKey(selection.gameObject.name);
            selection.GetComponent<keyController>().isPickedUp = true;
        }
    }

    private static Vector3 DeteksiArah(GameObject selection)//untuk mendeteksi dari mana player datang
    {
        Vector3 arah = selection.transform.position - Camera.main.transform.position;

        float arahZ = Mathf.Abs(arah.z);
        float arahX = Mathf.Abs(arah.x);

        if (arahZ > arahX)
        {
            arah.z = arah.z < 0 ? arah.z = -5 : arah.z = 5;

            arah.x = 0;
        }
        else
        {
            arah.x = arah.x < 0 ? arah.x = -5 : arah.x = 5;
            arah.z = 0;
        }

        arah.y = 0;

        return arah;
    }

    private void gulingObjek(GameObject selection)
    {
        LeanTween.rotateAround(selection, Vector3.right, 90, 0.5f).setEaseInOutQuint();

        // pengen objeknya memutar pivot dari bawah
    }//lagi gx dipake

    private void gantiWarna(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material = HightlightMaterial;
        }

        _selection = selection;
    }//percobaan awal doang

    private void setMiddleText(string namaObjek)
    {
        middelText.text = namaObjek;
    }

    private void setStatusText(string namaStatus)
    {
        StatusText.text = namaStatus;
        StartCoroutine(hideStatusText());
    }

    private IEnumerator hideStatusText()
    {
        yield return new WaitForSeconds(1);

        StatusText.text = "";
    }
}