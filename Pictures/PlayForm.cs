using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Exp6_Grp10.Pictures
{
    public partial class PlayForm : Form
    {
        List<Question> generalCultureQuestions = new List<Question>
{
    new Question { Category = "General Culture", Difficulty = "Easy", Word = "Earth", Clue = "Which planet do we live on?" },
    new Question { Category = "General Culture", Difficulty = "Medium", Word = "EiffelTower", Clue = "What famous landmark is located in Paris?" },
    new Question { Category = "General Culture", Difficulty = "Hard", Word = "MonaLisa", Clue = "What is the name of the famous painting by Leonardo da Vinci?" },
    new Question { Category = "General Culture", Difficulty = "Easy", Word = "Water", Clue = "What liquid is essential for all known forms of life?" },
    new Question { Category = "General Culture", Difficulty = "Medium", Word = "Shakespeare", Clue = "Who wrote 'Romeo and Juliet'?" },
    new Question { Category = "General Culture", Difficulty = "Hard", Word = "Vatican", Clue = "What is the smallest country in the world?" },
    new Question { Category = "General Culture", Difficulty = "Easy", Word = "Sun", Clue = "What is the star at the center of our solar system?" },
    new Question { Category = "General Culture", Difficulty = "Medium", Word = "MountEverest", Clue = "What is the tallest mountain on Earth?" },
    new Question { Category = "General Culture", Difficulty = "Hard", Word = "Nobel", Clue = "What prize is awarded for peace, literature, and sciences?" },
    new Question { Category = "General Culture", Difficulty = "Easy", Word = "Cat", Clue = "What is a common domestic pet that purrs?" },
    new Question { Category = "General Culture", Difficulty = "Medium", Word = "Amazon", Clue = "What is the largest rainforest in the world?" },
    new Question { Category = "General Culture", Difficulty = "Hard", Word = "Sahara", Clue = "What is the largest hot desert in the world?" },
    new Question { Category = "General Culture", Difficulty = "Easy", Word = "France", Clue = "Which country is famous for baguettes and wine?" },
    new Question { Category = "General Culture", Difficulty = "Medium", Word = "Olympics", Clue = "What international event features summer and winter sports?" },
    new Question { Category = "General Culture", Difficulty = "Hard", Word = "UNESCO", Clue = "Which organization protects world cultural heritage?" },
    new Question { Category = "General Culture", Difficulty = "Easy", Word = "Blue", Clue = "What color is the sky on a clear day?" },
    new Question { Category = "General Culture", Difficulty = "Medium", Word = "Tesla", Clue = "Who invented the alternating current system?" },
    new Question { Category = "General Culture", Difficulty = "Hard", Word = "HagiaSophia", Clue = "Which historical site in Istanbul was once a church and a mosque?" },
    new Question { Category = "General Culture", Difficulty = "Easy", Word = "Coffee", Clue = "Which drink is made from roasted beans and often consumed in the morning?" },
    new Question { Category = "General Culture", Difficulty = "Medium", Word = "GreatWall", Clue = "Which structure in China is visible from space?" }
};
        List<Question> foodQuestions = new List<Question>
{
    new Question { Category = "Food", Difficulty = "Easy", Word = "Pizza", Clue = "Which Italian dish is made with dough, sauce, and cheese?" },
    new Question { Category = "Food", Difficulty = "Medium", Word = "Sushi", Clue = "Which Japanese dish consists of rice and raw fish?" },
    new Question { Category = "Food", Difficulty = "Hard", Word = "Truffle", Clue = "Which expensive mushroom is often used in gourmet dishes?" },
    new Question { Category = "Food", Difficulty = "Easy", Word = "Apple", Clue = "What fruit keeps the doctor away?" },
    new Question { Category = "Food", Difficulty = "Medium", Word = "Falafel", Clue = "What is a Middle Eastern deep-fried ball made of chickpeas?" },
    new Question { Category = "Food", Difficulty = "Hard", Word = "Caviar", Clue = "Which luxury food is made from fish eggs?" },
    new Question { Category = "Food", Difficulty = "Easy", Word = "IceCream", Clue = "Which cold dessert comes in many flavors?" },
    new Question { Category = "Food", Difficulty = "Medium", Word = "Kimchi", Clue = "What spicy fermented cabbage is a Korean staple?" },
    new Question { Category = "Food", Difficulty = "Hard", Word = "Saffron", Clue = "What is the world’s most expensive spice by weight?" },
    new Question { Category = "Food", Difficulty = "Easy", Word = "Banana", Clue = "What yellow fruit is a good source of potassium?" },
    new Question { Category = "Food", Difficulty = "Medium", Word = "Taco", Clue = "What Mexican food is made with tortillas?" },
    new Question { Category = "Food", Difficulty = "Hard", Word = "Umami", Clue = "What is the fifth basic taste?" },
    new Question { Category = "Food", Difficulty = "Easy", Word = "Milk", Clue = "What drink comes from cows and is white?" },
    new Question { Category = "Food", Difficulty = "Medium", Word = "Couscous", Clue = "What grain-like pasta is a staple in North Africa?" },
    new Question { Category = "Food", Difficulty = "Hard", Word = "Foiegras", Clue = "Which French delicacy is made from duck liver?" },
    new Question { Category = "Food", Difficulty = "Easy", Word = "Egg", Clue = "What food comes from chickens and is used in omelets?" },
    new Question { Category = "Food", Difficulty = "Medium", Word = "Tofu", Clue = "What soy product is popular in vegetarian diets?" },
    new Question { Category = "Food", Difficulty = "Hard", Word = "Tempeh", Clue = "What Indonesian soy product is similar to tofu?" },
    new Question { Category = "Food", Difficulty = "Easy", Word = "Rice", Clue = "What grain is a staple in Asian cuisine?" },
    new Question { Category = "Food", Difficulty = "Medium", Word = "Churros", Clue = "What Spanish fried dough is coated in sugar?" }
};
        List<Question> breadQuestions = new List<Question>
{
    new Question { Category = "Bread", Difficulty = "Easy", Word = "Etliekmek", Clue = "What is the OBJECTIVELY best Bread ever?God given that to Konya folk for enduring the punishment of living there." },
    new Question { Category = "Bread", Difficulty = "Medium", Word = "Sourdough", Clue = "Which bread uses natural yeast and has a tangy taste?" },
    new Question { Category = "Bread", Difficulty = "Hard", Word = "Ciabatta", Clue = "Which Italian bread has a flat shape and many air holes?" },
    new Question { Category = "Bread", Difficulty = "Easy", Word = "Toast", Clue = "What do you call bread that's browned in a toaster?" },
    new Question { Category = "Bread", Difficulty = "Medium", Word = "Pita", Clue = "Which round flatbread often has a pocket?" },
    new Question { Category = "Bread", Difficulty = "Hard", Word = "Brioche", Clue = "Which French bread is rich with butter and eggs?" },
    new Question { Category = "Bread", Difficulty = "Easy", Word = "Sandwich", Clue = "What meal is made by putting fillings between slices of bread?" },
    new Question { Category = "Bread", Difficulty = "Medium", Word = "Bagel", Clue = "Which bread is boiled before baking and has a hole in the middle?" },
    new Question { Category = "Bread", Difficulty = "Hard", Word = "Focaccia", Clue = "What Italian flatbread is often topped with herbs and olive oil?" },
    new Question { Category = "Bread", Difficulty = "Easy", Word = "Bun", Clue = "What small, round bread is used for burgers?" },
    new Question { Category = "Bread", Difficulty = "Medium", Word = "Naan", Clue = "Which bread is baked in a tandoor and common in Indian cuisine?" },
    new Question { Category = "Bread", Difficulty = "Hard", Word = "Lavash", Clue = "Which soft, thin flatbread comes from Turkey,Used for wrapping Çiğköfte?" },
    new Question { Category = "Bread", Difficulty = "Easy", Word = "Roll", Clue = "What is a small, individual piece of bread called?" },
    new Question { Category = "Bread", Difficulty = "Medium", Word = "Rye", Clue = "Which bread is made from rye flour and has a strong taste?" },
    new Question { Category = "Bread", Difficulty = "Hard", Word = "Challah", Clue = "Which braided bread is traditional in Jewish cuisine?" },
    new Question { Category = "Bread", Difficulty = "Easy", Word = "Crust", Clue = "What is the outer part of bread called?" },
    new Question { Category = "Bread", Difficulty = "Medium", Word = "Cornbread", Clue = "Which American bread is made from cornmeal?" },
    new Question { Category = "Bread", Difficulty = "Hard", Word = "Zopf", Clue = "Which Swiss bread is braided and eaten on Sundays?" },
    new Question { Category = "Bread", Difficulty = "Easy", Word = "Whitebread", Clue = "What type of bread is made from refined flour?" },
    new Question { Category = "Bread", Difficulty = "Medium", Word = "Wholegrain", Clue = "Which bread contains all parts of the grain?" }
};
        List<Question> gamesQuestions = new List<Question>
{
    new Question { Category = "Games", Difficulty = "Easy", Word = "Chess", Clue = "Which board game includes kings, queens, and pawns?" },
    new Question { Category = "Games", Difficulty = "Medium", Word = "PacMan", Clue = "Which arcade game features a yellow character eating dots?" },
    new Question { Category = "Games", Difficulty = "Hard", Word = "DungeonsNDragons", Clue = "Which tabletop game uses dice and role-playing?" },
    new Question { Category = "Games", Difficulty = "Easy", Word = "Soccer", Clue = "What sport is played with a round ball and goals?" },
    new Question { Category = "Games", Difficulty = "Medium", Word = "Mario", Clue = "Which character is a plumber in a famous Nintendo series?" },
    new Question { Category = "Games", Difficulty = "Hard", Word = "Go", Clue = "Which ancient board game uses black and white stones?" },
    new Question { Category = "Games", Difficulty = "Easy", Word = "Tetris", Clue = "Which game involves stacking falling blocks?" },
    new Question { Category = "Games", Difficulty = "Medium", Word = "Minecraft", Clue = "Which sandbox game allows players to build with blocks?" },
    new Question { Category = "Games", Difficulty = "Hard", Word = "ClairObscur", Clue = "What is the current hot Turn based game of this year?" },
    new Question { Category = "Games", Difficulty = "Easy", Word = "Uno", Clue = "Which card game uses colors and numbers?" },
    new Question { Category = "Games", Difficulty = "Medium", Word = "Zelda", Clue = "Which game series features a hero named Link?" },
    new Question { Category = "Games", Difficulty = "Hard", Word = "EVEOnline", Clue = "Which space game is known for its economy and massive battles?" },
    new Question { Category = "Games", Difficulty = "Easy", Word = "Basketball", Clue = "What game is played with a hoop and an orange ball?" },
    new Question { Category = "Games", Difficulty = "Medium", Word = "Pokémon", Clue = "Which game involves catching and training creatures?" },
    new Question { Category = "Games", Difficulty = "Hard", Word = "Sekiro", Clue = "Which action game is set in feudal Japan and known for difficulty?" },
    new Question { Category = "Games", Difficulty = "Easy", Word = "Checkers", Clue = "What board game involves jumping over your opponent?" },
    new Question { Category = "Games", Difficulty = "Medium", Word = "Overwatch", Clue = "Which team shooter has characters with special abilities?" },
    new Question { Category = "Games", Difficulty = "Hard", Word = "StarCraft", Clue = "Which real-time strategy game involves Protoss, Terran, and Zerg?" },
    new Question { Category = "Games", Difficulty = "Easy", Word = "Pong", Clue = "Which is one of the first video games involving a bouncing ball?" },
    new Question { Category = "Games", Difficulty = "Medium", Word = "TheSims", Clue = "Which life simulation game allows controlling virtual people?" }
};
        List<Question> historyQuestions = new List<Question>
{
    new Question { Category = "History", Difficulty = "Easy", Word = "Napoleon", Clue = "Who was the French military leader exiled to Elba?" },
    new Question { Category = "History", Difficulty = "Medium", Word = "BerlinWall", Clue = "What structure divided East and West Germany until 1989?" },
    new Question { Category = "History", Difficulty = "Hard", Word = "TreatyofVersailles", Clue = "Which treaty ended World War I?" },
    new Question { Category = "History", Difficulty = "Easy", Word = "JuliusCaesar", Clue = "Which Roman leader was assassinated on the Ides of March?" },
    new Question { Category = "History", Difficulty = "Medium", Word = "Renaissance", Clue = "What cultural movement began in Italy in the 14th century?" },
    new Question { Category = "History", Difficulty = "Hard", Word = "MagnaCarta", Clue = "What 1215 document limited the power of the English king?" },
    new Question { Category = "History", Difficulty = "Easy", Word = "AbrahamLincoln", Clue = "Who was the U.S. president during the Civil War?" },
    new Question { Category = "History", Difficulty = "Medium", Word = "IndustrialRevolution", Clue = "What period saw major industrial changes in the 18th and 19th centuries?" },
    new Question { Category = "History", Difficulty = "Hard", Word = "Hammurabi", Clue = "Who created one of the earliest known legal codes?" },
    new Question { Category = "History", Difficulty = "Easy", Word = "ChristopherColumbus", Clue = "Who is credited with discovering the Americas in 1492?" },
    new Question { Category = "History", Difficulty = "Medium", Word = "ColdWar", Clue = "What term describes the tension between the U.S. and USSR after WWII?" },
    new Question { Category = "History", Difficulty = "Hard", Word = "BattleofHastings", Clue = "Which 1066 battle led to Norman control of England?" },
    new Question { Category = "History", Difficulty = "Easy", Word = "GeorgeWashington", Clue = "Who was the first President of the United States?" },
    new Question { Category = "History", Difficulty = "Medium", Word = "GreatDepression", Clue = "What was the global economic downturn in the 1930s called?" },
    new Question { Category = "History", Difficulty = "Hard", Word = "SuleimantheMagnificent", Clue = "Which Ottoman sultan ruled during the empire's peak?" },
    new Question { Category = "History", Difficulty = "Easy", Word = "WorldWarII", Clue = "Which global conflict lasted from 1939 to 1945?" },
    new Question { Category = "History", Difficulty = "Medium", Word = "NelsonMandela", Clue = "Who became South Africa's first Black president in 1994?" },
    new Question { Category = "History", Difficulty = "Hard", Word = "MaoZedong", Clue = "Who led the Chinese Communist Revolution?" },
    new Question { Category = "History", Difficulty = "Easy", Word = "Pyramids", Clue = "What ancient structures are found in Egypt?" },
    new Question { Category = "History", Difficulty = "Medium", Word = "Gutenberg", Clue = "Who invented the movable-type printing press?" }
};
        List<Question> mathQuestions = new List<Question>
{
    new Question { Category = "Math", Difficulty = "Easy", Word = "Pi", Clue = "What is the ratio of a circle's circumference to its diameter?" },
    new Question { Category = "Math", Difficulty = "Medium", Word = "PythagoreanTheorem", Clue = "Which theorem relates the sides of a right triangle?" },
    new Question { Category = "Math", Difficulty = "Hard", Word = "Fibonacci", Clue = "Which sequence starts with 0 and 1, with each number the sum of the two preceding ones?" },
    new Question { Category = "Math", Difficulty = "Easy", Word = "Triangle", Clue = "What shape has three sides?" },
    new Question { Category = "Math", Difficulty = "Medium", Word = "QuadraticEquation", Clue = "What type of equation is in the form ax² + bx + c = 0?" },
    new Question { Category = "Math", Difficulty = "Hard", Word = "EulersIdentity", Clue = "Which equation is considered the most beautiful in mathematics, involving e, i, and π?" },
    new Question { Category = "Math", Difficulty = "Easy", Word = "Addition", Clue = "What is the mathematical operation of combining two numbers?" },
    new Question { Category = "Math", Difficulty = "Medium", Word = "PrimeNumber", Clue = "What do you call a number greater than 1 with no positive divisors other than 1 and itself?" },
    new Question { Category = "Math", Difficulty = "Hard", Word = "ImaginaryNumber", Clue = "What type of number is the square root of -1?" },
    new Question { Category = "Math", Difficulty = "Easy", Word = "Zero", Clue = "What number represents nothing?" },
    new Question { Category = "Math", Difficulty = "Medium", Word = "Factorial", Clue = "What is the product of all positive integers up to a given number?" },
    new Question { Category = "Math", Difficulty = "Hard", Word = "GoldenRatio", Clue = "What is the special number approximately equal to 1.618, often found in nature and art?" },
    new Question { Category = "Math", Difficulty = "Easy", Word = "Circle", Clue = "What shape is perfectly round and has all points equidistant from the center?" },
    new Question { Category = "Math", Difficulty = "Medium", Word = "Logarithm", Clue = "What is the inverse operation of exponentiation?" },
    new Question { Category = "Math", Difficulty = "Hard", Word = "Matrix", Clue = "What is a rectangular array of numbers or expressions arranged in rows and columns?" },
    new Question { Category = "Math", Difficulty = "Easy", Word = "EvenNumber", Clue = "What do you call a number divisible by 2?" },
    new Question { Category = "Math", Difficulty = "Medium", Word = "Probability", Clue = "What measures the likelihood of an event occurring?" },
    new Question { Category = "Math", Difficulty = "Hard", Word = "Topology", Clue = "What branch of mathematics studies properties preserved under continuous deformations?" },
    new Question { Category = "Math", Difficulty = "Easy", Word = "Square", Clue = "What is the result of multiplying a number by itself?" },
    new Question { Category = "Math", Difficulty = "Medium", Word = "Derivative", Clue = "In calculus, what represents the rate of change of a function?" }
};
        List<Question> computerQuestions = new List<Question>
{
    new Question { Category = "Computer", Difficulty = "Easy", Word = "Keyboard", Clue = "What input device is used to type text into a computer?" },
    new Question { Category = "Computer", Difficulty = "Medium", Word = "OperatingSystem", Clue = "What software manages computer hardware and software resources?" },
    new Question { Category = "Computer", Difficulty = "Hard", Word = "AlanTuring", Clue = "Who is considered the father of modern computing?" },
    new Question { Category = "Computer", Difficulty = "Easy", Word = "Mouse", Clue = "What device controls the pointer on a computer screen?" },
    new Question { Category = "Computer", Difficulty = "Medium", Word = "RAM", Clue = "What type of memory is used for temporary data storage while a computer is running?" },
    new Question { Category = "Computer", Difficulty = "Hard", Word = "ENIAC", Clue = "What was the name of the first general-purpose electronic computer?" },
    new Question { Category = "Computer", Difficulty = "Easy", Word = "Monitor", Clue = "What device displays visual output from a computer?" },
    new Question { Category = "Computer", Difficulty = "Medium", Word = "Firewall", Clue = "What security system controls incoming and outgoing network traffic?" },
    new Question { Category = "Computer", Difficulty = "Hard", Word = "Linux", Clue = "What open-source operating system was created by Linus Torvalds?" },
    new Question { Category = "Computer", Difficulty = "Easy", Word = "Printer", Clue = "What device produces a hard copy of digital documents?" },
    new Question { Category = "Computer", Difficulty = "Medium", Word = "CloudComputing", Clue = "What term describes delivering computing services over the internet?" },
    new Question { Category = "Computer", Difficulty = "Hard", Word = "QuantumComputing", Clue = "What type of computing uses quantum bits or qubits?" },
    new Question { Category = "Computer", Difficulty = "Easy", Word = "USB", Clue = "What is the common interface for connecting peripherals to a computer?" },
    new Question { Category = "Computer", Difficulty = "Medium", Word = "Algorithm", Clue = "What is a step-by-step procedure for solving a problem or performing a task?" },
    new Question { Category = "Computer", Difficulty = "Hard", Word = "ArtificialIntelligence", Clue = "What field involves machines simulating human intelligence?" },
    new Question { Category = "Computer", Difficulty = "Easy", Word = "Browser", Clue = "What software is used to access and view websites?" },
    new Question { Category = "Computer", Difficulty = "Medium", Word = "Database", Clue = "What organized collection of data can be easily accessed, managed, and updated?" },
    new Question { Category = "Computer", Difficulty = "Hard", Word = "Blockchain", Clue = "What technology underlies cryptocurrencies like Bitcoin?" },
    new Question { Category = "Computer", Difficulty = "Easy", Word = "Wi-Fi", Clue = "What technology allows wireless connection to the internet?" },
    new Question { Category = "Computer", Difficulty = "Medium", Word = "Compiler", Clue = "What translates source code into executable programs?" },
     new Question { Category = "Computer", Difficulty = "Hard", Word = "TerryADavis", Clue = "Who wrote the TempleOS?" }
};
        string selectedWord;
        char[] guessedWord;
        string clue;
        int score = 100;
        int wrongGuesses = 0;
        int timeLeft;
        bool gameOver = false;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        List<char> wrongLetters = new List<char>();
        Random rnd = new Random();
        private GameSettings settings = new GameSettings(); // Ensure it's initialized
        public void StartTheGame()
        {
            // Seçilen kategoriye göre doğru listeyi belirle
            List<Question> selectedQuestionList = settings.SelectedCategory switch
            {
                "General Culture" => generalCultureQuestions,
                "Food" => foodQuestions,
                "Bread" => breadQuestions,
                "Games" => gamesQuestions,
                "History" => historyQuestions,
                "Math" => mathQuestions,
                "Computer" => computerQuestions,
                _ => new List<Question>()
            };

            // Seçilen zorluk seviyesine göre soruları filtrele
            var filteredQuestions = selectedQuestionList
                .Where(q => q.Difficulty.Equals(settings.SelectedDifficulty, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Eğer uygun soru bulunamazsa kullanıcıya bilgi ver
            if (filteredQuestions.Count == 0)
            {
                MessageBox.Show("Seçilen kategori ve zorluk seviyesine uygun soru bulunamadı!");
                return;
            }

            // Rastgele bir soru seç
            int index = rnd.Next(filteredQuestions.Count);
            var selectedQuestion = filteredQuestions[index];

            // Seçilen soruyu oyun için ayarla
            selectedWord = selectedQuestion.Word.ToUpper();
            clue = selectedQuestion.Clue;
            timeLeft = settings.GameDuration;
            // Oyun başlangıç ayarlarını yap
            guessedWord = new string('_', selectedWord.Length).ToCharArray();
            WordLabel.Text = string.Join(" ", guessedWord);
            WorlLengthLbl.Text = $"Kelime Uzunluğu: {selectedWord.Length}";
            PointLabel.Text = $"Puan: {score}";
            WrongLetterLbl.Text = "Yanlış harfler: ";
            DiffInfoLbl.Text = $"Topic: {settings.SelectedCategory} Difficulty: {settings.SelectedDifficulty} Time: {settings.GameDuration / 60:D2}:{settings.GameDuration % 60:D2}";
            this.BackColor = DefaultBackColor;

            // Görselleri güncelle
            UpdateHangmanImage();
        }

        private void GuessBtn_Click(object sender, EventArgs e)
        {
            string input = GuessTxtBox.Text.ToUpper();
            GuessTxtBox.Clear();
            if (input.Length != 1 || !char.IsLetter(input[0]))
            {
                MessageBox.Show("Lütfen Geçerli ve Tek bir Harf Girin.");
                return;
            }
            char guess = input[0];

            if (guessedWord.Contains(guess) || wrongLetters.Contains(guess))
            {
                MessageBox.Show("Zaten Bu harfi yazdın.");
                return;
            }
            if (selectedWord.Contains(guess))
            {
                for (int i = 0; i < selectedWord.Length; i++)
                    if (selectedWord[i] == guess)
                        guessedWord[i] = guess;

                WordLabel.Text = string.Join(" ", guessedWord);

                if (!guessedWord.Contains('_'))
                {
                    this.BackColor = Color.LightGreen;
                    timer1.Stop();
                    timer.Stop();
                    MessageBox.Show("Aferin Len!");
                    settings.ResetToDefaults();
                    GuessTxtBox.Enabled = false;
                    GuessBtn.Enabled = false;
                    StartGame start = new StartGame(settings);
                    start.Show();
                    this.Close();
                    
                }
            }
            else
            {
                wrongGuesses++;
                score -= 10;
                PointLabel.Text = $"Puan: {score}";
                wrongLetters.Add(guess);
                WrongLetterLbl.Text = "Yanlış Harfler: " + string.Join(", ", wrongLetters);
                UpdateHangmanImage();

                if (wrongGuesses >= 10)
                {
                    UpdateHangmanImage();
                    timer1.Stop();
                    timer.Stop();
                    this.BackColor = Color.LightCoral;
                    MessageBox.Show($"Vay Kolsuzum Vay! Kelimen: {selectedWord} idi");
                    WordLabel.Text = string.Join(" ", selectedWord.ToCharArray());
                    settings.ResetToDefaults();
                    GuessTxtBox.Enabled = false;
                    GuessBtn.Enabled = false;
                    StartGame start = new StartGame(settings);
                    start.Show();
                    this.Close();
                }
            }
        }
        private void UpdateHangmanImage()
        {
            switch (wrongGuesses)
            {
                case 0:
                    if (settings.SelectedImageType == "Hangman")
                    {
                        hangManpb.Image = Properties.Resources.man_01;
                    }
                    else if (settings.SelectedImageType == "Snowman")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Snowman_01))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    else if (settings.SelectedImageType == "Bread")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Bread_01))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    break;
                case 1:
                    if (settings.SelectedImageType == "Hangman")
                    {
                        hangManpb.Image = Properties.Resources.man_02;
                    }
                    else if (settings.SelectedImageType == "Snowman")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Snowman_02))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    else if (settings.SelectedImageType == "Bread")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Bread_02))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    break;
                case 2:
                    if (settings.SelectedImageType == "Hangman")
                    {
                        hangManpb.Image = Properties.Resources.man_03;
                    }
                    else if (settings.SelectedImageType == "Snowman")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Snowman_03))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    else if (settings.SelectedImageType == "Bread")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Bread_03))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    break;
                case 3:
                    if (settings.SelectedImageType == "Hangman")
                    {
                        hangManpb.Image = Properties.Resources.man_04;
                    }
                    else if (settings.SelectedImageType == "Snowman")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Snowman_04))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    else if (settings.SelectedImageType == "Bread")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Bread_04))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    break;
                case 4:
                    if (settings.SelectedImageType == "Hangman")
                    {
                        hangManpb.Image = Properties.Resources.man_05;
                    }
                    else if (settings.SelectedImageType == "Snowman")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Snowman_05))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    else if (settings.SelectedImageType == "Bread")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Bread_05))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    break;
                case 5:
                    if (settings.SelectedImageType == "Hangman")
                    {
                        hangManpb.Image = Properties.Resources.man_06;
                    }
                    else if (settings.SelectedImageType == "Snowman")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Snowman_06))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    else if (settings.SelectedImageType == "Bread")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Bread_06))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    break;
                case 6:
                    if (settings.SelectedImageType == "Hangman")
                    {
                        hangManpb.Image = Properties.Resources.man_07;
                    }
                    else if (settings.SelectedImageType == "Snowman")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Snowman_07))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    else if (settings.SelectedImageType == "Bread")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Bread_07))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    break;
                case 7:
                    if (settings.SelectedImageType == "Hangman")
                    {
                        hangManpb.Image = Properties.Resources.man_08;
                    }
                    else if (settings.SelectedImageType == "Snowman")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Snowman_08))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    else if (settings.SelectedImageType == "Bread")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Bread_08))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    break;
                case 8:
                    if (settings.SelectedImageType == "Hangman")
                    {
                        hangManpb.Image = Properties.Resources.man_09;
                    }
                    else if (settings.SelectedImageType == "Snowman")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Snowman_09))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    else if (settings.SelectedImageType == "Bread")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Bread_09))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    break;
                case 9:
                    if (settings.SelectedImageType == "Hangman")
                    {
                        hangManpb.Image = Properties.Resources.man_10;
                    }
                    else if (settings.SelectedImageType == "Snowman")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Snowman_10))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    else if (settings.SelectedImageType == "Bread")
                    {
                        using (var ms = new MemoryStream(Properties.Resources.Bread_10))
                        {
                            hangManpb.Image = Image.FromStream(ms);
                        }
                    }
                    break;
            }
        }

        private void GameOverBtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oyun sarmadı mı hacı?", "Çıkış", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show("De GET lo.");
                settings.ResetToDefaults();
                this.Close();
                StartGame start = new StartGame(settings);
                start.Show();
            }
        }

        private void TipButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clue, "Ok", MessageBoxButtons.OK);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timeLeft--;
            TimerLbl.Text = $"{timeLeft / 60:D2}:{timeLeft % 60:D2}";
            if (timeLeft <= 0 && !gameOver)
            {
                gameOver = true;
                timer.Stop();
                timer1.Stop();
                this.BackColor = Color.LightCoral;
                MessageBox.Show($"Vay Hantal Kaplumbağam Vay! Kelimen: {selectedWord} idi.Bi daha Dene!");
                settings.ResetToDefaults();
                WordLabel.Text = string.Join(" ", selectedWord.ToCharArray());
                GuessTxtBox.Enabled = false;
                GuessBtn.Enabled = false;
                StartGame start = new StartGame(settings);
                start.Show();
                this.Close();
            }
        }
        public PlayForm(GameSettings settings)
        {
            InitializeComponent();
            this.settings = settings ?? throw new ArgumentNullException(nameof(settings));

            // Initialize non-nullable fields to default values  
            selectedWord = string.Empty;
            guessedWord = Array.Empty<char>();
            clue = string.Empty;

            StartTheGame();
            timer1.Interval = 1000;
            timer1.Start();
        }

    }
    public class Question
    {
        public string Category { get; set; } = string.Empty; // Kategori (Tarih, Matematik vb.)  
        public string Difficulty { get; set; } = string.Empty; // Zorluk (Kolay, Orta, Zor)  
        public string Word { get; set; } = string.Empty; // Kelime  
        public string Clue { get; set; } = string.Empty; // İpucu  
    }
}
