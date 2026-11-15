using System;

class GameTrivia 
{
    public static void Main(string[] args) 
    {
        Random rand = new Random();
        int totalScore = 0;
        bool startRand = true;
        bool startGame = true;
        bool startTrivia = false;
       
        string country = "";
        Console.WriteLine("   ==========================================");
        Console.WriteLine("  /                                          \\");
        Console.WriteLine("<<       WELCOME TO THE COUNTRY TRIVIA        >>  ");
        Console.WriteLine("  \\                                          /");
        Console.WriteLine("   ==========================================");
        string[] questionsEasy = new string [3];
        string[] answersEasy = new string [3]; 
        string[,] choicesEasy = new string [3, 2];
        string[] questionsMed = new string [3];
        string[] answersMed = new string [3]; 
        string[,] choicesMed = new string [3, 2];
        string[] questionsHard = new string [3];
        string[] answersHard = new string [3]; 
        string[,] choicesHard = new string [3, 2];
        bool[] questionAmount;
        
        while (startGame) {
        Console.WriteLine("Enter X to exit");
        Console.Write("Select a country: ");
        country = Console.ReadLine().ToLower();
        if (country == "x") {
            startGame = false;
            Console.WriteLine("=============================");
            Console.WriteLine("||     TRIVIA FINISHED     ||");    
            Console.WriteLine("=============================");
            Console.WriteLine($"Total Accumulated Score: {totalScore}");
            Console.WriteLine("Thank you for Participating!");
            startRand = false;
            
            break;
        }
       
        if (country == "united kingdom" || country == "uk" || country == "britain" || country == "gb" || country == "great britain") {
            startTrivia = true;
            questionsEasy = new string[] 
            {
                "What is the capital of the United Kingdom?",
                "What is the prehistoric megalith found in WIltshire England built by Neolithic builders?",
                "What is the national animal of Scotland?"
            };
            answersEasy = new string[] {"B", "A", "B"};
            
            choicesEasy = new string[,] 
            {
                {"A. Edenburgh", "B. London", "C. Belfast"},
                {"A. Stonehenge", "B. Avebury", "C. The Roman Baths"},
                {"A. Lion", "B. Unicorn", "C. Dragon"}
            };
            questionsMed = new string[] 
            {
                "What is the full name of the United Kingdom?",
                "What is the city located in Greater London, England, that serves as the historic and political heart of the UK?",
                "According to historians, journalist and politians back un the early, 19th century. the UK is considered as the _ as it summarizes the its geopolitican status during that time?"
            };
            
            answersMed = new string[] {"C", "B", "A"};
            
            choicesMed = new string[,] 
            {
                {"A. United Kingdom of the British Isles", "B. United Kingdom of Great Britain and Ireland", "C. United Kingdom of Great Britain and Nothern Ireland"},
                {"A. Plymouth", "B. Westminster", "C. Birmingham"},
                {"A. Mistress of the Seas", "B. Dominator of the Seas", "C. Conqueror of the Continent"}
            };
            questionsHard = new string[] 
            {
                "Who was the king who inherited the throne of England leading to the both kingdoms being ruled by one monarch leading to the event called Union of the crowns?",
                "The British Empire is known for their naval power until the mid 20th century, What was the ship that revolutionize the Royal Navy by making existing ships obsolete against it?",
                "A global event that British Empire started where global economy, social and technology shifted from agrarian works to industrial and machine-based manufacturing?"
            };
            answersHard = new string[] {"B", "B", "C"};
            
            choicesHard = new string[,] 
            {
                {"A. King George III", "B. King James IV", "C. King Henry VIII"},
                {"A. HMS Brittania", "B. HMS Dreadnought", "C. HMS Queen Elizabeth"},
                {"A. Slavery Abolition", "B. signing of the Magna Carta", "C. Industrial Revoluton"}
            };
        }
        else if (country == "france" || country == "fr" || country == "fra") {
            startTrivia = true;
            questionsEasy = new string[] 
            {
                "What is the capital of France?",
                "What is the underground ossuary found under Paris that currently houses estimated 6 million corpses?",
                "What is the famous tower landmark found on the Champ De Mars in Paris?"
            };
            answersEasy = new string [] {"A", "C", "C"};
            
            choicesEasy = new string [,] 
            {
                {"A. Paris", "B. Marseille", "C. Lyon"},
                {"A. Catacombs of Naples", "B. Capuchin Catacomb", "C. Paris Catacombs"},
                {"A.  Blackpool Tower", "B. Space Needle", "C. Eiffel Tower"}
            };
            questionsMed = new string[] 
            {
                "A Corsican born in time to be French, who becomes the first emperor of France.",
                "According to historians, journalist and politians back un the early, 19th century. France is considered as the _ as it summarizes the its geopolitican status during that time",
                "What country is considered as France’s greatest rival until the end of the Napoleonic Wars?"
            };
            answersMed = new string[] {"C", "B", "B"};
            
            choicesMed = new string[,] 
            {
                {"A. Charlemagne", "B. Louis XVI", "C. Napoleon Bonaparte"},
                {"A. Ruler of the Europe", "B. Masters of the Continent", "C. Tyrant of Europe"},
                {"A. Germany", "B. United Kingdom", "C. Spain"}
            };
            
            questionsHard = new string[]
            {
                "What inscription is written on the entrance that describes the catacombs of Paris?",
                "When Napoleon was defeated during the Battle of Nations (1813), he was exiled to a Mediterranean island called Elba. What is the ship's name that delivered him to Elba?",
                "What event one of the beginning marks of the French Revolution where angry mobs of Parisians stormed a fortress with firearms, powder and ammunition"
            };
            answersHard = new string[] {"B", "A", "B"};
            
            choicesHard = new string [,]
            {
                {"A. Empire of the Undead", "B. Empire of Death", "C. Empire of the Dead"},
                {"A. HMS Undaunted", "B. HMS Northumberland", "C. HMS Victory"},
                {"A. Rise of Napoleon", "B. Storming the Bastille", "C. Execution of King Louis XVI"}
            };
        }
        else if (country == "germany" || country == "deutschland" || country == "de") 
        {
            startTrivia = true;
            questionsEasy = new string[] 
            {
                "What is the capital of Germany?",
                "What structure fell in 1989 that signifies the reunification of Germany, the end of the cold war, and the upcoming fall of the USSR?",
                "What university did Dr José Rizal attend in 1886 in which he stayed for 2.5 months and attended lectures of history and psychology?"
            };
            answersEasy = new string[] {"B", "C", "C"};
            choicesEasy = new string[,] 
            {
                {"A. Leipzig", "B. Berlin", "C. Cologne"},
                {"A. Sophienkirche", "B. Kehlsteinhaus", "C. Berlin Wall"},
                {"A. Heidelberg University", "B. Humboldt University of Berlin", "C. University of Leipzig"},
            };
            questionsMed = new string[] 
            {
                "Before Germany was unified into a country, there was a Germanic state known for its military power that leads to it dominating neighbouring german tribes, states, kingdoms and duchies.",
                "Who was the man known as the “Iron Chancellor” who unified neighboring German territory and Prussia to form the German Empire?",
                "A union of germanic states under Napoleon's rule."
            };
            answersMed = new string[] {"C", "A", "B"};
            choicesMed = new string[,] 
            {
                {"A. Holy Roman Empire", "B. German Empire", "C. Kingdom of Prussia"},
                {"A. Otto Von Bismarck", "B. Friedrich Wilhelm Viktor Albert", "C. Friedrich von Brandenburg"},
                {"A. The North German Confederation", "B. Confederation of the Rhine", "C. German Confederation"},
            };
            questionsHard = new string[] 
            {
                "At the end of the Napoleonic Wars, who was the field marshal who led the Prussian army at the fields of Waterloo to assist the Duke of Wellington to defeat Napoleon and end the war?",
                "What is the name of the river toll castle found in Kaub, Germany that was erected between 1326-1327 later being modified with extra protection and more firepower?",
                "What peace treaty after World War 1 caused Germany to fall into a dark age leading to it losing territory, paying reparations for wars, hyperinflation and political extremism leading to the rise of a certain dictator leading to World War 2?"
            };
            answersHard = new string[] {"B", "C", "A"};
            choicesHard = new string[,] 
            {
                {"A. Gerhard von Scharnhorst", "B. Gebhard Von Blücher", "C. August von Gneisenau"},
                {"A. Heidelberg Castle", "B. Burg Eltz", "C. Burg Pfalgrafenstein"},
                {"A. Treaty of Versailles", "B. Pact of Steel", "C. Treaty of Brest-Litovsk"}
            };
        }
        else if (country == "spain" || country == "es") {
            startTrivia = true;
            questionsEasy = new string[] 
            {
                "What is the capital of Spain?",
                "During Magellan's voyage to be the first one to circumnavigate, his fleet contains five ships named Trinidad, Conception, San Antonio, Victoria, and Santiago. Which of the 5 ships in Magellan's fleet made it home?",
                "He Is the first Governor-General and the first man who established the first permanent Spanish settlement in the Philippines"
            };
            answersEasy = new string[] {"A", "C", "A"};
            choicesEasy = new string[,] 
            {
                {"A. Madrid", "B. Barcelona", "C. Zaragoza"},
                {"A. Santiago", "B. Trinidad", "C. Victoria"},
                {"A. Miguel López De Legazpi", "B. Carlos María de la Torre", "C. José Basco y Vargas"}
            };
            questionsMed = new string[] 
            {
                "Out of all of Spain's colonies, which one of its colonies was under Spanish rule the longest?",
                "What is the Spanish trade route called that links Manila in the Philippines with Acapulco in Mexico? This is considered one of the earliest globalized trading networks?",
                "A coastal city in northern Spain near the the French boarder known for it's crescent-shaped beaches. Also known as Donostia."
            };
            answersMed = new string[] {"B", "A", "B"};
            choicesMed = new string[,] 
            {
                {"A. Philippines", "B. Puerto Rico", "C. Mexico"},
                {"A. Manila Galleon Trade", "B. The Spice Islands Supply Line", "C. The Cape of Good Hope Route"},
                {"A. Bilbao", "B. San Sebastián", "C. Gijón"}
            };
            questionsHard = new string [] 
            {
                "Long ago around 219 BC, what Pro-Roman city did Hannibal Barca besiege? Today this city is known today as Morverdre, located in Valencia, Spain.",
                "During Jose Rizal's childhood years he developed a deep passion for literature and books, one of them being “Don Quixote”. Who was the author who wrote it?",
                "What is the official name of the flag of Spain?"
            };
            answersHard = new string[] {"C", "A", "B"};
            choicesHard = new string[,] 
            {
                {"A. Messana", "B. Syracuse", "C. Saguntum"},
                {"A. Miguel de Cervantes", "B. Lope de Vega", "C. San Juan de la Cruz"},
                {"A. Negro-rojo-oro", "B. La Rojigualda", "C. La bandera nacional"}
            };
        }
        else if (country == "italy" || country == "it") {
            startTrivia = true;
            questionsEasy = new string[] 
            {
                "What is the capital of Italy?",
                "Who is the famous Italian renaissance painter and inventor who painted the Mona Lisa?",
                "A medieval free-standing bell tower, known for Its unintentional tilt."
            };
            answersEasy = new string[] {"B", "A", "A"};
            choicesEasy = new string[,] 
            {
                {"A. Naples", "B. Rome", "C. Venice"},
                {"A. Leonardo Da Vinci", "B. Michelangelo Buonarroti", "C. Raffaello Sanzio da Urbino"},
                {"A. Leaning Tower of Pisa", "B. Torre dei Lamberti", "C. Guinigi Tower"}
            };
            questionsMed = new string[] 
            {
                "Who was the first king of the newly unified kingdom of Italy, declared in 1861",
                "During World War 2, An anti-facist song was sung by Italian resistance fighters. This song represents freedom and resisting tyranny, but there is no little to no records of it being sung by Italian partisans",
                "An autonomous island region off the coast of southern Italian peninsula. Also is the largest island in the Mediterranean sea."
            };
            answersMed = new string[] {"A", "C", "C"};
            choicesMed = new string[,] 
            {
                {"A. Victor Emmanuel III", "B. Umberto I", "C. Victor Emmanuel II"},
                {"A. Fischia il Vento", "B. Giovinezza", "C. Bella Ciao"},
                {"A. Trentino-South Tyrol", "B. Abruzzo", "C. Sicily"}
            };
            questionsHard = new string [] 
            {
                "The seafront castle nicknamed “Egg Castle” situated on the former island of Megaride now Peninsular found in Naples",
                "What was the original name of the Colosseum?",
                "A Roman general and dictator.known for his brilliant tactics in war and one of the pivotal figures who caused the downfall of the Roman Republic and the Rise of the Roman Empire"
            };
            answersHard = new string[] {"B", "B", "B"};
            choicesHard = new string[,] 
            {
                {"A. Castello Sforzesco", "B. Castel dell'Ovo", "C. Castel Sant'Angelo"},
                {"A. Pyramidis Cestii", "B. Amphitheatrum Flavium", "C. Pons Fabricius"},
                {"A. Titus Lartius", "B. Julius Caesar", "C. Nero Caesar Augustus"}
            };
        }
        
        else if (country == "poland" || country == "pl") {
            startTrivia = true;
            questionsEasy = new string[] 
            {
                "What is the capital of Poland?",
                "What is the national anthem of Poland?",
                "What is the official state name of Poland?."
            };
            answersEasy = new string[] {"A", "C", "A"};
            choicesEasy = new string[,] 
            {
                {"A. Kraków", "B. Poznań", "C. Warsaw"},
                {"A. Poland's Liberty", "B. Long Live Poland", "C. Poland Is Not Yet Lost"},
                {"A. Rzeczpospolita Polska", "B. Demokratyczna Polska", "C. Demokratyczna Rzeczpospolita Polska"}
            };
            questionsMed = new string[] 
            {
                "During world war 2, an orphaned Syrian brown bear traded in by the Polish 22nd Artillery Supply Company that will eventually be enlisted to the Polish army and become corporal What is the bear's name?",
                "A polish astronomer who theorized the sun is the center of the universe and the solar system and not the Earth calling it the “Heliocentric Model”",
                "This is referred to as The First Polish Republic. A federal union between the Kingdom of Poland and the Grand Duchy of Lithuania lasting from 1569-1795."
            };
            answersMed = new string[] {"C", "C", "B"};
            choicesMed = new string[,] 
            {
                {"A. Bamse", "B. Corporal Wotjek", "C. Unsinkable Sam"},
                {"A. Claudius Ptolemy", "B. Giovinezza", "C. Nicolaus Copernicus"},
                {"A. Poluania Kingdom", "B. Polish Lithuania Commonwealth", "C. Polish-Lithuania Union"}
            };
            questionsHard = new string [] 
            {
                "During the Siege of Vienna (1684), the largest cavalry charge In history had occurred, being led by Poland's elite heavy cavalry famous for their large rear wings and their single use  long lance called the “kopia”.What are these cavalry units called?",
                "In 1807 during the Napoleonic wars Napoleon Bonaparte restored Polish statehood after the defeat of both Prussia and Russia, this nation was established by the treaty of Tilsit and ruled by King Frederick Augustus l of Saxony. What is this state called?",
                "What year did Poland break away from the USSR?"
            };
            answersHard = new string[] {"C", "A", "A"};
            choicesHard = new string[,] 
            {
                {"A. Winged Cuirassier", "B. Polish Lancers", "C. Winged Hussar"},
                {"A. Poland", "B. Dutchy of Warsaw", "C. State of Poland"},
                {"A. 1989", "B. 1991", "C. 1987"}
            };
            
        }
        else if (country == "denmark" || country == "dnk" || country == "dk") {
            startTrivia = true;
            questionsEasy = new string[] 
            {
                "What is the capital of denmark?",
                "What is the major peninsula called? That compromised Denmark's mainland and the portion of Germany's northernmost part.",
                "What is the name of the famous bronze statue located in Copenhagen, Denmark? based on a fairy tale. Originally as a gift as a literary tribute to a famous Danish author named Hans Christian."
            };
            answersEasy = new string[] {"C", "C", "A"};
            choicesEasy = new string[,] 
            {
                {"A. Odense", "B. Esbjerg", "C. Copenhagen"},
                {"A. Asnæs", "B. Djursland", "C. Jutland"},
                {"A. The Little Mermaid", "B. The Snow Queen", "C. The Emperor's New Clothes"}
            };
            questionsMed = new string[] 
            {
                "An autonomous territory with its government still ruled by the Danes located in the North Atlantic.",
                "A union consisting of the Kingdom of Denmark and the kingdom of Norway.",
                "A king of Denmark during The mid 10th century famous for his decaying tooth resembling a blue tooth, bringing christianity to Denmark and the one who unified the tribes in Denmark."
            };
            answersMed = new string[] {"B", "C", "B"};
            choicesMed = new string[,] 
            {
                {"A. Iceland", "B. Greenland", "C. Svalbard"},
                {"A. Dutchy of Norway Denmark", "B. Union of Denmark-Norway", "C. Denmark-Norway"},
                {"A. Gorm the Languid", "B. Harald Gormsson", "C. Canute the Holy"}
            };
            questionsHard = new string [] 
            {
                "What occurred in 1807 where the British Navy attacked Copenhagen for the reason of Napoleon using The Danish-Norwegian navy to invade the British Isles?",
                "What treaty caused the official dissolution of Denmark-Norway 1814?",
                "During the Great War, the largest naval battle took place in the coast of the Jutland peninsula, where a full-scale naval clash between the British Empire and the German Empire occurred."
            };
            answersHard = new string[] {"C", "B", "A"};
            choicesHard = new string[,] 
            {
                {"A. Occupation of Copenhagen", "B. Liberation of Copenhagen", "C. Battle of Copenhagen"},
                {"A. Treaty of Fontainebleau", "B. Treaty of Kiel", "C. Treaty of Prague"},
                {"A. Battle of Jutland", "B. Battle of the Denmark Strait", "C. The Gunboat War"}
            };
        }
        else if (country == "sweden" || country == "se" || country == "swe") {
            startTrivia = true;
            questionsEasy = new string[] 
            {
                "What is the capital of Sweden?",
                "What is the currency used in Sweden?",
                "IKEA is the world's multinational furniture retailer founded in Sweden, known for its flat-pack self-assembly. But where is the largest IKEA store located?."
            };
            answersEasy = new string[] {"C", "C", "B"};
            choicesEasy = new string[,] 
            {
                {"A. Uppsala", "B. Malmö", "C. Stockholm"},
                {"A. DKK", "B. NOK", "C. SEK"},
                {"A. Möbel-IKÉA", "B. IKEA Pasay City", "C. IKEA Gwangmyeong"}
            };
            questionsMed = new string[] 
            {
                "A king of Sweden who is also known as Olaf the Swede. He was the first king in Swedish history who converted the country from the viking age to Christianity",
                "What is the northernmost, largest and least populous among Sweden's three main regions?",
                "A king in Sweden who is credited for the rise of Sweden as an European power known as the Stormaktstiden, During the thirty years war he made Sweden the primary military force and is known as the father of modern warfare?"
            };
            answersMed = new string[] {"C", "C", "B"};
            choicesMed = new string[,] 
            {
                {"A. Erik Segersäl", "B. Anund Jacob", "C. Olaf Skötkonung"},
                {"A. Götaland", "B. Svealand", "C. Norrland"},
                {"A. Erik Gustavsson Vasa", "B. Gustavus Adolpus", "C. Gustav Vasa"}
            };
            questionsHard = new string [] 
            {
                "A king of Sweden who was known was Carolus Rex from 1697-1718, who received the throne from a being young age he is known for him being a brilliant militarystrategist who spent nearly his reign duration on leading Sweden through the Great Northern War.",
                "A horrible tragedy that happened when the nation of Denmark, Norway and Sweden was under the Danish crown Kalmar Union. Where in the Danish king executed dozens of Swedish Nobels",
                "A former French marshal and one of Napoleon's generals who was elected to be the crown prince of Sweden in 1810 taking the name Charles XIV John. He will eventually betray Napoleon for his duty shifted to favoring the people of Sweden's interest."
            };
            answersHard = new string[] {"B", "A", "B"};
            choicesHard = new string[,] 
            {
                {"A. King Stanisław I Leszczyński", "B. Charles Xll", "C. King George I"},
                {"A. Stockholm Bloodbath of 1520", "B. Stockholm Bloodbath of 1525", "C. Stockholm Bloodbath of 1523"},
                {"A. Michel Ney", "B. Jean-Baptiste Bernadotte", "C. Joachim Murat"}
            };
        }
        else if (country == "russia" || country == "ru" || country == "rus") {
            startTrivia = true;
            questionsEasy = new string[] 
            {
                "What is the capital of Russia?",
                "What is the region in covers most of Russia? This region is known for its extremely cold climate, permafrost and size of the region.",
                "What is the national anthem of Russian Federation?."
            };
            answersEasy = new string[] {"B", "C", "B"};
            choicesEasy = new string[,] 
            {
                {"A. Saint Petersburg", "B. Moscow", "C. Yekaterinburg"},
                {"A. Caucasus", "B. Ural Federation District", "C. Siberian"},
                {"A. God save the Tsar", "B. State Anthem of the Russian Federation", "C. State Anthem of the Soviet Union"}
            };
            questionsMed = new string[] 
            {
                "Russia's second largest city built on 42 islands on the Neva river, cultural capital of Russia, and former capital.",
                "A soviet politician and dictator who ruled and led the Soviet from the late 1920s until his death.",
                "Who is the last Tsar of the Russian Empire?"
            };
            answersMed = new string[] {"A", "B", "C"};
            choicesMed = new string[,] 
            {
                {"A. Saint Petersburg", "B. Yekaterinburg", "C. Novosibirsk"},
                {"A. Vladimir Lenin", "B. Joseph Stalin", "C. Mikhail Gorbachev"},
                {"A. Alexander I", "B. Ivan the Terrible", "C. Nicholas II"}
            };
            questionsHard = new string [] 
            {
                "An overture composed by Pyotr Ilyich Tchaikovsky to commemorate the successful defence of Russia against Napoleon's invasion",
                "What is the anthem of the Russian Empire?",
                "Who is the Father of Communism?"
            };
            answersHard = new string[] {"C", "B", "A"};
            choicesHard = new string[,] 
            {
                {"A. Hamlet Fantasy Overture, Op. 67", "B. Romeo and Juliet Fantasy Overture", "C. 1812 Overture"},
                {"A. State Anthem of the Soviet Union", "B. God save the Tsar", "C. State Anthem of the Russian Federation"},
                {"A. Karl Marx", "B. Vladimir Lenin", "C. Friedrich Engels"}
            };
        }
        else 
        {
            
            Console.WriteLine("Not a Valid Country or Coming soon");
        }
        
        
         questionAmount = new bool [3];
     while (startRand) {
         int randomizer;
         do {
            randomizer = rand.Next(0, 3);
         }
         while (questionAmount[randomizer] == true);
         
         
       while (startTrivia) {
        Console.WriteLine($"||| {country} Trivia! |||");
        Console.WriteLine("Instructions: Users must only input A, B, and C. Other inputs will be considered as wrong.");
        Console.WriteLine("Question Easy: ");
        Console.WriteLine(questionsEasy[randomizer]);
        for (int i = 0; i < 3; i++) 
        {
            Console.WriteLine(choicesEasy[randomizer, i]);
        }
        Console.Write("Your answer: ");
        string userEasyAns = Console.ReadLine().ToUpper();
        if (userEasyAns == answersEasy[randomizer] ) {
            Console.WriteLine("Correct!\n");
            totalScore += 1;
        }
        
        else {
            Console.WriteLine("Wrong!\n");
            Console.WriteLine($"The answer is {answersEasy[randomizer]}");
        }
        Console.WriteLine("Question Medium: ");
        Console.WriteLine(questionsMed[randomizer]);
        for (int i = 0; i < 3; i++) 
        {
            Console.WriteLine(choicesMed[randomizer, i]);
        }
        Console.Write("Your answer: ");
        string userMedAns = Console.ReadLine().ToUpper();
        if (userMedAns == answersMed[randomizer]) {
            Console.WriteLine("Correct!\n");
            totalScore += 2;
        }
        else {
            Console.WriteLine("Wrong!\n");
            Console.WriteLine($"THe answer is {answersMed[randomizer]}");
        }
        Console.WriteLine("Question Hard: ");
        Console.WriteLine(questionsHard[randomizer]);
        for (int i = 0; i < 3; i++) 
        {
            Console.WriteLine(choicesHard[randomizer, i]);
        }
        Console.Write("Your answer: ");
        string userHardans = Console.ReadLine().ToUpper();
        if (userHardans == answersHard[randomizer]) {
            Console.WriteLine("Correct!\n");
            totalScore += 3;
        }
        else {
            Console.WriteLine("Wrong!\n");
            Console.WriteLine($"THe answer is {answersHard[randomizer]}\n");
        }
        break;
       }
        break;
     }
     
        }
        
    }
}         
    
      
