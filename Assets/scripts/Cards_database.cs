    using UnityEngine;
    using System.Collections;

        [System.Serializable]
    public class Cards_database{
        public string cardName;
        public string idCard;
        public int power;
        public int Health;
        public float Stmina;
        public int Exp;
        public int Level;
        public Powertype itemtype;
        public enum Powertype {
            FIRE,
            WATER,
            ERTH,
            TIME,
            ELECTRIC,
            TOXIC,
        }
    public Cards_database(string name,string uniq_id,int strong,int health,float stmina1,int exp1,int level1,Powertype type)
    {
        cardName = name;
        idCard = uniq_id;
        strong = power;
        Health = health;
        Stmina = stmina1;
        Exp = exp1;
        Level = level1;
        itemtype = type;
    }
    }
