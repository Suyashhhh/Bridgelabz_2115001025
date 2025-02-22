using System;
using System.IO;

public class FileProcessor
{
    public void WriteToFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }

    public string ReadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            throw new IOException("file does not exist");
        }
        return File.ReadAllText(filename);
    }
}




using NUnit.Framework;
using System;
using System.IO;

[TestFixture]
public class FileProcessorTests
{
    private FileProcessor fileProcessor;
    private string testFilePath;

    [SetUp]
    public void Setup()
    {
        fileProcessor = new FileProcessor();
        testFilePath = "testfile.txt";
    }

    [TearDown]
    public void Teardown()
    {
        if (File.Exists(testFilePath))
        {
            File.Delete(testFilePath);
        }
    }

    [Test]
    public void WriteToFile_ShouldCreateFileAndWriteContent()
    {
        string content = "hello world";
        fileProcessor.WriteToFile(testFilePath, content);
        Assert.IsTrue(File.Exists(testFilePath));

        string fileContent = File.ReadAllText(testFilePath);
        Assert.AreEqual(content, fileContent);
    }

    [Test]
    public void ReadFromFile_ShouldReturnCorrectContent()
    {
        string content = "test content";
        File.WriteAllText(testFilePath, content);
        string readContent = fileProcessor.ReadFromFile(testFilePath);
        Assert.AreEqual(content, readContent);
    }

    [Test]
    public void ReadFromFile_ShouldThrowIOException_WhenFileDoesNotExist()
    {
        Assert.Throws<IOException>(() => fileProcessor.ReadFromFile("nonexistentfile.txt"));
    }
}
