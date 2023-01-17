// ----------------------------------------------------------------------------
// <copyright file="PhotonTransformView.cs" company="Exit Games GmbH">
//   PhotonNetwork Framework for Unity - Copyright (C) 2018 Exit Games GmbH
// </copyright>
// <summary>
//   Component to synchronize Transforms via PUN PhotonView.
// </summary>
// <author>developer@exitgames.com</author>
// ----------------------------------------------------------------------------


namespace Photon.Pun
{
    using UnityEngine;

    [AddComponentMenu("Photon Networking/Photon Transform View")]
    [HelpURL("https://doc.photonengine.com/en-us/pun/v2/gameplay/synchronization-and-state")]
    public class SendSomeOneFoundAllPlants : MonoBehaviourPun
    {
        public GameObject finishedInformation;

        public bool someonefinished = false;
        public bool Ifinished = false;

        private float spawnDistance = 2;

        public Transform headRig;

        private bool m_StoredSomeoneFinished;
        private bool m_StoredIfinished;


        bool m_firstTake = false;

        public void Awake()
        {
            m_StoredSomeoneFinished = someonefinished;
            m_StoredIfinished = Ifinished;

        }

        void OnEnable()
        {
            m_firstTake = true;
        }

        public void Update()
        {
            //var tr = transform;

            if (!this.photonView.IsMine)
            {
                if(!someonefinished && Ifinished)
                {
                    someonefinished = true;

                }
            }
        }

        public void IfoundAllPlants(){
            Debug.Log("foundallplants");
            Ifinished = true;
            someonefinished = true;
            photonView.RPC("SetSomeoneFinished", RpcTarget.All);
        }

        [PunRPC]
        public void SetSomeoneFinished(){
            Debug.Log("someone finished");
            finishedInformation.SetActive(true);
            finishedInformation.transform.position = headRig.position + new Vector3(headRig.forward.x -5, 30,headRig.forward.z + 15).normalized * spawnDistance;
            Debug.Log(finishedInformation.transform.position);
            Debug.Log("EndConditionMet");
            finishedInformation.transform.LookAt(new Vector3 (headRig.position.x, finishedInformation.transform.position.y, headRig.position.z));
            Debug.Log(finishedInformation.transform.position);
            finishedInformation.transform.forward *= -1;
        }

        
    }
}