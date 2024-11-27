using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _666666
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*0101
                        // 系統內部存儲的密碼
            string storedPassword = "SecurePassword123";

            // 用戶輸入的密碼
            string userInputPassword = "securepassword123";

            // 使用 Compare() 方法比較密碼，這裡忽略大小寫的比較
            int result = string.Compare(storedPassword, userInputPassword, ignoreCase: true);

            // 判斷比較結果，並給出提示
            if (result == 0)
            {
                Console.WriteLine("密碼匹配，登錄成功！");
            }
            else
            {
                Console.WriteLine("密碼錯誤，請再試一次！");
            }
            */
            /*0201
                         // 定義兩個用戶名稱
            string user1 = "Charlie";
            string user2 = "Alice";

            // 比較用戶名稱，判斷哪一個排在前面
            int result = user1.CompareTo(user2);

            // 輸出比較結果
            if (result < 0)
            {
                Console.WriteLine($"{user1} 排在 {user2} 前面");
            }
            else if (result > 0)
            {
                Console.WriteLine($"{user2} 排在 {user1} 前面");
            }
            else
            {
                Console.WriteLine("兩個用戶名稱相同");
            }

            // 另一種情況：對一個用戶名列表進行排序
            string[] userNames = { "Charlie", "Bob", "Alice" };

            // 使用 CompareTo() 方法進行排序
            Array.Sort(userNames);

            Console.WriteLine("\n按照字母順序排序後的用戶名稱：");
            foreach (var userName in userNames)
            {
                Console.WriteLine(userName);
            }
            */
            /*0301
                         // 提示用戶輸入命令
            Console.WriteLine("請輸入命令：");
            string userInput = Console.ReadLine();

            // 將用戶輸入轉換為大寫
            string command = userInput.ToUpper();

            // 根據轉換後的命令進行處理
            if (command == "START")
            {
                Console.WriteLine("系統啟動中...");
            }
            else if (command == "STOP")
            {
                Console.WriteLine("系統停止中...");
            }
            else if (command == "EXIT")
            {
                Console.WriteLine("退出系統...");
            }
            else
            {
                Console.WriteLine("無效的命令！");
            }
            */
            /*0401
                        // 提示用戶輸入字串
            Console.WriteLine("請輸入一個字串:");
            string userInput = Console.ReadLine(); // 讀取用戶輸入

            // 使用 Copy 方法將用戶輸入的字串複製到另一個變數
            string copiedInput = string.Copy(userInput);

            // 輸出複製的字串
            Console.WriteLine("你輸入的字串是: " + copiedInput);

            // 將複製的字串轉換為大寫
            string upperCaseInput = copiedInput.ToUpper();
            Console.WriteLine("轉換為大寫後的字串: " + upperCaseInput);
            */
            /*0501
                        string filePath = "C:\\Users\\John\\Documents\\file.txt";

            // 定義要檢查的目錄
            string directoryToCheck = "C:\\Users\\John";

            // 使用 StartsWith() 判斷檔案路徑是否以指定目錄開頭
            bool result = filePath.StartsWith(directoryToCheck);

            // 根據結果生成輸出訊息
            string output;
            if (result)
            {
                output = "檔案路徑以 '" + directoryToCheck + "' 開頭";
            }
            else
            {
                output = "檔案路徑不以 '" + directoryToCheck + "' 開頭";
            }

            // 輸出結果
            Console.WriteLine(output);
            Console.ReadLine();
            */
            /*0601
            string filename = "document.txt";
            bool result = filename.EndsWith(".txt");
            string output = result ? "檔案是 .txt 格式" : "檔案不是 .txt 格式";

            Console.WriteLine(output);
            Console.WriteLine();
            */
            /*0701
            string firstName = "John";
            string lastName = "Doe";
            string age = "30";
            string profession = "工程師";

            string result = string.Concat(firstName, " ", lastName, ", Age: ", age, ", Profession: ", profession);

            Console.WriteLine(result);
            Console.WriteLine();
            */
            /*0801
            string correctPassword = "Secure123";
            string userInput = "Secure123";

            bool result = correctPassword.Equals(userInput);

            if (result)
            {
                Console.WriteLine("密碼正確，登錄成功！");
            }
            else
            {
                Console.WriteLine("密碼錯誤，請重新輸入。");
            }
            Console.WriteLine();
            */
            /*0902
            string shoppingList = "牛奶,麵包,雞蛋"; // 定義初始的購物清單
            int insertPosition = shoppingList.IndexOf("麵包"); // 找到"麵包"的位置
            string updatedList = shoppingList.Insert(insertPosition, "香蕉,"); // 插入"香蕉,"
            Console.WriteLine(updatedList); // 輸出更新後的清單

            // 預期輸出: 牛奶,香蕉,麵包,雞蛋
            */
            /*1002
            // 假設我們有一個員工編號清單，並希望所有編號都是6位數，不足的前面補0
            string[] employeeIds = { "7", "45", "123", "4567" };

            // 遍歷每個員工編號
            foreach (string id in employeeIds)
            {
                // 將編號補足為6位數，左邊用'0'填充
                string formattedId = id.PadLeft(6, '0');

                // 輸出結果
                Console.WriteLine(formattedId);
            */
            /*1101
            // 定義商品名稱與其價格
            string productName = "Apple";
            double price = 1.99;

            // 使用 PadRight() 將商品名稱補齊到 15 個字元長度，並以 '-' 填充
            string formattedProductName = productName.PadRight(15, '-');

            // 格式化輸出
            string result = $"{formattedProductName} ${price:F2}";

            // 輸出結果
            Console.WriteLine(result);

            // 假設進一步儲存到報表檔案
            System.IO.File.AppendAllText("report.txt", result + Environment.NewLine);
            Console.WriteLine("格式化結果已追加至 report.txt");
            */
            /*1202
            string shoppingList = "apple, banana, cherry, date";
            int lastIndex = shoppingList.LastIndexOf(',');
            Console.WriteLine("The last index of ',' is: " + lastIndex);
            */
            /*1301
            string email = "example@domain.com";
            char[] charArray = email.ToCharArray();
            bool hasInvalidChar = false;

            foreach (char c in charArray)
            {
                if (!char.IsLetterOrDigit(c) && c != '@' && c != '.')
                {
                    hasInvalidChar = true;
                    break;
                }
            }

            Console.WriteLine(hasInvalidChar ? "Invalid Email" : "Valid Email");
            */
            /*1401
            string[] fruits = { "apple", "banana", "cherry" };
            string result = string.Join(",", fruits);

            Console.WriteLine("合併後的字串為: " + result);
            Console.ReadLine();
            */
            /*1501
            string filePath = "C:\\Users\\User\\Documents\\file.txt";
            string fileName = filePath.Remove(0, filePath.LastIndexOf('\\') + 1);
            Console.WriteLine(fileName);
            */
            /*1601
            string sentence = "I love programming in C#";
            string[] words = sentence.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
            */
            /*1701
            string str = "Hello World";
            string result = str.Replace("World", "C#");
            Console.WriteLine(result);
            */
            /*1701-1
            string str = "您好 [名字] 歡迎登入";
            string result = str.Replace("[名字]", "王曉明");
            Console.WriteLine(result);
            */
            /*1801
            string str = "programming";
            string result = str.Substring(2);
            Console.WriteLine(result);
            */
            /*1801-1
            string url = "https://www.example.com";
            string domain = url.Substring(8);
            Console.WriteLine(domain);
            */
            /*1901
            string str = "   Hello World!   ";
            string result = str.Trim();
            Console.WriteLine(result);
            */
            /*1901-1
            string line = "   Important Data   ";
            string cleanedLine = line.Trim();
            Console.WriteLine(cleanedLine);
            */
            /*2001
            string source = "hello world";
            char[] destination = new char[5];
            source.CopyTo(0, destination, 0, 5);
            Console.WriteLine(destination);
            */
        }
    }
}
