using System;
using System.Collections.Generic;
using System.IO;

namespace LotteryClassLibrary
{
    public class FileManager
    {
        public void CreateParticipant(object participant)
        {
            try
            {
                using (TextWriter fileToWrite = new StreamWriter(new FileStream("Participants.dat", FileMode.Append)))
                {
                    fileToWrite.Write(participant);
                }
            }
            catch (FileNotFoundException e)
            {

                throw e;
            }
        }

        public string ReadSerialNumber(String fileName)
        {
            try
            {
                using (TextReader fileToRead = new StreamReader(new FileStream(fileName, FileMode.Open)))
                {
                    return fileToRead.ReadToEnd();
                }
            }
            catch (FileNotFoundException e)
            {

                throw e;
            }
        }

        public List<string> GetSerialNumbers(string fileName)
        {
            try
            {
                using (TextReader fileToRead = new StreamReader(new FileStream(fileName, FileMode.Open)))
                {
                    List<string> serialNumbers = new List<string>();
                    string serialNumber;
                    while ((serialNumber = fileToRead.ReadLine()) != null)
                    {
                        serialNumbers.Add(serialNumber);
                    }
                    return serialNumbers;
                }
            }
            catch (FileNotFoundException e)
            {

                throw e;
            }
        }

        public void AssignSerialNumber(string filename, string entry)
        {
            try
            {
                using (TextWriter fileToWrite = new StreamWriter(new FileStream(filename, FileMode.Append)))
                {
                    fileToWrite.Write(entry);
                }
            }
            catch (FileNotFoundException e)
            {

                throw e;
            }
        }
    }
}
