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
            Ifinished = true;
            someonefinished = true;
            photonView.RPC("SetSomeoneFinished", RpcTarget.All);
        }

        [PunRPC]
        public void SetSomeoneFinished(){
            Debug.Log("someone finished");
            finishedInformation.SetActive(true);
        }

        
    }
}