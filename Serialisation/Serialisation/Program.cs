using System;

namespace Serialisation
{
    class Program
    {
        private static readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static void Main(string[] args)
        {
            //Trainee
            Trainee trainee = new Trainee() { FirstName = "Cathy", LastName = "French", SpartaNo = 123 };
            // Create a binary serialiser
            var _serialiser = new SerialiserBinary();
            // Writer trainee to file (binary)
            _serialiser.SerialiseToFile($"{_path}/BinaryTrainee.bin", trainee);
            // Deserialise
            Trainee deserialiseBinaryTrainee = _serialiser.DeserialiseFromFile<Trainee>($"{_path}/BinaryTrainee.bin");
            // Create course
            var serialiser = new SerialiserXML();
            Course eng91 = new Course { Title = "Engineering 91", Subject = "C# SDET", StartDate = new DateTime(2021, 8, 13) };
            // Add trainees
            eng91.AddTrainee(trainee);
            eng91.AddTrainee(new Trainee { FirstName = "Martin", LastName = "Beard", SpartaNo = 1243 });
            serialiser.SerialiseToFile($"{_path}/XMLCourse.xml", eng91);
            var serialiserj = new SerialiserJson();
            serialiserj.SerialiseToFile($"{_path}/JSONTrainee.json", trainee);
            Trainee deserialisedJSONTrainee = serialiserj.DeserialiseFromFile<Trainee>($"{_path}/JSONTrainee.json");

        }
    }
}
