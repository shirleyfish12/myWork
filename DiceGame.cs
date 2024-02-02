class Program
{

    static void Main()
    {
        int UserResult = 0;
        int AiResult = 0;
        Random rnd = new Random();

 
        Console.WriteLine("5 round to play a dice game!!!");

        // 玩家可以玩的次數
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Press any key to roll the Dice:");
            Console.ReadKey(); // for user press any key or only read a char
            
            int dice = rnd.Next(1, 7); //create a random number for user 1 to 6
            int AiDice;
          
            //使用 do-while 循環而不是 while 循環的原因是確保在生成敵方 AI 的骰子點數時，至少執行一次生成的動作。
            do
            {
              AiDice = rnd.Next(1, 7); // 產生一個1到6的隨機數字給敵方 AI
            } while (AiDice == dice); // 如果敵方 AI 擲出的是跟用戶相同，則重新生成骰子點數
           
            
            Console.WriteLine("You rolled " + dice);
            Console.WriteLine(".......");
            System.Threading.Thread.Sleep(1000);//執行緒會暫停指定的時間間隔，然後再繼續執行下一個指令
            Console.WriteLine("Enemy AI rolled " + AiDice);

            if (dice > AiDice)
            {

                Console.WriteLine("You win the game!");
                UserResult++;
                /*string interpolation
                使用 $ 字元開頭的字串，可以在其中使用 {} 包裹變數或運算式，這樣就可以直接將它們插入到字串中。
                這樣可以讓程式碼更簡潔易讀，並且不需要使用 + 來串接字串和變數。*/
                Console.WriteLine($"The score is now - Player : {UserResult} Enemy : {AiResult}");
                //Console.WriteLine("The score is now - Player : " + UserResult + " Enemy : " + AiResult);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Enemy AI win!");
                AiResult++;
                Console.WriteLine($"The score is now - Player : {UserResult} Enemy : {AiResult}");
                Console.WriteLine("");
            }
        }
    }
}  
