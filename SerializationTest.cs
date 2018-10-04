using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Serialization.Serialization
{
    class SerializationTest:MonoBehaviour
    {
        public inputField nameIF, ageIf, genderIf;
        string nameInput, genderInput;
        int ageInput;

        PlayerData playerData;
        //Use this for initialization
        void Start()
        {

        }
        //Update is called one per frame
        void Update()
        {

        }

        public void Serialize()
        {
            //string s = JsonUtility.TOJson(playerData);
            //string s = JsonUtility.ToJson(playerData,true);
            //Debug.Log(s);
            //File.WriteAllText("PlayerData.txt", s);


            //xmlnSerializer serializer = new xmlnSerializer(typeof(playerData));
            //FileStream stream = new FileStream("PlayerDtatXMl.xml", FileMode.Create);
            //serializer.Serialize(stream, playerData);
            //stream.Close();
        }

        public void Deserialize()
        {
            //string s =  File.WriteAllText("PlayerData.txt");
            // PlayerData playerDataFromFile = JsonUtility.FromJson<PlayerData>(s);

            // JsonUtility.FromJsonOverwrite(s, playerData);

            // nameIF.text = playerDataFromFile.name;
            // genderIf.text = playerDataFromFile.gender;
            // ageIf.text = playerDataFromFile.age.ToString;
           
            
            //xmlSerializer serializer = new xmlSerializer(typeof(PlayerData));
            //FileStream stream = new FileStream("PlayerDataListXML.xml", FileMode.Open);
            //playerData = serializer.Deserializer(stream, PlayerDataList);
            //stream.Close();
            
            // nameIF.text = playerDataFromFile.name;
            // genderIf.text = playerDataFromFile.gender;
            // ageIf.text = playerDataFromFile.age.ToString;

        }

        public void GetName(string s)
        {
            nameInput = s;
            playerData.name = nameInput;
        }

        public void GetGender(string s)
        {
            genderInput = s;
            playerData.gender = genderInput;
        }
    }
}
