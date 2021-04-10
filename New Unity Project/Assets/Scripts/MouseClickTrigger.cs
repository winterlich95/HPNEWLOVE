using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClickTrigger : MonoBehaviour
{
    [SerializeField] public List<string> selectableTags;
    



    public int distanceOfRay = 5000;
    private RaycastHit _hit;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {



        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit _hit;

            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));

            if (Physics.Raycast(ray, out _hit, 100.0f))
            {
                
                if ((_hit.transform != null) && (selectableTags.Contains(_hit.transform.gameObject.tag)))
                {
                    CallFunction(_hit.transform);
                }
            }
        }
    }

    public void CallFunction(Transform hitObject)
    {
            string tag = hitObject.gameObject.tag;
            switch (tag)
            {
    //            case "JumpscareTrigger":
    //                hitObject.gameObject.GetComponent<JumpTrigger>().StartJump();
      //              break;

                case "Door":
                    hitObject.gameObject.GetComponent<KeyScript>().OpenDoor();
                    break;

                case "Key":
                    hitObject.gameObject.GetComponent<Keyinventory>().KeyPick();
                    break;


                case "TextTrigger":
                case "QuestboxTrigger":
                    hitObject.gameObject.GetComponent<DialogueTrigger>().TriggerDialogue(tag);
                    break;

                case "AudioTrigger2":
                    hitObject.gameObject.GetComponent<AudioManager>().Play("Brief");
                    break;

                case "SceneTrigger":
                    hitObject.gameObject.GetComponent<SceneChange>().ChangeScene();
                    break;

                case "Teleport":
                    hitObject.gameObject.GetComponent<tp>().TeleportPlayer();
                    break;

                case "LetterTrigger":
                    hitObject.gameObject.GetComponent<CallLetter>().TeleportImage();
                    break;

                case "NoteDeadMan":
                case "NoteMerwin":
                case "NoteSon":
                    hitObject.gameObject.GetComponent<NoteManager>().ChangeState();
                    break;

                case "DoorTrigger":
                    hitObject.gameObject.GetComponent<FrontDoorScript>().OpenDoor();
                    break;

                default:
                    print("Das Objekt " + hitObject.gameObject.name + " hat keine Funktion.");
                    break;
            }
        
    }


   // public void CallJump()
   // {
     //   Ray ray = Camera.main.ScreenPointToRay(new Vector3(0.5f, 0.5f, 0f));

    //    if (Physics.Raycast(ray, out _hit, distanceOfRay))
      //  {

    //        _hit.transform.gameObject.GetComponent<JumpTrigger>().StartJump();

     //   }


    //}

    public void CallTeleport()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceOfRay))
        {

            _hit.transform.gameObject.GetComponent<DialogueTrigger>().TriggerDialogue(_hit.transform.gameObject.tag);

        }
    }
    public void CallText()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceOfRay))
        {

            _hit.transform.gameObject.GetComponent<tp>().TeleportPlayer();

        }


    }


    public void CallSound()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceOfRay))
        {

            _hit.transform.gameObject.GetComponent<AudioManager>().Play("Brief");

        }

    }

    public void CallImage()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceOfRay))
        {

            _hit.transform.gameObject.GetComponent<CallLetter>().TeleportImage();

        }
    }

    public void EndText()
    {
        FindObjectOfType<DialogueManager>().EndDialogue();
    }


}
