using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwLess2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            //обьявление переменных
            string userName;
            byte userAge;
            double userHeight, avgGrade;
            byte gradeFirstSubject, gradeSecondSubject, gradeThirdSubject;


            //присваивание переменным значений
            userName = "Александрова Алла";
            userAge = 20;
            userHeight = 1.65;

            gradeFirstSubject = 8;
            gradeSecondSubject = 9;
            gradeThirdSubject = 8;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            avgGrade = (double)(gradeFirstSubject + gradeSecondSubject + gradeThirdSubject) / 3;


            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            Console.WriteLine("Имя: " + userName + " Возраст: " + userAge + " Рост: " + userHeight + " Средний балл по трем предметам: " + avgGrade);
            //    - форматированного вывода;
            string writePattern = "\nФорматированный вывод \nИмя: {0} \nВозраст: {1} \nРост: {2} \nСредний балл: {3} \n";
            Console.WriteLine(writePattern,
                                userName,
                                userAge,
                                userHeight,
                                avgGrade);

            //    - использования интерполяции строк;

          

            Console.WriteLine($"Имя: {userName} Возраст: {userAge} Рост: {userHeight} Средний балл: " + "{0:0.00}", avgGrade);

            Console.ReadKey();

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

        }
    }
}
