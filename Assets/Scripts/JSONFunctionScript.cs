using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class JSONFunctionScript : MonoBehaviour
{

    public GameObject inputField;
    public InputField EnterName;
    public Text StrengthText;
    public Text DexterityText;
    public Text ConstitutionText;
    public Text IntelligenceText;
    public Text WisdomText;
    public Dropdown ddClass;
    public Dropdown ddAlignment;
    public Dropdown ddRace;
    public InputField CXPText;
    public Text MXPText;
    public InputField CHPText;
    public InputField MHPText;
    public InputField ArmorText;
    public InputField RunSpeedText;
    public InputField JumpHeightText;
    public Text SpeedText;
    public Text CharismaText;
    public Text itemListStringText;

    List<string> ddClassOptions = new List<string>(){"Select Class...","Barbarian","Bard","Cleric","Druid","Fighter","Monk","Paladin","Ranger","Rogue","Sorcerer","Warlock","Wizard"};
    List<string> ddRaceOptions = new List<string>(){"Select Race...","Dragonborn","Dwarf","Elf","Gnome","Half-Elf","Half-Orc","Halfling","Human","Tiefling"};
    List<string> ddAlignmentOptions = new List<string>(){"Select Alignment...","Lawful Good","Neutral Good","Chaotic Good","Lawful Neutral","Neutral","Chaotic Neutral","Lawful Evil","Neutral Evil","Chaotic Evil"};


    public void JSONStringOutput(){

        //character name
        string characterName = EnterName.GetComponent<InputField>().text.ToString();

        Character myCharacter = new Character();
        myCharacter.name = characterName;

        //class
        int indexClass = ddClass.GetComponent<Dropdown>().value;
        string valueClass = ddClassOptions[indexClass];

        myCharacter.SelectedClass = valueClass;

        //grace
        int indexRace = ddRace.GetComponent<Dropdown>().value;
        string valueRace = ddRaceOptions[indexRace];

        myCharacter.race = valueRace;

        //alignment 
        int indexAlignment = ddAlignment.GetComponent<Dropdown>().value;
        string valueAlignment = ddAlignmentOptions[indexAlignment];

        myCharacter.alignment = valueAlignment;

        //current experience points 
        string cxp = CXPText.GetComponent<InputField>().text.ToString();
        myCharacter.CurrentExperiencePoints = Int32.Parse(cxp);

        //current hit points
        string currhitpts = CHPText.GetComponent<InputField>().text.ToString();
        myCharacter.CurrentHitPoints = Int32.Parse(currhitpts);

        //max hit points
        string maxhitpts = MHPText.GetComponent<InputField>().text.ToString();
        myCharacter.MaxHitPoints = Int32.Parse(maxhitpts);

        //armor class
        string armorString = ArmorText.GetComponent<InputField>().text.ToString();
        myCharacter.armorClass = Int32.Parse(armorString);

        //run speed
        string RunSpeedString = RunSpeedText.GetComponent<InputField>().text.ToString();
        myCharacter.RunSpeed = Int32.Parse(RunSpeedString);

        //Jump Height
        string JumpHeightString = JumpHeightText.GetComponent<InputField>().text.ToString();
        myCharacter.JumpHeight = Int32.Parse(JumpHeightString);

        //max experience points
        string maxpString = MXPText.GetComponent<Text>().text;
        myCharacter.MaxExperiencePoints = maxpString; 

        //walk speed
        string speedString = SpeedText.GetComponent<Text>().text;
        myCharacter.WalkSpeed = Int32.Parse(speedString);

        //strength
        string strengthString = StrengthText.GetComponent<Text>().text;
        myCharacter.strength = Int32.Parse(strengthString);

        //dexterity
        string dexterityString = DexterityText.GetComponent<Text>().text;
        myCharacter.dexterity = Int32.Parse(dexterityString);

        //constitution
        string constitutionString = ConstitutionText.GetComponent<Text>().text;
        myCharacter.constitution = Int32.Parse(constitutionString);

        //intelligence
        string intelligenceString = IntelligenceText.GetComponent<Text>().text;
        myCharacter.intelligence = Int32.Parse(intelligenceString);

        //wisdom 
        string wisdomString = WisdomText.GetComponent<Text>().text;
        myCharacter.wisdom = Int32.Parse(wisdomString);

        //charisma
        string charismaString = CharismaText.GetComponent<Text>().text;
        myCharacter.charisma = Int32.Parse(charismaString);

        //item list
        string itemListString = itemListStringText.GetComponent<Text>().text;
        myCharacter.itemList = itemListString; 

        //output
        inputField.GetComponent<InputField>().text = myCharacter.TransformToJSON();
    }

    public class Character : MonoBehaviour {
        public string name;
        public string race;
        public string SelectedClass;
        public string alignment;
        public int CurrentExperiencePoints;
        public string MaxExperiencePoints;
        public int CurrentHitPoints;
        public int MaxHitPoints;
        public int armorClass;
        public int WalkSpeed;
        public int RunSpeed;
        public int JumpHeight;
        public int strength;
        public int dexterity;
        public int constitution;
        public int intelligence;
        public int wisdom;
        public int charisma;
        public string itemList;

        public string TransformToJSON(){
            return JsonUtility.ToJson(this);
        }
    }
}


