using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{

    public static class GameLogic
    {

        //Variables
        public static int CountGuesses { get; set; }
        public static bool GameWon { get; set; }
        public static string FullWord { get; set; }
        public static string SecretWord { get; set; }
        public static bool IsCorrectWord { get; set; }
        public static bool IsCorrectLetter { get; set; }
        public static bool GameLost { get; set; }



        /// <summary>
        /// Setup start condition
        /// </summary>
        public static void SetupStartCondition()
        {
            CountGuesses = 0;
            GameWon = false;
            GameLost = true;
            FullWord = GetOneWord(); //TODO: Will be replaced with random word
            SecretWord = GetSecretWord(); //TODO: Will be replaced with underscores
            IsCorrectLetter = false;
            IsCorrectWord = false;

        }
        public static bool IsWordCorrect(string fullword)
        {
            if (fullword == FullWord)
            {
                GameWon = true;
                return GameWon;
            }
            else
            {
                CountGuesses++;
                if (CountGuesses >= 10)
                {
                    GameLost = false;
                    return GameLost;
                }
                else
                    return false;
            }

        }

        /// <summary>
        /// Hides secret word with "_" while also giving hints 
        /// to the amount of letters for the word.
        /// </summary>
        /// <returns></returns>
        public static string GetSecretWord()
        {
            SecretWord = string.Empty;
            foreach (var letter in FullWord)
            {
                SecretWord += "_ ";
            }
            return SecretWord;
        }

        /// <summary>
        /// Gets one random word from the GetWords()-method
        /// </summary>
        /// <returns></returns>
        public static string GetOneWord()
        {
            Random random = new Random();

            List<string> words = GameLogic.Getwords();
            int randomNo = random.Next(words.Count);

            string FullWord = words[randomNo];
            return FullWord.ToUpper();
        }

        /// <summary>
        /// A list of a thousand words to use in the game - can be extended
        /// </summary>
        /// <returns></returns>
        private static List<string> Getwords()
        {
            List<string> words = new List<string>(new string[]{"about", "above", "across", "act", "actor", "active", "activity", "add", "afraid", "after", "again", "age", "ago", "agree", "air", "all", "alone",
                "along", "already", "always", "Allah", "amount", "Abyss", "Asteroid", "angry", "another", "answer", "ant", "anyone", "anything", "anytime", "appear", "apple", "amature", "area",
                "arm", "army", "around", "arrive", "art", "Alpha", "ashes", "amount", "animal", "attack", "aunt", "autumn", "amazing", "baby", "base", "back", "bad", "bag", "ball", "bank", "basket", "bath", "be",
                "bean", "bear", "beautiful", "beer", "bed", "bedroom", "behave", "before", "begin", "behind", "bell", "below", "besides", "best", "better", "between", "big", "bird", "birth", "birthday", "bit", "bite",
                "black", "bleed", "block", "blood", "blow", "blue", "board ", "boat", "body", "boil", "bone", "book", "border", "born", "borrow", "both", "bottle", "bottom", "bowl", "box", "boy", "branch", "brave",
                "bread", "break", "breakfast", "breathe", "bridge", "bright", "bring", "brother", "brown", "brush", "build", "burn", "business", "bus", "busy", "but", "buy", "by", "cake", "call", "can", "candle", "cap",
                "car", "card", "care", "careful", "careless", "carry", "case", "cat", "catch", "central", "century", "certain", "chair", "chance", "change", "chase", "cheap",
                "cheese", "chicken", "child", "children", "chocolate", "choice", "choose", "circle", "city", "class", "clever", "clean", "clear", "climb", "clock", "cloth",
                "clothes", "cloud", "cloudy", "close", "coffee", "coat", "coin", "cold", "collect", "colour", "comb", "come", "comfortable", "common", "compare", "complete", "computer",
                "condition", "continue", "control", "cook", "cool", "copper", "corn", "corner", "correct", "cost", "contain", "count", "country", "course", "cover", "crash",
                "cross", "cry", "cup", "cupboard", "cut", "each", "ear", "early", "earn", "earth", "east", "easy", "eat", "education", "effect", "egg", "eight", "either", "electric", "elephant",
                "else", "empty", "end", "enemy", "enjoy", "enough", "enter", "equal", "entrance", "escape", "even", "evening", "event", "ever", "every", "everyone", "exact", "everybody", "examination",
                "example", "except", "excited", "exercise", "expect", "expensive", "explain", "extremely", "eye", "face", "fact", "fail", "fall", "false", "family", "famous", "far", "farm", "father", "fast", "fat",
                "fault", "fear", "feed", "feel", "female", "fever", "few", "fight", "fill", "film", "find", "fine", "finger", "finish", "fire", "first", "fit", "five", "fix", "flag", "flat", "float", "floor", "flour", "flower",
                "fly", "fold", "food", "fool", "foot", "football", "for", "force", "foreign", "forest", "forget", "forgive", "fork", "form", "fox", "four", "flour", "free", "freedom", "freeze",
                "fresh", "friend", "friendly", "from", "front", "fruit", "full", "fun", "funny", "furniture", "further", "future", "game", "garden", "gate", "general", "gentleman", "get", "gift", "give",
                "glad", "glass", "go", "goat", "god", "gold", "good", "goodbye", "grandfather", "grandmother", "grass", "grave", "great", "green", "grey", "hair", "half", "hall", "hammer",
                "hand", "happen", "happy", "hard", "hat", "hate", "have", "he", "head", "healthy", "hear", "heavy", "hello", "help", "heart", "heaven", "height", "hen", "her", "here", "hers",
                "hide", "high", "hill", "him", "his", "hit", "hobby", "hold", "hole", "holiday", "home", "hope", "horse", "hospital", "hot", "hotel", "house", "how", "hundred", "hungry",
                "hour", "hurry", "husband", "hurt", "ground", "group", "grow", "gun", "I", "ice", "icing", "idea", "if", "important", "in", "increase", "inside", "into", "introduce", "invent", "iron", "invite",
                "is", "island", "it", "its", "itself"});

            return words;

        }

        public static bool CorrectLetter(char letter)
        {
            string secretWordTrimmed = SecretWord.Trim();
            string[] splitWord = secretWordTrimmed.Split();
                        
            if (FullWord.Contains(letter))
            {                    
                    
                         for (int i = 0; i <= FullWord.Length-1; i++)
                         {
                             if (FullWord[i] == letter)
                             {
                                 splitWord[i] = letter.ToString();
                             }
                         }

                SecretWord = string.Join(" ", splitWord);
                IsCorrectLetter = true;
                
                if (!SecretWord.Contains('_'))
                {
                    GameWon = true;
                    return GameWon;
                }

                return IsCorrectLetter;
            }
            else
            {
                IsCorrectLetter = false;
                CountGuesses++;
                return IsCorrectLetter;
            }

           

        }

    }
}