using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "Card 0", 0, 0, 0, "If you see this you messed up", Resources.Load<Sprite>("TestImage1")));

        cardList.Add(new Card(1, "Healing Potion", 1, 5, 1, "Instant health regeneration! Heal 5 HP!", Resources.Load<Sprite>("Healing_Potion")));

        cardList.Add(new Card(2, "Mana Potion", 1, 2, 2, "Unleash mystical power! +2 Mana Next Turn!", Resources.Load<Sprite>("Mana_Potion")));

        cardList.Add(new Card(3, "Devil", 1, 7, 3, "A fearsome creature from the underworld. Deal 7 Damage.", Resources.Load<Sprite>("Devil")));

        cardList.Add(new Card(4, "Cyclops", 2, 11, 3, "A one-eyed giant with great strength. Deal 11 Damage.", Resources.Load<Sprite>("Cyclops")));

        cardList.Add(new Card(5, "Ogre", 2, 13, 1, "A brutish and powerful monster. Heal 13 HP.", Resources.Load<Sprite>("Ogre")));

        cardList.Add(new Card(6, "Gremlin", 1, 2, 4, "A mischievous creature known for causing trouble. +2 cards Next Turn.", Resources.Load<Sprite>("Gremlin")));

        cardList.Add(new Card(7, "Gnome", 2, 4, 4, "A small, clever creature with a penchant for technology. +4 Cards Next Turn.", Resources.Load<Sprite>("Gnome")));

        cardList.Add(new Card(8, "Goblin", 1, 2, 4, "A sneaky and cunning humanoid creature. +2 Card Next Turn.", Resources.Load<Sprite>("Goblin")));

        cardList.Add(new Card(9, "Faerie", 1, 9, 1, "A magical being with ethereal wings. Heal 9 HP.", Resources.Load<Sprite>("Faerie")));

        cardList.Add(new Card(10, "Gorgon", 2, 9, 3, "A creature with snakes for hair that can turn enemies to stone. Deal 9 Damage.", Resources.Load<Sprite>("Gorgon")));

        cardList.Add(new Card(11, "Minotaur", 3, 17, 3, "A half-man, half-bull creature with great strength. Deal 17 Damage.", Resources.Load<Sprite>("Minotaur")));

        cardList.Add(new Card(12, "Skeleton", 1, 8, 3, "A reanimated skeleton warrior. Deal 8 Damage", Resources.Load<Sprite>("Skeleton")));

        cardList.Add(new Card(13, "Centaur", 2, 3, 4, "A creature with the upper body of a human and the lower body of a horse. +3 Cards Next Turn.", Resources.Load<Sprite>("Centaur")));

        cardList.Add(new Card(14, "Werewolf", 1, 9, 3, "A creature that transforms into a wolf under the full moon. Deal 9 Damage", Resources.Load<Sprite>("Werewolf")));

        cardList.Add(new Card(15, "Knight", 1, 7, 1, "A skilled and heavily armored warrior. Heal 7 HP.", Resources.Load<Sprite>("Knight")));

        cardList.Add(new Card(16, "Griffin", 2, 10, 3, "A majestic creature with the body of a lion and the head of an eagle. Deal 10 Damage", Resources.Load<Sprite>("Griffin")));

        cardList.Add(new Card(17, "Phoenix", 3, 20, 1, "A mythical bird that is reborn from its ashes. Heal 20 HP", Resources.Load<Sprite>("Phoenix")));

        cardList.Add(new Card(18, "Serpent", 1, 2, 2, "A long and powerful snake. +2 Mana Next Turn", Resources.Load<Sprite>("Serpent")));

        cardList.Add(new Card(19, "Unicorn", 2, 13, 1, "A magical horse with a single horn on its forehead. Heal 13 HP.", Resources.Load<Sprite>("Unicorn")));

        cardList.Add(new Card(20, "Dragon", 3, 5, 4, "A mighty and fire-breathing dragon. +5 Cards Next Turn", Resources.Load<Sprite>("Dragon")));

        cardList.Add(new Card(21, "Chimera", 3, 18, 3, "A creature with the body of a lion, the head of a goat, and the tail of a serpent. Deal 18 Damage", Resources.Load<Sprite>("Chimera")));

        cardList.Add(new Card(22, "Hydra", 3, 20, 1, "A multi-headed serpent with regenerative abilities. Heal 20 HP.", Resources.Load<Sprite>("Hydra")));

        cardList.Add(new Card(23, "Zombie", 1, 6, 1, "A reanimated corpse with a hunger for brains. Heal 6 HP", Resources.Load<Sprite>("Zombie")));

        cardList.Add(new Card(24, "Banshee", 1, 2, 2, "A wailing spirit that foretells doom. +2 Mana Next Turn", Resources.Load<Sprite>("Banshee")));

        cardList.Add(new Card(25, "Vampire", 3, 17, 3, "An immortal creature that feeds on the blood of the living. Deal 17 Damage.", Resources.Load<Sprite>("Vampire")));

        cardList.Add(new Card(26, "Nightmare", 2, 13, 3, "A terrifying and otherworldly being. Deal 13 Damage", Resources.Load<Sprite>("Nightmare")));

        cardList.Add(new Card(27, "Elemental", 2, 12, 3, "A being made of pure elemental energy. Deal 12 Damage", Resources.Load<Sprite>("Elemental")));

        cardList.Add(new Card(28, "Angel", 1, 10, 1, "A celestial being of light and goodness. Heal 10 HP", Resources.Load<Sprite>("Angel")));

        cardList.Add(new Card(29, "Giant", 3, 20, 3, "A colossal humanoid with great strength. Deal 20 damage", Resources.Load<Sprite>("Giant")));

        cardList.Add(new Card(30, "Cthulhu", 3, 17, 3, "An ancient and cosmic horror. Deal 17 Damage", Resources.Load<Sprite>("Cthulhu")));

        cardList.Add(new Card(31, "The King in Yellow", 2, 6, 4, "A mysterious and malevolent entity. +6 Cards Next Turn.", Resources.Load<Sprite>("The King in Yellow")));

        cardList.Add(new Card(32, "Witch", 2, 3, 2, "A practitioner of dark magic. +3 Mana Next Turn", Resources.Load<Sprite>("Witch")));

        cardList.Add(new Card(33, "Bugbear", 2, 12, 1, "A fearsome humanoid creature. Heal 12 HP.", Resources.Load<Sprite>("Bugbear")));

        cardList.Add(new Card(34, "Mothman", 2, 14, 1, "A cryptid with moth-like features that forewarns of disasters. Heal 14 HP", Resources.Load<Sprite>("Mothman")));

        cardList.Add(new Card(35, "Bear", 3, 16, 3, "A powerful and ferocious wild animal. Deal 16 Damage.", Resources.Load<Sprite>("Bear")));

        cardList.Add(new Card(36, "Swine", 1, 2, 4, "A monstrous and grotesque pig-like creature. +2 Cards Next Turn", Resources.Load<Sprite>("Swine")));

        cardList.Add(new Card(37, "Cats of Nine", 1, 3, 4, "A magical cat with nine lives. +3 Cards Next Turn", Resources.Load<Sprite>("Cats of Nine")));

        cardList.Add(new Card(38, "Loyal Hound", 2, 10, 1, "A faithful and loyal canine companion. Heal 10 HP.", Resources.Load<Sprite>("Faithful Hound")));

        cardList.Add(new Card(39, "Rodent of Unusual Size", 1, 7, 3, "An unusually large and formidable rodent. Deal 7 Damage", Resources.Load<Sprite>("Rodent of Unusual Size")));

        cardList.Add(new Card(40, "Killer Rabbit", 1, 14, 3, "A seemingly harmless rabbit with a deadly bite. Deal 14 Damage", Resources.Load<Sprite>("Killer Rabbit")));

        cardList.Add(new Card(41, "Holy Hand Grenade", 3, 30, 3, "A powerful explosive with holy properties. Deal 30 Damage", Resources.Load<Sprite>("Holy Hand Grenade")));

        cardList.Add(new Card(42, "Python", 2, 12, 3, "A large and powerful snake, not to be confused with a serpent. Deal 12 Damage", Resources.Load<Sprite>("Python")));

        cardList.Add(new Card(43, "Spirit", 3, 8, 2, "A disembodied and ethereal entity. +8 Mana next Turn", Resources.Load<Sprite>("Spirit")));

        cardList.Add(new Card(44, "Ent", 1, 10, 1, "A tree-like creature that protects the forest. Heal 10 HP.", Resources.Load<Sprite>("TestImage1")));

        cardList.Add(new Card(45, "Troll", 2, 16, 1, "A large and regenerative creature known for its toughness. Heal 16 HP.", Resources.Load<Sprite>("TestImage1")));

        cardList.Add(new Card(46, "Soldier", 1, 2, 4, "A trained and disciplined warrior. +2 Cards Next Turn", Resources.Load<Sprite>("TestImage1")));

        cardList.Add(new Card(47, "Poet", 1, 2, 2, "A creative soul who weaves magic through words. +2 Mana next Turn", Resources.Load<Sprite>("TestImage1")));

        cardList.Add(new Card(48, "King", 3, 5, 4, "A powerful and authoritative ruler. +5 Cards Next Turn", Resources.Load<Sprite>("TestImage1")));

        cardList.Add(new Card(49, "Wizard", 2, 5, 2, "A master of arcane and magical arts. +5 Mana Next Turn", Resources.Load<Sprite>("TestImage1")));

        cardList.Add(new Card(50, "Wyvern", 3, 25, 3, "A dragon-like creature with two legs and wings. Deal 25 Damage.", Resources.Load<Sprite>("TestImage1")));
    }
}
