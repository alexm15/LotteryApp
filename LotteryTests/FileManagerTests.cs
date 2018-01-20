using LotteryApp.Models;
using LotteryClassLibrary;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class FileManagerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateParticipant()
        {
            Participants participants = new Participants();
            Submission submission = new Submission();
            submission.Email = "Test@Test";
            submission.DateOfBirth = new System.DateTime(1999, 9, 9);
            submission.FirstName = "Alexander";
            submission.SurName = "Markussen";
            submission.PhoneNumber = 123423;
            submission.SerialNumber = "12342sdf";

            participants.Submissions.Add(submission);

            FileManager fileManager = new FileManager();
            fileManager.CreateParticipant(participants.ToString());
        }

        [Test]
        public void TestReadSerialNumber()
        {
            FileManager fileManager = new FileManager();
            string result = fileManager.ReadSerialNumber("../../../../LotteryClassLibrary/SerialNumbers.dat");
            System.Console.WriteLine(result);
        }

        [Test]
        public void TestWriteSerialNumber()
        {
            FileManager fileManager = new FileManager();
            fileManager.AssignSerialNumber("SerialNumbers.dat", "LOT999");
            string result = fileManager.ReadSerialNumber("SerialNumbers.dat");

            System.Console.WriteLine(result);
            Assert.IsTrue(result.Contains("LOT999"));
        }

        [Test]
        public void TestGetSerialNumbers()
        {
            FileManager fileManager = new FileManager();
            List<string> result = fileManager.GetSerialNumbers("../../../../LotteryClassLibrary/SerialNumbers.dat");
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}