using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyServiceStack.UnitTesting
{
    [TestClass]
    public class Testing
    {
        static string filename;
        int iterations = 5;
        IReader reader;
        Stopwatch sw = new Stopwatch();

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            filename = Path.Combine(System.Environment.CurrentDirectory, @"..\..\..\Data\SampleData.json");
            bool exists = File.Exists(filename);
            Assert.IsTrue(exists);
        }

        [TestMethod]
        public void TestOption1_File()
        {
            List<Element> result = new List<Element>();
            reader = new Option1Reader();

            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                var read = reader.GetAllFromFile(filename);
                result.AddRange(read);
            }
            sw.Stop();

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count);
            Debug.WriteLine(sw.Elapsed.ToString());
        }

        [TestMethod]
        public void TestOption2_File()
        {
            List<Element> result = new List<Element>();
            reader = new Option2Reader();

            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                var read = reader.GetAllFromFile(filename);
                result.AddRange(read);
            }
            sw.Stop();

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count);
            Debug.WriteLine(sw.Elapsed.ToString());
        }

        [TestMethod]
        public void TestOption3_File()
        {
            List<Element> result = new List<Element>();
            reader = new Option3Reader();

            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                var read = reader.GetAllFromFile(filename);
                result.AddRange(read);
            }
            sw.Stop();

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count);
            Debug.WriteLine(sw.Elapsed.ToString());
        }

        [TestMethod]
        public void TestOption1_Json()
        {
            List<Element> result = new List<Element>();
            reader = new Option1Reader();
            string json = System.IO.File.ReadAllText(filename);

            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                var read = reader.GetAllFromJson(json);
                result.AddRange(read);
            }
            sw.Stop();

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count);
            Debug.WriteLine(sw.Elapsed.ToString());
        }

        [TestMethod]
        public void TestOption2_Json()
        {
            List<Element> result = new List<Element>();
            reader = new Option2Reader();
            string json = System.IO.File.ReadAllText(filename);

            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                var read = reader.GetAllFromJson(json);
                result.AddRange(read);
            }
            sw.Stop();

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count);
            Debug.WriteLine(sw.Elapsed.ToString());
        }

        [TestMethod]
        public void TestOption3_Json()
        {
            List<Element> result = new List<Element>();
            reader = new Option3Reader();
            string json = System.IO.File.ReadAllText(filename);

            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                var read = reader.GetAllFromJson(json);
                result.AddRange(read);
            }
            sw.Stop();

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count);
            Debug.WriteLine(sw.Elapsed.ToString());
        }
    }
}