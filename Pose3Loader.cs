using System.Text.Json;

namespace Revolt2D.Pose.Json
{
    public class Pose3Loader
    {
        private Pose3 _pose;

        public Pose3Loader(string filePath)
        {
            _pose = LoadFromFile(filePath);
        }

        public Pose3 GetPose()
        {
            return _pose;
        }

        public Pose3? LoadFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                throw new Exception($"Invalid path! {filePath}");

            string? jsonData = File.ReadAllText(filePath);
            return LoadJson(jsonData);
        }

        public Pose3? LoadJson(string jsonData)
        {
            try
            {
                if (string.IsNullOrEmpty(jsonData))
                    throw new Exception("JSON data empty!");

                JsonSerializerOptions options = new JsonSerializerOptions { IncludeFields = true };
                return JsonSerializer.Deserialize<Pose3>(jsonData, options);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}
