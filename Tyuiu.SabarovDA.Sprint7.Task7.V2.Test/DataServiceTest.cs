using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
namespace Tyuiu.SabarovDA.Sprint7.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testFilePath = @"C:\Users\UserHome\source\repos\Tyuiu.SabarovDA.Sprint7\Tyuiu.SabarovDA.Sprint7.Task7.V2\bin\Debug\Rows.csv";
            int lineCount = 0;
            // Действие
            using (var reader = new StreamReader(testFilePath))
            {                // Пропускаем заголовок
                reader.ReadLine();
                // Считаем оставшиеся строки                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            // Проверка
            Assert.AreEqual(10, lineCount); // Предполагаемое количество строк: 14
        }
    }
}
