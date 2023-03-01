using System.Text.Json;

public static class JsonExtensions {
    public static string ToJson<T>(this object o) {
        var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        var ret = JsonSerializer.Serialize(o, options);
        return ret;
    }
    public static T FromJson<T>(this string json) {
        var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        var ret = JsonSerializer.Deserialize<T>(json, options);
        return ret;
    }
}
